using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL1G06.Minesweeper.UWP.Classes
{
    class Jogador
    {
        public string nome { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string pais { get; set; }
        public int jogos_ganhos { get; set; }
        public int jogos_perdidos { get; set; }
        public string best_time { get; set; }
    }
}
