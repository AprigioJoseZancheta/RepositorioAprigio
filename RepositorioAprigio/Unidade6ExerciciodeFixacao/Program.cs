using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6ExerciciodeFixacao
{
    class Program
    {
        // Numeros
        static void Numeros()
        {
            int[] vetorInteiro = new int[21];

            int countPos = 0;
            int countNeg = 0;
            int countZero = 0;

            for (int i = 0; i < vetorInteiro.Length; i++)
            {
                Console.WriteLine("Digite um valor: ");
                vetorInteiro[i] = int.Parse(Console.ReadLine());
                if (vetorInteiro[i] >= 1)
                {
                    countPos++;
                }
                if (vetorInteiro[i] == 0)
                {
                    countZero++;
                }
                if (vetorInteiro[i] < 0)
                {
                    countNeg++;
                }
            }
            Console.Clear();
            for (int i = 0; i < vetorInteiro.Length; i++)
            {
                if (vetorInteiro[i] > 0)
                {
                    Console.WriteLine(vetorInteiro[i]);
                }
            }
            Console.WriteLine("Quantidade de positivos: " + countPos);
            Console.WriteLine("Quantidade de negativos: " + countNeg);
            Console.WriteLine("Quantidade de zeros: " + countZero);

            Console.ReadKey();
        }

        // Soma Vetore
        static void SomaVetore()
        {
            int[] vetorA = new int[11];
            int[] vetorB = new int[16];
            int[] vetorC = new int[16];
            int[] vetorD = new int[1];

            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.WriteLine("Digite um valor para A: ");
                vetorA[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite um valor para B: ");
                vetorB[i] = int.Parse(Console.ReadLine());
                vetorC[i] = vetorA[i] + vetorB[i];
            }
            Console.Clear();

            for (int i = 0; i < vetorC.Length; i++)
            {
                Console.WriteLine(vetorC[i]);
                vetorD[0] = vetorC[i] + vetorD[0];
            }

            Console.WriteLine("Soma total: " + vetorD[0]);
            Console.ReadKey();
        }

        // Data de Nascimento
        static void DataNascimento()
        {
            int dia;
            int mes;
            int ano;
            Console.WriteLine("Digite o dia em que você nasceu: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mês em que você nasceu: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano em que você nasceu: ");
            ano = int.Parse(Console.ReadLine());

            DateTime dt = new DateTime(ano, mes, dia);
            Console.WriteLine(dt.ToLongDateString());
            Console.ReadKey();
        }

        // Temperatura
        static void Temperatura()
        {
            int[] temp_mes = new int[31];
            int soma_dia_mais_quante = 0;

            for (int i = 1; i < temp_mes.Length; i++)
            {
                Console.WriteLine("Digite a temperatura do dia " + i + "...");
                temp_mes[i] = int.Parse(Console.ReadLine());
                if (temp_mes[i] >= 35)
                {
                    soma_dia_mais_quante++;
                }
            }
            Console.WriteLine("Quantidade de dias que passaram dos 35 graus: " + soma_dia_mais_quante + " dias.");
            Console.ReadKey();
        }

        // Ano Bissexto
        static void AnoBissexto()
        {
            Console.WriteLine("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());
            if (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0)
            {
                Console.WriteLine("Este ano é bissexto!");
            }
            else
            {
                Console.WriteLine("Este ano não é bissexto!");
            }
            Console.ReadKey();
        }

        // Prestação
        static void Prestacao()
        {
            int total_prestacoes;
            int quant_prest_pagas;
            double valor_pres;
            int prestacoes_sobrando;
            double total_pago;
            double total_devedor;

            Console.WriteLine("Digite o total de prestações: ");
            total_prestacoes = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas prestações foram pagas: ");
            quant_prest_pagas = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor das prestações: ");
            valor_pres = int.Parse(Console.ReadLine());
            prestacoes_sobrando = total_prestacoes - quant_prest_pagas;
            total_pago = quant_prest_pagas * valor_pres;
            Console.WriteLine("Total pago até agora: R$ "+total_pago);
            total_devedor = prestacoes_sobrando * valor_pres;
            Console.WriteLine("Devendo: R$ "+total_devedor);
            Console.ReadKey();
        }
           
        // Carros
        static void Carros()
        {
            int salario_minimo = 750;
            double comissao = 0.05;
            double salario_total;
            string nome;
            double valor_ganho;
            int quant_carros_vendidos;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos carros " + nome + " vendeu?");
            quant_carros_vendidos = int.Parse(Console.ReadLine());
            valor_ganho = (150 * quant_carros_vendidos);
            salario_total = (valor_ganho * comissao) + (salario_minimo * 2) + valor_ganho;
            Console.WriteLine("Nome: " + nome + ". Salário total: R$ " + salario_total);
            Console.ReadKey();
        }

        // Corretores
        static void Corretores()
        {
            string[] nome = new string[3];
            double[] venda = new double[3];
            double[] comissao = new double[3];
            double[] totalVendas = new double[3];
            double soma = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite o nome do corretor:");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Digite o valor de venda:");
                venda[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                soma += venda[i];
                if (venda[i] > 50000)
                {
                    comissao[i] = venda[i] * 0.12;
                }
                if (venda[i] >= 30000 && venda[i] <= 50000)
                {
                    comissao[i] = venda[i] * 0.095;
                }
                else
                {
                    comissao[i] = venda[i] * 0.07;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Corretor: " + nome[i]);
                Console.WriteLine("Comissão: " + comissao[i]);
                Console.WriteLine("Total de venda: " + venda[i]);
            }
            Console.WriteLine(soma);
        }

        // Maior Valor
        static void MaiorValor()
        {
            double A, B, C;
            Console.WriteLine("Valor de A: ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de B: ");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de C: ");
            C = double.Parse(Console.ReadLine());

            if ((A + B) > C)
            {
                Console.WriteLine("Soma de A: " + A + " com B: " + B + " é maior que C: " + C);
            }
            if ((A + B) == C)
            {
                Console.WriteLine("Soma de A: " + A + " com B: " + B + " é igual a C: " + C);
            }
            if ((A + B) < C)
            {
                Console.WriteLine("Soma de A: " + A + " com B: " + B + " é menor que C: " + C);
            }
            Console.ReadKey();
        }

        // Loja
        static void Loja()
        {
            string[] nomes = new string[4];
            double[] precos = new double[4];
            double[] descontos = new double[4];
            double[] total = new double[4];
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Digite o nome do artigo " + (i + 1) + ": ");
                nomes[i] = Console.ReadLine();
                Console.Write("Digite o preco de artigo: ");
                precos[i] = double.Parse(Console.ReadLine());
                Console.Write("Digite o desconto do artigo: ");
                descontos[i] = double.Parse(Console.ReadLine());
                total[i] = precos[i] - (precos[i] * (descontos[i] / 100));
                Console.WriteLine();
            }
            for (int i = 0; i < nomes.Length; i++)
            {

                Console.WriteLine("=== Artigo " + (i + 1) + " ======");
                Console.WriteLine("Nome: " + nomes[i]);
                Console.WriteLine("Preco: " + precos[i]);
                Console.WriteLine("Desconto: " + descontos[i] + "%");
                Console.WriteLine("TOTAL: " + total[i]);
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Numeros();
            SomaVetore();
            DataNascimento();
            Temperatura();
            AnoBissexto();
            Prestacao();
            Carros();
            Corretores();
            MaiorValor();
            Loja();
        }
    }
}
