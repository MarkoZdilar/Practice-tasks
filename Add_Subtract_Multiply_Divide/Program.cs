using System;
using System.Dynamic;
using System.Globalization;

namespace Add_Subtract_Multiply_Divide
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Insert first number: ");
            float number1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine("Insert second number: ");
            float number2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
            DoTheMath(number1, number2);
        }

        static void DoTheMath(float _num1, float _num2)
        {
            Console.WriteLine("{0} + {1} = {2}", _num1, _num2, (_num1 + _num2));
            Console.WriteLine("{0} - {1} = {2}", _num1, _num2, (_num1 - _num2));
            Console.WriteLine("{0} * {1} = {2}", _num1, _num2, (_num1 * _num2));
            Console.WriteLine("{0} / {1} = {2}", _num1, _num2, (_num1 / _num2));
        }
    }
}