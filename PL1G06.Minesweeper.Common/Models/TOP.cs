using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using PL1G06.Minesweeper.Common.Diversos;

namespace PL1G06.Minesweeper.Common.Models
{
    public class TOP
    {
        public event DelegadoParaRecordes RespostaTOP1;
        public event DelegadoParaListasdeRecordes RespostaTOP10;

        public enum DificuldadesDisponiveis
        {
            Facil = 0,
            Medio = 1
        }

        public List<string> nomeJogadores { get; private set; }
        //public List<List<string>> nomeJogadores { get; private set; }

        public List<string> melhoresTempos { get; private set; }
        //public List<List<string>> melhoresTempos { get; private set; }

        public List<string> dataJogos { get; private set; }
        //public List<List<string>> dataJogos { get; private set; }


        public TOP()
        {
            //As variáveis e objetos devem ser inicializados dentro dos construtores das classes
            nomeJogadores = new List<string>();
            //nomeJogadores = new List<List<string>>();
            melhoresTempos = new List<string>();
            //melhoresTempos = new List<List<string>>();
            dataJogos = new List<string>();
            //dataJogos = new List<List<string>>();

            DificuldadesDisponiveis[] valuesDificuldades = (DificuldadesDisponiveis[])Enum.GetValues(typeof(DificuldadesDisponiveis));

            for (int i = 0; i < valuesDificuldades.Length; i++)
            {
                nomeJogadores.Add("default");
                melhoresTempos.Add("9999");
                dataJogos.Add("2000-01-01T00:00:00.0");
            }
        }

        //O método CriaTOP será invocado pelo Controller
        //public void CriaTOP(List<string> nomes, List<string> tempos, List<string> datas, string dificuldade)
        public void CriaTOP(string nome, string tempo, string data, string dificuldade)
        {
            DificuldadesDisponiveis[] valuesDificuldades = (DificuldadesDisponiveis[])Enum.GetValues(typeof(DificuldadesDisponiveis));

            int indexDificuldade = 0;

            for (int i = 0; i < valuesDificuldades.Length; i++)
            {
                /*
                nomeJogadores.Add(nomes);
                melhoresTempos.Add(tempos);
                dataJogos.Add(datas);*/

                if ((string.Compare(dificuldade, valuesDificuldades[i].ToString())) == 0)
                {
                    indexDificuldade = i;
                }
            }
            /*
            for( int i = 0; i < 1; i++)
            {
                string nome = "default";
                string tempo = "9999";
                string quando = "2000-01-01T00:00:00.0";

                nomeJogadores[indexDificuldade].Add(nome);
                melhoresTempos[indexDificuldade].Add(tempo);
                dataJogos[indexDificuldade].Add(quando);

                nomeJogadores[indexDificuldade][i] = nomes[i];
                melhoresTempos[indexDificuldade][i] = tempos[i];
                dataJogos[indexDificuldade][i] = datas[i];*/

            nomeJogadores[indexDificuldade] = nome;
            melhoresTempos[indexDificuldade] = tempo;
            dataJogos[indexDificuldade] = data;
            //}

            //O Model após criar o TOP notifica a View interessada que já tem um novo TOP disponível para exibição
            //if (nomes.Count == 1)
            {
                if (RespostaTOP1 != null) //Verifica se existe algum método inscrito no evento
                    RespostaTOP1(nomeJogadores[indexDificuldade], melhoresTempos[indexDificuldade], dataJogos[indexDificuldade], dificuldade); //Dispara o evento (Notificação) passando como parâmetro o novo TOP armazenada
            }
            /*
            else if( nomes.Count == 10)
            {
                if (RespostaTOP10 != null) //Verifica se existe algum método inscrito no evento
                    RespostaTOP10(nomeJogadores[indexDificuldade], melhoresTempos[indexDificuldade], dataJogos[indexDificuldade], dificuldade); //Dispara o evento (Notificação) passando como parâmetro o novo TOP armazenada
            }*/
        }
    }
}
