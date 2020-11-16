using System;

namespace Quadratic_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~QUADRATIC EQUATION PROGRAM~~");
            float[] results = CalculateQuadraticEquation();
            Console.WriteLine("x1= {0}\nx2= {1}", results[0], results[1]);
        }

        static float[] CalculateQuadraticEquation()
        {
            Console.Write("Insert a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Insert b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Insert c: ");
            float c = float.Parse(Console.ReadLine());

            float result1 = (-b + MathF.Sqrt((b * b) - (4 * a * c))) / (2 * a);
            float result2 = (-b - MathF.Sqrt((b * b) - (4 * a * c))) / (2 * a);
            float[] results = new float[2];
            results[0] = result1;
            results[1] = result2;
            return results;
        }
    }
}