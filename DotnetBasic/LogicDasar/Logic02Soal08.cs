using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic02Soal08
    {
        public static void CetakData(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= 1)
                    {
                        array[j] = 1;
                    }
                    else
                    {
                        array[j] = array[j - 1] + array[j - 2];
                    }

                    if (j >= n / 2 && j <= n - i - 1 || j <= n / 2 && j >= n - i - 1)
                    {
                        if (n / 2 < i)
                        {
                            Console.Write(array[n - i - 1] + "\t");
                        }
                        else
                        {
                            Console.Write(array[i] + "\t");
                        }
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
