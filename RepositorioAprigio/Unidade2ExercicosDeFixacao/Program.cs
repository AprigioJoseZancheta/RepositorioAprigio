using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2ExercicosDeFixacao
{
    class Program
    {
        // Soma
        static void Soma()
        {
            double n1, n2, result;
            Console.Write("Digite o primeiro numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            n2 = double.Parse(Console.ReadLine());
            result = n1 + n2;
            Console.Write("Resultado (soma):  " + result);
            Console.ReadKey();
        }

        // Calculadora
        static void Calculadora()
        {
            double n1, n2;
            Console.Write("Digite o primeiro numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultado:  ");
            Console.WriteLine("\tSoma: " + (n1 + n2));
            Console.WriteLine("\tSubtração: " + (n1 - n2));
            Console.WriteLine("\tMultiplicação: " + (n1 * n2));
            Console.WriteLine("\tDivisão: " + Math.Round((n1 / n2), 2));
            Console.ReadKey();
        }

        // Distância Percorrida
        static void DistanciaPercorida()
        {
            double distancia, totalCombustivel;
            Console.Write("Digite a distancia: ");
            distancia = double.Parse(Console.ReadLine());
            Console.Write("Digite o total de combustível: ");
            totalCombustivel = double.Parse(Console.ReadLine());
            String result = (distancia / totalCombustivel).ToString("#0.0");
            Console.WriteLine("\nConsumo Médio: " + result);
            Console.ReadKey();
        }

        // Salario
        static void Salario()
        {
            string nome;
            double salario, totalVendas, totalSalario;
            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o salario fixo: ");
            salario = double.Parse(Console.ReadLine());
            Console.Write("Digite o total vendas: ");
            totalVendas = double.Parse(Console.ReadLine());
            totalSalario = salario + (totalVendas * 0.15);
            Console.WriteLine("\n====== Resultado ======");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Salario Fixo: " + salario);
            Console.WriteLine("Salario Líquido: " + totalSalario.ToString("#0.00"));
            Console.ReadKey();
        }

        // Media Nota
        static void MediaNota()
        {
            string nome;
            double n1, n2, n3, media;
            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            n3 = double.Parse(Console.ReadLine());
            media = (n1 + n2 + n3) / 3;

            Console.WriteLine("==== Resultado ====");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Salario Líquido: " + media.ToString("#0.0"));
            Console.ReadKey();
        }

        // Troaca Valor
        static void TrocaValor()
        {
            double a, b, aux;
            Console.Write("Digite o valor de a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            b = double.Parse(Console.ReadLine());
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine("==== Resultado ====");
            Console.WriteLine("Valor de A e B: " + a + " " + b);
            Console.ReadKey();
        }

        // Converte Temperatura
        static void ConverteTemperatura()
        {
            double tempC, tempF;
            Console.Write("Digite a temperatura ºC: ");
            tempC = double.Parse(Console.ReadLine());
            tempF = (9 * tempC + 160) / 5;
            Console.WriteLine("==== Resultado ====");
            Console.WriteLine("Temperatura em ºF: " + tempF);
            Console.ReadKey();
        }

        // Dolar Real
        static void DolarReal()
        {
            double valorDolar, valorReal, cotacao;
            Console.WriteLine("Digite a cotacao: ");
            cotacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor em dólar (US$): ");
            valorDolar = double.Parse(Console.ReadLine());
            valorReal = (valorDolar * cotacao);
            Console.WriteLine("Valor convertido(R$): " + valorReal);
            Console.ReadKey();
        }

        // Compra
        static void Compra()
        {
            double valorCompra;
            Console.Write("Digite o valor da compra: ");
            valorCompra = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor com juros: " + (valorCompra / 5));
            Console.ReadKey();
        }

        // Preço Custo
        static void PercoCusto()
        {
            double precoCusto, valorRenda, percentAcresc;
            Console.WriteLine("Digite o preço de custo: ");
            precoCusto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o percentual (%): ");
            percentAcresc = double.Parse(Console.ReadLine());
            valorRenda = precoCusto + (precoCusto * (percentAcresc / 100));
            Console.WriteLine("Valor da renda: ", valorRenda);
            Console.ReadKey();
        }

        // Custo de Fabrica
        static void CustoDeFabrica()
        {
            double custoFabrica, custoTotal;
            Console.Write("Digite o custo de fábrica: ");
            custoFabrica = double.Parse(Console.ReadLine());
            //  Acréscimo de Imposto
            custoTotal = custoFabrica + (custoFabrica * 0.45);
            // Acrécimo de Distribuidor
            custoTotal = custoTotal + (custoTotal * 0.28);
            Console.WriteLine("Custo total (R$): " + custoTotal);
            Console.ReadKey();
        }

        // Concatenação de String
        static void ConcatencaoString()
        {
            Console.WriteLine("Curso " + "NDDigital" + " " + "Beginner " + 2014);
            Console.ReadKey();
        }

        // Operadores
        static void Operadores()
        {
            double num1, num2;
            Console.Write("Digite o primeiro numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(!(num1 < num2));
            Console.WriteLine(!(num1 > num2));
            Console.WriteLine(!(num1 <= num2));
            Console.WriteLine(!(num1 >= num2));
            Console.WriteLine(!(num1 != num2));
            Console.WriteLine(!(num1 == num2));

            Console.ReadKey();
        }

        // Nomes Inversos
        static void NomesInversos()
        {
            string[] nomes = new string[10];

            for (int i = 0; i < nomes.Length; i++)
            {
                nomes[i] = Console.ReadLine();
            }

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i] + "           " + nomes[9 - i]);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Soma();
            Calculadora();
            DistanciaPercorida();
            Salario();
            MediaNota();
            TrocaValor();
            ConverteTemperatura();
            DolarReal();
            Compra();
            PercoCusto();
            CustoDeFabrica();
            ConcatencaoString();
            Operadores();
            NomesInversos();
        }
    }
}
