using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL1G06.Minesweeper.Winform.Views;
using PL1G06.Minesweeper.Common.Models;
using PL1G06.Minesweeper.Common.Diversos;
using System.Xml.Linq;

namespace PL1G06.Minesweeper.Winform.Views
{
	public partial class ViewTOP10 : Form, JanelaTOP10
	{
        public event DelegadoSemParametros PedidoVoltar;
        public event DelegadoParaPerfil PedidoVerPerfil;
        public event DelegadoSemParametros PedidoTOP10;
        public event DelegadoComDificuldade PedidoTOP1;

        public ViewTOP10()
		{
			InitializeComponent();

            //Program.C_Winform.RespostaTOP1 += C_Winform_RespostaTOP1;
            Program.M_TOP1.RespostaTOP1 += M_TOP1_RespostaTOP1;
            Program.M_TOP1.RespostaTOP10 += M_TOP1_RespostaTOP10;
        }

        private void M_TOP1_RespostaTOP10(List<string> nome, List<string> tempo, List<string> quando, string dificuldade)
        {
            throw new NotImplementedException();
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

        /*
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
                listBoxTOP10Facil.Items.Add(tempo + " - " + nome + " - " + data + " " + hora + " ");
            }
            else if (string.Compare(dificuldade, "Medio") == 0)
            {
                listBoxTOP10Medio.Items.Add(tempo + " - " + nome + " - " + data + " " + hora + " ");
            }
        }*/

        /*
        private void C_Winform_RespostaTOP1(string nome, string tempo, string quando, string dificuldade)
        {
            string data = string.Empty;
            string hora = string.Empty;
            string[] quandosplit = null;

            quandosplit = quando.Split('T', '.');
            data = quandosplit[0];
            hora = quandosplit[1];

            if (string.Compare(dificuldade, "Facil") == 0)
            {
                listBoxTOP10Facil.Items.Add(tempo + " - " + nome + " - " + data + " " + hora + " ");
            }
            else if (string.Compare(dificuldade, "Medio") == 0)
            {
                listBoxTOP10Medio.Items.Add(tempo + " - " + nome + " - " + data + " " + hora + " ");
            }
        }*/


		private void buttonVoltar_Click(object sender, EventArgs e)
		{
            if (PedidoVoltar != null)
            {
                PedidoVoltar();
            }
            else
            {
                MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxTOP10Facil_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(listBoxTOP10Facil.SelectedItem.ToString() != "Sem acesso ao Servidor!")
            {
                if (PedidoVerPerfil != null)
                {
                    PedidoVerPerfil(listBoxTOP10Facil.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listBoxTOP10Medio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listBoxTOP10Medio.SelectedItem.ToString() != "Sem acesso ao Servidor!")
            {
                if (PedidoVerPerfil != null)
                {
                    PedidoVerPerfil(listBoxTOP10Medio.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ApresentarJogadoresTop10()
        {
            string data = string.Empty;
            string hora = string.Empty;
            string quando = string.Empty;
            string[] quandosplit = null;

            try
            {
                XDocument xmlResposta = Program.S_1.GetConsultarTOP10();

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
            catch(Exception ex)
            {
                //throw ex;

                listBoxTOP10Facil.Items.Add("Sem acesso ao Servidor!");
                listBoxTOP10Facil.Enabled = false;
                listBoxTOP10Medio.Items.Add("Sem acesso ao Servidor!");
                listBoxTOP10Medio.Enabled = false;
            }
        }

        private void ViewTOP10_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                listBoxTOP10Facil.Items.Clear();
                listBoxTOP10Facil.Enabled = true;
                listBoxTOP10Medio.Items.Clear();
                listBoxTOP10Medio.Enabled = true;
                textBoxMTF.Clear();
                textBoxMTM.Clear();
                buttonApagar.Visible = true;
            }
            if (this.Visible)
            {
                ApresentarJogadoresTop10();

                if (PedidoTOP1 != null)
                {
                    PedidoTOP1("Facil");
                    PedidoTOP1("Medio");
                }
                else
                {
                    MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (textBoxMTF.Text == "9999 - Sem Registo - 0000-00-00 00:00:00 " && textBoxMTM.Text == "9999 - Sem Registo - 0000-00-00 00:00:00 ")
                {
                    buttonApagar.Visible = false;
                }
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            //Falta apagar também o ficheiro!!!

            textBoxMTF.Clear();
            textBoxMTM.Clear();
        }
    }
}
