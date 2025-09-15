using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePrimeChecker
{
    class Program
    {
        static bool Prime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            String inp = Console.ReadLine().Trim();
            var str = inp.Split();

            List<int> num = new List<int>();

            for (int i = 0; i < str.Length; i++)
            {
                    num.Add(int.Parse(str[i]));
            }

            Console.WriteLine("");
            for (int i = 0; i < num.Count; i++)
            {
                if (Prime(num[i]))
                {
                    Console.WriteLine($"{i + 1}. {num[i]}   Prime");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. {num[i]}   Composite");
                }
            }

            Console.ReadKey();
        }
    }

}
