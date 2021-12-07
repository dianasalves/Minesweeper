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
using PL1G06.Minesweeper.Common.Server;
using Windows.UI.Popups;
using Windows.UI;
using System.Xml.Linq;
using System.Runtime.Serialization;
using Windows.Storage;

namespace PL1G06.Minesweeper.UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ViewLogin : Page, JanelaLogin
    {
        public event DelegadoSemParametros PedidoVoltar;
        public event DelegadoParaLogin PedidoLogin;
        public event DelegadoSemParametros PedidoCriarConta;
        public event DelegadoSemParametros PedidoEsqueceuPassword;

        public ViewLogin()
        {
            this.InitializeComponent();
        }

        private async void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            if (PedidoLogin != null)
            {
                PedidoLogin(textBoxUsername.Text, textBoxPassword.Text);
            }
            else
            {
                var messageDialog = new MessageDialog("Erro!", "ERRO");
                messageDialog.DefaultCommandIndex = 0;
                await messageDialog.ShowAsync();
            }
        }

        private async void buttonNovaConta_Click(object sender, RoutedEventArgs e)
        {
            if (PedidoCriarConta != null)
            {
                PedidoCriarConta();
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

        private async void HyperlinkButtonPassword_Click(object sender, RoutedEventArgs e)
        {
            if (PedidoEsqueceuPassword != null)
            {
                PedidoEsqueceuPassword();
            }
            else
            {
                var messageDialog = new MessageDialog("Erro!", "ERRO");
                messageDialog.DefaultCommandIndex = 0;
                await messageDialog.ShowAsync();
            }
        }

        private void TextBoxUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                //textBoxUsername.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void TextBoxUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username";
                //textBoxUsername.Foreground = new SolidColorBrush(Colors.DarkGreen);
            }
        }

        private void TextBoxPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                //textBoxPassword.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void TextBoxPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
                //textBoxPassword.Foreground = new SolidColorBrush(Colors.DarkGreen);
            }
        }

        private void textBoxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
