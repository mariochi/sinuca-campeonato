using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Scripts
{

    class Tabela
    {
        private class PlacarTime : IEquatable<PlacarTime>
        {
            TimeDeSinuca timeRepresentado;
            int placar;


            public PlacarTime(TimeDeSinuca time)
            {

            }
            public override bool Equals(object obj)
            {
                return Equals(obj as PlacarTime);
            }

            public bool Equals(PlacarTime other)
            {
                return other != null &&
                       EqualityComparer<TimeDeSinuca>.Default.Equals(timeRepresentado, other.timeRepresentado);
            }
        }
        private const int MAX_TIMES_TABELA = 10;
        private List<PlacarTime> timesNestaTabela;
        public int pontosParaVitoria;
        public string descricaoPremio;


        public Tabela(int pontosVitoria, string descricao)
        {
            timesNestaTabela = new List<PlacarTime>();
            pontosParaVitoria = pontosVitoria;
            descricaoPremio = descricao;
        }
        public void AdicionaTime(int hash)
        {
            if (timesNestaTabela.Count >= MAX_TIMES_TABELA)
            {
                Console.WriteLine("Tabela cheia");
                return;
            }
            TimeDeSinuca time = TimeDeSinuca.timesDisponiveis.Where(t => t.GetHashCode() == hash).FirstOrDefault();
            if(time == null)
            {
                Console.WriteLine("Nenhum time com esse código");
                return;
            }
            PlacarTime pt = new PlacarTime(time);
            if(timesNestaTabela.Contains(pt))
            {
                Console.WriteLine("Esse time já está na tabela, retornando");
                return;
            }
            timesNestaTabela.Add(pt);
            
            
    
        }
        public void AdicionaTime(string Nome, string jog1, string jog2)
        {
            if(timesNestaTabela.Count >= MAX_TIMES_TABELA)
            {
                Console.WriteLine("Tabela cheia");
                return;
            }
            TimeDeSinuca time = new TimeDeSinuca(Nome, jog1, jog2);
            if(TimeDeSinuca.timesDisponiveis.Contains(time))
            {
                Console.WriteLine("Nome de time indisponível");
                return;
            }

        }
    }
}
