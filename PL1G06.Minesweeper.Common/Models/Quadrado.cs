using System;
using System.Collections.Generic;
using System.Text;
using PL1G06.Minesweeper.Common.Diversos;

namespace PL1G06.Minesweeper.Common.Models
{
    public class Quadrado 
    {
        public event DelegadoSemParametros QuadradoAberto;
        public event DelegadoSemParametros BandeiraAlterada;

        //public Quadrado() { }
        
        public static int comp = 30;

        private bool _bandeira;
        private bool _minado;
        private bool _aberto;
        private int _vizinhas;
        private bool _duvida;
        //private int _x;
        //private int _y;

        public bool Bandeira
        {
            get
            {
                return _bandeira;
            }
            set
            {
                _bandeira = value;
                if(BandeiraAlterada != null)
                {
                    BandeiraAlterada();
                }
            }
        }
        public bool Minado
        {
            get
            {
                return _minado;
            }
            set
            {
                _minado = value;
            }
        }
        public bool Aberto
        {
            get
            {
                return _aberto;
            }
            set
            {
                _aberto = value;
                if(QuadradoAberto!=null)
                {
                    QuadradoAberto();
                }
            }
        }
        public int Vizinhas
        {
            get
            {
                return _vizinhas;
            }
            set
            {
                _vizinhas = value;
            }
        }
        public bool Duvida
        {
            get
            {
                return _duvida;
            }
            set
            {
                _duvida = value;
            }
        }

        /*
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }*/
    }
}
