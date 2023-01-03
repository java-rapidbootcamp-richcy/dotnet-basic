using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic02Soal07
    {
        public static void CetakData(int n)
        {
            int[,] array = new int[n, n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(j <= 1 || i <= 1 || i >= n-2 || j >= n - 2)
                    {
                        array[i, j] = 1;
                    }
                    else if(j >= i && j < n - i)
                    {
                        array[i, j] = array[n - i, n / 2] + array[i - 2, n / 2];
                    }
                    else if(j >= n-i-1 && j <= i)
                    {
                        array[i, j] = array[n - i - 2, n / 2] + array[n - i - 3, n / 2];
                    }
                    else if(j <= n / 2)
                    {
                        array[i, j] = array[i, j - 1] + array[i, j - 2];
                    }
                    else if(j >= n/2)
                    {
                        array[i, j] = array[n / 2, n - j - 2] + array[n / 2, n - j - 3];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= i && j >= n - i - 1 && n / 2 <= i || j <= i && j <= n - i - 1 && n / 2 >= i || j >= n / 2 && j <= n - i - 1 || j <= n / 2 && j >= n - i - 1)
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
