﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade11ExercicioFixcao3
{
    class Program
    {
        static void Main1(string[] args)
        {

        }

        public static double Soma(double[] array)
        {
            double soma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                soma += array[i];
            }
            return soma;
        }
    }
}
