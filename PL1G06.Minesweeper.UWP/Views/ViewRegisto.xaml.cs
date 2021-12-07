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
using System.Xml.Linq;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage.Streams;
using System.Threading.Tasks;
using Windows.Storage.Pickers;
using Windows.Storage.AccessCache;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Controls.Maps;
using Windows.Graphics.Imaging;
using Windows.Data.Pdf;
using System.Runtime.CompilerServices;

namespace PL1G06.Minesweeper.UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ViewRegisto : Page, JanelaRegisto
    {
        public event DelegadoSemParametros PedidoVoltar;
        public event DelegadoParaRegistar PedidoRegistar;
        public event DelegadoSemParametros PedidoErro;



        public ViewRegisto()
        {
            this.InitializeComponent();
        }

        private async void buttonRegistar_Click(object sender, RoutedEventArgs e)
        {
            //fazer o registo ou apresentar o erro caso os campos não estejam todos preenchidos
            if (PedidoRegistar != null)
            {
                PedidoRegistar(textBoxUsername.Text, textBoxPassword.Text, textBoxNome.Text, textBoxEmail.Text, textBoxPais.Text, ImagemConvertida);
            }
            else
            {
                var messageDialog = new MessageDialog("Erro!", "ERRO");
                messageDialog.DefaultCommandIndex = 0;
                await messageDialog.ShowAsync();
            }

            if (PedidoErro != null)
            {
                PedidoErro();
            }
            else
            {
                var messageDialog = new MessageDialog("Erro!", "ERRO");
                messageDialog.DefaultCommandIndex = 0;
                await messageDialog.ShowAsync();
            }

        }

       
        //string onde é guardada a string da foto
        public string ImagemConvertida;

        private async void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            FileOpenPicker fop = new FileOpenPicker();
            fop.ViewMode = PickerViewMode.Thumbnail;
            fop.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            fop.FileTypeFilter.Add(".jpg");
            fop.FileTypeFilter.Add(".jpeg");
            fop.FileTypeFilter.Add(".png");

            StorageFile file = await fop.PickSingleFileAsync();
            if (file != null)
            {
                Windows.Storage.Streams.IRandomAccessStream fileStream = await file.OpenAsync(FileAccessMode.Read);
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.SetSource(fileStream);
                Imagem.Source = bitmapImage;

                using (var inputStream = await file.OpenSequentialReadAsync())
                {
                    var readStream = inputStream.AsStreamForRead();

                    var byteArray = new byte[readStream.Length];
                    await readStream.ReadAsync(byteArray, 0, byteArray.Length);
                    string base64 = Convert.ToBase64String(byteArray);
                    ImagemConvertida = base64;
                }

            }


            
        }

     

        private void TextBoxNome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxPais_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxUsername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

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
                await messageDialog.ShowAsync();
            }
        }

        private void textBoxUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                //textBoxUsername.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void textBoxUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username";
                //textBoxUsername.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void textBoxPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
            }
        }

        private void textBoxPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
                //textBoxUsername.Foreground = new SolidColorBrush(Colors.Black);
            }
        }
    }
}
