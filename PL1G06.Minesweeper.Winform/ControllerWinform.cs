using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL1G06.Minesweeper.Winform.Views;
using PL1G06.Minesweeper.Common.Diversos;
using System.Xml.Linq;
using System.Xml;
using System.Globalization;

namespace PL1G06.Minesweeper.Winform
{
    public class ControllerWinform
    {
        //public event DelegadoParaRecordes RespostaTOP1;

        public enum DificuldadesDisponiveis
        {
            Facil = 0,
            Medio = 1
        }

        List<XElement> nomeJogadores;
        List<XElement> melhoresTempos;
        List<XElement> dataJogos;

        public ControllerWinform()
        {
            //V_Principal
            Program.V_Principal.PedidoSair += V_Principal_PedidoSair;
            Program.V_Principal.PedidoStandalone += V_Principal_PedidoStandalone;
            Program.V_Principal.PedidoRede += V_Principal_PedidoRede;
            Program.V_Principal.PedidoOpcoes += V_Principal_PedidoOpcoes;

            //V_Dificuldade
            Program.V_Dificuldade.PedidoVoltar += V_Dificuldade_PedidoVoltar;
            Program.V_Dificuldade.PedidoJogo += V_Dificuldade_PedidoJogo;

            //V_Game
            Program.V_Game.PedidoPerdeu += V_Game_PedidoPerdeu;
            Program.V_Game.PedidoGanhou += V_Game_PedidoGanhou;
            Program.V_Game.PedidoGuardar += V_Game_PedidoGuardar;

            //V_GOver
            Program.V_GOver.PedidoFechar += V_GOver_PedidoFechar;
            
            //V_Win
            Program.V_Win.PedidoFechar += V_Win_PedidoFechar;
            Program.V_Win.PedidoGuardar += V_Win_PedidoGuardar;
            Program.V_Win.PedidoRecorde += V_Win_PedidoRecorde;

            //V_Login
            Program.V_Login.PedidoVoltar += V_Login_PedidoVoltar;
            Program.V_Login.PedidoLogin += V_Login_PedidoLogin;
            Program.V_Login.PedidoCriarConta += V_Login_PedidoCriarConta;
            Program.V_Login.PedidoEsqueceuPassword += V_Login_PedidoEsqueceuPassword;

            //V_Registo
            Program.V_Registo.PedidoVoltar += V_Registo_PedidoVoltar;
            Program.V_Registo.PedidoRegistar += V_Registo_PedidoRegistar;
            Program.V_Registo.PedidoErro += V_Registo_PedidoErro;

            //V_Opcoes
            Program.V_Opcoes.PedidoVoltar += V_Opcoes_PedidoVoltar;
            Program.V_Opcoes.PedidoVerPerfil += V_Opcoes_PedidoVerPerfil;
            Program.V_Opcoes.PedidoTOP10 += V_Opcoes_PedidoTOP10;
            Program.V_Opcoes.PedidoRegras += V_Opcoes_PedidoRegras;
            Program.V_Opcoes.PedidoDescricao += V_Opcoes_PedidoDescricao;
            Program.V_Opcoes.PedidoLogout += V_Opcoes_PedidoLogout;
            Program.V_Opcoes.PedidoRede += V_Opcoes_PedidoRede;

            //V_Perfil
            Program.V_Perfil.PedidoVoltar += V_Perfil_PedidoVoltar;
            Program.V_Perfil.PedidoPerfil += V_Perfil_PedidoPerfil;

            //V_TOP10
            Program.V_TOP10.PedidoVoltar += V_TOP10_PedidoVoltar;
            Program.V_TOP10.PedidoVerPerfil += V_TOP10_PedidoVerPerfil;
            Program.V_TOP10.PedidoTOP10 += V_TOP10_PedidoTOP10;
            Program.V_TOP10.PedidoTOP1 += V_TOP10_PedidoTOP1;

            //V_Regras
            Program.V_Regras.PedidoVoltar += V_Regras_PedidoVoltar;

            //V_Descricao
            Program.V_Descricao.PedidoVoltar += V_Descricao_PedidoVoltar;

            //V_Erro
            Program.V_Erro.PedidoFechar += V_Erro_PedidoFechar;
        }


        /// Controla o pedido para leitura de historico de pontuação offline.
        /// Lança evento para apresentação da consulta.
        private void V_TOP10_PedidoTOP1(string dificuldade)
        {
            int indexDificuldade = 0;

            List<XElement> nomeJogadores = new List<XElement>();
            List<XElement> melhoresTempos = new List<XElement>();
            List<XElement> dataJogos = new List<XElement>();

            /*
            List<string> nomes = new List<string>();
            List<string> tempos = new List<string>();
            List<string> datas = new List<string>();*/

            DificuldadesDisponiveis[] valuesDificuldades = (DificuldadesDisponiveis[])Enum.GetValues(typeof(DificuldadesDisponiveis));

            for (int i = 0; i < valuesDificuldades.Length; i++)
            {
                if ((string.Compare(dificuldade, valuesDificuldades[i].ToString())) == 0)
                {
                    indexDificuldade = i;
                }
            }
            /*
            string nome = "default";
            string tempo = "9999";
            string quando = "2000-01-01T00:00:00.0";

            nomes.Add(nome);
            tempos.Add(tempo);
            datas.Add(quando);*/

            try
            {
                // Invoca método responsável por fazer a leitura do ficheiro XML dos recordes de pontuação.
                LerInformacaoTOP1(ref nomeJogadores, ref melhoresTempos, ref dataJogos);

                /*
                nomes[0] = nomeJogadores[indexDificuldade].ToString();
                tempos[0] = melhoresTempos[indexDificuldade].ToString();
                datas[0] = dataJogos[indexDificuldade].ToString();*/

                Program.M_TOP1.CriaTOP(nomeJogadores[indexDificuldade].Value, melhoresTempos[indexDificuldade].Value, dataJogos[indexDificuldade].Value, dificuldade);
                /*
                // Lança evento que será apanhado pelas Views para apresentarem a consulta do histórico de pontuação offline.
                if (RespostaTOP1 != null)
                {
                    RespostaTOP1(nomeJogadores[indexDificuldade].Value, melhoresTempos[indexDificuldade].Value, dataJogos[indexDificuldade].Value, dificuldade);
                }*/
            }
            catch
            {
                /*
                nomes[0] = "Sem Registo";
                tempos[0] = "9999";
                datas[0] = "0000-00-00T00:00:00.0";*/

                Program.M_TOP1.CriaTOP("Sem Registo", "9999", "0000-00-00T00:00:00.0", dificuldade);
                /*
                // Lança evento que será apanhado pelas Views para apresentarem a consulta do histórico de pontuação offline.
                if (RespostaTOP1 != null)
                {
                    RespostaTOP1("9999", "Sem Registo", "0000-00-00 00:00:00", dificuldade);
                }*/
            }
        }

        // Verifica se o jogo bateu o recorde existente
        // Definindo Program.M_Tabuleiro.Recorde para true caso recorde batido
        private void V_Win_PedidoRecorde(string time, string dificuldade)
        {
            int indexDificuldade = 0;
            Program.M_Tabuleiro.Recorde = false;

            //List<XElement> dificuldades = new List<XElement>();
            nomeJogadores = new List<XElement>();
            melhoresTempos = new List<XElement>();
            dataJogos = new List<XElement>();

            //// Determina o index da dificuldade
            //if (dificuldade == "Facil")
            //{
            //    indexDificuldade = 0;
            //}
            //else if (dificuldade == "Medio")
            //{
            //    indexDificuldade = 1;
            //}

            DificuldadesDisponiveis[] valuesDificuldades = (DificuldadesDisponiveis[])Enum.GetValues(typeof(DificuldadesDisponiveis));

            try
            {
                for (int i = 0; i < valuesDificuldades.Length; i++)
                {
                    if ((string.Compare(dificuldade, valuesDificuldades[i].ToString())) == 0)
                    {
                        indexDificuldade = i;
                    }
                }

                LerInformacaoTOP1(ref nomeJogadores, ref melhoresTempos, ref dataJogos);

                if (Int32.Parse(time) <= Int32.Parse(melhoresTempos[indexDificuldade].Value))
                {
                    Program.M_Tabuleiro.Recorde = true;
                }
            }
            catch
            {
                // Caso ficheiro ainda não exista ou tenha ocorrido erro na leitura

                nomeJogadores.Clear();
                melhoresTempos.Clear();
                dataJogos.Clear();

                Program.M_Tabuleiro.Recorde = true;

                for (int i = 0; i < valuesDificuldades.Length; i++)
                {
                    XElement nome = new XElement("default");
                    XElement tempo = new XElement("default");
                    XElement quando = new XElement("default");

                    nomeJogadores.Add(nome);
                    melhoresTempos.Add(tempo);
                    dataJogos.Add(quando);

                    nomeJogadores[i].Value = "default";
                    melhoresTempos[i].Value = "9999";
                    dataJogos[i].Value = "2000-01-01T00:00:00.0";
                }


                EscreverFicheiroTOP1(nomeJogadores, melhoresTempos, dataJogos);
            }
        }

        // Função que é executada quando clicamos no butão guardar(apenas disponível se tiver batido o recorde), recolhendo o nome que o jogador inseriu para guardar no ficheiro
        private void V_Win_PedidoGuardar(string nome, string tempo, string quando, string dificuldade)
        {
            DificuldadesDisponiveis[] valuesDificuldades = (DificuldadesDisponiveis[])Enum.GetValues(typeof(DificuldadesDisponiveis));

            int indexDificuldade = 0;

            ////List<XElement> dificuldades = new List<XElement>();
            //List<XElement> nomeJogadores = new List<XElement>();
            //List<XElement> melhoresTempos = new List<XElement>();
            //List<XElement> dataJogos = new List<XElement>();

            //// Determina o index da dificuldade
            //if (dificuldade == "Facil")
            //{
            //    indexDificuldade = 0;
            //    dificuldades[indexDificuldade].Value = "Facil";
            //}
            //else if (dificuldade == "Medio")
            //{
            //    indexDificuldade = 1;
            //    dificuldades[indexDificuldade].Value = "Medio";
            //}

            for (int i = 0; i < valuesDificuldades.Length; i++)
            {
                if ((string.Compare(dificuldade, valuesDificuldades[i].ToString())) == 0)
                {
                    indexDificuldade = i;
                }
            }

            nomeJogadores[indexDificuldade].Value = nome;
            melhoresTempos[indexDificuldade].Value = tempo;
            dataJogos[indexDificuldade].Value = quando;

            EscreverFicheiroTOP1(nomeJogadores, melhoresTempos, dataJogos);

            (Program.V_Principal as Form).Show();
            (Program.V_Game as Form).Hide();
            (Program.V_Win as Form).Hide();
        }

        public void LerInformacaoTOP1(ref List<XElement> nomeJogadores, ref List<XElement> melhoresTempos, ref List<XElement> dataJogos)
        {
            XDocument file = XDocument.Load("TOP1.xml");

            var nomeJogadoresLeitura = file.Descendants("nome");
            var melhoresTemposLeitura = file.Descendants("tempo");
            var dataJogosLeitura = file.Descendants("quando");

            nomeJogadores = nomeJogadoresLeitura.ToList();
            melhoresTempos = melhoresTemposLeitura.ToList();
            dataJogos = dataJogosLeitura.ToList();
        }

        public void EscreverFicheiroTOP1(List<XElement> nomeJogadores, List<XElement> melhoresTempos, List<XElement> dataJogos)
        {
            DificuldadesDisponiveis[] valuesDificuldades = (DificuldadesDisponiveis[])Enum.GetValues(typeof(DificuldadesDisponiveis));

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            XmlWriter xmlWriter = XmlWriter.Create("TOP1.xml", settings);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("TOP1");
            for (int i = 0; i < valuesDificuldades.Length; i++)
            {
                xmlWriter.WriteStartElement("Recorde");
                xmlWriter.WriteAttributeString("dificuldade", valuesDificuldades[i].ToString());

                Console.WriteLine("\n " + valuesDificuldades[i].ToString());

                xmlWriter.WriteStartElement("nome");
                xmlWriter.WriteString(nomeJogadores[i].Value);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("tempo");
                xmlWriter.WriteString(melhoresTempos[i].Value);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("quando");
                xmlWriter.WriteString(dataJogos[i].Value);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }

        private void V_Game_PedidoGuardar(string id, string nivel, string tempo, string vitoria)
        {
            try
            {
                XDocument xmlResposta = Program.S_1.PostRegistarResultado(id, nivel, tempo, vitoria);

                if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
                {
                    MessageBox.Show(xmlResposta.Element("resultado").Element("contexto").Value,
                            "ERRO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO!" + ex.Message);
            }
        }

        private void V_Opcoes_PedidoRede()
        {
            (Program.V_Login as Form).Show();
            (Program.V_Opcoes as Form).Hide();
        }

        private void V_Registo_PedidoErro()
        {
            (Program.V_Erro as Form).Show();
        }

        private void V_Opcoes_PedidoLogout()
        {
            Program.M_Jogador.ID = null;
            Program.M_Jogador.username = null;

            (Program.V_Opcoes as Form).Hide();
            (Program.V_Opcoes as Form).Show();
            MessageBox.Show("Logout realizado com sucesso!");
        }

        private void V_TOP10_PedidoTOP10()
        {
            //throw new NotImplementedException();
        }

        private void V_TOP10_PedidoVerPerfil(string username)
        {
            //para ver o perfil da pessoa selecionada na lista
            string user = username.Substring(username.IndexOf('-') + 2);
            Program.M_JogadorConsulta.username = user.Split('-')[0];   //split faz com apenas seja "usado" o username da linha selcionada na listbox
            //mostrar o perfil do user selecionado
            //Program.S_1.GetPerfil(Program.M_Jogador.username);

            (Program.V_Perfil as Form).Show();
        }

        private void V_Perfil_PedidoPerfil()
        {
            //throw new NotImplementedException();
        }

        private void V_Opcoes_PedidoDescricao()
        {
            (Program.V_Descricao as Form).Show();
            (Program.V_Opcoes as Form).Hide();
        }

        private void V_Opcoes_PedidoRegras()
        {
            (Program.V_Regras as Form).Show();
            (Program.V_Opcoes as Form).Hide();
        }

        private void V_Opcoes_PedidoTOP10()
        {
            (Program.V_TOP10 as Form).Show();
            (Program.V_Opcoes as Form).Hide();
        }

        private void V_Opcoes_PedidoVerPerfil(string username)
        {
            Program.M_JogadorConsulta.username = username;
            (Program.V_Perfil as Form).Show();
        }

        private void V_Registo_PedidoRegistar(string username, string password, string nome, string email, string pais, string foto)
        {
            try
            {
                //if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(pais))
                //{
                    XDocument xmlResposta = Program.S_1.PostRegisto(foto, username, password, nome, email, pais);

                    if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
                    {
                        MessageBox.Show(xmlResposta.Element("resultado").Element("contexto").Value,
                                "ERRO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Registo realizado com sucesso!");
                        //apos o registo passa logo para a viewLogin
                        (Program.V_Login as Form).Show();
                        (Program.V_Registo as Form).Hide();
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO!" + ex.Message);
            }
        }

        private void V_Login_PedidoEsqueceuPassword()
        {
            //throw new NotImplementedException();
        }

        private void V_Login_PedidoCriarConta()
        {
            (Program.V_Registo as Form).Show();
            (Program.V_Login as Form).Hide();
        }

        private void V_Login_PedidoLogin(string username, string password)
        {
            try
            {
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    XDocument xmlResposta = Program.S_1.PostLogins(username, password);

                    if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
                    {
                        // apresenta mensagem de erro 
                        MessageBox.Show(xmlResposta.Element("resultado").Element("contexto").Value,
                                        "Erro",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        // assume a autenticação e obtem o ID do resultado...para ser usado noutros pedidos 
                        Program.M_Jogador.ID = xmlResposta.Element("resultado").Element("objeto").Element("ID").Value;
                        //MessageBox.Show("Login realizado com sucesso! O ID criado : " + Program.M_Jogador.ID); //mostra o id do jogador
                        Program.M_Jogador.username = username;
                        Program.M_JogadorConsulta.username = username;
                        MessageBox.Show("Login realizado com sucesso! username: " + Program.M_Jogador.username); //mostra o user do jogador

                        //chama a viewPerfil para apresentar os dados do jogador que acabou de fazer login
                        (Program.V_Principal as Form).Show();
                        (Program.V_Perfil as Form).Show();
                        (Program.V_Login as Form).Hide();
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void V_Game_PedidoGanhou()
        {
            (Program.V_Win as Form).Show();
        }

        private void V_Game_PedidoPerdeu()
        {
            (Program.V_GOver as Form).Show();
        }

        private void V_Dificuldade_PedidoJogo(Common.Models.Tabuleiro tab)
        {
            Program.M_Tabuleiro.n_linhas = tab.n_linhas;
            Program.M_Tabuleiro.n_colunas = tab.n_colunas;
            Program.M_Tabuleiro.n_minas = tab.n_minas;
            Program.M_Tabuleiro.n_flags = tab.n_flags;

            (Program.V_Game as Form).Show();
            (Program.V_Dificuldade as Form).Hide();
        }

        private void V_Principal_PedidoOpcoes()
        {
            (Program.V_Opcoes as Form).Show();
            (Program.V_Principal as Form).Hide();
        }

        private void V_Principal_PedidoRede()
        {
            if(Program.M_Jogador.ID == null)
            {
                (Program.V_Login as Form).Show();
                (Program.V_Principal as Form).Hide();
            }
            else
            {
                Program.M_Tabuleiro.Rede = true;

                (Program.V_Dificuldade as Form).Show();
                (Program.V_Principal as Form).Hide();
            }
        }

        private void V_Principal_PedidoStandalone()
        {
            Program.M_Tabuleiro.Rede = false;

            (Program.V_Dificuldade as Form).Show();
            (Program.V_Principal as Form).Hide();
        }

        private void V_Erro_PedidoFechar()
        {
            (Program.V_Erro as Form).Hide();
        }

        private void V_Descricao_PedidoVoltar()
        {
            (Program.V_Opcoes as Form).Show();
            (Program.V_Descricao as Form).Hide();
        }

        private void V_Regras_PedidoVoltar()
        {
            (Program.V_Opcoes as Form).Show();
            (Program.V_Regras as Form).Hide();
        }

        private void V_TOP10_PedidoVoltar()
        {
            (Program.V_Opcoes as Form).Show();
            (Program.V_TOP10 as Form).Hide();
        }

        private void V_Perfil_PedidoVoltar()
        {
            (Program.V_Perfil as Form).Hide();
        }

        private void V_Opcoes_PedidoVoltar()
        {
            (Program.V_Principal as Form).Show();
            (Program.V_Opcoes as Form).Hide();
        }

        private void V_Registo_PedidoVoltar()
        {
            (Program.V_Login as Form).Show();
            (Program.V_Registo as Form).Hide();
        }

        private void V_Login_PedidoVoltar()
        {
            (Program.V_Principal as Form).Show();
            (Program.V_Login as Form).Hide();
        }

        private void V_Win_PedidoFechar()
        {
            (Program.V_Principal as Form).Show();
            //(Program.V_Game as Form).Controls.Clear();
            (Program.V_Game as Form).Hide();
            (Program.V_Win as Form).Hide();
        }

        private void V_GOver_PedidoFechar()
        {
            (Program.V_Principal as Form).Show();
            //(Program.V_Game as Form).Controls.Clear();
            (Program.V_Game as Form).Hide();
            (Program.V_GOver as Form).Hide();
        }

        private void V_Dificuldade_PedidoVoltar()
        {
            (Program.V_Principal as Form).Show();
            (Program.V_Dificuldade as Form).Hide();
        }

        private void V_Principal_PedidoSair()
        {
            Application.Exit();
        }
    }
}
