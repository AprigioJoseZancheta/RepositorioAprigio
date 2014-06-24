using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade13
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList cores = new ArrayList();

            cores.Add("Branco");
            cores.Add("Vermelho");
            cores.Add("Azul");

            ArrayList numeros = new ArrayList();

            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(9);

            MostraCores(cores);
            MostraNumero(numeros);
            Console.ReadKey();
        }

        static void MostraCores(ArrayList cores)
        {
            foreach (string i in cores)
            {
                Console.WriteLine(i);
            }
        }

        static void MostraNumero(ArrayList numeros)
        {
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
        }
    }
}
