using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace variant2
{
    class Program
    {
        public static void Task1()
        {
            string s = "one, two, three, one, three, two, two, one, one";
            Regex reg = new Regex(@"(\s?(one),?|\s?(two),?|\s?(three),?\s?){0,}");
            MatchCollection matches = reg.Matches(s);
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Value);
            }
        }
        public static void Task2()
        {
            string s = "";
            Regex reg = new Regex(@"");
            MatchCollection matches = reg.Matches(s);
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Value);
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
