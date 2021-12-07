using System;
using System.Drawing;
using System.Windows.Forms;
using PL1G06.Minesweeper.Common.Models;
using PL1G06.Minesweeper.Common.Diversos;
using System.Xml.Linq;

namespace PL1G06.Minesweeper.Winform.Views
{
    public partial class ViewGame : Form, JanelaGame
    {
        public event DelegadoSemParametros PedidoPerdeu;
        public event DelegadoSemParametros PedidoGanhou;
        //public event DelegadoSemParametros PedidoTabuleiro;
        public event DelegadoParaGuardarJogo PedidoGuardar;

        Tabuleiro tabuleiro = new Tabuleiro();
        Quadrado[,] quadrado;
        Button[,] quadradoArray;
        private Size tamanhoGrelha;
        Timer tempo = new Timer();

        public ViewGame()
        {
            InitializeComponent();
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
        private void TimerTempo_Tick(object sender, EventArgs e)
        {
            //Para que apareça os segundos de jogo em textBoxTempo
            tabuleiro.n_tempo++;
            //Atualiza também o tempo no Tablueiro criado no Program
            Program.M_Tabuleiro.n_tempo = tabuleiro.n_tempo;
            string time = string.Format("{0}", tabuleiro.n_tempo);
            textBoxTempo.Text = time;
        }

        //Faz com que seja começado um novo jogo, de cada vez que a ViewGame é mostrada
        private void ViewGame_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                /*Array.Clear(quadrado, 0, quadrado.Length);
                Array.Clear(quadradoArray, 0, quadradoArray.Length);

                groupBoxTabuleiro.Controls.Clear();
                //textBoxFlags.Text = "";
                //textBoxTempo.Text = "000";

                this.ClientSize = new System.Drawing.Size(508, 377);
                this.MinimumSize = new System.Drawing.Size(293, 173);
                this.CenterToScreen();*/
            }
            if (this.Visible)
            {
                NovoJogo();
            }
        }

        //------------------------------------
        // MÉTODOS PARA INÍCIO DE JOGOS
        //------------------------------------

        //Método para reinicializar a janela de jogo
        private void NovoJogo()
        {
            //Para de contar o tempo e recomeça o timer
            tempo.Stop();
            tempo = new Timer();

            //Limpa o tabuleiro
            panelTabuleiro.Controls.Clear();

            //Cria um novo jogo
            InicializaJogo();

            //Centra a janela com o novo tabuleiro
            this.CenterToScreen();
        }

        //Método que prepara um novo jogo com a dificuldade escolhida 
        private void InicializaJogo()
        {
            buttonSair.Enabled = true;

            //Retorna o butão do smile à imagem inicial, caso tenha perdido
            buttonJogo.BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.BotaoJogo;

            //Zera o tempo de jogo
            tabuleiro.n_tempo = 0;
            textBoxTempo.Text = tabuleiro.n_tempo.ToString();

            //timerTempo = new Timer();
            tempo.Interval = 1000;
            tempo.Tick += TimerTempo_Tick;

            //função que inicializa o tabuleiro 
            InicializaTabuleiro();
        }

        //Método que prepara um novo tabuleiro com a dificuldade escolhida 
        private void InicializaTabuleiro()
        {
            //Passa para o tabuleiro de jogo, o jogo pretendido
            tabuleiro.n_flags = Program.M_Tabuleiro.n_flags;
            tabuleiro.n_linhas = Program.M_Tabuleiro.n_linhas;
            tabuleiro.n_colunas = Program.M_Tabuleiro.n_colunas;
            tabuleiro.n_minas = Program.M_Tabuleiro.n_minas;
            tabuleiro.Rede = Program.M_Tabuleiro.Rede;
            tabuleiro.Vitoria = true;

            //Inicializa os arrays que guardam cada quadrado e butão
            quadrado = InicializaArray<Quadrado>(tabuleiro.n_linhas, tabuleiro.n_colunas);
            quadradoArray = InicializaArray<Button>(tabuleiro.n_linhas, tabuleiro.n_colunas);

            //Carrega a nova grelha com o tamanho de jogo
            this.CarregarGrelha(new Size(Program.M_Tabuleiro.n_linhas, Program.M_Tabuleiro.n_colunas));
        }

        //Método para preencher de butões o panelTabuleiro com o tamanho necessário para o jogo e ajustar o tamanho da janela
        private void CarregarGrelha(Size tamanhoGrelha)
        {
            //this.Controls.Clear();
            //this.Location = new System.Drawing.Point(10, 50);

            this.tamanhoGrelha = tamanhoGrelha;
            this.Size = new Size(tamanhoGrelha.Width * Quadrado.comp + 20, tamanhoGrelha.Height * Quadrado.comp + 105);

            textBoxFlags.Text = tabuleiro.n_flags.ToString();

            //Define as propriedades e localização de cada butão e adiciona-o ao panel
            for (int y = 0; y < tamanhoGrelha.Width; y++)
            {
                for (int x = 0; x < tamanhoGrelha.Height; x++)
                {
                    //quadrado[x, y].X = x;
                    //quadrado[x, y].Y = y;
                    //Quadrado quadrado = new Quadrado(x, y);

                    quadradoArray[x, y].BackColor = System.Drawing.Color.Transparent;
                    quadradoArray[x, y].BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.Quadrado;
                    quadradoArray[x, y].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    quadradoArray[x, y].FlatAppearance.BorderSize = 0;
                    quadradoArray[x, y].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    quadradoArray[x, y].Location = new System.Drawing.Point(y * Quadrado.comp, x * Quadrado.comp);
                    quadradoArray[x, y].Margin = new System.Windows.Forms.Padding(0);
                    quadradoArray[x, y].Name = $"button{x}x{y}";
                    quadradoArray[x, y].Size = new System.Drawing.Size(Quadrado.comp, Quadrado.comp);
                    quadradoArray[x, y].TabStop = false;
                    quadradoArray[x, y].UseVisualStyleBackColor = false;
                    //myButton.Location = new System.Drawing.Point(x, y);
                    quadradoArray[x, y].MouseDown += new System.Windows.Forms.MouseEventHandler(CliqueQuadrado);

                    //myButton.Click += QuadradoClick;
                    panelTabuleiro.Controls.Add(quadradoArray[x, y]);
                }
            }
        }

        //Método para iniciar o jogo, a partir do quadrado clicado, caso ainda não tenha sido
        private bool VerificaPlay(int x, int y)
        {
            if (!tempo.Enabled)
            {
                if (Program.M_Tabuleiro.Rede)
                {
                    JogoNoServidor(quadrado);
                }
                else
                {
                    //Distribuir minas pelo tabuleiro
                    ColocaMinas(quadrado, tabuleiro.n_minas, x, y);
                }

                //Atualiza o numero de vizinhas para cada quadrado
                ContaVizinhas(quadrado);

                //Começar a contar o tempo de jogo
                tempo.Start();

                //this.AcceptButton = this.buttonSair;
            }
            return true;
        }

        //Método para colocar minas a partir do quadrado clicado pela primeira vez, não colocando minas nesse quadrado nem nos adjacentes, 
        //garantindo assim alguma abertura de tabuleiro e possibilidade de jogo lógico
        private void ColocaMinas(Quadrado[,] quadrado, int minas, int x, int y)
        {
            Random random = new Random();
            int aux1, aux2;
            for (int i = 0; i < minas; i++)
            {
                //Escolhe posições aleatórias para as minas
                aux1 = random.Next(0, quadrado.GetLength(0));
                aux2 = random.Next(0, quadrado.GetLength(1));
                //Caso coincida com o quadrado clicado ou adjacentes desse, escolhe posição nova
                while (aux1 >= x - 1 && aux1 <= x + 1 && aux2 >= y - 1 && aux2 <= y + 1)
                {
                    aux1 = random.Next(0, quadrado.GetLength(0));
                    aux2 = random.Next(0, quadrado.GetLength(1));
                }

                if (quadrado[aux1, aux2].Minado == false)
                {
                    quadrado[aux1, aux2].Minado = true;
                }
                //Caso tenha escolhoido uma posição já com mina, repete a colocação dessa mina
                else if (quadrado[aux1, aux2].Minado == true)
                {
                    i--;
                }
            }
        }

        //Método para contabilizar o número de vizinhas com mina
        private void ContaVizinhas(Quadrado[,] quadrado)
        {
            //Passa por todas as posições do tabuleiro
            for (int i = 0; i < quadrado.GetLength(0); i++)
            {
                for (int j = 0; j < quadrado.GetLength(1); j++)
                {
                    //Caso a posição atual tenha mina, aumenta o número de vizinhas nos quadrados adjacentes
                    if (quadrado[i, j].Minado)
                    {
                        for (int k = -1; k <= 1; k++)
                        {
                            for (int l = -1; l <= 1; l++)
                            {
                                //Garante que não ultrapassa as margens do tabuleiro
                                if (i + k >= 0 && i + k < quadrado.GetLength(0) && j + l >= 0 && j + l < quadrado.GetLength(1))
                                {
                                    quadrado[i + k, j + l].Vizinhas++;
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
        private void StopJogo()
        {
            if(tempo.Enabled)
            {
                //deixar de contar o tempo
                tempo.Stop();

                //Verifica se efetivamente ganhou
                VerificaJogo();

                //Abre resto dos quadrados fechados
                AbreTudo(quadrado, quadradoArray);

                if (tabuleiro.Rede)
                {
                    if (PedidoGuardar != null)
                    {
                        PedidoGuardar(Program.M_Jogador.ID, Program.M_Tabuleiro.nivel, Program.M_Tabuleiro.n_tempo.ToString(), tabuleiro.Vitoria.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                /*
                if (tabuleiro.Perdeu == true)
                {
                    if (PedidoPerdeu != null)
                    {
                        PedidoPerdeu();
                    }
                    else
                    {
                        MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }*/
                //Caso não tenha perdido... Ganhou!
                //AINDA COM PROBLEMAS NA APRESENTAÇÃO DA JANELA DE GANHO
                if (tabuleiro.Vitoria)
                {
                    if (PedidoGanhou != null)
                    {
                        PedidoGanhou();
                    }
                    else
                    {
                        MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                        buttonJogo.BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.BotaoJogoPerdeu;
                    }
                }
            }
            return tabuleiro.Vitoria;
        }

        //Método sem utilização
        private void VerificaFim()
        {
            int aux = 0;
            int fim = tabuleiro.n_linhas * tabuleiro.n_colunas;
            fim = fim - tabuleiro.n_minas;
            for (int x = 0; x < tabuleiro.n_linhas; x++)
            {
                for (int y = 0; y < tabuleiro.n_colunas; y++)
                {
                    if (quadrado[x, y].Aberto && !quadrado[x, y].Minado)
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
        public void AbreQuadrado(Quadrado[,] quadrado, Button[,] butao, int x, int y)
        {
            if (quadrado[x, y].Bandeira)
            {
                //Para fazer a atualização de bandeiras, caso o quadrado tenha sido aberto através de ação em outro e tivesse uma bandeira
                quadrado[x, y].Bandeira = false;
                tabuleiro.n_flags++;
                textBoxFlags.Text = tabuleiro.n_flags.ToString();
            }

            quadrado[x, y].Aberto = true;

            //Caso não esteja minado, coloca o número de vizinhas
            if (!quadrado[x, y].Minado)
            {
                switch (quadrado[x, y].Vizinhas)
                {
                    case 0:
                        butao[x, y].BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.QuadradoVazio_0;
                        break;
                    case 1:
                        butao[x, y].BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.QuadradoVazio_1;
                        break;
                    case 2:
                        butao[x, y].BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.QuadradoVazio_2;
                        break;
                    case 3:
                        butao[x, y].BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.QuadradoVazio_3;
                        break;
                    case 4:
                        butao[x, y].BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.QuadradoVazio_4;
                        break;
                    case 5:
                        butao[x, y].BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.QuadradoVazio_5;
                        break;
                    case 6:
                        butao[x, y].BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.QuadradoVazio_6;
                        break;
                    case 7:
                        butao[x, y].BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.QuadradoVazio_7;
                        break;
                    case 8:
                        butao[x, y].BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.QuadradoVazio_8;
                        break;
                    default:
                        break;
                }
                VerificaFim();
            }

            //Caso esteja minado, coloca a mina, e para o jogo caso ainda esteja a decorrer
            if (quadrado[x, y].Minado)
            {
                butao[x, y].BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.Mina;

                if (tempo.Enabled)
                {
                    butao[x, y].BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.MinaClicada;
                    tabuleiro.Vitoria = false;
                    buttonJogo.BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.BotaoJogoPerdeu;
                    StopJogo();
                }
            }

            //Depois da abertura do quadrado, e não tiver minas vizinhas, abre também os quadrados adjacentes
            if (quadrado[x, y].Vizinhas == 0)
                AbreAdjacentes(quadrado, butao, x, y);

            //Nunca vai executar esta condição... método antigo!
            //else
            //{
              //  VerificaFim();
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
                    if (butao[x + j, y + i] != null && quadrado[x + j, y + i] != null)
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


        //---------------------------
        // CLIQUES EM BUTÕES
        //---------------------------

        private void buttonJogo_Click(object sender, EventArgs e)
        {
            //Butão do smile reinicia o jogo em curso a qualquer momento
            NovoJogo();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            //Após ganhar ou sair do jogo, o utilizador volta ao menu principal

            //buttonSair.Enabled = false;

            //Escolhe uma posição aleatória para começar um jogo e mostrar um possível tabuleiro
            Random random = new Random();
            int aux1, aux2;
            aux1 = random.Next(0, quadrado.GetLength(0));
            aux2 = random.Next(0, quadrado.GetLength(1));
            VerificaPlay(aux1, aux2);

            StopJogo();

            if (!tabuleiro.Vitoria)
            {
                if (PedidoPerdeu != null)
                {
                    PedidoPerdeu();
                }
                else
                {
                    MessageBox.Show("Erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Quando um dos botoes do rato for clicado
        private void CliqueQuadrado(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            string linha = string.Empty;
            string coluna = string.Empty;
            string nome = string.Empty;
            string[] nomesplit = null;

            Button butao = ((Button)sender);

            if (butao != null)
            {
                //Regista posição do Quadrado a partir do nome
                //nome: button{x}x{y}
                nome = butao.Name.Substring(butao.Name.IndexOf('n') + 1);
                nomesplit = nome.Split('x');
                if (nomesplit.Length == 2)
                {
                    linha = nomesplit[0];
                    coluna = nomesplit[1];
                }
                else
                {
                    return;
                }
                if (linha.Length > 0)
                    x = int.Parse(linha);
                if (coluna.Length > 0)
                    y = int.Parse(coluna);

                //Só faz alguma alteração nesse quadrado caso esteja fechado
                if (quadrado[x, y].Aberto == false)
                {
                    switch (MouseButtons)
                    {
                        case MouseButtons.Left:

                            VerificaPlay(x, y);

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
                            break;
                        case MouseButtons.Right:
                            //Só deixa colocar bandeiras, caso o jogo esteja a decorrer
                            if (tempo.Enabled)
                            {
                                //O botão clicado passa a bandeira 
                                if (quadrado[x, y].Bandeira == false && quadrado[x, y].Duvida == false)
                                {
                                    quadrado[x, y].Bandeira = true;
                                    quadradoArray[x, y].BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.Flag;
                                    //Atualiza o numero de bandeiras
                                    tabuleiro.n_flags--;
                                    textBoxFlags.Text = tabuleiro.n_flags.ToString();
                                }

                                //O botão clicado passa de bandeira a dúvida
                                else if (quadrado[x, y].Bandeira == true)
                                {
                                    quadrado[x, y].Bandeira = false;
                                    quadrado[x, y].Duvida = true;
                                    quadradoArray[x, y].BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.Duvida;
                                    //Atualiza o numero de bandeiras
                                    tabuleiro.n_flags++;
                                    textBoxFlags.Text = tabuleiro.n_flags.ToString();
                                }

                                //O botão clicado retira a dúvida
                                else if (quadrado[x, y].Duvida == true)
                                {
                                    quadrado[x, y].Duvida = false;
                                    quadradoArray[x, y].BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.Quadrado;
                                    textBoxFlags.Text = tabuleiro.n_flags.ToString();
                                }
                            }
                            break;
                    }
                }

                //Quando clicado com ambos os botões do rato, caso o quadrado esteja aberto, são abertos os quadrados adjacentes sem bandeiras caso o número de bandeiras corresponda
                if (quadrado[x, y].Aberto)
                {
                    AbreSemBandeiras(quadrado, quadradoArray, x, y);
                }
            }
        }


        public void JogoNoServidor(Quadrado[,] quadrado)
        {
            try
            {
                XDocument xmlResposta = Program.S_1.GetPedirNovoJogo(Program.M_Tabuleiro.nivel, Program.M_Jogador.ID);

                if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
                {
                    // apresenta mensagem de erro 
                    MessageBox.Show(xmlResposta.Element("resultado").Element("contexto").Value,
                                    "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    foreach(var nivel in xmlResposta.Element("resultado").Element("objeto").Descendants("campo"))
                    {
                        foreach (var posicao in nivel.Descendants("posicao"))
                        {
                            if(int.Parse(posicao.Value) == -1)
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

        //Agora está no controller
        /*
        private void ServidorGuardaJogo(string id, string nivel, string tempo, string vitoria)
        {
            try
            {
                XDocument xmlResposta = Program.S_1.PostRegistarResultado(id, nivel, tempo, vitoria);

                if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
                {
                    MessageBox.Show(xmlResposta.Element("resultado").Element("contexto").Value,
                            "ERRO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO!" + ex.Message);
            }
        }*/
    }
}