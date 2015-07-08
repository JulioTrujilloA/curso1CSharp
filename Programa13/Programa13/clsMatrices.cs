﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa13
{

    public class clsMatrices
    {
        private int[,] Matriz;

        public clsMatrices()
        {
            Matriz = new int[4, 2];
        }

        public void inicializaMatriz()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Matriz[i, j] = 1;
                }
            }
        }

        public void imprimeMatriz()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0} ", Matriz[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
