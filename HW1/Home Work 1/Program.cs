using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter String: ");
                string input = Console.ReadLine();


                if (input != "*")
                {
                    int size = input.Length;
                    char[] reverse = new char[size];
                    char[] original = new char[size];

                    string strRev = "";
                    string strOrig = "";
                    int counter = 0;

                    for (int i = size - 1; i >= 0; i--)
                    {
                        reverse[counter] = input[i];
                        original[counter] = input[counter];
                        counter++;
                    }

                    for (int j = 0; j < size; j++)
                    {
                        strRev += reverse[j];
                        strOrig += original[j];
                    }

                    if (strOrig.ToLower() == strRev.ToLower())
                    {
                        Console.WriteLine($"Original String: {strOrig} \nReversed String: {strRev.ToLower()} \nPalindrome? Yes\n");
                    }
                    else
                    {
                        Console.WriteLine($"Original String: {strOrig} \nReversed String: {strRev.ToLower()} \nPalindrome? No\n");
                    }
                }
                else
                {
                    Console.WriteLine("Bye!");
                    break;
                }
            }
        }
    }
}