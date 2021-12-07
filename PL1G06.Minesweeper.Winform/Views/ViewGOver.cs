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
	public partial class ViewGOver : Form, JanelaGOver
	{
        public event DelegadoSemParametros PedidoFechar;

        public ViewGOver()
		{
			InitializeComponent();
		}

		private void ViewGOver_Load(object sender, EventArgs e)
		{

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

        /*
        public void RegistarResultadoJogo()
        {
            try
            {
                XDocument xmlResposta = Program.S_1.PostRegitarResultado(Program.M_Jogador.ID, Program.M_Tabuleiro.nivel, Program.M_Jogador.best_timeM);

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
                    Program.M_Jogador.best_timeM = xmlResposta.Element("resultado").Element("objeto").Value;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/
    }
}
