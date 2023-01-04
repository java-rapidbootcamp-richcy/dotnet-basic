using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic02Soal09
    {
        public static void CetakData(int n)
        {
            int[,] array = new int[n, n];
            int column = 0;

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 && j == n / 2 || j == 0 && i == n / 2)
                    {
                        array[i, j] = 1;
                    }
                    else if (j == n / 2 && i <= n / 2)
                    {
                        array[i, j] = array[i - 1, j] + 2;
                    }
                    else if (j == n / 2 && i > n / 2)
                    {
                        array[i, j] = array[i - 1, j] - 2;
                    }
                }
                if (i <= n / 2 && i > 0)
                {
                    for (int k = 1; k <= i; k++)
                    {
                        array[i, n / 2 - k] = array[i, n / 2] - 2 * k;
                        array[i, n / 2 + k] = array[i, n / 2] - 2 * k;
                    }
                    column++;
                }
                else
                {
                    for (int k = 1; k <= column; k++)
                    {
                        array[i, n / 2 - k] = array[i, n / 2] - 2 * k;
                        array[i, n / 2 + k] = array[i, n / 2] - 2 * k;
                    }
                    column--;
                }
            }
            int middleValue = n / 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j - i <= middleValue && i - j <= middleValue && i + j >= middleValue && i + j <= middleValue + n - 1)
                    {
                        Console.Write(array[i, j] + "\t");
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
