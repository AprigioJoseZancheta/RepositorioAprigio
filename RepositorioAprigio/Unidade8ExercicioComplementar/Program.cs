using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8ExercicioComplementar
{
    class Program
    {
        // Numero
        static void Numero()
        {
            Random gerador = new Random();
            int num1 = gerador.Next(), num2 = gerador.Next();
            Console.WriteLine("Numero 1: {0} \nNumero 2: {1}", num1, num2);
            string msg = (num1 > num2) ? "Primeiro > Segundo" : (num1 < num2) ? "Segundo < Primeiro" : "Primeiro = Segundo";
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        // Asterisco
        static void Asterisco()
        {
            int numEspaco = 0;
            for (int desenho = 0; desenho < 3; desenho++) // 3 desenhos
            {
                for (int linha = 0; linha < 5; linha++) // 5 linhas por desenho
                {
                    for (int espaco = 0; espaco < numEspaco; espaco++) // Espacos
                    {
                        Console.Write(" ");
                    }
                    for (int simbolo = 0; simbolo < 9; simbolo++) // 9 asteriscos por linha
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(); // Quebra a linha
                    numEspaco++; // aumenta o numero de espacos
                }
                numEspaco = 0;
            }
            Console.ReadKey();
        }

        // Apartamento
        static void Apartamento()
        {
            int numApt = 10;
            int vaga = 0;
            for (int bloco = 1; bloco <= 3; bloco++)
            {
                Console.WriteLine("\n===============  Bloco {0}  ================\n", bloco);
                for (int andar = 1; andar <= 9; andar++)
                {
                    for (int apt = 1; apt <= 4; apt++)
                    {
                        Console.WriteLine("Vaga: {0} - Bloco: {1} - Andar: {2} - Apartamento: {3}", ++vaga, bloco, andar, apt + numApt);
                    }
                    Console.WriteLine();
                    numApt += 10;
                }
                numApt = 10;
            }
            Console.ReadKey();
        }

        // Tabuada
        static void Tabuada()
        {
            Console.WriteLine("=== TABUADA ====\n");
            for (int numTab = 1; numTab <= 10; numTab++)
            {
                for (int numMultiplicador = 1; numMultiplicador <= 10; numMultiplicador++)
                {
                    Console.WriteLine("{0} x {1} = {2}", numTab, numMultiplicador, numTab * numMultiplicador);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        // Mega Sena
        static void MegaSena()
        {
            Random gerador = new Random();
            int numJogada, soma = 0, contSeis = 0;
            bool perdeu = false;
            for (int jogadas = 0; jogadas < 10; jogadas++)
            {
                numJogada = gerador.Next(1, 7);
                if (numJogada == 6)
                {
                    contSeis++;
                    if (contSeis >= 2)
                    {
                        Console.WriteLine("Perdeu !! Jogou 2 vezes o numero 6");
                        perdeu = true;
                        break;
                    }
                    continue;
                }
                if ((numJogada % 2) == 0 || numJogada == 1)
                {
                    continue;
                }
                soma += numJogada;
            }
            if (!perdeu)
            {
                Console.WriteLine((soma % 2) == 0 ? "Perdeu !!!" : "Ganhou !!!"); // Se for par a soma ele perde, senão(ímpar) ganha
            }
            Console.ReadKey();
        }

        // Numero Aleatorio
        static void NumeroAleatorio()
        {
            Random gerador = new Random();
            int num = gerador.Next(), contUm = 0;
            char[] numChar = num.ToString().ToCharArray();
            for (int i = 0; i < numChar.Length; i++)
            {
                if (numChar[i] == '1')
                {
                    contUm++;
                }
            }
            Console.WriteLine("Numero Aletorio: {0}", num);
            Console.WriteLine("Quantidade de '1': {0} vezes", contUm);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Numero();
            Asterisco();
            Apartamento();
            Tabuada();
            MegaSena();
            NumeroAleatorio();
        }
    }
}
