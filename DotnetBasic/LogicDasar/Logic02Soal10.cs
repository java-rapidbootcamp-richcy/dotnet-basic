using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic02Soal10
    {
        public static void CetakData(int n)
        {
            int[,] array=new int[n,n];
            int column = n / 2;
            int row = 0;

            for (int i = 0; i < n; i++)
            {
                for(int j=0; j < n; j++)
                {
                    if(i == 0 && j == 0)
                    {
                        array[i,j] = n;
                    }
                    else if (j == 0 && i <= n / 2)
                    {
                        array[i, j] = array[i - 1, j] - 2;
                    }
                    else if (j == 0 && i > n / 2)
                    {
                        array[i, j] = array[i - 1, j] + 2;
                    }
                }
                if (i <= n / 2)
                {
                    for(int k = 1; k < column + 1; k++)
                    {
                        array[i, k] = array[i, k - 1] - 2;
                        array[i, n - k] = array[i, k - 1];
                    }
                    column--;
                }
                else
                {
                    for(int k = 1; k < column + 3; k++)
                    {
                        array[i, k] = array[i, k - 1] - 2;
                        array[i, n - k] = array[i, k - 1];
                    }
                    column++;
                }

                if (i > 0 && i <= n / 2)
                {
                    array[i, n / 2 - i] = 1;
                    array[i, n / 2 + i] = 1;
                    row++;
                }
                else if (i > 0 && i > n / 2)
                {
                    row--;
                    array[i, n / 2 - row] = 1;
                    array[i, n / 2 + row] = 1;
                }
            }
            int middleValue = n / 2;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (j - i >= middleValue || i - j >= middleValue || i + j <= middleValue || i + j >= middleValue + n - 1)
                    {
                        Console.Write(array[i,j]+"\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
