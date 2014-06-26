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
        public static ArrayList _ArrayList = new ArrayList();
        public static List<int> _ListInt = new List<int>();
        //public static IList<string> _IList = new List<string>();
        //public static Dictionary<char, string> _Dictionary =  new Dictionary<int,string>();
        static void Main(string[] args)
        {
            /*_ArrayList.Add(1);
            _ArrayList.Add("Aprigio");
            _ArrayList.Add(1.77);
            _ArrayList.Add('M');

            // remove
            _ArrayList.Remove(1);
            _ArrayList.Insert(3, 1);
            int idex = _ArrayList.IndexOf(1);
            int lastIndex = _ArrayList.LastIndexOf(1);
            _ArrayList.RemoveAt(3);
            _ArrayList.Sort();// Crescente
            _ArrayList.Reverse();// Decrescente
            _ArrayList.Clear();// Limpa Lista*/

            // List

            // Adiconar

            _ListInt.Add(12);
            _ListInt.Add(13);
            _ListInt.Add(56);
            _ListInt.Add(6);
            _ListInt.Add(2);
            _ListInt.Sort();
            _ListInt.Reverse();

            double maior = _ListInt.Max();
            double menor = _ListInt.Min();
            double qtdElementos = _ListInt.LongCount();
            double soma = _ListInt.Sum();

            foreach (var item in _ListInt)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Maior: {0} ", maior);
            Console.WriteLine("Menor: {0} ", menor);
            Console.WriteLine("Qtd elementos da Lista: {0} ", qtdElementos);
            Console.WriteLine("Soma: {0} ", soma);
            Console.ReadKey();


            /*_Dictionary.Add('a', "2");
            _Dictionary.Add('b', "22");
            _Dictionary.Add('c', "222");
            _Dictionary.Add('d', "3");
            _Dictionary.Add('e', "33");
            _Dictionary.Add('f', "333");
            _Dictionary.Add('a', "2");*/

            /*ArrayList cores = new ArrayList();

            cores.Add("Branco");
            cores.Add("Vermelho");
            cores.Add("Azul");
            

            ArrayList numeros = new ArrayList();

            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(9);
            

            MostraCores(cores);
            Console.WriteLine("Contém a cor Branca: {0} ", cores.Contains("Branco"));
            
            MostraNumero(numeros);
            Console.WriteLine("Contém o número 4: {0} ", numeros.Contains(4));
            Console.ReadKey();*/
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
