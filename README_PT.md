# Campo de Minas
Neste projeto foi desenvolvido duas aplicações, em ambientes de execução diferentes, que permitam ao utilizador jogar “Campo Minado” em modo solitário 
(anónimo ou autenticado em rede). Foi utilizado o Microsoft Visual Studio 2019 e dois templates aplicacionais:
  • Windows Forms App (.NET Framework) (obrigatório);
  • Universal Windows Platform (UWP) (opcional);
qualquer um deles com a linguagem C#. As duas aplicações são implementadas de forma a tirar partido do uso do padrão Model-View-Controller através da potenciação da 
reutilização dos componentes Model e Controller entre as aplicações.

Descrição Funcional:
  A plataforma desenvolvida incorpora as seguintes funcionalidades:
      • Apresenta dois níveis de dificuldade que fazem variar a dimensão do campo e o correspondente número de minas:
            o Fácil – campo 9x9 com 10 minas
            o Médio – campo 16x16 com 40 minas
      • Regista o tempo com que o jogador descobre todas as minas (vence o jogo);
      • Indica o número de minas que falta identificar;
      • Funciona em modo standalone ou em rede.
      
  Standalone:
      • As minas nos campos são posicionadas aleatoriamente em cada jogo;
      • No final de cada jogo ganho, guarda no sistema de ficheiros, em formato XML, o nome do jogador, o nível do mapa e tempo de resolução do mapa. O ficheiro guarda 
        apenas a informação do mais rápido a resolver em cada nível de dificuldade;
      • O nome do jogador que termina o jogo é solicitado quando ele vence;
      • Permite consultar o nome do jogador mais rápido e respetivo tempo para cada nível de dificuldade;
      
  Rede:
      • A aplicação liga-se a um servidor para poder funcionar (endereço a fornecer)
      • Para cada jogo novo, a aplicação solicita ao servidor um campo novo, com a dimensão adequada ao nível indicado;
      • Quando o jogo termina, a aplicação pede ao servidor para registar o jogador, o resultado e, em caso de vitória, o tempo;
      • Apenas pode jogar em rede quem estiver autenticado no servidor;
      • Para se poder autenticar, é necessário proceder ao registo prévio no servidor. O registo é feito através da própria aplicação e é baseado num perfil com a 
        seguinte informação:
            o Nome abreviado
            o Username
            o Password
            o Email
            o Fotografia
            o País
    • Os restantes dados serão guardados no servidor para completar o perfil de cada jogador:
          o Número de jogos ganhos/perdidos
          o Melhor tempo pessoal em cada nível
    • A aplicação permite consultar o TOP 10 dos mais rápidos a resolver cada um dos níveis de dificuldade. Neste TOP é possível consultar para cada jogador o nome, 
      fotografia, país, número de jogos ganhos e perdidos e tempos
      
  Protocolo de comunicação em rede:
          A comunicação com o servidor será efetuada através de uma API de Serviços Web (a ser fornecida) com os dados formatados em XML.


Requisitos do projeto desenvolvido:
  Funcionalidades em cada uma das aplicações:
    • Consultar TOP10 (online)
    • Consultar perfil de um qualquer jogador da lista (online)
    • Consultar TOP1 (offline)
    • Registar utilizador (online)
    • Autenticar utilizador (online)
    • Iniciar jogo e gerar o mapa (offline)
    • Iniciar jogo e pedir o mapa ao servidor (online)
    • Apresentar a informação do jogo (tempo, minas e matriz)
    • Implementação da lógica do jogo
    • Marcar bandeiras
    • Mostrar números de vizinhança
    • Terminar o jogo se “pisar” mina – jogo perdido
    • Terminar o jogo se marcar todas as minas corretamente – jogo ganho
    • Quando abre uma casa com vizinhança 0, automaticamente todas as casas vizinhas e  não marcadas são abertas (clicadas). A ação repete-se para todas as casas de vizinhança 
      com valor 0.
    • Em caso de vitória, guardar resultado se tiver melhor tempo (offline)
    • Guardar o resultado no servidor – vitória ou derrota (online)
   Características gerais:
    • Modelo de dados igual nos dois projetos implementados
    • Código da lógica da aplicação (controlador) com partes comuns
