using System;

namespace Addition_of_two_numbers
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter two digits: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered number {0}, and number {1}\n{0}+{1}={2}", a, b, a+b);
        }
    }
}