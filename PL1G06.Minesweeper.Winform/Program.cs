using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL1G06.Minesweeper.Common.Models;
using PL1G06.Minesweeper.Winform.Views;
using PL1G06.Minesweeper.Common.Diversos;
using PL1G06.Minesweeper.Winform;
using PL1G06.Minesweeper.Common.Server;

namespace PL1G06.Minesweeper.Winform
{
    static class Program
    {
        //public static ModelMinesweeper M_minesweeper { get; private set; }
        public static Jogador M_Jogador { get; private set; }
        public static Jogador M_JogadorConsulta { get; private set; }
        public static Quadrado M_Quadrado { get; private set; }
        public static Tabuleiro M_Tabuleiro { get; private set; }
        public static TOP M_TOP1 { get; private set; }
        //public static TOP M_TOP10 { get; private set; }

        public static Server1 S_1 { get; private set; }

        public static JanelaPrincipal V_Principal { get; private set; }  //interface principal do jogo
        public static JanelaErro V_Erro { get; private set; }    //interface só aparece quando o grau de dificuldade não e selecionado
        public static JanelaGOver V_GOver { get; private set; }   //interface aparece quando perder o jogo
        public static JanelaWin V_Win { get; private set; }    // interface aparece quando ganhar um jogo
        public static JanelaGame V_Game { get; private set; }   // interface aparece quando o jogador selecionar o grau de dificuldade
        public static JanelaTOP10 V_TOP10 { get; private set; }   // interface aparce quando o utilizador quer ver o top10 de cada nível de jogo(server)
        public static JanelaLogin V_Login { get; private set; }   //interface que aparece para o utilizador fazer login (server)
        public static JanelaRegisto V_Registo { get; private set; } //interface que aparece para o utilizador fazer o registo (server)
        public static JanelaDificuldade V_Dificuldade { get; private set; }  // interface que aparece para o utilizador escolher o grau de dificuldade
        public static JanelaPerfil V_Perfil { get; private set; }  // interface que aparece para o utilizador visualizar o perfil de jogador (server)
        public static JanelaOpcoes V_Opcoes { get; private set; }  // interface que aparece para o utilizador visualizar as opções
        public static JanelaRegras V_Regras { get; private set; }  // interface que aparece para o utilizador visualizar as regras
        public static JanelaDescricao V_Descricao { get; private set; } // interface que aparece para o utilizador visualizar a descrição

        public static ControllerWinform C_Winform { get; private set; }

        //public static ControllerMinesweeper C_Minesweeper { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Models:
            //M_minesweeper = new ModelMinesweeper();
            M_Jogador = new Jogador();
            M_JogadorConsulta = new Jogador();
            M_Quadrado = new Quadrado();
            M_Tabuleiro = new Tabuleiro();
            M_TOP1 = new TOP();
            //M_TOP10 = new TOP();
            S_1 = new Server1();

            //Views:
            V_Principal = new ViewPrincipal();
            V_Erro = new ViewErro();
            V_GOver = new ViewGOver();
            V_Win = new ViewWin();
            V_Game = new ViewGame();
            V_TOP10 = new ViewTOP10();
            V_Login = new ViewLogin();
            V_Registo = new ViewRegisto();
            V_Dificuldade = new ViewDificuldade();
            V_Perfil = new ViewPerfil();
            V_Opcoes = new ViewOpcoes();
            V_Descricao = new ViewDescricao();
            V_Regras = new ViewRegras();

            //Controllers:
            //C_Minesweeper = new ControllerMinesweeper();
            C_Winform = new ControllerWinform();

            Application.Run(V_Principal as Form);
            //Application.Run(new ViewPrincipal());
        }

        public static void NovaViewGame()
        {
            V_Game = new ViewGame();
        }
    }
}
