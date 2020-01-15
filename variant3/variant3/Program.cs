using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace variant3
{
    class Program
    {
        public static void Task1()
        {
            Console.WriteLine("task 1");
            string s = " 20:20 13:24 ";
            Regex reg = new Regex(@"([0|1][0-9]|[2][0-4]):[0-5][0-9]\W");
            MatchCollection matches = reg.Matches(s);
            foreach(Match m in matches)
            {
                Console.WriteLine(m.Value);
            }
        }
        public static void Task2()
        {
            Console.WriteLine("task2");
            string s = "456-67-98 234-23-32 666-66-66 34555";
            Regex reg = new Regex(@"[0-9]{3}-[0-9]{2}-[0-9]{2}\W");
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
