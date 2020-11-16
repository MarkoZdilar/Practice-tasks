using System;

namespace Even_odd
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter your number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            EvenOddModulus(number);
            EvenOddBitwise(number);
        }
        static void EvenOddModulus(int _number)
        {
            if(_number%2==0)
                Console.WriteLine("Even number");
            else
                Console.WriteLine("Odd number");
        }

        static void EvenOddBitwise(int _number)
        {
            if((_number & 1) == 0)
                Console.WriteLine("Even number");
            else
                Console.WriteLine("Odd number");
        }
    }
}