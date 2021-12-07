using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;


namespace PL1G06.Minesweeper.UWP.Classes
{
    public class Quadrado : Button
    {
        public Quadrado() { }

        public const int comp = 30;

        public bool Bandeira { get; set; }
        public bool Minado { get; set; }
        public bool Aberto { get; set; }
        public int Vizinhos { get; set; }
    }
}
