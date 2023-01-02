using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    public class MainLogic
    {
        public static void Main()
        {
            Console.WriteLine("Masukan Angka :");
            string? input = Console.ReadLine();
            int n = input == null ? 0 : int.Parse(input);

            Logic02Soal01.CetakData(n);
            Logic02Soal02.CetakData(n);
            Logic02Soal03.CetakData(n);

        }
    }
}
