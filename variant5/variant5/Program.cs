using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace variant5
{
    class Program
    {
        public static string MatchChange(Match m)
        {
            return "<a href="+m.Value+">"+m.Value+"</a>";
        }
        public static void Task1()
        {
            string words = "http://www.eeffefe.com effeefeffe";
            string pattern = @"http:\/\/www\.\w{0,}\.com";
            MatchEvaluator evaluator = new MatchEvaluator(MatchChange);
            try
            {
                Console.WriteLine("Scrambled words:");
                Console.WriteLine(Regex.Replace(words, pattern, evaluator,
                                                RegexOptions.IgnorePatternWhitespace,
                                                TimeSpan.FromSeconds(.25)));
            }
            catch (RegexMatchTimeoutException)
            {
                Console.WriteLine("Word Scramble operation timed out.");
                Console.WriteLine("Returned words:");
            }
        }

        public static void Task2()
        {
            string s = "+375296055004 time=10 +375296694276 time=4";
            Regex reg = new Regex(@"(\+37529\d{7}) time=(\d{0,3})");
            MatchCollection matches = reg.Matches(s);
            foreach(Match m in matches)
            {
                if(Convert.ToInt16(m.Groups[2].Value) < 5)
                {
                    Console.WriteLine(m.Groups[1].Value);
                }
            }
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Console.ReadKey();
        }
    }
}
