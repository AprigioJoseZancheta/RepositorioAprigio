using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3ExercicioComplementar
{
    class Program
    {
        // Distância
        static void Distancia()
        {
            double tempo, velMedia, distancia, litrosUsados;
            Console.Write("Digite o tempo da viagem: ");
            tempo = double.Parse(Console.ReadLine());
            Console.Write("Digite a velocidade média: ");
            velMedia = double.Parse(Console.ReadLine());
            distancia = tempo * velMedia;
            litrosUsados = distancia / 12;
            Console.WriteLine("==== Resultados ====");
            Console.WriteLine("Velcidade Média: " + velMedia);
            Console.WriteLine("Tempo: " + tempo);
            Console.WriteLine("Distancia percorrida: " + distancia);
            Console.WriteLine("Quantidade de Litros: " + litrosUsados.ToString("#0.00") + "L");
            Console.ReadKey();
        }

        public static int potenciaP = 1, potencia = 1, expoente, bas;
        // Potenciacao
        static void Potenciacao()
        {
             Console.Write("Digite o expoente: ");
            expoente = int.Parse(Console.ReadLine());
            Console.Write("Digite a base: ");
            bas = int.Parse(Console.ReadLine());
            potenciacaoComParametro(expoente, bas);
            potenciacao();
            Console.WriteLine("Potenciação com parametro: " + potenciaP);
            Console.WriteLine("Potenciação: " + potencia);
            Console.ReadKey();
        }

        public static void potenciacaoComParametro(int expo, int bas)
        {
            for (int i = 1; i < expo; i++)
            {
                potenciaP = potenciaP * bas;
            }
        }

        public static void potenciacao()
        {
            for (int i = 0; i < expoente; i++)
            {
                potencia = potencia * bas;
            }
        }
        
        // Função
        static void Funcao()
        {
            int num1, num2;
            double media;
            Console.Write("Digite o numero 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero 2: ");
            num2 = int.Parse(Console.ReadLine());
            media = calcularMedia(num1, num2);
            Console.WriteLine("Media: " + media.ToString("#0.00"));
            Console.ReadKey();
        }

        static double calcularMedia(int num1, int num2)
        {
            return (num1 + num2) / 2;
        }

        public static int num1, num2, result;
        // Multiplicação
        static void Multiplicacao()
        {
             Console.Write("Digite o numero 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero 2: ");
            num2 = int.Parse(Console.ReadLine());
            multiplica();
            Console.WriteLine("Resultado: " + result);
            Console.ReadKey();
        }

        static void multiplica()
        {
            result = num1 * num2;
        }

        // Positivo Negativo
        static void PositivoNegativo()
        {
            int num;
            Console.Write("Digite um numero: ");
            num = int.Parse(Console.ReadLine());
            if (positivo(num))
            {
                Console.WriteLine("É positivo");
            }
            else if (negativo(num))
            {
                Console.WriteLine("É negativo");
            }
            else if(zero(num)){
                Console.WriteLine("É zero");
            }
            Console.ReadKey();
        }

        static bool positivo(int num)
        {
            if (num > 0)
            {
                return true;
            }
            return false;
        }

        static bool negativo(int num)
        {
            if (num < 0)
            {
                return true;
            }
            return false;
        }

        static bool zero(int num)
        {
            if (num == 0)
            {
                return true;
            }
            return false;
        }
        
        // Idade
        static void Idade()
        {
            int idade;
            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());
            if (idade > 25 || idade < 5)
            {
                Console.WriteLine("Idade fora do limite de 25 ate 5 anos !!");
            }
            else
            {
                Console.WriteLine("Categoria do nadador: " + definirCategoria(idade));
            }
            Console.ReadKey();
        }

        static string definirCategoria(int idade)
        {
            if (idade >= 18)
            {
                return "Senior";
            }
            else if (idade >= 14)
            {
                return "Juvenil B";
            }
            else if (idade >= 11)
            {
                return "Juvenil A";
            }
            else if (idade >= 8)
            {
                return "Infantil B";
            }
            else
            {
                return "Infantil A";
            }
        }

        // Produto
        static void Produto()
        {
            int cod, qtd;
            double total = 0;
            Console.Write("Digite o codigo do lanche: ");
            cod = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade: ");
            qtd = int.Parse(Console.ReadLine());
            switch (cod)
            {
                case 100:
                case 103:
                    total = 1.10 * qtd;
                    break;
                case 105:
                    total = 1.00 * qtd;
                    break;
                case 101:
                case 104:
                    total = 1.30 * qtd;
                    break;
                case 102:
                    total = 1.50 * qtd;
                    break;
                default:
                    Console.WriteLine("Opcao Inválida !!");
                    break;
            }
            Console.WriteLine("Total: " + total);
            Console.ReadKey();
        }

        
        // Calculadora
       
        private static void ler()
        {
            Console.Write("Digite o numero 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero 2: ");
            num2 = int.Parse(Console.ReadLine());
        }
       
        private static void divisao()
        {
            result = num1 / num2;
            Console.WriteLine("Resultado: "+ result);
        }

        private static void multiplicacao()
        {
            result = num1 * num2;
            Console.WriteLine("Resultado: " + result);
        }

        private static void adicao()
        {
            result = num1 + num2;
            Console.WriteLine("Resultado: " + result);
        }

        private static void subtracao()
        {
            result = num1 - num2;
            Console.WriteLine("Resultado: " + result);
        }

        // Salario Categoria
        static void SalarioCategoria()
        {
            string nome, categoria;
            double salario, percent;

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o salario: ");
            salario = double.Parse(Console.ReadLine());
            Console.Write("Digite a categoria: ");
            categoria = Console.ReadLine();
            switch (categoria)
            {
                case "A":
                case "C":
                case "F":
                case "H":
                    percent = 0.1;   // 10%
                    break;
                case "B":
                case "D":
                case "E":
                case "I":
                case "J":
                case "T":
                    percent = 0.15;    // 15%
                    break;
                case "K":
                case "R":
                    percent = 0.25;     // 25%
                    break;
                case "L":
                case "M":
                case "N":
                case "O":
                case "P":
                case "Q":
                case "S":
                    percent = 0.35; // 35%
                    break;
                case "U":
                case "V":
                case "X":
                case "Y":
                case "W":
                case "Z":
                    percent = 0.5;    // 50 %
                    break;
                default:
                    Console.WriteLine("Categoria Inválida !!");
                    percent = 0;
                    break;
            }
            salario += (salario * percent);   // Salario fixo + percentual
            Console.WriteLine("=== Resultado ===");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Salario com aumento de " + (percent * 100) + " %: " + salario);
            Console.ReadKey();
        }

        // Triângulo
        static void Triangulo()
        {
            int x, y, z;
            Console.Write("Digite o x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o y: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Digite o z: ");
            z = int.Parse(Console.ReadLine());
            if ((x >= (y + z)) || (y >= (x + z)) || (z >= (x + y)))
            {
                Console.WriteLine("Não é um triângulo");
            }
            else if (x == y && x == z)
            {
                Console.WriteLine("Triângulo equilátero");
            }
            else if ((x == y) || (x == z) || (y == z))
            {
                Console.WriteLine("Triângulo isósceles");
            }
            else
            {
                Console.WriteLine("Triângulo escaleno");
            }
            Console.ReadKey();
        }
        
        static void Main(string[] args)
        {
            Distancia();
            Potenciacao();
            potenciacaoComParametro(expo,bas);
            potenciacao();
            Funcao();
            calcularMedia(num1,num2);
            Multiplicacao();
            multiplica();
            PositivoNegativo();
            positivo(num);
            negativo(num);
            zero(num);
            Idade();
            definirCategoria(idade);
            Produto();
            ler();
            divisao();
            multiplicacao();
            adicao();
            subtracao();

            int op;
            Console.WriteLine("=== Calculadora ===");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.Write("Digite a opção: ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    ler();
                    adicao();
                    break;
                case 2:
                    ler();
                    subtracao();
                    break;
                case 3:
                    ler();
                    multiplicacao();
                    break;
                case 4:
                    ler();
                    divisao();
                    break;
                default:
                    Console.WriteLine("Opção Inválida !!");
                    break;
            }
            SalarioCategoria();
            Triangulo();
        }

        public static int num { get; set; }

        public static int expo { get; set; }

        public static int idade { get; set; }
    }
}
