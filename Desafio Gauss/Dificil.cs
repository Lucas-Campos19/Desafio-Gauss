﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Gauss
{
    public class Dificil
    {
        public Dificil()
        {
            int soma = 0;
            for (int i = 100; i >= 1; i--)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("Lucas Campos");
                    if (i % 2 == 0)
                    {
                        soma += i;
                    }
                }
                else if (i % 2 == 0)
                {
                    soma += i;
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"A soma dos números pares de 1 a 100 é: {soma}");
            Console.WriteLine("----------------------------------------------------------------------------");
        }
    }
}
