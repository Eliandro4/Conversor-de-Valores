using System.Collections.ObjectModel;
using System.Text;

namespace AtMir
{
    internal class Atbash
    {
        private readonly Dictionary<char, char> haraci = new Dictionary<char, char>()
            {
                {'A', 'Z'},
                {'B', 'Y'},
                {'C', 'X'},
                {'D', 'W'},
                {'E', 'V'},
                {'F', 'U'},
                {'G', 'T'},
                {'H', 'S'},
                {'I', 'R'},
                {'J', 'Q'},
                {'K', 'P'},
                {'L', 'O'},
                {'M', 'N'},
                {'N', 'M'},
                {'O', 'L'},
                {'P', 'K'},
                {'Q', 'J'},
                {'R', 'I'},
                {'S', 'H'},
                {'T', 'G'},
                {'U', 'F'},
                {'V', 'E'},
                {'W', 'D'},
                {'X', 'C'},
                {'Y', 'B'},
                {'Z', 'A'},
                {' ', ' '}
            };
        public string atbashio_rapido(string mazzo) //Eu tinha feito outra versão, mas ela era mais lenta
        {
            StringBuilder margo = new StringBuilder();
            foreach (char c in mazzo.ToUpper())
            {
                if (haraci.ContainsKey(c))
                {
                    margo.Append(haraci[c]);
                }
                else
                {
                    margo.Append("");
                }
            }
            return Convert.ToString(margo)!;
        }
    }
    internal class Mirror
    {
        public string espelhar(string pato)
        {
            char[] sprito = pato.ToCharArray();
            int io = (sprito.Length - 1);
            char[] oio = new char[sprito.Length];
            for (int i = 0; i < sprito.Length; i++)
            {
                oio[i] = sprito[io];
                io--;
            }
            return String.Join("", oio)!;
        }
    }
}