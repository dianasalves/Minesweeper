using System;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI;
using PL1G06.Minesweeper.Common.Models;
using PL1G06.Minesweeper.Common.Diversos;
using Windows.UI.Popups;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Linq;

namespace PL1G06.Minesweeper.UWP.Views
{
    public sealed partial class ViewGame : Page, JanelaGame
    {
        public event DelegadoSemParametros PedidoPerdeu;
        public event DelegadoSemParametros PedidoGanhou;
        public event DelegadoParaGuardarJogo PedidoGuardar;

        //public event DelegadoSemParametros PedidoTabuleiro;

        Tabuleiro tabuleiro = new Tabuleiro();
        Quadrado[,] quadrado;
        Button[,] quadradoArray;
        //private Size tamanhoGrelha;
        DispatcherTimer tempo = new DispatcherTimer();

        public ViewGame()
        {
            this.InitializeComponent();
        }

        //Inicializa um array do tipo que quisermos com o tamanho desejado nos parametros de entrada
        T[,] InicializaArray<T>(int x, int y) where T : new()
        {
            T[,] array = new T[x, y];
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; ++j)
                {
                    array[j, i] = new T();
                }
            }
            return array;
        }

        //Timer
        private void Timer_Tick(object sender, object e)
        {
            //Para que apareça os segundos de jogo em textBoxTempo
            tabuleiro.n_tempo++;
            //Atualiza também o tempo no Tabuleiro criado na App
            (App.Current as App).M_Tabuleiro.n_tempo = tabuleiro.n_tempo;
            textBoxTempo.Text = tabuleiro.n_tempo.ToString();
        }

        //Faz com que seja começado um novo jogo, de cada vez que a ViewGame é mostrada
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            NovoJogo();
        }


        //------------------------------------
        // MÉTODOS PARA INÍCIO DE JOGOS
        //------------------------------------

        //Método para reinicializar a janela de jogo
        private void NovoJogo()
        {
            //Para de contar o tempo e recomeça o timer
            tempo.Stop();
            tempo = new DispatcherTimer();

            //Limpa a grelha com o tabuleiro
            gridJogo.Children.Clear();
            gridJogo.RowDefinitions.Clear();
            gridJogo.ColumnDefinitions.Clear();

            //Cria um novo tabuleiro
            InicializaJogo();
        }

        //Método que prepara um novo jogo com a dificuldade escolhida 
        private void InicializaJogo()
        {
            buttonSair.IsEnabled = true;

            //Retorna o butão do smile à imagem inicial, caso tenha perdido
            buttonJogo.Height = buttonJogo.Width = 50;
            buttonJogo.Margin = new Thickness(0, 0, 0, 0);
            buttonJogo.Padding = new Thickness(0, 0, 0, 0);
            buttonJogo.BorderThickness = new Thickness(0, 0, 0, 0);
            BitmapImage btm1 = new BitmapImage(new Uri("ms-appx:///Assets/BotaoJogo.png"));
            Image img1 = new Image();
            img1.Source = btm1;
            img1.Stretch = Stretch.Fill;
            buttonJogo.Content = img1;

            //Zera o tempo de jogo
            tabuleiro.n_tempo = 0;
            textBoxTempo.Text = tabuleiro.n_tempo.ToString();

            tempo.Interval = TimeSpan.FromSeconds(1);
            tempo.Tick += Timer_Tick;

            InicializaTabuleiro();
           
        }

        private void InicializaTabuleiro()
        {
            //Passa para o tabuleiro de jogo, o jogo pretendido
            tabuleiro.n_flags = (App.Current as App).M_Tabuleiro.n_flags;
            tabuleiro.n_linhas = (App.Current as App).M_Tabuleiro.n_linhas;
            tabuleiro.n_colunas = (App.Current as App).M_Tabuleiro.n_colunas;
            tabuleiro.n_minas = (App.Current as App).M_Tabuleiro.n_minas;
            tabuleiro.Rede = (App.Current as App).M_Tabuleiro.Rede;
            tabuleiro.Vitoria = true;

            //Inicializa os arrays que guardam cada quadrado e butão
            quadrado = InicializaArray<Quadrado>(tabuleiro.n_linhas, tabuleiro.n_colunas);
            quadradoArray = InicializaArray<Button>(tabuleiro.n_linhas, tabuleiro.n_colunas);

            //Carrega a nova grelha com o tamanho de jogo
            this.CarregarGrelha(tabuleiro, quadradoArray);
        }

        //Método para preencher de butões o panelTabuleiro com o tamanho necessário para o jogo e ajustar o tamanho da janela
        private void CarregarGrelha(Tabuleiro tab, Button[,] butao)
        {
            //Quadrado[,] quadrado = new Quadrado[l,c];

            textBoxFlags.Text = tab.n_flags.ToString();

            //Verificar se necessita mais colunas/linhas
            for (int x = 0; x < tab.n_linhas; x++)
            {
                RowDefinition novaRow = new RowDefinition();
                novaRow.Height = new GridLength(x, GridUnitType.Auto);
                gridJogo.RowDefinitions.Add(novaRow);
            }
            for (int y = 0; y < tab.n_colunas; y++)
            {
                ColumnDefinition novaColumn = new ColumnDefinition();
                novaColumn.Width = new GridLength(y, GridUnitType.Auto);
                gridJogo.ColumnDefinitions.Add(novaColumn);
            }

            //Define as propriedades e localização de cada butão e adiciona-o à grid
            for (int y = 0; y < tab.n_colunas; y++)
            {
                for (int x = 0; x < tab.n_linhas; x++)
                {
                    butao[x, y].Height = butao[x, y].Width = Quadrado.comp;
                    butao[x, y].VerticalAlignment = VerticalAlignment.Top;
                    butao[x, y].HorizontalAlignment = HorizontalAlignment.Left;
                    butao[x, y].Name = $"button{x}x{y}";
                    butao[x, y].Margin = new Thickness(0, 0, 0, 0);
                    butao[x, y].Padding = new Thickness(0, 0, 0, 0);
                    butao[x, y].BorderThickness = new Thickness(0, 0, 0, 0);

                    SolidColorBrush transparenteBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 255, 255));
                    butao[x, y].BorderBrush = transparenteBrush;
                    butao[x, y].Foreground = transparenteBrush;
                    butao[x, y].FocusVisualSecondaryBrush = transparenteBrush;
                    butao[x, y].FocusVisualPrimaryBrush = transparenteBrush;

                    BitmapImage btm = new BitmapImage(new Uri("ms-appx:///Assets/Quadrado.png"));
                    Image img = new Image();
                    img.Source = btm;
                    img.Stretch = Stretch.Fill;
                    butao[x, y].Content = img;

                    //Adicionar os eventos dos cliques
                    butao[x, y].Click += QuadradoClick;
                    butao[x, y].RightTapped += QuadradoFlag;
                    //quadradoArray[x, y].DoubleTapped += DoubleTappAbreVizinhas;

                    //Adicionar o Botão
                    gridJogo.Children.Add(butao[x, y]);
                    Grid.SetColumn(butao[x, y], y);
                    Grid.SetRow(butao[x, y], x);
                }
            }
        }

        //Método para iniciar o jogo, a partir do quadrado clicado, caso ainda não tenha sido
        private bool VerificaPlay(Quadrado[,] qua, Tabuleiro tab, int x, int y)
        {
            if (!tempo.IsEnabled)
            {
                if((App.Current as App).M_Tabuleiro.Rede)
                {
                    JogoNoServidor(quadrado);
                }
                else
                {
                    //Distribuir minas pelo tabuleiro
                    ColocaMinas(qua, tab.n_minas, x, y);
                }
               

                //Atualiza o numero de vizinhas para cada quadrado
                ContaVizinhas(qua);

                //Começar a contar o tempo de jogo
                tempo.Start();
            }
            return true;


        }

        //Método para colocar minas a partir do quadrado clicado pela primeira vez, não colocando minas nesse quadrado nem nos adjacentes, 
        //garantindo assim alguma abertura de tabuleiro e possibilidade de jogo lógico
        private void ColocaMinas(Quadrado[,] qua, int minas, int x, int y)
        {
            Random random = new Random();
            int aux1, aux2;
            for (int i = 0; i < minas; i++)
            {
                //Escolhe posições aleatórias para as minas
                aux1 = random.Next(0, qua.GetLength(0));
                aux2 = random.Next(0, qua.GetLength(1));
                //Caso coincida com o quadrado clicado ou adjacentes desse, escolhe posição nova
                while (aux1 >= x - 1 && aux1 <= x + 1 && aux2 >= y - 1 && aux2 <= y + 1)
                {
                    aux1 = random.Next(0, qua.GetLength(0));
                    aux2 = random.Next(0, qua.GetLength(1));
                }

                if (qua[aux1, aux2].Minado == false)
                {
                    qua[aux1, aux2].Minado = true;
                }
                //Caso tenha escolhoido uma posição já com mina, repete a colocação dessa mina
                else if (qua[aux1, aux2].Minado == true)
                {
                    i--;
                }
            }
        }

        //Método para contabilizar o número de vizinhas com mina
        private void ContaVizinhas(Quadrado[,] qua)
        {
            //Passa por todas as posições do tabuleiro
            for (int i = 0; i < qua.GetLength(0); i++)
            {
                for (int j = 0; j < qua.GetLength(1); j++)
                {
                    //Caso a posição atual tenha mina, aumenta o número de vizinhas nos quadrados adjacentes
                    if (qua[i, j].Minado)
                    {
                        for (int k = -1; k <= 1; k++)
                        {
                            for (int l = -1; l <= 1; l++)
                            {
                                //Garante que não ultrapassa as margens do tabuleiro
                                if (i + k >= 0 && i + k < qua.GetLength(0) && j + l >= 0 && j + l < qua.GetLength(1))
                                {
                                    qua[i + k, j + l].Vizinhas++;
                                }
                            }
                        }
                    }
                }
            }
        }


        //------------------------------------
        // MÉTODOS PARA FINALIZAR JOGOS
        //------------------------------------

        //Método para finalizar o jogo, chamado sempre que perde, ganha ou sai do jogo
        private async void StopJogo()
        {
            //desabilita o butão de stop
            //buttonStop.IsEnabled = false;
            if (tempo.IsEnabled)
            {
                //para de contar o tempo
                tempo.Stop();

                //Verifica se efetivamente ganhou
                VerificaJogo();

                //Abre resto dos quadrados fechados
                AbreTudo(quadrado, quadradoArray);

                if ((App.Current as App).M_Tabuleiro.Rede == true)
                {
                    if (PedidoGuardar != null)
                    {
                        PedidoGuardar((App.Current as App).M_Jogador.ID, (App.Current as App).M_Tabuleiro.nivel, (App.Current as App).M_Tabuleiro.n_tempo.ToString(), tabuleiro.Vitoria.ToString());
                    }
                    else
                    {
                        var messageDialog = new MessageDialog("Erro!", "ERRO");
                        messageDialog.DefaultCommandIndex = 0;
                        await messageDialog.ShowAsync();
                    }
                }

                /*await Task.Delay(TimeSpan.FromSeconds(3));
                if (tabuleiro.Perdeu == true)
                {
                    if (PedidoPerdeu != null)
                    {
                        PedidoPerdeu();
                    }
                    else
                    {
                        var messageDialog = new MessageDialog("Erro!", "ERRO");
                        await messageDialog.ShowAsync();
                    }
                }*/
                //Caso não tenha perdido... Ganhou!
                if (tabuleiro.Vitoria)
                {
                    await Task.Delay(TimeSpan.FromSeconds(1));
                    if (PedidoGanhou != null)
                    {
                        PedidoGanhou();
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



        //Faz uma última verificação para ver se existem quadrados fechados e sem mina
        //Método inútil no estado de jogo atual
        private bool VerificaJogo()
        {
            for (int x = 0; x < tabuleiro.n_linhas; x++)
            {
                for (int y = 0; y < tabuleiro.n_colunas; y++)
                {
                    if (quadrado[x, y].Aberto == false && quadrado[x, y].Minado == false)
                    {
                        tabuleiro.Vitoria = false;

                        BitmapImage btm1 = new BitmapImage(new Uri("ms-appx:///Assets/BotaoJogoPerdeu.png"));
                        Image img1 = new Image();
                        img1.Source = btm1;
                        img1.Stretch = Stretch.Fill;
                        buttonJogo.Content = img1;
                    }
                }
            }
            return tabuleiro.Vitoria;
        }

        //Método sem utilização
        private void VerificaFim(Tabuleiro tab, Quadrado[,] qua)
        {
            int aux = 0;
            int fim = tab.n_linhas * tab.n_colunas;
            fim = fim - tab.n_minas;
            for (int x = 0; x < tab.n_linhas; x++)
            {
                for (int y = 0; y < tab.n_colunas; y++)
                {
                    if (qua[x, y].Aberto && !qua[x, y].Minado)
                    {
                        aux++;
                    }
                }
            }
            if (aux == fim)
            {
                StopJogo();
            }
        }


        //------------------------------------
        // MÉTODOS PARA ABERTURA DE QUARDADOS
        //------------------------------------

        //Método utilizado sempre que é necessária a abertura de um quadrado
        private void AbreQuadrado(Quadrado[,] qua, Button[,] butao, int x, int y)
        {
            if (qua[x, y].Bandeira)
            {
                //Para fazer a atualização de bandeiras, caso o quadrado tenha sido aberto através de ação em outro e tivesse uma bandeira
                qua[x, y].Bandeira = false;
                tabuleiro.n_flags++;
                textBoxFlags.Text = tabuleiro.n_flags.ToString();
            }

            //Para garantir que o butão é mostrado corretamente
            butao[x, y].Height = butao[x, y].Width = Quadrado.comp;
            butao[x, y].Margin = new Thickness(0, 0, 0, 0);
            butao[x, y].Padding = new Thickness(0, 0, 0, 0);
            butao[x, y].BorderThickness = new Thickness(0, 0, 0, 0);

            qua[x, y].Aberto = true;

            //Caso não esteja minado, coloca o número de vizinhas
            if (!qua[x, y].Minado)
            {
                //Verificar se tem vizinhas
                //quadrado[x, y].Vizinhas = VerificaVizinhas(quadrado[x, y]);
                BitmapImage btm1 = new BitmapImage();
                switch (qua[x, y].Vizinhas)
                {
                    case 0:
                        btm1 = new BitmapImage(new Uri("ms-appx:///Assets/QuadradoVazio_0.png"));
                        break;
                    case 1:
                        btm1 = new BitmapImage(new Uri("ms-appx:///Assets/QuadradoVazio_1.png"));
                        break;
                    case 2:
                        btm1 = new BitmapImage(new Uri("ms-appx:///Assets/QuadradoVazio_2.png"));
                        break;
                    case 3:
                        btm1 = new BitmapImage(new Uri("ms-appx:///Assets/QuadradoVazio_3.png"));
                        break;
                    case 4:
                        btm1 = new BitmapImage(new Uri("ms-appx:///Assets/QuadradoVazio_4.png"));
                        break;
                    case 5:
                        btm1 = new BitmapImage(new Uri("ms-appx:///Assets/QuadradoVazio_5.png"));
                        break;
                    case 6:
                        btm1 = new BitmapImage(new Uri("ms-appx:///Assets/QuadradoVazio_6.png"));
                        break;
                    case 7:
                        btm1 = new BitmapImage(new Uri("ms-appx:///Assets/QuadradoVazio_7.png"));
                        break;
                    case 8:
                        btm1 = new BitmapImage(new Uri("ms-appx:///Assets/QuadradoVazio_8.png"));
                        break;
                    default:
                        break;
                }

                Image img1 = new Image();
                img1.Source = btm1;
                img1.Stretch = Stretch.Fill;
                butao[x, y].Content = img1;

                VerificaFim(tabuleiro, qua);
            }

            //Caso esteja minado, coloca a mina, e para o jogo caso ainda esteja a decorrer
            if (qua[x, y].Minado)
            {
                BitmapImage btm1 = new BitmapImage(new Uri("ms-appx:///Assets/Mina.png"));
                Image img1 = new Image();
                img1.Source = btm1;
                img1.Stretch = Stretch.Fill;
                butao[x, y].Content = img1;

                if (tempo.IsEnabled)
                {
                    tabuleiro.Vitoria = false;
                    //Troca a imagem do butão do smile para jogo perdido
                    BitmapImage btm2 = new BitmapImage(new Uri("ms-appx:///Assets/BotaoJogoPerdeu.png"));
                    Image img2 = new Image();
                    img1.Source = btm1;
                    img1.Stretch = Stretch.Fill;
                    butao[x, y].Content = img1;
                    StopJogo();
                }
            }

            //Depois da abertura do quadrado, e não tiver minas vizinhas, abre também os quadrados adjacentes
            if (qua[x, y].Vizinhas == 0)
                AbreAdjacentes(qua, butao, x, y);

            //Método antigo
            //if (!VerificaVizinhasMinadas(x, y))

            //Nunca vai executar esta condição... método antigo!
            //else
            //{
            //VerificaFim(tabuleiro, qua);
            //}
        }

        //Método utilizado para abrir todos os quadrados sem mina, adjacentes à posição indicada
        private void AbreAdjacentes(Quadrado[,] quadrado, Button[,] butao, int x, int y)
        {
            for (int i = -1; i < 2; i++)
            {
                //Garante que não ultrapassa as margens do tabuleiro
                if (y + i < 0 || y + i >= quadrado.GetLength(1))
                {
                    continue;
                }
                for (int j = -1; j < 2; j++)
                {
                    if (x + j < 0 || x + j >= quadrado.GetLength(0))
                    {
                        continue;
                    }
                    if (quadradoArray[x + j, y + i] != null && quadrado[x + j, y + i] != null)
                    {
                        //Apenas abre o quadrado se este estiver fechado e não tiver mina
                        if (!quadrado[x + j, y + i].Aberto && !quadrado[x + j, y + i].Minado)
                            AbreQuadrado(quadrado, butao, x + j, y + i);
                    }
                }
            }
        }

        //São abertos os quadrados adjacentes sem banderias do quadrado aberto clicado, caso o número de bandeiras corresponda ao número do quadrado
        private void AbreSemBandeiras(Quadrado[,] quadrado, Button[,] butao, int x, int y)
        {
            if (butao[x, y] != null)
            {
                int bandeiras_v = 0;

                //Apenas faz alguma coisa caso o quadrado esteja aberto e tenha vizinhas
                if (quadrado[x, y].Aberto == true)
                {
                    //Primeiro faz a contagem do número de bandeiras colocadas nas adjacentes
                    if (quadrado[x, y].Vizinhas > 0)
                    {
                        for (int i = -1; i < 2; i++)
                        {
                            //Garante que não ultrapassa as margens do tabuleiro
                            if (y + i < 0 || y + i >= quadrado.GetLength(1))
                            {
                                continue;
                            }
                            for (int j = -1; j < 2; j++)
                            {
                                if (x + j < 0 || x + j >= quadrado.GetLength(0))
                                {
                                    continue;
                                }
                                if (butao[x + j, y + i] != null && quadrado[x + j, y + i] != null)
                                {
                                    if (!quadrado[x + j, y + i].Aberto && quadrado[x + j, y + i].Bandeira)
                                        bandeiras_v++;
                                }
                            }
                        }
                    }
                    //Caso a contagem de bandeiras seja igual ao número de vizinhas com mina, abre os quadrados sem bandeira
                    if (quadrado[x, y].Vizinhas == bandeiras_v)
                    {
                        for (int i = -1; i < 2; i++)
                        {
                            if (y + i < 0 || y + i >= quadrado.GetLength(1))
                            {
                                continue;
                            }
                            for (int j = -1; j < 2; j++)
                            {
                                if (x + j < 0 || x + j >= quadrado.GetLength(0))
                                {
                                    continue;
                                }
                                if (butao[x + j, y + i] != null && quadrado[x + j, y + i] != null)
                                {
                                    if (!quadrado[x + j, y + i].Aberto && !quadrado[x + j, y + i].Bandeira)
                                        AbreQuadrado(quadrado, butao, x + j, y + i);
                                }
                            }
                        }
                    }
                }
            }
        }

        //Método usado no final dos jogos, para abrir todo o tabuleiro
        private void AbreTudo(Quadrado[,] quadrado, Button[,] butao)
        {
            //Passa por todas as posições do tabuleiro, abrindo os quadrados caso estejam fechados
            for (int y = 0; y < quadrado.GetLength(1); y++)
            {
                for (int x = 0; x < quadrado.GetLength(0); x++)
                {
                    if (butao[x, y] != null && quadrado[x, y] != null)
                    {
                        if (!quadrado[x, y].Aberto)
                            AbreQuadrado(quadrado, butao, x, y);
                    }
                }
            }
        }
        //Forma anterior do método, também funciona!
        /*
        public void AbreTudo()
        {
            foreach (Button b in gridJogo.Children.OfType<Button>())
            {
                if (b != null)
                {
                    int x = Grid.GetRow(b);
                    int y = Grid.GetColumn(b);
                    if (!quadrado[x, y].Aberto)
                        AbreQuadrado(quadrado, b, x, y);
                }
            }
        }*/


        //---------------------------
        // CLIQUES EM BUTÕES
        //---------------------------

        private void ButtonJogo_Click(object sender, RoutedEventArgs e)
        {
            //Butão do smile reinicia o jogo em curso a qualquer momento
            NovoJogo();
        }

        private async void ButtonSair_Click(object sender, RoutedEventArgs e)
        {
            //Após ganhar ou sair do jogo, o utilizador volta ao menu principal

            buttonSair.IsEnabled = false;

            //Escolhe uma posição aleatória para começar um jogo e mostrar um possível tabuleiro
            Random random = new Random();
            int aux1, aux2;
            aux1 = random.Next(0, quadrado.GetLength(0));
            aux2 = random.Next(0, quadrado.GetLength(1));
            VerificaPlay(quadrado, tabuleiro, aux1, aux2);

            StopJogo();

            if (!tabuleiro.Vitoria)
            {
                if (PedidoPerdeu != null)
                {
                    PedidoPerdeu();
                }
                else
                {
                    var messageDialog = new MessageDialog("Erro!", "ERRO");
                    messageDialog.DefaultCommandIndex = 0;
                    await messageDialog.ShowAsync();
                }
            }


        }

        //Quando um dos quadrados for clicado com o butão esquerdo
        private void QuadradoClick(object sender, RoutedEventArgs e)
        {
            var q = ((Button)sender);

            //Regista posição do Quadrado a partir da sua posição na grelha
            int x = Grid.GetRow(q);
            int y = Grid.GetColumn(q);

            VerificaPlay(quadrado, tabuleiro, x, y);

            //Só faz alguma alteração nesse quadrado caso esteja fechado
            if (quadrado[x, y].Aberto == false)
            {
                //O botão clicado abre caso não tenha bandeira 
                if (quadrado[x, y].Bandeira == false)
                {
                    AbreQuadrado(quadrado, quadradoArray, x, y);
                    /*
                    if (quadrado[x, y].Minado)
                    {
                        tabuleiro.Perdeu = true;

                        StopJogo();
                    }
                    else
                    {
                        VerificaFim();
                    }*/
                }
            }

            //Quando clicado com ambos os botões do rato, caso o quadrado esteja aberto, são abertos os quadrados adjacentes sem bandeiras caso o número de bandeiras corresponda
            if (quadrado[x, y].Aberto)
            {
                AbreSemBandeiras(quadrado, quadradoArray, x, y);
            }
        }

        //Quando um dos quadrados for clicado com o butão direito
        private void QuadradoFlag(object sender, RoutedEventArgs e)
        {
            //Só deixa colocar bandeiras, caso o jogo esteja a decorrer
            if (tempo.IsEnabled)
            {
                var q = ((Button)sender);

                //Regista posição do Quadrado a partir da sua posição na grelha
                int x = Grid.GetRow(q);
                int y = Grid.GetColumn(q);

                if (quadrado[x, y].Aberto == false)
                {
                    //O botão clicado passa a bandeira 
                    if (quadrado[x, y].Bandeira == false && quadrado[x, y].Duvida == false)
                    {/*
                    q.Height = q.Width = Quadrado.comp;
                    q.Margin = new Thickness(0, 0, 0, 0);
                    q.Padding = new Thickness(0, 0, 0, 0);
                    q.BorderThickness = new Thickness(0, 0, 0, 0);
                    */
                        BitmapImage btm2 = new BitmapImage(new Uri("ms-appx:///Assets/Flag.png"));
                        Image img2 = new Image();
                        img2.Source = btm2;
                        img2.Stretch = Stretch.Fill;
                        q.Content = img2;

                        //Atualiza o numero de bandeiras
                        quadrado[x, y].Bandeira = true;
                        tabuleiro.n_flags--;
                        textBoxFlags.Text = tabuleiro.n_flags.ToString();
                    }

                    //O botão clicado passa de bandeira a dúvida
                    else if (quadrado[x, y].Bandeira == true)
                    {/*
                    q.Height = q.Width = Quadrado.comp;
                    q.Margin = new Thickness(0, 0, 0, 0);
                    q.Padding = new Thickness(0, 0, 0, 0);
                    q.BorderThickness = new Thickness(0, 0, 0, 0);
                    */
                        BitmapImage btm2 = new BitmapImage(new Uri("ms-appx:///Assets/Duvida.png"));
                        Image img2 = new Image();
                        img2.Source = btm2;
                        img2.Stretch = Stretch.Fill;
                        q.Content = img2;

                        //Atualiza o numero de bandeiras
                        quadrado[x, y].Bandeira = false;
                        quadrado[x, y].Duvida = true;
                        tabuleiro.n_flags++;
                        textBoxFlags.Text = tabuleiro.n_flags.ToString();
                    }

                    //O botão clicado retira a dúvida
                    else if (quadrado[x, y].Duvida == true)
                    {/*
                    q.Height = q.Width = Quadrado.comp;
                    q.Margin = new Thickness(0, 0, 0, 0);
                    q.Padding = new Thickness(0, 0, 0, 0);
                    q.BorderThickness = new Thickness(0, 0, 0, 0);
                    */
                        BitmapImage btm2 = new BitmapImage(new Uri("ms-appx:///Assets/Quadrado.png"));
                        Image img2 = new Image();
                        img2.Source = btm2;
                        img2.Stretch = Stretch.Fill;
                        q.Content = img2;

                        quadrado[x, y].Duvida = false;
                    }
                }

                //Quando clicado com ambos os botões do rato, caso o quadrado esteja aberto, são abertos os quadrados adjacentes sem bandeiras caso o número de bandeiras corresponda
                if (quadrado[x, y].Aberto)
                {
                    AbreSemBandeiras(quadrado, quadradoArray, x, y);
                }
            }
        }

        //Código anterior, para utilizar caso a AbreSemBandeiras seja feito com duplo clique
        /*
        private void DoubleTappAbreVizinhas(object sender, RoutedEventArgs e)
        {
            var q = ((Button)sender);

            int x = Grid.GetRow(q);
            int y = Grid.GetColumn(q);

            int bandeiras_v = 0;

            if (quadrado[x, y].Aberto == true)
            {
                if (quadrado[x, y].Vizinhas > 0)
                {
                    for (int i = -1; i < 2; i++)
                    {
                        if (y + i < 0 || y + i >= quadrado.GetLength(1))
                        {
                            continue;
                        }
                        for (int j = -1; j < 2; j++)
                        {
                            if (x + j < 0 || x + j >= quadrado.GetLength(0))
                            {
                                continue;
                            }
                            if (quadradoArray[x + j, y + i] != null && quadrado[x + j, y + i] != null)
                            {
                                if (!quadrado[x + j, y + i].Aberto && quadrado[x + j, y + i].Bandeira)
                                    bandeiras_v++;
                            }
                        }
                    }
                }
                if (quadrado[x, y].Vizinhas == bandeiras_v)
                {
                    for (int i = -1; i < 2; i++)
                    {
                        if (y + i < 0 || y + i >= quadrado.GetLength(1))
                        {
                            continue;
                        }
                        for (int j = -1; j < 2; j++)
                        {
                            if (x + j < 0 || x + j >= quadrado.GetLength(0))
                            {
                                continue;
                            }
                            if (quadradoArray[x + j, y + i] != null && quadrado[x + j, y + i] != null)
                            {
                                if (!quadrado[x + j, y + i].Aberto && !quadrado[x + j, y + i].Bandeira)
                                    AbreQuadrado(quadrado, quadradoArray[x + j, y + i], x + j, y + i);
                            }
                        }
                    }
                }
            }
        }
        */

        //Métodos antigos, sem utilização no jogo atual
        /*
        private int VerificaVizinhas(Quadrado[,] quadrado)
        {
            int vizinhas = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (quadrado[x+i, y+j].Minado == true)
                    {
                        vizinhas++;
                    }
                }
            }

            return vizinhas;
        }*/
        /*
        private bool VerificaVizinhasMinadas(int x, int y)
        {
            for (int i = -1; i < 2; i++)
            {
                if (y + i < 0 || y + i >= quadrado.GetLength(1))
                {
                    continue;
                }
                for (int j = -1; j < 2; j++)
                {
                    if (x + j < 0 || x + j >= quadrado.GetLength(0))
                    {
                        continue;
                    }
                    if (quadrado[x + j, y + i] != null)
                    {
                        if (quadrado[x + j, y + i].Minado)
                            return true;
                    }
                }
            }
            return false;
        }*/


        public async void JogoNoServidor(Quadrado[,] quadrado)
        {
            try
            {

                XDocument xmlResposta = (App.Current as App).s_1.GetPedirNovoJogo((App.Current as App).M_Tabuleiro.nivel, (App.Current as App).M_Jogador.ID);

                if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
                {
                    // apresenta mensagem de erro 
                    var messageDialog = new MessageDialog(xmlResposta.Element("resultado").Element("contexto").Value,
                                    "Erro");
                    messageDialog.DefaultCommandIndex = 0;
                    await messageDialog.ShowAsync();
                }
                else
                {
                    foreach (var nivel in xmlResposta.Element("resultado").Element("objeto").Descendants("campo"))
                    {

                        foreach (var posicao in nivel.Descendants("posicao"))
                        {
                            if (int.Parse(posicao.Value) == -1)
                            {
                                //recebe as posições: linha e coluna
                                int linha = (int.Parse(posicao.Attribute("linha").Value));
                                int coluna = (int.Parse(posicao.Attribute("coluna").Value));

                                quadrado[linha, coluna].Minado = true;
                            }


                        }
                    }

               
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}