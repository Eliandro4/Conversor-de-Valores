using System.Text;

namespace Conversores
{
    public class Conv
    {
        public void AscHex(string asc)
        {
            char[] asm = asc.ToCharArray();
            int i = 0;
            string[] amm = new string[asm.Length];
            foreach (char cha in asm)
            {
                amm[i] = ($"{Convert.ToInt32(cha):X}");
                i = i + 1;
            }

            Console.WriteLine(string.Join(" ", amm));
        }
        public void HexAsc(string hexa)
        {
            string[] asm = hexa.Split(' ');
            int i = 0;
            string[] amm = new string[asm.Length];
            foreach (string hex in asm)
            {
                int valor = Convert.ToInt32(hex, 16);
                string stringValue = Char.ConvertFromUtf32(valor);
                amm[i] = stringValue;
                i++;
            }
            Console.WriteLine(string.Join("", amm));
        }
        public void AscBi(string asc)
        {
            StringBuilder binaryString = new StringBuilder();
            foreach (char c in asc)
            {
                binaryString.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
                binaryString.Append(" ");
            }
            Console.WriteLine(binaryString.ToString().Trim());
        }
        public void BiAsc(string input)
        {
            string[] binaryValues = input.Split(' ');
            StringBuilder text = new StringBuilder();
            foreach (string binary in binaryValues)
            {
            int decimalValue = Convert.ToInt32(binary, 2);
            text.Append((char)decimalValue);
            }
            Console.WriteLine(text.ToString());
        }
        public void AscMor(string asc)
        {

        }
        public void MorAsc(string asc)
        {

        }
    }
}