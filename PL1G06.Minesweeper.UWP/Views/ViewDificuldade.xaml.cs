using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
//using PL1G06.Minesweeper.UWP.Classes;
using PL1G06.Minesweeper.Common.Models;
using PL1G06.Minesweeper.Common.Diversos;
using Windows.UI.Popups;

namespace PL1G06.Minesweeper.UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ViewDificuldade : Page, JanelaDificuldade
    {
        public event DelegadoSemParametros PedidoVoltar;
        public event DelegadoComTabuleiro PedidoJogo;

        public ViewDificuldade()
        {
            this.InitializeComponent();
        }

        private async void buttonFacil_Click(object sender, RoutedEventArgs e)
        {
            var tab = new Tabuleiro();

            tab.n_linhas = Tabuleiro.linhasFacil;
            tab.n_colunas = Tabuleiro.colunasFacil;
            tab.n_minas = tab.n_flags = Tabuleiro.minasFacil;

            (App.Current as App).M_Tabuleiro.nivel = "Facil";

            if (PedidoJogo != null)
            {
                PedidoJogo(tab);
            }
            else
            {
                var messageDialog = new MessageDialog("Erro!", "ERRO");
                messageDialog.DefaultCommandIndex = 0;
                await messageDialog.ShowAsync();
            }
        }

        private async void buttonMedio_Click(object sender, RoutedEventArgs e)
        {
            var tab = new Tabuleiro();

            tab.n_linhas = Tabuleiro.linhasMedio;
            tab.n_colunas = Tabuleiro.colunasMedio;
            tab.n_minas = tab.n_flags = Tabuleiro.minasMedio;

            (App.Current as App).M_Tabuleiro.nivel = "Medio";

            if (PedidoJogo != null)
            {
                PedidoJogo(tab);
            }
            else
            {
                var messageDialog = new MessageDialog("Erro!", "ERRO");
                messageDialog.DefaultCommandIndex = 0;
                await messageDialog.ShowAsync();
            }
        }

        private async void buttonVoltar_Click(object sender, RoutedEventArgs e)
        {
            if (PedidoVoltar != null)
            {
                PedidoVoltar();
            }
            else
            {
                var messageDialog = new MessageDialog("Erro!", "ERRO");
                messageDialog.DefaultCommandIndex = 0;
                await messageDialog.ShowAsync();
            }
        }

        private async void buttonDificil_Click(object sender, RoutedEventArgs e)
        {
            var tab = new Tabuleiro();

            tab.n_linhas = Tabuleiro.linhasDificil;
            tab.n_colunas = Tabuleiro.colunasDificil;
            tab.n_minas = tab.n_flags = Tabuleiro.minasDificil;

            (App.Current as App).M_Tabuleiro.nivel = "Dificil";

            if (PedidoJogo != null)
            {
                PedidoJogo(tab);
            }
            else
            {
                var messageDialog = new MessageDialog("Erro!", "ERRO");
                messageDialog.DefaultCommandIndex = 0;
                await messageDialog.ShowAsync();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if((App.Current as App).M_Tabuleiro.Rede == true)
            {
                buttonDificil.Visibility = Visibility.Collapsed;
            }
        }
    }
}
