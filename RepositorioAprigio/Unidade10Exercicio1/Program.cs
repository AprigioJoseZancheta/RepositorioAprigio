using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade10Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            preencheArray(ref array);
            exibeArray(ref array);
            Console.ReadKey();
        }

        static void preencheArray(ref int[] array)
        {
            Random gerador = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = gerador.Next(0, 100);
            }
        }

        static void exibeArray(ref int[] array)
        {
            Random gerador = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Posicao {0} : {0}", i, array[i] = gerador.Next());
            }
        }

    }
}
