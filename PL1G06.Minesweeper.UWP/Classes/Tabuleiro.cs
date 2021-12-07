using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL1G06.Minesweeper.UWP.Classes
{
    public class Tabuleiro
    {
        public Tabuleiro() { }

        public const int minasFacil = 10;
        public const int linhasFacil = 9;
        public const int colunasFacil = 9;

        public const int minasMedio = 40;
        public const int linhasMedio = 16;
        public const int colunasMedio = 16;

        public int n_linhas { get; set; }
        public int n_colunas { get; set; }
        public int n_minas { get; set; }
        public int n_flags { get; set; }

        public bool Perdeu { get; set; }
    }
}