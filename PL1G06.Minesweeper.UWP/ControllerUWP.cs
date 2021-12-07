using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using PL1G06.Minesweeper.UWP.Views;
using System.Xml.Linq;
using Windows.UI.Popups;
using System.Reflection.Metadata;

namespace PL1G06.Minesweeper.UWP
{
    public class ControllerUWP
    {
        public enum DificuldadesDisponiveis
        {
            Facil = 0,
            Medio = 1
        }

        List<XElement> nomeJogadores;
        List<XElement> melhoresTempos;
        List<XElement> dataJogos;

        public ControllerUWP()
        {
            //V_Principal
            if ((App.Current as App).V_Principal != null)
            {
                ConfiguraMensagensViewPrincipal();
            }

            //V_Dificuldade
            if ((App.Current as App).V_Dificuldade != null)
            {
                ConfiguraMensagensViewDificuldade();
            }

            //V_Game
            if ((App.Current as App).V_Game != null)
            {
                ConfiguraMensagensViewGame();
            }

            //V_GOver
            if ((App.Current as App).V_GOver != null)
            {
                ConfiguraMensagensViewGOver();
            }

            //V_Win
            if ((App.Current as App).V_Win != null)
            {
                ConfiguraMensagensViewWin();
            }

            //V_Login
            if ((App.Current as App).V_Login != null)
            {
                ConfiguraMensagensViewLogin();
            }

            //V_Registo
            if ((App.Current as App).V_Registo != null)
            {
                ConfiguraMensagensViewRegisto();
            }

            //V_Opcoes
            if ((App.Current as App).V_Opcoes != null)
            {
                ConfiguraMensagensViewOpcoes();
            }

            //V_Perfil
            if ((App.Current as App).V_Perfil != null)
            {
                ConfiguraMensagensViewPerfil();
            }

            //V_TOP10
            if ((App.Current as App).V_TOP10 != null)
            {
                ConfiguraMensagensViewTOP10();
            }

            //V_Regras
            if ((App.Current as App).V_Regras != null)
            {
                ConfiguraMensagensViewRegras();
            }

            //V_Descricao
            if ((App.Current as App).V_Descricao != null)
            {
                ConfiguraMensagensViewDescricao();
            }

            //V_Erro
            if ((App.Current as App).V_Erro != null)
            {
                ConfiguraMensagensViewErro();
            }
        }

        //V_Principal
        public void ConfiguraMensagensViewPrincipal()
        {
            (App.Current as App).V_Principal.PedidoSair += V_Principal_PedidoSair;
            (App.Current as App).V_Principal.PedidoStandalone += V_Principal_PedidoStandalone;
            (App.Current as App).V_Principal.PedidoRede += V_Principal_PedidoRede;
            (App.Current as App).V_Principal.PedidoOpcoes += V_Principal_PedidoOpcoes;
        }

        //V_Dificuldade
        public void ConfiguraMensagensViewDificuldade()
        {
            (App.Current as App).V_Dificuldade.PedidoVoltar += V_Dificuldade_PedidoVoltar;
            (App.Current as App).V_Dificuldade.PedidoJogo += V_Dificuldade_PedidoJogo;
        }

        //V_Game
        public void ConfiguraMensagensViewGame()
        {
            (App.Current as App).V_Game.PedidoPerdeu += V_Game_PedidoPerdeu;
            (App.Current as App).V_Game.PedidoGanhou += V_Game_PedidoGanhou;
            (App.Current as App).V_Game.PedidoGuardar += V_Game_PedidoGuardar;
        }
      

        //V_GOver
        public void ConfiguraMensagensViewGOver()
        {
            (App.Current as App).V_GOver.PedidoFechar += V_GOver_PedidoFechar;
        }

        //V_Win
        public void ConfiguraMensagensViewWin()
        {
            (App.Current as App).V_Win.PedidoFechar += V_Win_PedidoFechar;
            (App.Current as App).V_Win.PedidoGuardar += V_Win_PedidoGuardar;
            (App.Current as App).V_Win.PedidoRecorde += V_Win_PedidoRecorde;
        }

        //V_Login
        public void ConfiguraMensagensViewLogin()
        {
            (App.Current as App).V_Login.PedidoVoltar += V_Login_PedidoVoltar;
            (App.Current as App).V_Login.PedidoLogin += V_Login_PedidoLogin;
            (App.Current as App).V_Login.PedidoCriarConta += V_Login_PedidoCriarConta;
            (App.Current as App).V_Login.PedidoEsqueceuPassword += V_Login_PedidoEsqueceuPassword;
        }

        //V_Registo
        public void ConfiguraMensagensViewRegisto()
        {
            (App.Current as App).V_Registo.PedidoVoltar += V_Registo_PedidoVoltar;
            (App.Current as App).V_Registo.PedidoRegistar += V_Registo_PedidoRegistar1;
            (App.Current as App).V_Registo.PedidoErro += V_Registo_PedidoErro;
        }

        //V_Opcoes
        public void ConfiguraMensagensViewOpcoes()
        {
            (App.Current as App).V_Opcoes.PedidoVoltar += V_Opcoes_PedidoVoltar;
            (App.Current as App).V_Opcoes.PedidoVerPerfil += V_Opcoes_PedidoVerPerfil1;
            (App.Current as App).V_Opcoes.PedidoTOP10 += V_Opcoes_PedidoTOP10;
            (App.Current as App).V_Opcoes.PedidoRegras += V_Opcoes_PedidoRegras;
            (App.Current as App).V_Opcoes.PedidoDescricao += V_Opcoes_PedidoDescricao;
            (App.Current as App).V_Opcoes.PedidoLogout += V_Opcoes_PedidoLogout;
            (App.Current as App).V_Opcoes.PedidoRede += V_Opcoes_PedidoRede;
        }

        //V_Perfil
        public void ConfiguraMensagensViewPerfil()
        {
            (App.Current as App).V_Perfil.PedidoVoltar += V_Perfil_PedidoVoltar;
            (App.Current as App).V_Perfil.PedidoPerfil += V_Perfil_PedidoPerfil;
        }

        //V_TOP10
        public void ConfiguraMensagensViewTOP10()
        {
            (App.Current as App).V_TOP10.PedidoVoltar += V_TOP10_PedidoVoltar;
            (App.Current as App).V_TOP10.PedidoVerPerfil += V_TOP10_PedidoVerPerfil;
            (App.Current as App).V_TOP10.PedidoTOP10 += V_TOP10_PedidoTOP10;
            //(App.Current as App).V_TOP10.PedidoTOP1 += V_TOP10_PedidoTOP1;
        }

        //V_Regras
        public void ConfiguraMensagensViewRegras()
        {
            (App.Current as App).V_Regras.PedidoVoltar += V_Regras_PedidoVoltar;
        }

        //V_Descricao
        public void ConfiguraMensagensViewDescricao()
        {
            (App.Current as App).V_Descricao.PedidoVoltar += V_Descricao_PedidoVoltar;
        }

        //V_Erro
        public void ConfiguraMensagensViewErro()
        {
            (App.Current as App).V_Erro.PedidoFechar += V_Erro_PedidoFechar;
        }



        public async Task V_TOP10_PedidoTOP1(string dificuldade)
        {
            int indexDificuldade = 0;
            
            DificuldadesDisponiveis[] valuesDificuldades = (DificuldadesDisponiveis[])Enum.GetValues(typeof(DificuldadesDisponiveis));

            string[] nomeJogadores = new string[valuesDificuldades.Length];
            string[] melhoresTempos = new string[valuesDificuldades.Length];
            string[] dataJogos = new string[valuesDificuldades.Length];

            for (int i = 0; i < valuesDificuldades.Length; i++)
            {
                if ((string.Compare(dificuldade, valuesDificuldades[i].ToString())) == 0)
                {
                    indexDificuldade = i;
                }
            }

            try
            {
                // Invoca método responsável por fazer a leitura do ficheiro XML dos recordes de pontuação.
                await LerInformacaoTOP1(nomeJogadores, melhoresTempos, dataJogos);

                (App.Current as App).M_TOP1.CriaTOP(nomeJogadores[indexDificuldade], melhoresTempos[indexDificuldade], dataJogos[indexDificuldade], dificuldade);

            }
            catch
            {
                (App.Current as App).M_TOP1.CriaTOP("Sem Registo", "9999", "0000-00-00T00:00:00.0", dificuldade);
            }
        }

        public async Task LerInformacaoTOP1(string[] nomeJogadores, string[] melhoresTempos, string[] dataJogos)
        {
            try
            {
                int i = 0;

                // Abre localização do ficheiro e prepara o ficheiro para leitura.
                Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                Windows.Storage.StorageFile sampleFile = await storageFolder.GetFileAsync("TOP1.xml");

                string text = await Windows.Storage.FileIO.ReadTextAsync(sampleFile);

                XDocument doc = XDocument.Parse(text);

                var registo = from al in doc.Element("TOP1").Descendants("Recorde") select al;

                foreach (var campos in registo)
                {
                    nomeJogadores[i] = campos.Element("Nome").Value;
                    melhoresTempos[i] = campos.Element("Tempo").Value;
                    dataJogos[i] = campos.Element("Tempo").Value;

                    i++;
                }
            }
            catch
            {
                throw new Exception();
            }
        }

        private void V_Opcoes_PedidoRede()
        {
            throw new NotImplementedException();
        }

        private void V_Win_PedidoRecorde(string tempo, string dificuldade)
        {
            throw new NotImplementedException();
        }

        private void V_Win_PedidoGuardar(string nome, string tempo, string quando, string dificuldade)
        {
            throw new NotImplementedException();
        }

        private async void V_Game_PedidoGuardar(string id, string nivel, string tempo, string vitoria)
        {
            try
            {
                XDocument xmlResposta = (App.Current as App).s_1.PostRegistarResultado(id, nivel, tempo, vitoria);

                if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
                {
                    var messageDialog = new MessageDialog(xmlResposta.Element("resultado").Element("contexto").Value,
                            "ERRO");
                    messageDialog.DefaultCommandIndex = 0;
                    await messageDialog.ShowAsync();
                }
            }
            catch (Exception ex)
            {
                var messageDialogg = new MessageDialog("ERRO!" + ex.Message);
                messageDialogg.DefaultCommandIndex = 0;
                await messageDialogg.ShowAsync();
            }
        }

        private void V_Erro_PedidoFechar()
        {
            //pressupondo que vai ser mostrado este erro caso os campos do registo estejam incompletos
            ((App.Current as App).V_Erro as Page).Frame.Navigate(typeof(ViewRegisto), null);
        }

        private void V_Descricao_PedidoVoltar()
        {
            ((App.Current as App).V_Descricao as Page).Frame.Navigate(typeof(ViewOpcoes), null);
        }

        private void V_Regras_PedidoVoltar()
        {
            ((App.Current as App).V_Regras as Page).Frame.Navigate(typeof(ViewOpcoes), null);
        }

        private void V_TOP10_PedidoTOP10()
        {
            //throw new NotImplementedException();
        }

        private void V_TOP10_PedidoVerPerfil(string username)
        {
            ////para ver o perfil da pessoa selecionada na lista
            //string user = username.Substring(username.IndexOf(';'));
            //(App.Current as App).M_JogadorConsulta.username = user.Split(';')[1];   //split faz com apenas seja "usado" o username da linha selcionada na listbox
            ////mostrar o perfil do user selecionado
            ////Program.S_1.GetPerfil(Program.M_Jogador.username);
            ((App.Current as App).V_TOP10 as Page).Frame.Navigate(typeof(ViewPerfil), null);
        }

        private void V_TOP10_PedidoVoltar()
        {
            ((App.Current as App).V_TOP10 as Page).Frame.Navigate(typeof(ViewOpcoes), null);
        }

        private void V_Perfil_PedidoPerfil()
        {
            //throw new NotImplementedException();
        }

        private void V_Perfil_PedidoVoltar()
        {
            ((App.Current as App).V_Perfil as Page).Frame.Navigate(typeof(ViewOpcoes), null);
            //((App.Current as App).V_Perfil as Page).Frame.GoBack();
        }

        private async void V_Opcoes_PedidoLogout()
        {
            (App.Current as App).M_Jogador.ID = null;
            (App.Current as App).M_Jogador.username = null;
            ((App.Current as App).V_Opcoes as Page).Frame.Navigate(typeof(ViewOpcoes), null);
            var messageDialog = new MessageDialog("Logout realizado com sucesso!");
            messageDialog.DefaultCommandIndex = 0;
            await messageDialog.ShowAsync();
        }

        private void V_Opcoes_PedidoDescricao()
        {
            ((App.Current as App).V_Opcoes as Page).Frame.Navigate(typeof(ViewDescricao), null);
        }

        private void V_Opcoes_PedidoRegras()
        {
            ((App.Current as App).V_Opcoes as Page).Frame.Navigate(typeof(ViewRegras), null);
        }

        private void V_Opcoes_PedidoTOP10()
        {

            ((App.Current as App).V_Opcoes as Page).Frame.Navigate(typeof(ViewTOP10), null);
        }


        private void V_Opcoes_PedidoVerPerfil1(string username)
        {
            (App.Current as App).M_JogadorConsulta.username = username;
            ((App.Current as App).V_Opcoes as Page).Frame.Navigate(typeof(ViewPerfil), null);
        }


        private void V_Opcoes_PedidoVoltar()
        {
            ((App.Current as App).V_Opcoes as Page).Frame.Navigate(typeof(ViewPrincipal), null);
        }

        private void V_Registo_PedidoErro()
        {
            ((App.Current as App).V_Registo as Page).Frame.Navigate(typeof(ViewErro), null);
        }

        private async void V_Registo_PedidoRegistar1(string username, string password, string nome, string email, string pais, string foto)
        {
            try
            {

                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(pais))
                {

                    XDocument xmlResposta = (App.Current as App).s_1.PostRegisto(foto, username, password, nome, email, pais);

                    if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
                    {
                        var messageDialog = new MessageDialog("ERRO!" + xmlResposta.Element("resultado").Element("contexto").Value);
                        messageDialog.DefaultCommandIndex = 0;
                        await messageDialog.ShowAsync();

                    }
                    else
                    {

                        var messageDialogg = new MessageDialog("Registo realizado com sucesso!");
                        messageDialogg.DefaultCommandIndex = 0;
                        await messageDialogg.ShowAsync();

                        //chama a view login para fazer o login com os dados registados
                        ((App.Current as App).V_Registo as Page).Frame.Navigate(typeof(ViewLogin), null);

                    }
                }
            }
            catch (Exception ex)
            {
                var messageDialogg = new MessageDialog("ERRO!" + ex.Message);
                messageDialogg.DefaultCommandIndex = 0;
                await messageDialogg.ShowAsync();
            }
        }
    

        private void V_Registo_PedidoVoltar()
        {
            ((App.Current as App).V_Registo as Page).Frame.Navigate(typeof(ViewLogin), null);
        }

        private void V_Login_PedidoEsqueceuPassword()
        {
            //throw new NotImplementedException();
            //NÃO É NECESSÁRIO PORQUE O SERVER NÃO TEM ESSA OPÇÃO
        }

        private void V_Login_PedidoCriarConta()
        {
            ((App.Current as App).V_Login as Page).Frame.Navigate(typeof(ViewRegisto), null);
        }

        private async void V_Login_PedidoLogin(string username, string password)
        {
            try
            {
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                   
                    XDocument xmlResposta = (App.Current as App).s_1.PostLogins(username, password);

                    if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
                    {
                        // apresenta mensagem de erro 
                        var messageDialog = new MessageDialog("Erro: " + xmlResposta.Element("resultado").Element("contexto").Value + "ERRO!");
                        messageDialog.DefaultCommandIndex = 0;
                        await messageDialog.ShowAsync();
                    }
                    else
                    {

                        // assume a autenticação e obtem o ID do resultado...para ser usado noutros pedidos 
                        (App.Current as App).M_Jogador.ID = xmlResposta.Element("resultado").Element("objeto").Element("ID").Value;
                      
                        (App.Current as App).M_JogadorConsulta.username = username;
                        (App.Current as App).M_Jogador.username = username;
                        var messagemDialog = new MessageDialog("LOGIN REALIZADO COM SUCESSO! USERNAME: " + (App.Current as App).M_Jogador.username); //mostra o id do jogador(é atribuido pelo servidor)
                        messagemDialog.DefaultCommandIndex = 0;
                        await messagemDialog.ShowAsync();


                        (App.Current as App).s_1.GetPerfil((App.Current as App).M_Jogador.username);

                        //mostrar a view perfil 
                        ((App.Current as App).V_Login as Page).Frame.Navigate(typeof(ViewPerfil), null);
                    }
                }
            }
            catch (Exception ex)
            {
                var messageDialogg = new MessageDialog("ERRO!" + ex.Message);
                messageDialogg.DefaultCommandIndex = 0;
                await messageDialogg.ShowAsync();
            }
        }

        private void V_Login_PedidoVoltar()
        {
            ((App.Current as App).V_Login as Page).Frame.Navigate(typeof(ViewPrincipal), null);
        }

        private void V_Win_PedidoFechar()
        {
            ((App.Current as App).V_Win as Page).Frame.Navigate(typeof(ViewPrincipal), null);
        }

        private void V_GOver_PedidoFechar()
        {
            ((App.Current as App).V_GOver as Page).Frame.Navigate(typeof(ViewPrincipal), null);
        }

        private void V_Game_PedidoGanhou()
        {
            ((App.Current as App).V_Game as Page).Frame.Navigate(typeof(ViewWin), null);
        }

        private void V_Game_PedidoPerdeu()
        {
            ((App.Current as App).V_Game as Page).Frame.Navigate(typeof(ViewGOver), null);
        }

        private void V_Dificuldade_PedidoJogo(Common.Models.Tabuleiro tab)
        {
            (App.Current as App).M_Tabuleiro.n_linhas = tab.n_linhas;
            (App.Current as App).M_Tabuleiro.n_colunas = tab.n_colunas;
            (App.Current as App).M_Tabuleiro.n_minas = tab.n_minas;
            (App.Current as App).M_Tabuleiro.n_flags = tab.n_flags;

            ((App.Current as App).V_Dificuldade as Page).Frame.Navigate(typeof(ViewGame), null);
        }

        private void V_Dificuldade_PedidoVoltar()
        {
            ((App.Current as App).V_Dificuldade as Page).Frame.Navigate(typeof(ViewPrincipal), null);
        }

        private void V_Principal_PedidoOpcoes()
        {
            ((App.Current as App).V_Principal as Page).Frame.Navigate(typeof(ViewOpcoes), null);
        }

        private void V_Principal_PedidoRede()
        {

            if((App.Current as App).M_Jogador.ID == null)
            {
              
                ((App.Current as App).V_Principal as Page).Frame.Navigate(typeof(ViewLogin), null);
                //(Program.V_Principal as Form).Hide();
            }
            else if((App.Current as App).M_Jogador.ID != null)
            {
                (App.Current as App).M_Tabuleiro.Rede = true;

                ((App.Current as App).V_Principal as Page).Frame.Navigate(typeof(ViewDificuldade), null);
                //(Program.V_Dificuldade as Form).Show();
                //(Program.V_Principal as Form).Hide();
            }
            
        }

        private void V_Principal_PedidoStandalone()
        {
            (App.Current as App).M_Tabuleiro.Rede = false;
            ((App.Current as App).V_Principal as Page).Frame.Navigate(typeof(ViewDificuldade), null);
        }

        private void V_Principal_PedidoSair()
        {
            Windows.UI.Xaml.Application.Current.Exit();
        }
    }
}
