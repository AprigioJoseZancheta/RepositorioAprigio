using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6ExercicioComplementar
{
    class Program
    {

        // Maças
        static void Macas()
        {
            Console.Write("Digite o numero de maças compradas: ");
            int numMaca = Convert.ToInt32(Console.ReadLine());
            double total, taxa;
            if (numMaca >= 12)
            {
                taxa = 0.25;
            }
            else
            {
                taxa = 0.30;
            }
            total = taxa * numMaca;
            Console.WriteLine("Custo de cada maça: {0}\nTotal é: {1:F2}", taxa, total);
            Console.ReadKey();
        }

        // Calcula Peso
        static void CalculaPeso()
        {
            Console.WriteLine("==== Calculadora de Peso Ideal =====");
            Console.Write("Digite o sexo: ");
            int sexo = int.Parse(Console.ReadLine());
            Console.Write("Digite a altura: ");
            double altura = double.Parse(Console.ReadLine());
            double pesoIdeal = 0;
            switch (sexo)
            {
                case 1:
                    pesoIdeal = (62.1 * altura) - 44.7;
                    break;
                case 2:
                    pesoIdeal = (72.7 * altura) - 58;
                    break;
                default:
                    Console.WriteLine("Sexo Inválido !!");
                    break;
            }
            Console.WriteLine("Peso Ideal: {0:F2}", pesoIdeal);
            Console.ReadLine();
        }

        // Jogo
        static void Jogo()
        {
            int gremio = 0, inter = 0;
            Console.WriteLine("======== Greanal ==========");
            Random gerador = new Random();
            gremio = gerador.Next(0, 5);
            inter = gerador.Next(0, 5);
            if (inter > gremio)
            {
                Console.WriteLine("Inter venceu ! :)");
            }
            else if (inter < gremio)
            {
                Console.WriteLine("Gremio venceu ! :(");
            }
            else
            {
                Console.WriteLine("Empate !!");
            }
            Console.WriteLine("\n\n*** PLACAR *** \nGremio: {0} \nInter: {1}", gremio, inter);
            Console.ReadKey();
        }

        // Moça
        static void Moca()
        {
            double altura, maiorAltura = 0;
            string nome = null, nomeAlta = null;
            int qtdMocas = 0;
            while (true)
            {
                Console.Write("\nDigite o nome da moça (fim p/ finalizar): ");
                nome = Console.ReadLine();
                if (nome.ToLower() == "fim")
                {
                    Console.WriteLine();
                    break;
                }
                Console.Write("Digite a altua da moça: ");
                altura = double.Parse(Console.ReadLine());
                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                    nomeAlta = nome;
                }
                qtdMocas++;
                Console.WriteLine();
            }
            Console.WriteLine("====== RESULTADO =====");
            Console.WriteLine("Nome da mais alta: {0}", nomeAlta);
            Console.WriteLine("Altura: {0} metros", maiorAltura);
            Console.WriteLine("Quantidade de moças: {0}", qtdMocas);
            Console.ReadKey();
        }

        // Salario
        static void Salario()
        {
            double salBruto = 0;
            double salarioHora = 0, salarioMes = 0, salarioDia = 0;
            int numHora, numFalta;
            Console.WriteLine("=== Calculadora de Salario Bruto ====");
            Console.Write("H - Horista \nM - Mensalista\n");
            Console.Write("\nDigite o tipo de funcionario: ");
            string op = Console.ReadLine();
            op = op.ToUpper();
            switch (op)
            {
                case "H": // Horista
                    Console.Write("\nDigite o salario por hora: ");
                    salarioHora = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o numero de horas trabalhadas: ");
                    numHora = Convert.ToInt32(Console.ReadLine());
                    salBruto = numHora * salarioHora;
                    Console.WriteLine("==== Resultado Horista =====");
                    break;
                case "M":     // Mensalista              
                    Console.Write("\nDigite o salario por mes: ");
                    salarioMes = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o numero faltas (em dias): ");
                    numFalta = Convert.ToInt32(Console.ReadLine());

                    salarioDia = (double)salarioMes / 30; // Salario por dia
                    salBruto = salarioMes - (salarioDia * numFalta); // Fórmula: salario do mes - (salarioPorDia * numFaltas)

                    Console.WriteLine("\n=== Resultado Mensalista =====");
                    Console.WriteLine("Salario por dia: {0:F2}", salarioDia);
                    Console.WriteLine("Numero de Faltas: {0}", numFalta);
                    break;
                default:
                    Console.WriteLine("Opção Invalida !!");
                    break;
            }
            Console.WriteLine("\nSalario Bruto: R${0:F2}", salBruto);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Macas();
            CalculaPeso();
            Jogo();
            Moca();
            Salario();
        }
    }
}       
            