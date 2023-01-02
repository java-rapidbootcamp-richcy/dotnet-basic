using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement
{
    public class ForStatement
    {
        public ForStatement()
        {
        }
        public static void SampleFor()
        {
            Console.WriteLine("Masukan Angka : ");
            string? nStr = Console.ReadLine();

            int n = nStr == null ? 0 : int.Parse(nStr);

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(i == j || i + j == n - 1)
                    {
                        Console.Write("["+i+","+j+"]\t");
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
