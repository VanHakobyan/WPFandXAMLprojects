using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightBall
{
   public static class AnswerGenerator
    {
        private static string[] answer = new string[]
        {
            "Կրկին փորձիր",
            "Այո իհարկե",
            "Այո",

            "Չեմ կողմնորոշվում",
            "Օ ինչ եք ասում?",
            "Կտեսնենք",
            "Դեռ ոչ",
            "Հնարավոր է",
            "Ոչ",
            "Միանշանակ",
            "Ինչու ոչ",
            "Փործել է պետք",
            "Չեմ կարծում"

        };
        public static string GetRandomAnswer()
        {
            return answer[new Random().Next(answer.Length)];
        }
    }
}
