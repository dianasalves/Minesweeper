using PL1G06.Minesweeper.UWP.Views;
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

namespace PL1G06.Minesweeper.UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ViewPrincipal : Page, JanelaPrincipal
    {
        public event DelegadoSemParametros PedidoSair;
        public event DelegadoSemParametros PedidoStandalone;
        public event DelegadoSemParametros PedidoRede;
        public event DelegadoSemParametros PedidoOpcoes;

        public ViewPrincipal()
        {
            this.InitializeComponent();
        }

        private async void buttonStandalone_Click(object sender, RoutedEventArgs e)
        {
            if (PedidoStandalone != null)
            {
                PedidoStandalone();
            }
            else
            {
                var messageDialog = new MessageDialog("Erro!", "ERRO");
                messageDialog.DefaultCommandIndex = 0;
                await messageDialog.ShowAsync();
            }
        }

        private async void buttonRede_Click(object sender, RoutedEventArgs e)
        {
            if (PedidoRede != null)
            {
                PedidoRede();
            }
            else
            {
                var messageDialog = new MessageDialog("Erro!", "ERRO");
                messageDialog.DefaultCommandIndex = 0;
                await messageDialog.ShowAsync();
            }
        }

        private async void buttonOpcoes_Click(object sender, RoutedEventArgs e)
        {
            if (PedidoOpcoes != null)
            {
                PedidoOpcoes();
            }
            else
            {
                var messageDialog = new MessageDialog("Erro!", "ERRO");
                messageDialog.DefaultCommandIndex = 0;
                await messageDialog.ShowAsync();
            }
        }

        private async void buttonSair_Click(object sender, RoutedEventArgs e)
        {
            if (PedidoSair != null)
            {
                PedidoSair();
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
