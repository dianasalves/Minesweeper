using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL1G06.Minesweeper.Common.Diversos;

namespace PL1G06.Minesweeper.Winform.Views
{
	public partial class ViewOpcoes : Form, JanelaOpcoes
	{
        public event DelegadoSemParametros PedidoVoltar;
        public event DelegadoParaPerfil PedidoVerPerfil;
        public event DelegadoSemParametros PedidoTOP10;
        public event DelegadoSemParametros PedidoRegras;
        public event DelegadoSemParametros PedidoDescricao;
        public event DelegadoSemParametros PedidoLogout;
        public event DelegadoSemParametros PedidoRede;

        public ViewOpcoes()
		{
			InitializeComponent();
		}

		private void buttonRegras_Click(object sender, EventArgs e)
		{
            if (PedidoRegras != null)
            {
                PedidoRegras();
            }
            else
            {
                MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void buttonTOP10_Click(object sender, EventArgs e)
		{
            if (PedidoTOP10 != null)
            {
                PedidoTOP10();
            }
            else
            {
                MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDescricao_Click(object sender, EventArgs e)
		{
            if (PedidoDescricao != null)
            {
                PedidoDescricao();
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (PedidoLogout != null)
            {
                PedidoLogout();
            }
            else
            {
                MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVerPerfil_Click(object sender, EventArgs e)
        {
            if (PedidoVerPerfil != null)
            {
                PedidoVerPerfil(Program.M_Jogador.username);
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

        private void labelUsername_Click(object sender, EventArgs e)
        {
            if (PedidoVerPerfil != null)
            {
                PedidoVerPerfil(labelUsername.Text);
            }
            else
            {
                MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewOpcoes_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                if (!string.IsNullOrEmpty(Program.M_Jogador.username))
                {
                    labelSS.Visible = false;
                    labelUsername.Text = "@" + Program.M_Jogador.username;
                    labelUsername.Visible = true;
                    buttonLogout.Visible = true;
                    buttonVerPerfil.Visible = true;
                }
                if (string.IsNullOrEmpty(Program.M_Jogador.username))
                {
                    labelSS.Visible = true;
                    labelUsername.Text = "@username";
                    labelUsername.Visible = false;
                    buttonLogout.Visible = false;
                    buttonVerPerfil.Visible = false;
                }
            }
        }

        private void labelSS_Click(object sender, EventArgs e)
        {
            if (PedidoRede != null)
            {
                PedidoRede();
            }
            else
            {
                MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
