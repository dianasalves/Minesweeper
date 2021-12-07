using PL1G06.Minesweeper.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Xml.Linq;
using System.Media;
using PL1G06.Minesweeper.Common.Diversos;

namespace PL1G06.Minesweeper.Winform.Views
{
	public partial class ViewPerfil : Form, JanelaPerfil
	{
        public event DelegadoSemParametros PedidoVoltar;
        public event DelegadoSemParametros PedidoPerfil;

		public ViewPerfil()
		{
			InitializeComponent();
		}

		private void ViewPerfil_Load(object sender, EventArgs e)
		{
            //if (PedidoPerfil != null)
            //{
            //    PedidoPerfil();
            //}
            //else
            //{
            //    MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //chama a função para apresentar os dados do Jogador
            //ApresentarDados(Program.M_Jogador.username);
		}

        public void ApresentarDados(string username)
        {
            XDocument xmlResposta = Program.S_1.GetPerfil(username);

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
                labelUsername.Text = '@' + username;
                textBoxNome.Text = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("nomeabreviado").Value;
                textBoxEmail.Text = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("email").Value;
                textBoxPais.Text = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("pais").Value;
                textBoxJG.Text = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("jogos").Element("ganhos").Value;
                textBoxJP.Text = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("jogos").Element("perdidos").Value;
                textBoxMTF.Text = (string) xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("tempos").Element("facil");
                textBoxMTM.Text = (string) xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("tempos").Element("Medio");

                string base64Imagem = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("fotografia").Value;
                //NOTA IMPORTANTE: MUDAR PARA "1" OU PARA "0", CASO CAI NUM EXEPÇÃO NAs DUAS LINHAs SEGUINTES::
                try
                {
                    string base64 = base64Imagem.Split(',')[0];   // retira a parte da string correspondente aos bytes da imagem.. 
                    byte[] bytes = Convert.FromBase64String(base64);
                    Image image = Image.FromStream(new MemoryStream(bytes));//... e, por fim, para Image 
                                                                            // pode mostrar a imagem num qualquer componente...como por exemplo: 
                    pictureBoxFotografia.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBoxFotografia.BackgroundImage = image;

                    buttonConsultar.Show();
                    buttonProcurar.Hide();
                    textBoxUsername.Hide();
                }
                catch
                {
                    string base64 = base64Imagem.Split(',')[1];   // retira a parte da string correspondente aos bytes da imagem.. 
                    byte[] bytes = Convert.FromBase64String(base64);
                    Image image = Image.FromStream(new MemoryStream(bytes));//... e, por fim, para Image 
                    // pode mostrar a imagem num qualquer componente...como por exemplo: 
                    pictureBoxFotografia.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBoxFotografia.BackgroundImage = image;

                    buttonConsultar.Show();
                    buttonProcurar.Hide();
                    textBoxUsername.Hide();
                }
                 
            }
        }

        public void ApagarDados()
        {
            labelUsername.Text = "@username";
            textBoxNome.Text = "";
            textBoxEmail.Text = "";
            textBoxPais.Text = "";
            textBoxJG.Text = "";
            textBoxJP.Text = "";
            textBoxMTF.Text = "";
            textBoxMTM.Text = "";
            pictureBoxFotografia.BackgroundImage = null;
        }

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

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewPerfil_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                ApresentarDados(Program.M_JogadorConsulta.username);
            }
            if (!this.Visible)
            {
                ApagarDados();
            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            buttonConsultar.Hide();
            buttonProcurar.Show();
            textBoxUsername.Show();
            this.AcceptButton = buttonProcurar;
            ApagarDados();
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            Program.M_JogadorConsulta.username = textBoxUsername.Text;
            ApresentarDados(Program.M_JogadorConsulta.username);
        }
    }
}