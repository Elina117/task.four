using System;
using System.Reflection.Emit;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Data;


namespace SquareRoot
{
    public class SquareRootCalculator
    {

        static void Main(string[] args)
        {
            Console.WriteLine("1 task");
            double a, b, c;
            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            c = Convert.ToDouble(Console.ReadLine());

            double[] result = solveSquareRoot(a, b, c);

            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);

        }

        public static double[] solveSquareRoot(double a, double b, double c)
        {
            double D;

            D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                double[] expected = {x1, x2};
                return expected;

            }
            else if (D==0)
            {
                double x1 = -b / (2 * a);
                double[] expected = { x1 };
                return expected;
            }

            else
            {
                double[] expected = { };
                return expected;
                
            }
        }

        
    }
     
    
}



namespace bubblesort
{
    
}