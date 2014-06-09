using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2ExerciciosComplementares
{
    class Program
    {
        // Valor Antecessor
        static void ValorAntecessor()
        {
            int valor;
            Console.Write("Digite um valor: ");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine("Antecessor: " + (valor - 1));
            Console.ReadKey();
        }

        // Calcula Area
        static void CalculaArea()
        {
            double bas, alt;
            Console.Write(("Digite a base: "));
            bas = double.Parse(Console.ReadLine());
            Console.Write(("Digite a altura: "));
            alt = double.Parse(Console.ReadLine());
            Console.Write("Area: " + (bas * alt));
            Console.ReadKey();
        }

        // Anos Vividos
        static void AnosVividos()
        {
            int anos, meses, dia, idade;
            Console.Write("Digite a idade em anos: ");
            anos = int.Parse(Console.ReadLine());
            Console.Write("Digite a idade em meses: ");
            meses = int.Parse(Console.ReadLine());
            Console.Write("Digite a idade em dias: ");
            dia = int.Parse(Console.ReadLine());
            idade = (anos * 365) + (meses * 30) + dia;
            Console.WriteLine("Idade em dias: " + idade);
            Console.ReadKey();
        }

        // Eleição 
        static void Eleicao()
        {
            int total, branco, nulo, valido;
            int totalBranco, totalNulo, totalValido;

            Console.WriteLine("Digite o Total: ");
            total = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de votos brancos: ");
            branco = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de votos nulos: ");
            nulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de votos validos: ");
            valido = int.Parse(Console.ReadLine());

            totalBranco = (branco / total) * 100;
            totalNulo = (nulo / total) * 100;
            totalValido = (valido / total) * 100;

            Console.WriteLine("======= Porcentagens =======");
            Console.WriteLine("Votos Brancos: " + totalBranco + "%");
            Console.WriteLine("Votos Nulos: " + totalNulo + "%");
            Console.WriteLine("Votos Validos: " + totalValido + "%");
            Console.ReadKey();
        }

        // Xadrez
        static void Xadrez()
        {
            int horaInicio, horaFim, total;
            Console.WriteLine("Digite a hora inicial: ");
            horaInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hora final: ");
            horaFim = int.Parse(Console.ReadLine());
            if (horaInicio == horaFim)
            {
                Console.WriteLine("\t\tTempo de limite atingido: 24 horas de jogo !");
            }
            else
            {
                if (horaInicio > horaFim)
                {
                    total = horaFim + (24 - horaInicio);
                }
                else
                {
                    total = horaFim - horaInicio;
                }
                Console.WriteLine("Total de horas de jogo é: ", total);
            }
        }

        // Salario Funcionairo
        static void SalarioFuncionario()
        {
            int horaInicio, horaFim, total;
            Console.WriteLine("Digite a hora inicial: ");
            horaInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hora final: ");
            horaFim = int.Parse(Console.ReadLine());
            if (horaInicio == horaFim)
            {
                Console.WriteLine("\t\tTempo de limite atingido: 24 horas de jogo !");
            }
            else
            {
                if (horaInicio > horaFim)
                {
                    total = horaFim + (24 - horaInicio);
                }
                else
                {
                    total = horaFim - horaInicio;
                }
                Console.WriteLine("Total de horas de jogo é: ", total);
            }
        }

        // Saldo
        static void Saldo()
        {
            int numConta;
            float saldo, debito, credito, saldoAtual;
            Console.Write("Digite o numero da conta: ");
            numConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o saldo: ");
            saldo = float.Parse(Console.ReadLine());
            Console.Write("Digite o saldo do débito: ");
            debito = float.Parse(Console.ReadLine());
            Console.Write("Digite o saldo do crédito: ");
            credito = float.Parse(Console.ReadLine());
            saldoAtual = saldo - (debito + credito);
            if (saldoAtual >= 0)
            {
                Console.WriteLine("   (Saldo Positivo)");
            }
            else
            {
                Console.WriteLine("   (Saldo Negativo)");
            }
            Console.ReadKey();
        }

        // Quantidade Compra
        static void QuantidadeCompra()
        {
            float qtdAtual, qtdMax, qtdMin, qtdMedia;
            Console.Write("Digite a quantidade atual: ");
            qtdAtual = float.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade maxima: ");
            qtdMax = float.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade minima: ");
            qtdMin = float.Parse(Console.ReadLine());
            qtdMedia = (qtdMax + qtdMin) / 2;
            Console.Write("Quantidade Média: " + qtdMedia);
            if (qtdAtual >= qtdMedia)
            {
                Console.WriteLine("   (Não Efetuar Compra)");
            }
            else
            {
                Console.WriteLine("  (Efetuar Compra)");
            }
            Console.ReadKey();
        }

        // Combustivel
        static void Combustivel()
        {
            float numLitros, valorTotal, valorLitro = 0, desconto = 0;
            string tipo;

            Console.Write("Digite quantidade de litros: ");
            numLitros = float.Parse(Console.ReadLine());
            Console.Write("Digite o tipo de combustível(A - Alcool / G - Gasolina): ");
            tipo = Console.ReadLine();
            switch (tipo)
            {
                case "a":
                    valorLitro = 2.90f;
                    if (numLitros <= 20)
                    {
                        desconto = 0.03f;
                    }
                    else
                    {
                        desconto = 0.05f;
                    }
                    break;
                case "g":
                    valorLitro = 3.30f;
                    if (numLitros <= 20)
                    {
                        desconto = 0.04f;
                    }
                    else
                    {
                        desconto = 0.06f;
                    }
                    break;
                default:
                    Console.WriteLine("Tipo Inválido !!");
                    break;
            }
            valorTotal = (valorLitro * numLitros);
            valorTotal = valorTotal - ((valorTotal * desconto) * numLitros);
            Console.WriteLine("Valor Total: " + valorTotal);
            Console.ReadKey();
        }

        // Homem Mulher
        static void HomemMulher()
        {
            int idHomem1, idHomem2, idMulher1, idMulher2;
            int idhNovo, idhVelho, idmNova, idmVelha;
            Console.WriteLine(" ==== Mulheres =====");
            Console.Write("Digite a idade da primeira mulher : ");
            idMulher1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a idade da segunda mulher : ");
            idMulher2 = int.Parse(Console.ReadLine());
            Console.WriteLine("====== Homens ======");
            Console.Write("Digite a idade do primeiro homem : ");
            idHomem1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a idade do segundo homem : ");
            idHomem2 = int.Parse(Console.ReadLine());
            if (idMulher1 > idMulher2)
            {
                idmVelha = idMulher1;
                idmNova = idMulher2;
            }
            else
            {
                idmVelha = idMulher2;
                idmNova = idMulher1;
            }

            if (idHomem1 > idHomem2)
            {
                idhVelho = idHomem1;
                idhNovo = idHomem2;
            }
            else
            {
                idhVelho = idHomem2;
                idhNovo = idHomem1;
            }
            Console.WriteLine("====== Resultados ======");
            Console.WriteLine("Soma da idade  (homem mais velho com mulher mais nova) :  " + (idhVelho + idmNova));
            Console.WriteLine("Produto da idade  (homem mais novo com mulher mais velha) :  " + (idhNovo * idmVelha));
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            ValorAntecessor();
            CalculaArea();
            AnosVividos();
            Eleicao();
            Xadrez();
            SalarioFuncionario();
            Saldo();
            QuantidadeCompra();
            Combustivel();
            HomemMulher();
        }
    }
}
