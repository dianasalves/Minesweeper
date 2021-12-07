using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace PL1G06.Minesweeper.Common.Models
{
    public class Jogador
    {
        public string nome { get; set; }
        public string ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string fotografia { get; set; }
        public string pais { get; set; }
        public int jogos_ganhos { get; set; }
        public int jogos_perdidos { get; set; }
        public string best_timeF { get; set; }   //melhor tempo do nivel facil
        public string best_timeM { get; set; }   //melhor tempo do nivel medio
    }
}
