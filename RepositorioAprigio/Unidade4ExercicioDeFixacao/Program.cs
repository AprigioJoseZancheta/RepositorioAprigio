using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4ExercicioDeFixacao
{
    class Program
    {
        // Invertida
        static void Invertida()
        {
            int[] vet = new int[10];
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = i;
            }

            for (int i = vet.Length - 1; i > 0; i--)
            {
                Console.WriteLine(vet[i]);
            }
            Console.ReadKey();
        }

        // Substituição
        static void Substituicao()
        {
            int[] vet1 = new int[10];
            int[] vet2 = new int[10];
            for (int i = 0; i < vet1.Length; i++)
            {
                vet1[i] = int.Parse(Console.ReadLine());
                if (vet1[i] < 0)
                {
                    vet2[i] = 1;
                }
                else
                {
                    vet2[i] = vet1[i];
                }
            }

            for (int i = 0; i < vet1.Length; i++)
            {
                Console.Write(vet1[i] + " " + vet2[i]);
            }
            Console.ReadKey();
        }

        // Matriz Linha Coluna
        static void MatrizLinhaColuna()
        {
            int[,] matriz = new int[3, 4];
            int[,] matrizModificada = new int[3, 4];
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    Console.Write("Digite o valor de " + linha + "," + coluna + ": ");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                    if (matriz[linha, coluna] < 0)
                    {
                        matrizModificada[linha, coluna] = 0;
                    }
                    else
                    {
                        matrizModificada[linha, coluna] = matriz[linha, coluna];
                    }
                }
            }
            Console.WriteLine("=== Original ====");
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    Console.Write(matriz[linha, coluna] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("=== Modificada ====");
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    Console.Write(matrizModificada[linha, coluna] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        // Ordem
        static void Ordem()
        {
            int cod;
            double[] vet = new double[50];
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
            }
            do
            {
                Console.Write("Digite o código: ");
                cod = int.Parse(Console.ReadLine());
                switch (cod)
                {
                    case 0:
                        Console.WriteLine("Encerrado !!");
                        break;
                    case 1:
                        Console.WriteLine("Ordem Direta: ");
                        for (int i = 0; i < vet.Length; i++)
                        {
                            Console.Write(vet[i]);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ordem inversa: ");
                        for (int i = vet.Length - 1; i < 0; i--)
                        {
                            Console.Write(vet[i]);
                        }
                        break;
                    default:
                        Console.WriteLine("Inválido !!");
                        break;
                }
            } while (cod == 0);
            Console.ReadKey();
        }

        // Classe
        static void Classe()
        {
            string nomeProf;
            string[,] vet = new string[3, 4];
            nomeProf = "Thiago";
            vet[1, 1] = "Giorgi";
            vet[1, 2] = "Lucas";
            vet[1, 3] = "Camila";
            vet[1, 4] = "Greicy";
            vet[1, 5] = "Mateus";

            vet[2, 1] = "Lucas 2";
            vet[2, 2] = "Guilherme";
            vet[2, 3] = "Arnaldo";
            vet[2, 4] = "Felipe";
            vet[2, 5] = " - ";

            vet[3, 1] = "Luiz";
            vet[3, 2] = "Raul";
            vet[3, 3] = "Aprigio";
            vet[3, 4] = "Antonio";
            vet[3, 5] = "Rafael";

            Console.WriteLine(nomeProf);
            Console.WriteLine();

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    Console.Write(vet[linha, coluna]);
                    Console.Write("|");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        // Desafio
        static void Desafio()
        {
            int result = 0;
            int[] a = new int[50];
            int[] b = new int[50];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                result += (a[i] - b[51 - i]);
            }
            Console.WriteLine("Total da soma: " + result);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Invertida();
            Substituicao();
            MatrizLinhaColuna();
            Ordem();
            Classe();
            Desafio();
        }
    }
}
