using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using PL1G06.Minesweeper.Winform.Properties;

namespace PL1G06.Minesweeper.Winform
{
    public class Quadrado : Button
    {
        public Quadrado() { }

        public const int comp = 30;

        public System.Drawing.Point PosicaoGrelha { get; }

        public bool Bandeira { get; set; }
        public bool Minado { get; set; }
        public bool Aberto { get; set; }
        public int Vizinhos { get; set; }

        //Para desenhar o quadrado
        public Quadrado(int x, int y)
        {
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.Quadrado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Location = new System.Drawing.Point(x * comp, y * comp);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = $"button{x}x{y}";
            this.Size = new System.Drawing.Size(comp, comp);
            this.TabIndex = 5;
            this.TabStop = false;
            this.UseVisualStyleBackColor = false;
            this.PosicaoGrelha = new System.Drawing.Point(x, y);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CliqueQuadrado);
        }

        //Quando um dos botoes for clicado
        private void CliqueQuadrado(object sender, EventArgs e)
        {
            if (Aberto == false)
            {
                switch (MouseButtons)
                {
                    case MouseButtons.Left:  // se cliclar no lado esquerdo do rato o botão clicaldo passa aberto e é colocado uma quadrado vazio da resources
                        switch (Bandeira)
                        {
                            case false:
                                Aberto = true;
                                this.BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.QuadradoVazio_0;

                                break;
                            case true:           //se já lá estiver uma bandeira retira a bandeira que estava no botão clicado

                                break;
                        }
                        break;
                    case MouseButtons.Right:         // se clicar no lado direito do rato:
                        {
                            switch (Bandeira)
                            {
                                case false:             //desenha uma bandeira no botão clicado
                                    Bandeira = true;
                                    this.BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.Flag;

                                    break;
                                case true:           //se já lá estiver uma bandeira retira a bandeira que estava no botão clicado
                                    Bandeira = false;
                                    this.BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.Quadrado;

                                    break;
                            }
                            //apenas para confirmar:
                            // Bandeira = true;
                            //this.BackgroundImage = global::Minesweeper.Properties.Resources.Flag;
                        }
                        break;
                }
            }
        }
    }
}
