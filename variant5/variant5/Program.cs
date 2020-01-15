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
        static void Main(string[] args)
        {
            Task1();
            Console.ReadKey();
        }
    }
}
