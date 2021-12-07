using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using PL1G06.Minesweeper.Common.Models;
using System.Net;
using System.Xml.Linq;
using PL1G06.Minesweeper.Common.Diversos;
using Windows.UI.Popups;
using Windows.UI.Xaml.Media.Imaging;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using Windows.UI.Core;

namespace PL1G06.Minesweeper.UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ViewPerfil : Page, JanelaPerfil
    {
        public event DelegadoSemParametros PedidoVoltar;
        public event DelegadoSemParametros PedidoPerfil;

        Jogador jogador = new Jogador();

        
        public ViewPerfil()
        {
            this.InitializeComponent();
        }

        private async void buttonVoltar_Click(object sender, RoutedEventArgs e)
        {
            if (PedidoVoltar != null)
            {
                PedidoVoltar();
            }
            else
            {
                var messageDialog = new MessageDialog("Erro!", "ERRO");
                messageDialog.DefaultCommandIndex = 0;
                await messageDialog.ShowAsync();
            }
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //if (PedidoPerfil != null)
            //{
            //    PedidoPerfil();
            //}
            //else
            //{
            //    var messageDialog = new MessageDialog("Erro!", "ERRO");
            //    messageDialog.DefaultCommandIndex = 0;
            //    await messageDialog.ShowAsync();
            //}

          ApresentarDados((App.Current as App).M_Jogador.username);
        }

        public async void ApresentarDados(string username)
        {
            XDocument xmlResposta = (App.Current as App).s_1.GetPerfil(username);

            if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
            {
                // apresenta mensagem de erro 
                var messageDialog = new MessageDialog(xmlResposta.Element("resultado").Element("contexto").Value, 
                                    "ERRO!");
                messageDialog.DefaultCommandIndex = 0;
                await messageDialog.ShowAsync();
            }
            else
            {
                textBoxUsername.Text = username;
                textBoxNome.Text = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("nomeabreviado").Value;
                textBoxEmail.Text = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("email").Value;
                textBoxPais.Text = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("pais").Value;
                labelJogosGanhos.Text = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("jogos").Element("ganhos").Value;
                labelJogosPerdidos.Text = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("jogos").Element("perdidos").Value;
                //labelMelhorTFacil.Text = (string) xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("tempos").Element("facil").Value;
                //labelMelhorTMedio.Text = (string) xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("tempos").Element("medio").Value;

                string base64Imagem = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("fotografia").Value;
                //NOTA IMPORTANTE: MUDAR PARA "1" OU PARA "0", CASO CAI NUM EXEPÇÃO NAs DUAS LINHAs SEGUINTES::

                try
                {
                    string base64 = base64Imagem.Split(',')[0];   // retira a parte da string correspondente aos bytes da imagem.. 
                    byte[] bytes = Convert.FromBase64String(base64);  //...converte para array de bytes... 

                    Imagem.Source = await Base64ToImagem(bytes);

                   
                    
                }
                catch
                {
                    string base64 = base64Imagem.Split(',')[1];   // retira a parte da string correspondente aos bytes da imagem.. 
                    byte[] bytes = Convert.FromBase64String(base64);  //...converte para array de bytes... 

                    Imagem.Source = await Base64ToImagem(bytes);

                   
                    
                }

            }
        }

     
        public async Task<BitmapImage> Base64ToImagem(byte[] byteArray)  //função que converte a base64 string em Image
        {
            using (InMemoryRandomAccessStream stream = new InMemoryRandomAccessStream())
            {
                using (DataWriter writer = new DataWriter(stream.GetOutputStreamAt(0)))
                {
                    writer.WriteBytes(byteArray);
                    await writer.StoreAsync();
                }
                var image = new BitmapImage();
                await image.SetSourceAsync(stream);
                return image;

            }
        }

        public void ApagarDados()
        {
            textBoxUsername.Text = "";
            textBoxNome.Text = "";
            textBoxEmail.Text = "";
            textBoxPais.Text = "";
            labelJogosGanhos.Text = "";
            labelJogosPerdidos.Text = "";
            labelMelhorTFacil.Text = "";
            labelMelhorTMedio.Text = "";
            Imagem.Source = null;
        }

        private void buttonIr_Click(object sender, RoutedEventArgs e)
        {
            ApagarDados();
            (App.Current as App).M_JogadorConsulta.username = textBoxUsernameConsulta.Text;
            ApresentarDados((App.Current as App).M_JogadorConsulta.username);
        }

        //private void ViewPerfil_VisibiltyChanged(object sender, VisibilityChangedEventArgs e)
        //{
        //    if(Visibility)
        //    {
        //        ApresentarDados((App.Current as App).M_JogadorConsulta.username);
        //    }
        //    else
        //    {
        //        ApagarDados();
        //    }
        //}


    }
}
