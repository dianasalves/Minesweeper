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

namespace PL1G06.Minesweeper.Winform.Views
{
	public partial class ViewWin : Form, JanelaWin
	{
        public event DelegadoSemParametros PedidoFechar;
        public event DelegadoParaRecordes PedidoGuardar;
        public event DelegadoParaVerificarRecorde PedidoRecorde;

        public ViewWin()
		{
			InitializeComponent();
		}

        private void buttonSair_Click(object sender, EventArgs e)
        {
            if (PedidoFechar != null)
            {
                PedidoFechar();
            }
            else
            {
                MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (PedidoGuardar != null && textBoxNome.Text != null)
            {
                PedidoGuardar(textBoxNome.Text, Program.M_Tabuleiro.n_tempo.ToString(), DateTime.Now.ToString("o"), Program.M_Tabuleiro.nivel);
            }
            else
            {
                MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewWin_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                this.buttonGuardar.Visible = false;
                this.labelNome.Visible = false;
                this.textBoxNome.Visible = false;
                this.labelVenceu.Text = "Parabéns!\nVenceu o jogo!";
                this.buttonSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                this.buttonSair.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.buttonSair.Location = new System.Drawing.Point(103, 107);
            }
            if (this.Visible)
            {
                if(!Program.M_Tabuleiro.Rede)
                {
                    if (PedidoRecorde != null)
                    {
                        PedidoRecorde(Program.M_Tabuleiro.n_tempo.ToString(), Program.M_Tabuleiro.nivel);
                    }
                    else
                    {
                        MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (Program.M_Tabuleiro.Recorde)
                    {
                        this.buttonGuardar.Visible = true;
                        this.labelNome.Visible = true;
                        this.textBoxNome.Visible = true;
                        this.labelVenceu.Text = "Novo Recorde! " + Program.M_Tabuleiro.n_tempo.ToString() + "s";
                        this.buttonSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.buttonSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        this.buttonSair.Location = new System.Drawing.Point(19, 107);
                    }
                }
            }
        }

        private void ViewWin_Load(object sender, EventArgs e)
        {
            this.buttonGuardar.Visible = false;
            this.labelNome.Visible = false;
            this.textBoxNome.Visible = false;
            this.labelVenceu.Text = "Parabéns!\nVenceu o jogo!";
            this.buttonSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSair.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSair.Location = new System.Drawing.Point(103, 107);
        }
    }
}
