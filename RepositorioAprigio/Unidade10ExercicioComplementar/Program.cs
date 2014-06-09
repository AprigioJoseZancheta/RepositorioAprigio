using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade10ExercicioComplementar
{
    class Program
    {
        private static void Main1(string[] args)
        {
            Console.Write("Digite o ano: ");
            int ano = int.Parse(Console.ReadLine());
            if (isBissexto(ano))
            {
                Console.WriteLine("É BISSEXTO!!!");
            }
            else
            {
                Console.WriteLine("NÃO É BISSEXTO!!!");
            }
            Console.ReadKey();
        }

        private static bool isBissexto(int ano)
        {
            if (ano % 400 == 0) // É multiplo de 400
            {
                return true;
            }
            if (ano % 100 == 0) // É multiplo de 100
            {
                return false;
            }
            if (ano % 4 == 0) // É multiplo de 4
            {
                return true;
            }
            return false;
        }
    }
}
