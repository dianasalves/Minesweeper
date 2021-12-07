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
using PL1G06.Minesweeper.Common.Models;
using PL1G06.Minesweeper.Common.Diversos;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PL1G06.Minesweeper.UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ViewWin : Page, JanelaWin
    {
        public event DelegadoSemParametros PedidoFechar;
        public event DelegadoParaRecordes PedidoGuardar;
        public event DelegadoParaVerificarRecorde PedidoRecorde;

        public ViewWin()
        {
            this.InitializeComponent();

            //Tabuleiro tabuleiro = new Tabuleiro();
            labelTempo.Text = $"Tempo: {(App.Current as App).M_Tabuleiro.n_tempo}";

            //Falta implementar a verificação se realmente é um recorde
            labelNRecorde.Visibility = Visibility.Visible;
        }

        private async void buttonSair_Click(object sender, RoutedEventArgs e)
        {
            if (PedidoFechar != null)
            {
                PedidoFechar();
            }
            else
            {
                var messageDialog = new MessageDialog("Erro!", "ERRO");
                messageDialog.DefaultCommandIndex = 0;
                await messageDialog.ShowAsync();
            }
        }
    }
}
