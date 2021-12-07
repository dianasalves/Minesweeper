using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using PL1G06.Minesweeper.UWP.Views;
using PL1G06.Minesweeper.Common.Diversos;
using PL1G06.Minesweeper.Common.Models;
using PL1G06.Minesweeper.Common.Server;

namespace PL1G06.Minesweeper.UWP
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        //public ViewPrincipal V_Principal { get; private set; }

        public Jogador M_Jogador { get; private set; }
        public Jogador M_JogadorConsulta { get; private set; }

        public Quadrado M_Quadrado { get; private set; }
        public Tabuleiro M_Tabuleiro { get; private set; }

        public TOP M_TOP1 { get; private set; }
        public Server1 s_1 { get; private set; }


        public JanelaPrincipal V_Principal { get; private set; }  //interface principal do jogo
        public JanelaErro V_Erro { get; private set; }    //interface só aparece quando o grau de dificuldade não e selecionado
        public JanelaGOver V_GOver { get; private set; }   //interface aparece quando perder o jogo
        public JanelaWin V_Win { get; private set; }    // interface aparece quando ganhar um jogo
        public JanelaGame V_Game { get; private set; }   // interface aparece quando o jogador selecionar o grau de dificuldade
        public JanelaTOP10 V_TOP10 { get; private set; }   // interface aparce quando o utilizador quer ver o top10 de cada nível de jogo
        public JanelaLogin V_Login { get; private set; }   //interface que aparece para o utilizador fazer login
        public JanelaRegisto V_Registo { get; private set; } //interface que aparece para o utilizador fazer o registo
        public JanelaDificuldade V_Dificuldade { get; private set; }  // interface que aparece para o utilizador escolher o grau de dificuldade
        public JanelaPerfil V_Perfil { get; private set; }  // interface que aparece para o utilizador visualizar o perfil de jogador
        public JanelaOpcoes V_Opcoes { get; private set; }  // interface que aparece para o utilizador visualizar o perfil de jogador
        public JanelaRegras V_Regras { get; private set; }  // interface que aparece para o utilizador visualizar as regras
        public JanelaDescricao V_Descricao { get; private set; } // interface que aparece para o utilizador visualizar as regras

        public ControllerUWP C_UWP { get; private set; }

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;

            //Models
            M_Jogador = new Jogador();
            M_JogadorConsulta = new Jogador();
            M_Quadrado = new Quadrado();
            M_Tabuleiro = new Tabuleiro();
            M_TOP1 = new TOP();
            s_1 = new Server1();

            

            //Controllers
            C_UWP = new ControllerUWP();
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                rootFrame.Navigated += this.RootFrame_FirstNavigated;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    // When the navigation stack isn't restored navigate to the first page,
                    // configuring the new page by passing required information as a navigation
                    // parameter
                    rootFrame.Navigate(typeof(ViewPrincipal), e.Arguments);
                }
                // Ensure the current window is active
                Window.Current.Activate();
            }

            //V_Principal = rootFrame.Content as ViewPrincipal;

        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }

        private void RootFrame_FirstNavigated(object sender, NavigationEventArgs e)
        {
            var rootFrame = sender as Frame;

            if (rootFrame.Content is JanelaPrincipal)
            {
                V_Principal = rootFrame.Content as JanelaPrincipal;
                C_UWP.ConfiguraMensagensViewPrincipal();
            }

            if (rootFrame.Content is JanelaDificuldade)
            {
                V_Dificuldade = rootFrame.Content as JanelaDificuldade;
                C_UWP.ConfiguraMensagensViewDificuldade();
            }

            if (rootFrame.Content is JanelaGame)
            {
                V_Game = rootFrame.Content as JanelaGame;
                C_UWP.ConfiguraMensagensViewGame();
            }

            if (rootFrame.Content is JanelaGOver)
            {
                V_GOver = rootFrame.Content as JanelaGOver;
                C_UWP.ConfiguraMensagensViewGOver();
            }

            if (rootFrame.Content is JanelaWin)
            {
                V_Win = rootFrame.Content as JanelaWin;
                C_UWP.ConfiguraMensagensViewWin();
            }

            if (rootFrame.Content is JanelaLogin)
            {
                V_Login = rootFrame.Content as JanelaLogin;
                C_UWP.ConfiguraMensagensViewLogin();

            }

            if (rootFrame.Content is JanelaRegisto)
            {
                V_Registo = rootFrame.Content as JanelaRegisto;
                C_UWP.ConfiguraMensagensViewRegisto();
            }

            if (rootFrame.Content is JanelaOpcoes)
            {
                V_Opcoes = rootFrame.Content as JanelaOpcoes;
                C_UWP.ConfiguraMensagensViewOpcoes();
            }

            if (rootFrame.Content is JanelaPerfil)
            {
                V_Perfil = rootFrame.Content as JanelaPerfil;
                C_UWP.ConfiguraMensagensViewPerfil();
            }

            if (rootFrame.Content is JanelaTOP10)
            {
                V_TOP10 = rootFrame.Content as JanelaTOP10;
                C_UWP.ConfiguraMensagensViewTOP10();
            }

            if (rootFrame.Content is JanelaRegras)
            {
                V_Regras = rootFrame.Content as JanelaRegras;
                C_UWP.ConfiguraMensagensViewRegras();
            }

            if (rootFrame.Content is JanelaDescricao)
            {
                V_Descricao = rootFrame.Content as JanelaDescricao;
                C_UWP.ConfiguraMensagensViewDescricao();
            }

            if (rootFrame.Content is JanelaErro)
            {
                V_Erro = rootFrame.Content as JanelaErro;
                C_UWP.ConfiguraMensagensViewErro();
            }
        }
    }
}
