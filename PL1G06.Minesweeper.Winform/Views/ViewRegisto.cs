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
using System.Net;
using System.Net.Http;
using System.IO;
using System.Xml.Linq;
using System.Net.Security;
using PL1G06.Minesweeper.Common.Diversos;
using System.Xml;

namespace PL1G06.Minesweeper.Winform.Views
{
	public partial class ViewRegisto : Form, JanelaRegisto
	{
        public event DelegadoSemParametros PedidoVoltar;
        public event DelegadoParaRegistar PedidoRegistar;
        public event DelegadoSemParametros PedidoErro;

        public ViewRegisto()
		{
			InitializeComponent();
        }

		private void buttonRegistar_Click(object sender, EventArgs e)
        {
            if (PedidoVoltar != null && !string.IsNullOrEmpty(textBoxUsername.Text) && !string.IsNullOrEmpty(textBoxPassword.Text) && !string.IsNullOrEmpty(textBoxNome.Text) && !string.IsNullOrEmpty(textBoxEmail.Text) && !string.IsNullOrEmpty(comboBoxPais.SelectedIndex.ToString()) && comboBoxPais.SelectedIndex != -1)
            {
                PedidoRegistar(textBoxUsername.Text, textBoxPassword.Text, textBoxNome.Text, textBoxEmail.Text, comboBoxPais.SelectedItem.ToString(), FotografiaConverter());
            }
            else
            {
                MessageBox.Show("Erro! Campos incompletos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*
            try
            {
                if (!string.IsNullOrEmpty(textBoxUsername.Text) && !string.IsNullOrEmpty(textBoxPassword.Text) && !string.IsNullOrEmpty(textBoxNome.Text) && !string.IsNullOrEmpty(textBoxEmail.Text) && !string.IsNullOrEmpty(comboBoxPais.SelectedIndex.ToString()))
                {
                    XDocument xmlResposta = Program.S_1.PostRegisto(FotografiaConverter(), textBoxUsername.Text, textBoxPassword.Text, textBoxNome.Text, textBoxEmail.Text, comboBoxPais.SelectedItem.ToString());

                    if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
                    {
                        MessageBox.Show(xmlResposta.Element("resultado").Element("contexto").Value,
                                "ERRO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                    else
                    {
                        //NOTA IMPORTANTE: SE CAIR NUMA EXEPÇÃO NAS LINHAS A SEGUIR, O JOGADOR FOI CRIADO NA MESMA! CASO CONTRARIO É PORQUE NÃO CORREU BEM O REGISTO

                        //Program.M_Jogador.username = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("username").Value;
                        //Program.M_Jogador.password = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("password").Value;
                        //Program.M_Jogador.nome = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("nomeabreviado").Value;
                        //Program.M_Jogador.email = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("email").Value;
                        //Program.M_Jogador.fotografia = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("fotografia").Value;
                        //Program.M_Jogador.pais = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("pais").Value;

                        MessageBox.Show("Registo realizado com sucesso!");
                        //apos o registo passa logo para a viewLogin
                        (Program.V_Login as Form).ShowDialog();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERRO!" + ex.Message);
            }*/
        }

        public string FotografiaConverter()   //função que converte a fotografia numa base64string
        {
            using (Image imagem = pictureBoxFotografia.Image)
            {
                using (MemoryStream memory = new MemoryStream())
                {
                    imagem.Save(memory, imagem.RawFormat);
                    byte[] imagemBytes = memory.ToArray();

                    string base64string = Convert.ToBase64String(imagemBytes);
                    return base64string;
                }
            }
        }

        private void pictureBoxFotografia_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPEG|*.JPG;*.JPEG;*.JPE|PNG|*.PNG|Todos os formatos|*.*";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFotografia.Image = new Bitmap(dlg.FileName);
            }
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

        private void textBoxNome_Enter(object sender, EventArgs e)
        {
            if (textBoxNome.Text == " (Primeiro e último nome)")
            {
                textBoxNome.Text = "";
                textBoxNome.ForeColor = Color.DarkGreen;
            }
        }

        private void textBoxNome_Leave(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "")
            {
                textBoxNome.Text = " (Primeiro e último nome)";
                textBoxNome.ForeColor = SystemColors.InactiveBorder;
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMostrar_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void buttonMostrar_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }
    }
}