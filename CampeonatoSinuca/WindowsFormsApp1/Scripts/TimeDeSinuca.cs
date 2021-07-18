using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Scripts
{
    class TimeDeSinuca : IEquatable<TimeDeSinuca>
    {
        public static List<TimeDeSinuca> timesDisponiveis;

        public string NomeDoTime { get; private set; }
        public string NomeDoJogador1 { get; private set; }
        public string NomeDoJogador2 { get; private set; }


        public TimeDeSinuca(string nome, string jog1, string jog2)
        {
            NomeDoTime = nome;
            NomeDoJogador1 = jog1;
            NomeDoJogador2 = jog2;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as TimeDeSinuca);
        }

        public bool Equals(TimeDeSinuca other)
        {
            return other != null &&
                   NomeDoTime == other.NomeDoTime;
        }

        public override int GetHashCode()
        {
            int hashCode = 1994906337;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NomeDoTime);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NomeDoJogador1);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NomeDoJogador2);
            return hashCode;
        }
    }
}
