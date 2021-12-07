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
using PL1G06.Minesweeper.Common.Diversos;
using Windows.UI.Popups;
using System.Xml.Linq;

namespace PL1G06.Minesweeper.UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ViewTOP10 : Page, JanelaTOP10
    {
        public event DelegadoSemParametros PedidoVoltar;
        public event DelegadoParaPerfil PedidoVerPerfil;
        public event DelegadoSemParametros PedidoTOP10;
        public event DelegadoComDificuldade PedidoTOP1;

        public ViewTOP10()
        {
            this.InitializeComponent();

            (App.Current as App).M_TOP1.RespostaTOP1 += M_TOP1_RespostaTOP1;
        }

        private void M_TOP1_RespostaTOP1(string nome, string tempo, string quando, string dificuldade)
        {
            string data = string.Empty;
            string hora = string.Empty;
            string[] quandosplit = null;

            quandosplit = quando.Split('T', '.');
            data = quandosplit[0];
            hora = quandosplit[1];

            if (string.Compare(dificuldade, "Facil") == 0)
            {
                textBoxMTF.Text = (tempo + " - " + nome + " - " + data + " " + hora + " ");
            }
            else if (string.Compare(dificuldade, "Medio") == 0)
            {
                textBoxMTM.Text = (tempo + " - " + nome + " - " + data + " " + hora + " ");
            }
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
                await messageDialog.ShowAsync();
            }
        }

        /*
        private async void ListViewTOP10_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (PedidoVerPerfil != null)
            //{
            //    PedidoVerPerfil(listBoxTOP10.SelectedItem.ToString());
            //}
            //else
            //{
            //    var messageDialog = new MessageDialog("Erro!", "ERRO");
            //    messageDialog.DefaultCommandIndex = 0;
            //    await messageDialog.ShowAsync();
            //}


            //para ver o perfil da pessoa selecionada na lista
            string username = listBoxTOP10.Items[listBoxTOP10.SelectedIndex].ToString();
            (App.Current as App).M_Jogador.username = username.Split(';')[0];   //split faz com apenas seja "usado" o username da linha selcionada na listbox
            //mostrar o perfil do user selecionado
            (App.Current as App).s_1.GetPerfil((App.Current as App).M_Jogador.username);
            this.Frame.Navigate(typeof(ViewPerfil), null);
        }*/

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listBoxTOP10Facil.Items.Clear();
            listBoxTOP10Facil.IsEnabled = true;
            listBoxTOP10Medio.Items.Clear();
            listBoxTOP10Medio.IsEnabled = true;
            textBoxMTF.Text = "";
            textBoxMTM.Text = "";
            buttonApagar.Visibility = Visibility.Visible;

            ApresentarJogadoresTOP10();

            if (PedidoTOP1 != null)
            {
                PedidoTOP1("Facil");
                PedidoTOP1("Medio");
            }
            else
            {
                var messageDialog = new MessageDialog("Erro!", "ERRO");
                await messageDialog.ShowAsync();
            }
            if (textBoxMTF.Text == "9999 - Sem Registo - 0000-00-00 00:00:00 " && textBoxMTM.Text == "9999 - Sem Registo - 0000-00-00 00:00:00 ")
            {
                buttonApagar.Visibility = Visibility.Collapsed;
            }
        }

        public async void ApresentarJogadoresTOP10()
        {
            string data = string.Empty;
            string hora = string.Empty;
            string quando = string.Empty;
            string[] quandosplit = null;

            try
            {
                XDocument xmlResposta = (App.Current as App).s_1.GetConsultarTOP10();

                if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
                {
                    // apresenta mensagem de erro 
                    var messagedialog = new MessageDialog(xmlResposta.Element("resultado").Element("contexto").Value,
                                    "Erro");
                    await messagedialog.ShowAsync();
                }
                else
                {
                    foreach (var nivel in xmlResposta.Element("resultado").Element("objeto").Element("top").Descendants("nivel"))
                    {
                        if (string.Compare(nivel.Attribute("dificuldade").Value, "Facil") == 0)
                        {
                            foreach (var jogador in nivel.Descendants("jogador"))
                            {
                                quando = jogador.Attribute("quando").Value;
                                quandosplit = quando.Split('T', '.');
                                data = quandosplit[0];
                                hora = quandosplit[1];

                                listBoxTOP10Facil.Items.Add(jogador.Attribute("tempo").Value + " - "
                                                        + jogador.Attribute("username").Value + " - "
                                                        + data + " " + hora + " ");
                            }

                        }
                        else if (string.Compare(nivel.Attribute("dificuldade").Value, "Medio") == 0)
                        {
                            foreach (var jogador in nivel.Descendants("jogador"))
                            {
                                quando = jogador.Attribute("quando").Value;
                                quandosplit = quando.Split('T', '.');
                                data = quandosplit[0];
                                hora = quandosplit[1];

                                listBoxTOP10Medio.Items.Add(jogador.Attribute("tempo").Value + " - "
                                                        + jogador.Attribute("username").Value + " - "
                                                        + data + " " + hora + " ");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //throw ex;
                listBoxTOP10Facil.Items.Add("Sem acesso ao Servidor!");
                listBoxTOP10Facil.IsEnabled = false;
                listBoxTOP10Medio.Items.Add("Sem acesso ao Servidor!");
                listBoxTOP10Medio.IsEnabled = false;
            }
        }

        private async void ListViewTOP10Facil_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            {
                if (PedidoVerPerfil != null)
                {
                    PedidoVerPerfil(listBoxTOP10Facil.SelectedItem.ToString());
                }
                else
                {
                    var messageDialog = new MessageDialog("Erro!", "ERRO");
                    await messageDialog.ShowAsync();
                }
            }
        }

        private async void ListViewTOP10Medio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            {
                if (PedidoVerPerfil != null)
                {
                    PedidoVerPerfil(listBoxTOP10Medio.SelectedItem.ToString());
                }
                else
                {
                    var messageDialog = new MessageDialog("Erro!", "ERRO");
                    await messageDialog.ShowAsync();
                }
            }
        }

        private void buttonApagar_Click(object sender, RoutedEventArgs e)
        {
            //Falta apagar também o ficheiro!!!

            textBoxMTF.Text ="";
            textBoxMTM.Text = "";
        }
    }
}
