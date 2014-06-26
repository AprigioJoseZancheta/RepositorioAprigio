using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar
{
    class Program
    {
        static void Main1()
        {
            /* 1)	Faça um algoritmo que adicione 100 números em qualquer coleção que vocês preferir, 
            ao final imprima esses números decrescente e depois crescente.*/

            ArrayList lista = new ArrayList();

            for (int i = 0; i < 100; i++)
            {
                lista.Add(i);
            }

            Console.WriteLine("Lista ordem Crescente");
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            lista.Reverse();
            Console.WriteLine("+++++++++++++++++++++");
            Console.WriteLine("Lista ordem Decrescente");
            
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        static void Main2()
        {
            /*2)	Faça um algoritmo que leia uma coleção com 80 números decimais e encontre o menor valor, 
            o maior valor, a média e a soma de todos os valores.*/

            List<int> lista = new List<int>();

            for (int i = 0; i < 80; i++)
            {
                lista.Add(i);
            }

            int maior = lista.Max();
            int menor = lista.Min();
            int soma = lista.Sum();
            double media = lista.Average();

            Console.WriteLine("Maior: {0} ", maior);
            Console.WriteLine("Menor: {0} ", menor);
            Console.WriteLine("Soma: {0} ", soma);
            Console.WriteLine("Media: {0} ", media);
            Console.ReadKey();
        }

        static void Main3()
        {
            /* 3)	Faça um programa que leia n nomes inserindo-os em uma lista de forma ordenada utilizando a ideia do algoritmo da inserção. 
             * No final, o programa deve mostrar todos os nomes ordenados alfabeticamente. */

            List<string> lista = new List<string> { "Fabiane", "Luiz", "Raul", "Aprigio"};

            lista.Sort();

            foreach (var item in lista)
            {
                Console.WriteLine("Ordem Alfabetica: {0} ", item);
            }
            Console.ReadKey();
        }

         /*public static ArrayList lista = new ArrayList();
         public static List<int> lista1 = new List<int> {2, 5, 7, 9, 34, 55};
         public static IList<string> lista2 = new List<string> {"Aprigio", "Faby", "Luiz"};
         public static Dictionary<string, char> lista3 = new Dictionary<string, char> {{"Aprigio", 'A'} , {"Ricardo", 'R'} , {"Iolanda", 'I'} };
        static void Main4()
        {
            /* 4) Faça 4 listas com diferentes coleções, List, ArrayList, IList, Dictionary. Adicione dados em cada uma delas e no final liste-os.

            lista.Add(3);
            lista.Add("Aprigio");
            lista.Add(25);
            lista.Add("Fabiane");

            foreach (var item in lista)
            {
                Console.WriteLine("Elementos ArrayList: {0} ", item);
            }

            foreach (var item in lista1)
            {
                Console.WriteLine("Elementos da List: {0} ", item);
            }

            foreach (var item in lista2)
            {
                Console.WriteLine("Elementos do IList: {0} ", item);
            }

            foreach (var item in lista3)
            {
                Console.WriteLine("Elementos do Dictionary: {0}", item);
            }

            Console.ReadKey();
        }*/

        static public List<string> times = new List<string> {"Brasil","Camaroes","Mexico","Croacia","Holanda","Chile","Espanha","Australia","Colombia","Grecia","Costa do Marfim","Japao","Costa Rica","Uruguai","Italia","Inglaterra","Franca","Suica","Equador","Honduras","Argentina","Nigeria","Bosnia","Ira","Alemanha","E.U.A","Gana","Portugual","Belgica","Argelia","Russia","Correia do Sul" };
        static public List<string> grupoA = new List<string>();
        static public List<string> grupoB = new List<string>();
        static public List<string> grupoC = new List<string>();
        static public List<string> grupoD = new List<string>();
        static public List<string> grupoE = new List<string>();
        static public List<string> grupoF = new List<string>();
        static public List<string> grupoG = new List<string>();
        static public List<string> grupoH = new List<string>();

        
        static public Random gera = new Random();
        static void Main()
        {
            
            /* 5)	Crie um algoritmo com uma coleção com todos dos times da copa. Sabe-se que são 32 times que serão sorteados e divididos em 8 grupos, do A ao H. 
             * Depois de sorteados e alocados o algoritmo deve imprimir na tela todos os grupos.*/

            sorteiaTime();

            Console.WriteLine("Grupo A");
            Console.WriteLine("                  ");
            for (int i = 0; i < grupoA.Count; i++)
            {
                Console.WriteLine(grupoA[i]);
            }
            Console.WriteLine("                  ");
            Console.WriteLine("Grupo B");
            Console.WriteLine("                  ");
            for (int i = 0; i < grupoA.Count; i++)
            {
                Console.WriteLine(grupoB[i]);
            }
            Console.WriteLine("                  ");
            Console.WriteLine("Grupo C");
            Console.WriteLine("                  ");
            for (int i = 0; i < grupoA.Count; i++)
            {
                Console.WriteLine(grupoC[i]);
            }
            Console.WriteLine("                  ");
            Console.WriteLine("Grupo D");
            Console.WriteLine("                  ");
            for (int i = 0; i < grupoA.Count; i++)
            {
                Console.WriteLine(grupoD[i]);
            }
            Console.WriteLine("                  ");
            Console.WriteLine("Grupo E");
            Console.WriteLine("                  ");
            for (int i = 0; i < grupoA.Count; i++)
            {
                Console.WriteLine(grupoE[i]);
            }
            Console.WriteLine("                  ");
            Console.WriteLine("Grupo F");
            Console.WriteLine("                  ");
            for (int i = 0; i < grupoA.Count; i++)
            {
                Console.WriteLine(grupoF[i]);
            }
            Console.WriteLine("                  ");
            Console.WriteLine("Grupo G");
            Console.WriteLine("                  ");
            for (int i = 0; i < grupoA.Count; i++)
            {
                Console.WriteLine(grupoG[i]);
            }
            Console.WriteLine("                  ");
            Console.WriteLine("Grupo H");
            Console.WriteLine("                  ");
            for (int i = 0; i < grupoA.Count; i++)
            {
                Console.WriteLine(grupoH[i]);
            }
            Console.ReadKey();
        }

        static void sorteiaTime()
        {
            for (int i = 0; i < 4; i++)
            {
                int sorteio = gera.Next(times.Count);
                grupoA.Add(times[sorteio]);
                times.RemoveAt(sorteio);
            }

            for (int i = 0; i < 4; i++)
            {
                int sorteio = gera.Next(times.Count);
                grupoB.Add(times[sorteio]);
                times.RemoveAt(sorteio);
            }

            for (int i = 0; i < 4; i++)
            {
                int sorteio = gera.Next(times.Count);
                grupoC.Add(times[sorteio]);
                times.RemoveAt(sorteio);
            }

            for (int i = 0; i < 4; i++)
            {
                int sorteio = gera.Next(times.Count);
                grupoD.Add(times[sorteio]);
                times.RemoveAt(sorteio);
            }

            for (int i = 0; i < 4; i++)
            {
                int sorteio = gera.Next(times.Count);
                grupoE.Add(times[sorteio]);
                times.RemoveAt(sorteio);
            }

            for (int i = 0; i < 4; i++)
            {
                int sorteio = gera.Next(times.Count);
                grupoF.Add(times[sorteio]);
                times.RemoveAt(sorteio);
            }

            for (int i = 0; i < 4; i++)
            {
                int sorteio = gera.Next(times.Count);
                grupoG.Add(times[sorteio]);
                times.RemoveAt(sorteio);
            }

            for (int i = 0; i < 4; i++)
            {
                int sorteio = gera.Next(times.Count);
                grupoH.Add(times[sorteio]);
                times.RemoveAt(sorteio);
            }
        }
    }
}
