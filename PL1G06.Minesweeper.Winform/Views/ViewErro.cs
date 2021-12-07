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
	public partial class ViewErro : Form, JanelaErro
	{
        public event DelegadoSemParametros PedidoFechar;

        public ViewErro()
		{
			InitializeComponent();
		}

		private void buttonOK_Click(object sender, EventArgs e)
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

		private void ViewErro_Load(object sender, EventArgs e)
		{

		}
	}
}
