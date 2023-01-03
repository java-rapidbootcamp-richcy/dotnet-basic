﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    public class Logic02Soal04
    {
        public static void CetakData(int n)
        {
            int[] array = new int[n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (j <= 1)
                    {
                        array[j] = 1;
                    }
                    else
                    {
                        array[j] = array[j - 1] + array[j - 2];
                    }

                    if (j == 0 || i == 0 || j == n - 1 || i == n - 1 || j == n / 2 || i == n / 2)
                    {
                        Console.Write(array[j] + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
    }
}
