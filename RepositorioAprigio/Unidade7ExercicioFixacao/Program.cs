using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade7ExercicioFixacao
{
    class Program
    {
        // Produto
        static void Produto()
        {
            int qtdProdutos = 2; // 15 produtos
            int maiorCodigo = 0, codigo = 0;
            double maiorPreco = 0, somaProdutos = 0, preco = 0;
            for (int i = 0; i < qtdProdutos; i++)
            {
                Console.WriteLine("\n==== PRODUTO {0} ====", i + 1);
                Console.Write("Digite o codigo: ");
                codigo = int.Parse(Console.ReadLine());
                Console.Write("Digite o preco: ");
                preco = double.Parse(Console.ReadLine());
                if (preco > maiorPreco)
                {
                    maiorPreco = preco;
                    maiorCodigo = codigo;
                }
                somaProdutos += preco;
            }
            double media = somaProdutos / qtdProdutos;
            Console.WriteLine("\n==== RESULTADO =====");
            Console.WriteLine("Codigo do produto de maior preco: {0}", maiorCodigo);
            Console.WriteLine("Maior preco: {0}", maiorPreco);
            Console.WriteLine("Média: {0}", media);
            Console.ReadKey();
        }

        // Salario
        static void Salario()
        {
            double salario = 0, maiorSalario = 0, somaSalario = 0, contSalarioMenor = 0;
            int numTotalFilhos = 0, numPessoas = 0;
            while (true)
            {
                Console.Write("Digite o salario do habitante (negativo p/ sair): ");
                salario = double.Parse(Console.ReadLine());
                if (salario < 0)
                    break;
                Console.Write("Digite o numero de filhos: ");
                numTotalFilhos += int.Parse(Console.ReadLine());
                if (maiorSalario < salario)
                {
                    maiorSalario = salario;
                }
                if (salario < 150)
                {
                    contSalarioMenor++;
                }
                somaSalario += salario;
                numPessoas++;
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n==== RESULTADO =====\n");
            double mediaSalario = somaSalario / numPessoas;
            Console.WriteLine("Media salario da população: R$ {0:F2}", mediaSalario);
            Console.WriteLine("Media de numero de filhos: {0}", numTotalFilhos / numPessoas);
            Console.WriteLine("Maior salario dos habitantes: R$ {0:F2}", maiorSalario);
            double percenAbaixo = ((double)contSalarioMenor / (double)numPessoas) * 100;
            Console.WriteLine("Percentual de pessoas com salario abaixo de R$ 150: {0:F2}%", percenAbaixo);
            Console.ReadKey();
        }
            // Mercadorias
        static void Mercadoria()
        {
                Console.Write("Digite o numero total de mercadorias: ");
                int qtdMercadoria = int.Parse(Console.ReadLine());
                double totalMercadoria = 0;
                for (int i = 0; i < qtdMercadoria; i++)
                {
                    Console.WriteLine("Digite o valor da mercadoria {0}: ", i + 1);
                    totalMercadoria += double.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                Console.WriteLine("\n===== Resultado =====\n");
                Console.WriteLine("Valor total: R$ {0}", totalMercadoria);
                Console.WriteLine("Média de valor: R$ {0}", totalMercadoria / qtdMercadoria);
                Console.ReadKey();
        }

        // Gerador
        static void Gerador()
        {
            int[] contador = new int[6];
            Random gerador = new Random();
            for (int i = 0; i < 100; i++)
            {
                contador[gerador.Next(0, 6)]++;
            }
            Console.WriteLine("=== RESULTADO ===");
            for (int i = 0; i < contador.Length; i++)
            {
                Console.WriteLine("Numero {0}: {1} vezes", i + 1, contador[i]);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Produto();
            Salario();
            Mercadoria();
            Gerador();
        }
    }
}
