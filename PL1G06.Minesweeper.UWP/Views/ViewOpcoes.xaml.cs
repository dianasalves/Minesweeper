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
    public sealed partial class ViewOpcoes : Page, JanelaOpcoes
    {
        public event DelegadoSemParametros PedidoVoltar;
        public event DelegadoParaPerfil PedidoVerPerfil;
        public event DelegadoSemParametros PedidoTOP10;
        public event DelegadoSemParametros PedidoRegras;
        public event DelegadoSemParametros PedidoDescricao;
        public event DelegadoSemParametros PedidoLogout;
        public event DelegadoSemParametros PedidoRede;

        public ViewOpcoes()
        {
            this.InitializeComponent();
        }

        private async void buttonTOP10_Click(object sender, RoutedEventArgs e)
        {
            if (PedidoTOP10 != null)
            {
                PedidoTOP10();
            }
            else
            {
                var messageDialog = new MessageDialog("Erro!", "ERRO");
                messageDialog.DefaultCommandIndex = 0;
                await messageDialog.ShowAsync();
            }
        }

        private async void buttonRegras_Click(object sender, RoutedEventArgs e)
        {
            if (PedidoRegras != null)
            {
                PedidoRegras();
            }
            else
            {
                var messageDialog = new MessageDialog("Erro!", "ERRO");
                messageDialog.DefaultCommandIndex = 0;
                await messageDialog.ShowAsync();
            }
        }

        private async void ButtonDescricao_Click(object sender, RoutedEventArgs e)
        {
            if (PedidoDescricao != null)
            {
                PedidoDescricao();
            }
            else
            {
                var messageDialog = new MessageDialog("Erro!", "ERRO");
                messageDialog.DefaultCommandIndex = 0;
                await messageDialog.ShowAsync();
            }
        }

        private async void ButtonVerPerfil_Click(object sender, RoutedEventArgs e)
        {
            if (PedidoVerPerfil != null)
            {
                PedidoVerPerfil(textBlockUsername.Text);
            }
            else
            {
                var messageDialog = new MessageDialog("Erro!", "ERRO");
                messageDialog.DefaultCommandIndex = 0;
                await messageDialog.ShowAsync();
            }
        }

        private async void ButtonLogout_Click(object sender, RoutedEventArgs e)
        {
            if (PedidoLogout != null)
            {
                PedidoLogout();
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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if ((App.Current as App).M_Jogador.ID == null)
            {
                buttonLogout.Visibility = Visibility.Collapsed;
                buttonVerPerfil.Visibility = Visibility.Collapsed;
                textBlockUsername.Visibility = Visibility.Collapsed;
            }
            if ((App.Current as App).M_Jogador.ID != null)
            {
                textBlockUsername.Text = "@" + (App.Current as App).M_Jogador.username;

            }
        }
    }
}
