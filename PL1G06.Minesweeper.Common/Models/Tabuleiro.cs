using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL1G06.Minesweeper.Common.Models
{
    public class Tabuleiro
    {
        public Tabuleiro() { }

        public static int minasFacil = 10;
        public static int linhasFacil = 9;
        public static int colunasFacil = 9;

        public static int minasMedio = 40;
        public static int linhasMedio = 16;
        public static int colunasMedio = 16;

        public static int minasDificil = 99;
        public static int linhasDificil = 16;
        public static int colunasDificil = 30;

        public int n_linhas { get; set; }
        public int n_colunas { get; set; }
        public int n_minas { get; set; }
        public int n_flags { get; set; }
        public int n_tempo = 0;

        public string nivel;     //Facil ou Medio

        public bool Rede { get; set; } //True para jogo online

        //Para eliminar depois de alterar no UWP
        public bool Perdeu { get; set; } //True para jogo perdido
        public bool Vitoria { get; set; } //True para jogo ganho

        public bool Recorde { get; set; } //True para novo recorde
    }
}
