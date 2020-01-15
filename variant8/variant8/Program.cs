using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace variant8
{
    class Program
    {
        public static void Task1()
        {
            Console.WriteLine("Task1");
            
        }
        public static void Task2()
        {
            Console.WriteLine("Task2");
            string text = "tfghjmhugfyvgbhnjmhg#vgbhjnnhugyftuh";
            string pattern = "";
            Regex reg = new Regex("#");
            MatchCollection matches = reg.Matches(text);
            int index = 0;
            foreach (Match m in matches)
            {
                index = m.Index;
            }
            Console.WriteLine(text.Substring(0, index));
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Console.ReadKey();
        }
    }
}
