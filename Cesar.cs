using System.Collections;
using System.Globalization;
using System.Text;

namespace Cesar
{
    internal class Cesar
    {
        public string ceso(int ces, string text)
        {
            if (ces > 26)
            {
                for (int i = 26; ces > i; ces = ces - i);
            }
            if (ces < -26)
            {
                for (int i = 26; ces < (-i); ces = ces + i);
            }
            string[] larer = text.Split(' ');
            StringBuilder stringo = new StringBuilder();
            int lero;
            foreach (string laser in larer)
            {
                char[] letters = laser.ToCharArray();
                int[] lamers = new int[laser.Length];
                for (int i = 0; i < lamers.Length; i++)
                {
                    if (letters[i] > 90)
                    {
                        lamers[i] = 0;
                    }
                    else if (letters[i] < 65)
                    {
                        lamers[i] = 0;
                    }
                    else
                    {
                        lamers[i] = letters[i] + ces;
                    }
                }
                int io = 0;
                foreach (char letter in lamers)
                {
                    if (letter > 90)
                    {
                        lero = letter - 26;
                        lamers[io] = lero;
                    }
                    if (letter < 65)
                    {
                        lero = letter + 26;
                        lamers[io] = lero;
                    }
                    char am = (char)lamers[io];
                    stringo.Append(am);
                    io++;
                }
                stringo.Append(" ");
            }
            return stringo.ToString();
        }
    }
}