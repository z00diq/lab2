using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            string culinf;
            DateTime months = new DateTime();
            culinf = Console.ReadLine();
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(months.ToString("MMMM", new System.Globalization.CultureInfo(culinf)));
                months = months.AddMonths(1);
            }



            Random rand = new Random();
            string s = Console.ReadLine();
            var shuffle = string.Join("", s.OrderBy(x => rand.Next()));
            Console.WriteLine(shuffle);



            string s1 = Console.ReadLine();
            foreach (char c in s1)
            {
                if (char.IsUpper(c)==true && !(c >= 'A' && c <= 'Z'))
                Console.Write(c);
            }
            Console.ReadKey();

        }
    }
}
