using System;
using Conversores;

namespace Prog
{
    internal class Pgconv
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] == "-h")
                {
                    string[] helpmsg = { "Texto para Hexadecimal", "Hexadecimal para Texto", "Texto para Binário", "Binário para Texto", "Texto para Código Morse", "Código Morse para Texto" };
                    int i = 1;
                    foreach (string msg in helpmsg)
                    {
                        Console.WriteLine($"\"-{i}\". {msg}");
                        i++;
                    }
                }
                else
                {
                    if (args.Length > 1)
                    {
                        var con = new Conv();
                        string arms = string.Join(" ", args.Skip(1)); // Pega somente os "argumentos" após o parametro
                        switch (args[0])
                        {
                        case "-1": //Texto para Hex
                            con.AscHex(arms);
                            con = null;
                            break;
                        case "-2": //Hex para Texto
                            con.HexAsc(arms);
                            con = null;
                            break;
                        case "-3": // Texto para Binario
                            con.AscBi(arms);
                            con = null;
                            break;
                        case "-4": // Binario para Texto
                            con.BiAsc(arms);
                            con = null;
                            break;
                        case "-5": //Texto para Codigo morse
                            con.AscMor(arms);
                            con = null;
                            break;
                        case "-6": //Codigo morse para texto
                            con.MorAsc(arms);
                            con = null;
                            break;
                        }                    
                    }
                }
            }
        }
    }
}