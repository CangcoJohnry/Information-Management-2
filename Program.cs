using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Enter row: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter col: ");
        int cols = int.Parse(Console.ReadLine());

        List<List<double>> list = new List<List<double>>();
        double sum = 0;
        int total = 0;

        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine("Row " + (i + 1));
            List<double> row = new List<double>();

            for (int j = 0; j < cols; j++)
            {
                Console.Write("Enter number" + (j + 1) + ": ");
                double n = double.Parse(Console.ReadLine());
                row.Add(n);
                sum += n;
                total++;
            }
            list.Add(row);
        }

        Console.WriteLine("\nThe numbers are:");
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list[i].Count; j++)
            {
                Console.Write(list[i][j].ToString("0.0") + " ");
            }
            Console.WriteLine();
        }

        double avg = sum / total;
        Console.WriteLine("\nSum: " + sum.ToString("0.0") + " ; Average: " + avg.ToString("0.0"));

        Console.ReadKey();
    }
}