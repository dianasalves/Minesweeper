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
using System.Xml.Linq;
using System.IO;
using PL1G06.Minesweeper.Common.Diversos;

namespace PL1G06.Minesweeper.Winform.Views
{
	public partial class ViewLogin : Form, JanelaLogin
	{
        public event DelegadoSemParametros PedidoVoltar;
        public event DelegadoParaLogin PedidoLogin;
        public event DelegadoSemParametros PedidoCriarConta;
        public event DelegadoSemParametros PedidoEsqueceuPassword;

		public ViewLogin()
		{
			InitializeComponent();
		}

		private void buttonNovaConta_Click(object sender, EventArgs e)
		{
            if (PedidoCriarConta != null)
            {
                PedidoCriarConta();
            }
            else
            {
                MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void buttonLogin_Click(object sender, EventArgs e)
		{
            if (PedidoLogin != null)
            {
                PedidoLogin(textBoxUsername.Text, textBoxPassword.Text);
            }
            else
            {
                MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.DarkGreen;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username";
                textBoxUsername.ForeColor = SystemColors.InactiveBorder;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.DarkGreen;
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = SystemColors.InactiveBorder;
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }

        private void linkLabelLembrarPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (PedidoEsqueceuPassword != null)
            {
                PedidoEsqueceuPassword();
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
