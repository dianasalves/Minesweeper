using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL1G06.Minesweeper.Common.Models;
using PL1G06.Minesweeper.Common.Diversos;
using System.Xml.Linq;

namespace PL1G06.Minesweeper.Winform.Views
{
	public partial class ViewDificuldade : Form, JanelaDificuldade
	{
        public event DelegadoSemParametros PedidoVoltar;
        public event DelegadoComTabuleiro PedidoJogo;

		public ViewDificuldade()
		{
			InitializeComponent();
		}

		private void buttonFacil_Click(object sender, EventArgs e)
		{
            
            var tab = new Tabuleiro();

            tab.n_linhas = Tabuleiro.linhasFacil;
            tab.n_colunas = Tabuleiro.colunasFacil;
            tab.n_minas = tab.n_flags = Tabuleiro.minasFacil;
            Program.M_Tabuleiro.nivel = "Facil";

            //Program.V_Game.Show();
            /*
            ViewGame V_Game = new ViewGame(tab);

            V_Game.ShowDialog();

            this.Close();
            */
            if (PedidoJogo != null)
            {
                PedidoJogo(tab);
            }
            else
            {
                MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMedio_Click(object sender, EventArgs e)
		{
            var tab = new Tabuleiro();

            tab.n_linhas = Tabuleiro.linhasMedio;
            tab.n_colunas = Tabuleiro.colunasMedio;
            tab.n_minas = tab.n_flags = Tabuleiro.minasMedio;
            Program.M_Tabuleiro.nivel = "Medio";

            //Program.V_Game.Show();
            /*
            ViewGame V_Game = new ViewGame(tab);
            V_Game.ShowDialog();

            this.Close();
            */
            if (PedidoJogo != null)
            {
                PedidoJogo(tab);
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

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
