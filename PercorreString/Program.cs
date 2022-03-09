// See https://aka.ms/new-console-template for more information
using System;

namespace OlaMundo
///
{
    class Program
    ///
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira a string\n");
            string s = Console.ReadLine(); 

            Console.WriteLine("insira o caractere a omitir");
            char c = Console.Read(); 

            Convert.ToChar(s);

            for (int i = 0; i < args.Length; i++) //
            {
                if (s[i] == c)
                {
                    s -= c;
                }
            }
        }
    }
}
