using System;
using System.Collections.Generic;
using System.Text;
using PL1G06.Minesweeper.Common.Models;

namespace PL1G06.Minesweeper.Common.Diversos
{
    public delegate void DelegadoSemParametros();
    public delegate void DelegadoComTabuleiro(Tabuleiro tab);
    public delegate void DelegadoParaLogin(string username, string password);
    public delegate void DelegadoParaRegistar(string username, string password, string nome, string email, string pais, string foto); 
    public delegate void DelegadoParaPerfil(string username);
    public delegate void DelegadoParaVerificarRecorde(string tempo, string dificuldade);
    public delegate void DelegadoParaRecordes(string nome, string tempo, string quando, string dificuldade);
    public delegate void DelegadoParaListasdeRecordes(List<string> nome, List<string> tempo, List<string> quando, string dificuldade);
    public delegate void DelegadoParaGuardarJogo(string id, string nivel, string tempo, string vitoria);
    public delegate void DelegadoComDificuldade(string dificuldade);
    //public delegate void DelegadoComString(string umaString);
    //public delegate void DelegadoComInt(int umInt);
}
