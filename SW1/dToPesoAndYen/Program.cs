using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dToPesoAndYen
{
    class Program
    {
        static (double peso, double yen) DToPhAndYen(double dollar) {

            double peso = dollar * 57.17;
            double yen = dollar * 146.67;

            return (peso, yen);
            
        }

        static void Main(string[] args)
        {

            Console.Write("Enter currency in ($): ");
            double dollar = Convert.ToDouble(Console.ReadLine());

            var result = DToPhAndYen(dollar);

            Console.WriteLine("\nPhil Peso (P): " + result.peso);
            Console.WriteLine("Jpn Yen (Y): " + result.yen);


            Console.ReadKey();
        }
    }
}
