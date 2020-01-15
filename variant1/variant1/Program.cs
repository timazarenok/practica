using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace variant1
{
    class Program
    {
        public static void Task1()
        {
            Console.WriteLine("Task1");
            string s = "<b>cat</b> is hdfdbkf";
            Regex reg = new Regex(@"<\w>(\w{0,})<\/\w>");
            MatchCollection matches = reg.Matches(s);
            foreach(Match m in matches)
            {
                Console.WriteLine(m.Groups[1]);
            }
        }
        public static void Task2()
        {
            Console.WriteLine("Task2");
            string s = "tima zarenok +375296055004 ";
            Regex reg = new Regex(@"\s\+[0-9]{0,12}\W");
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
