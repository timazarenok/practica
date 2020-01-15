using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace variant7
{
    class Program
    {
        public static void Task1()
        {
            Console.WriteLine("Task 1");
            string text = "3-1 1.2 * 33 3 + 2 3 + 2";
            Regex reg = new Regex(@"-?\d\.?\d?\s?[-+\/*]\s?-?\d\.?\d?");
            MatchCollection matches = reg.Matches(text);
            foreach(Match m in matches)
            {
                Console.WriteLine(m.Value);
            }
        }
        public static string ReplaceMethod(Match m)
        {
            return " ";
        }
        public static void Task2()
        {
            Console.WriteLine("Task 2");
            string words = "cat dog laba cat cat fefeefe";
            string pattern = @"laba\s";
            MatchEvaluator evaluator = new MatchEvaluator(ReplaceMethod);
            Console.WriteLine("ORIGINAL STRING ---> " + words);
            Console.WriteLine(Regex.Replace(words, pattern, evaluator, RegexOptions.IgnorePatternWhitespace, TimeSpan.FromSeconds(.25)));
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Console.ReadKey();
        }
    }
}
