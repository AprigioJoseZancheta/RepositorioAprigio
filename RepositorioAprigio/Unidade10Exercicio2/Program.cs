using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade10Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a distancia percorrida: ");
            double distancia = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de litros: ");
            double qtdLitros = double.Parse(Console.ReadLine());
            double consumo = CalculaConsumo(distancia, qtdLitros);
            Console.WriteLine("Consumo: {0} KM/L", consumo);
            Console.ReadKey();
        }

        static double CalculaConsumo(double distancia, double qtdLitros)
        {
            return (double)distancia / qtdLitros;
        }
    }
}
