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
            Console.WriteLine("insira a string\n"); //
            string s = Console.ReadLine(); 

            Console.WriteLine("insira o caractere a omitir");
            char c = Console.Read();

            string novaString = s.TrimEnd(c); //
        }
    }
}
