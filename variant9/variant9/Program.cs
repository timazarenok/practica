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
            string text = "+375296055004 cost=10 +375297543333 cost=78 +375294567890 cost=89";
            Regex reg = new Regex(@"(\+37529\d{7}) cost=(\d{0,3})");
            MatchCollection matches = reg.Matches(text);
            Dictionary<int, string> telephones = new Dictionary<int, string>();
            foreach(Match m in matches)
            {
                telephones.Add(Convert.ToInt32(m.Groups[2].Value), m.Groups[1].Value);
            }
            var list = telephones.OrderBy(item => item.Key);
            Dictionary<int, string> dic = list.ToDictionary(keyItem => keyItem.Key, valueItem => valueItem.Value);
            foreach(var item in dic)
            {
                Console.WriteLine(item.Value +" " + item.Key);
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
