using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace variant9
{
    class Program
    {
        public static void Task1()
        {
            Console.WriteLine("Task1");
            string text = ".25 0.24";
            Regex reg = new Regex(@"(\d{0,}?\.\d{0,})");
            MatchCollection matches = reg.Matches(text);
            foreach(Match m in matches)
            {
                Console.WriteLine(m.Groups[1].Value);
            }
        }
        public static void Task2()
        {
            Console.WriteLine("Task2");
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Console.ReadKey();
        }
    }
}
