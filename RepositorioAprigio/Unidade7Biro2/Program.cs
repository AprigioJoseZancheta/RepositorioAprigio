﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade7Biro2
{
    class Program
    {
        public static List<string> Anagramas = new List<string>();

        public static void Main()
        {
            Console.WriteLine("Digite uma palavra:");
            string palavra = Console.ReadLine();
            if (palavra != null) Anagrama(palavra, palavra.Length);
            foreach (var anagrama in Anagramas)
            {
                Console.Write("{0} ", anagrama);
            }
            Console.ReadKey();
        }

        public static void Anagrama(string palavra, int tamanho)
        {
            if (tamanho == 1)
            {
                if (!Anagramas.Contains(palavra))
                    Anagramas.Add(palavra);
            }
            else
            {
                string palavraAtual = palavra;
                for (int i = 0; i < tamanho; i++)
                {
                    palavraAtual = palavraAtual.Substring(1, tamanho - 1) + palavraAtual[0] + palavraAtual.Substring(tamanho);
                    Anagrama(palavraAtual, tamanho - 1);
                }
            }
        }
    }
}
