using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    public class IntroLinq
    {
        public static void Introduction()
        {
            int[] scores = { 98, 23, 44, 87, 50, 85, 83, 71 };
            //tanpa linq
            List<int> listScore = new List<int>();
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > 80)
                {
                    listScore.Add(scores[i]);
                }
            }
            foreach (int i in listScore)
            {
                Console.Write(i + " ");
            }
        }
        public static void IntroductionWithLinq()
        {
            int[] scores = { 98, 23, 44, 87, 50, 85, 83, 71 };
            IEnumerable<int> listScore = from score in scores where score > 80 select score;
            foreach(int i in listScore)
            {
                Console.Write(i+" ");
            }
        }
    }
}
