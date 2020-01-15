using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace variant6
{
    class Program
    {
        public static void Task1()
        {
            Console.WriteLine("task1");
            string s = "#123456 #4567898765678 #4556fe ";
            Regex reg = new Regex(@"#[ABCDEFabcdef0-9]{6}\s");
            MatchCollection matches = reg.Matches(s);
            foreach(Match m in matches)
            {
                Console.WriteLine(m.Value);
            }
        }
        public static string ReplaceMethod(Match m)
        {
            return "kitty ";
        }
        public static void Task2()
        {
            Console.WriteLine("task2");
            string words = "cat dog kitten cat cat fefeefe";
            string pattern = @"cat\s";
            MatchEvaluator evaluator = new MatchEvaluator(ReplaceMethod);
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
