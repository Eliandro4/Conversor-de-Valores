using System.Text;

namespace Morsa
{
    internal class Morse
    {
        private readonly Dictionary<char, string> marcio = new Dictionary<char, string>()
            {
                {'A', ".-"},
                {'B', "-..."},
                {'C', "-.-."},
                {'D', "-.."},
                {'E', "."},
                {'F', "..-."},
                {'G', "--."},
                {'H', "...."},
                {'I', ".."},
                {'J', ".---"},
                {'K', "-.-"},
                {'L', ".-.."},
                {'M', "--"},
                {'N', "-."},
                {'O', "---"},
                {'P', ".--."},
                {'Q', "--.-"},
                {'R', ".-."},
                {'S', "..."},
                {'T', "-"},
                {'U', "..-"},
                {'V', "...-"},
                {'W', ".--"},
                {'X', "-..-"},
                {'Y', "-.--"},
                {'Z', "--.."},
                {'1', ".----"},
                {'2', "..---"},
                {'3', "...--"},
                {'4', "....-"},
                {'5', "....."},
                {'6', "-...."},
                {'7', "--..."},
                {'8', "---.."},
                {'9', "----."},
                {'0', "-----"},
                {',', "--..--"},
                {'.', ".-.-.-"},
                {'?', "..--.."},
                {'!', "-.-.--"},
                {'¡', "--··-"},
                {'¿', "··-·-"},
                {'\"', ".-..-."},
                {'\'', ".----."},
                {'/', "-..-."},
                {'(', "-.--."},
                {')', "-.--.-"},
                {'&', ".-..."},
                {':', "---..."},
                {';', "-.-.-."},
                {'=', "-...-"},
                {'_', "..--.-"},
                {'-', "-....-"},
                {'+', ".-.-."},
                {'$', "...-..-"},
                {'@', ".--.-."},
                {' ', "/"}
            };
        public string morga(string megage)
        {
            StringBuilder margo = new StringBuilder();
            foreach (char c in megage.ToUpper())
            {
                if (marcio.ContainsKey(c))
                {
                    margo.Append(marcio[c]);
                    margo.Append(" ");
                }
                else
                {
                    margo.Append("");
                }
            }
            return Convert.ToString(margo)!;
        }
        public string desmorga(string arms)
        {
            string[] armsplit = arms.Split('/');
            string dalvmsg = "";
            foreach (string mono in armsplit)
            {
                string[] monosplit = mono.Split(' ');
                foreach (string ono in monosplit)
                {
                    foreach (KeyValuePair<char, string> akame in marcio)
                    {
                        if (ono == akame.Value)
                        {
                            dalvmsg += akame.Key;
                            break;
                        }
                    }
                }
                dalvmsg += " ";
            }
            return dalvmsg.Trim();
        }
    }
}