using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using Conversores;
using Morsa;

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
                    string[] helpmsg = { "Texto para Hexadecimal", "Texto para Binário", "Texto para Código Morse", "Hexadecimal para Texto", "Hexadecimal para Binário", "Hexadecimal para Código Morse", "Binário para Texto", "Binário para Hexadecimal", "Binário para Código Morse", "Código Morse para Texto", "Código Morse para Hexadecimal", "Código Morse para Binário" };
                    int i = 1;
                    foreach (string msg in helpmsg)
                    {
                        Console.WriteLine($"\"-{i}\". {msg}");
                        i++;
                    }
                }
                string arms = string.Join(" ", args.Skip(1)); // Pega somente os "argumentos" após o parametro
                string Nezu;
                switch (args[0])
                {
                    case "-1": //Texto para Hex
                        if (arms.Length > 0)
                        {
                            var con = new HexBi();
                            Nezu = con.AscHex(arms);
                        }
                        break;
                    case "-2": // Texto para Binario
                        if (arms.Length > 0)
                        {
                            var con = new HexBi();
                            Nezu = con.AscBi(arms);
                        }
                        break;
                    case "-3": //Texto para Codigo morse
                        if (arms.Length > 0)
                        {
                            var morse = new Morse();
                            Nezu = morse.morga(arms);
                        }
                        break;
                    case "-4": //Hex para Texto
                        if (arms.Length > 0)
                        {
                            var con = new HexBi();
                            Nezu = con.HexAsc(arms);
                        }
                        break;
                    case "-5": //Hex para Binário
                        if (arms.Length > 0)
                        {
                            var con = new HexBi();
                            string asc = con.HexAsc(arms);
                            Nezu = con.AscBi(asc);
                        }
                        break;
                    case "-6": //Hex para morse
                        if (arms.Length > 0)
                        {
                            var con = new HexBi();
                            string asc = con.HexAsc(arms);
                            con = null;
                            var morse = new Morse();
                            Nezu = morse.morga(asc);
                        }
                        break;
                    case "-7": // Binario para Texto
                        if (arms.Length > 0)
                        {
                            var con = new HexBi();
                            Nezu = con.BiAsc(arms);
                        }
                        break;
                    case "-8": // Binario para Hex
                        if (arms.Length > 0)
                        {
                            var con = new HexBi();
                            string asc = con.BiAsc(arms);
                            Nezu = con.AscHex(asc);
                        }
                        break;
                    case "-9": // Binario para Morse
                        if (arms.Length > 0)
                        {
                            var con = new HexBi();
                            string asc = con.BiAsc(arms);
                            con = null;
                            var morse = new Morse();
                            Nezu = morse.morga(asc);
                        }
                        break;
                    case "-10": //Codigo morse para texto
                        if (arms.Length > 0)
                        {
                            var morse = new Morse();
                            Nezu = morse.desmorga(arms);
                        }
                        break;
                    case "-11": //Codigo morse para hex
                        if (arms.Length > 0)
                        {
                            var morse = new Morse();
                            string asc = morse.desmorga(arms);
                            morse = null;
                            var con = new HexBi();
                            Nezu = con.AscHex(asc);
                        }
                        break;
                    case "-12": //Codigo morse para binário
                    if (arms.Length > 0)
                        {
                            var morse = new Morse();
                            string asc = morse.desmorga(arms);
                            morse = null;
                            var con = new HexBi();
                            Nezu = con.AscBi(asc);
                        }
                        break; 
                }
            }
        }
    }
}