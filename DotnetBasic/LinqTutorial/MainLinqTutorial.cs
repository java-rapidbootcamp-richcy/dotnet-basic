using LinqTutorial.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    public class MainLinqTutorial
    {
       public static void Main()
        {
            IntroductionLinq();
            Console.WriteLine();
            Product.SampleFilterProduct();
        }
        #region Introduction Linq
        public static void IntroductionLinq()
        {
            Console.WriteLine("Introduction without Linq");
            IntroLinq.Introduction();
            Console.WriteLine("\nIntroduction with Linq");
            IntroLinq.IntroductionWithLinq();
        }
        #endregion
    }
}
