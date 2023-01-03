using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic02Soal05
    {
        public static void CetakData(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (j <= 2)
                    {
                        array[j] = 1;
                    }
                    else
                    {
                        array[j] = array[j - 1] + array[j - 2] + array[j - 3];
                    }

                    if (j >= i && j >= n - i - 1 || j <= i && j <= n - i - 1)
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
