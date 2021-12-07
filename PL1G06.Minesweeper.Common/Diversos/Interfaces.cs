using System;
using System.Collections.Generic;
using System.Text;

namespace PL1G06.Minesweeper.Common.Diversos
{
    public interface JanelaPrincipal
    {
        event DelegadoSemParametros PedidoSair;
        event DelegadoSemParametros PedidoStandalone;
        event DelegadoSemParametros PedidoRede;
        event DelegadoSemParametros PedidoOpcoes;
    }

    public interface JanelaDificuldade
    {
        event DelegadoSemParametros PedidoVoltar;
        event DelegadoComTabuleiro PedidoJogo;
    }

    public interface JanelaGame
    {
        event DelegadoSemParametros PedidoPerdeu;
        event DelegadoSemParametros PedidoGanhou;
        //event DelegadoSemParametros PedidoTabuleiro;
        event DelegadoParaGuardarJogo PedidoGuardar;
    }

    public interface JanelaGOver
    {
        event DelegadoSemParametros PedidoFechar;
    }

    public interface JanelaWin
    {
        event DelegadoSemParametros PedidoFechar;
        event DelegadoParaRecordes PedidoGuardar;
        event DelegadoParaVerificarRecorde PedidoRecorde;
    }

    public interface JanelaLogin
    {
        event DelegadoSemParametros PedidoVoltar;
        event DelegadoParaLogin PedidoLogin;
        event DelegadoSemParametros PedidoCriarConta;
        event DelegadoSemParametros PedidoEsqueceuPassword;
    }

    public interface JanelaRegisto
    {
        event DelegadoSemParametros PedidoVoltar;
        event DelegadoParaRegistar PedidoRegistar;
        event DelegadoSemParametros PedidoErro;
    }

    public interface JanelaOpcoes
    {
        event DelegadoSemParametros PedidoVoltar;
        event DelegadoParaPerfil PedidoVerPerfil;
        event DelegadoSemParametros PedidoTOP10;
        event DelegadoSemParametros PedidoRegras;
        event DelegadoSemParametros PedidoDescricao;
        event DelegadoSemParametros PedidoLogout;
        event DelegadoSemParametros PedidoRede;
    }

    public interface JanelaPerfil
    {
        event DelegadoSemParametros PedidoVoltar;
        event DelegadoSemParametros PedidoPerfil;
    }

    public interface JanelaTOP10
    {
        event DelegadoSemParametros PedidoVoltar;
        event DelegadoParaPerfil PedidoVerPerfil;
        event DelegadoSemParametros PedidoTOP10;
        event DelegadoComDificuldade PedidoTOP1;
    }

    public interface JanelaRegras
    {
        event DelegadoSemParametros PedidoVoltar;
    }

    public interface JanelaDescricao
    {
        event DelegadoSemParametros PedidoVoltar;
    }

    public interface JanelaErro
    {
        event DelegadoSemParametros PedidoFechar;
    }

    public interface JanelaSaveGame
    {
        event DelegadoSemParametros PedidoFechar;
    }
}

