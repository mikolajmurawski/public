using System;
using System.Collections.Generic;
namespace horners_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            uint degree;
            var coefficients_list = new List<double>();
            double point, f;
            try
            {
                Console.Write("Enter polynomial's degree (positive intiger): ");
                degree = uint.Parse(Console.ReadLine());
                for (int i = 0; i < degree; i++)
                {
                    Console.Write($"Enter the coefficient standing by x^{degree - i} (real number): ");
                    coefficients_list.Add(double.Parse(Console.ReadLine()));
                }
                Console.Write("Enter constant term (real number): ");
                coefficients_list.Add(double.Parse(Console.ReadLine()));
                Console.Write("Enter x, for which you want to evaluate the polynomial (real number): ");
                point = double.Parse(Console.ReadLine());
                f = coefficients_list[0];
                for (int i = 0; i < degree; i++)
                {
                    f = f * point + coefficients_list[i + 1];
                }
                Console.WriteLine($"The value of givem polynomial at point x = {point} equals to {f}");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid data has been provided.");
            }
        }
    }
}