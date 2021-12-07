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

namespace PL1G06.Minesweeper.Winform.Views
{
	public partial class ViewPrincipal : Form, JanelaPrincipal
	{
        public event DelegadoSemParametros PedidoSair;
        public event DelegadoSemParametros PedidoStandalone;
        public event DelegadoSemParametros PedidoRede;
        public event DelegadoSemParametros PedidoOpcoes;

        public ViewPrincipal()
		{
			InitializeComponent();
		}

		private void ViewPrincipal_Load(object sender, EventArgs e)
		{
			
		}

		private void buttonRede_Click(object sender, EventArgs e)
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

		private void buttonStandalone_Click(object sender, EventArgs e)
		{
            if (PedidoStandalone != null)
            {
                PedidoStandalone();
            }
            else
            {
                MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void buttonOpcoes_Click(object sender, EventArgs e)
		{
            if (PedidoOpcoes != null)
            {
                PedidoOpcoes();
            }
            else
            {
                MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            if(PedidoSair!=null)
            {
                PedidoSair();
            }
            else
            {
                MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
