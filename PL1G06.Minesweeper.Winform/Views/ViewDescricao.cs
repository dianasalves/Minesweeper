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
using PL1G06.Minesweeper.Common.Diversos;

namespace PL1G06.Minesweeper.Winform.Views
{
	public partial class ViewDescricao : Form, JanelaDescricao
	{
        public event DelegadoSemParametros PedidoVoltar;

        public ViewDescricao()
		{
			InitializeComponent();
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
