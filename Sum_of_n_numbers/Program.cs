using System;
using System.Collections.Generic;

namespace Sum_of_n_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers, number, temp;
            Console.Write("How many numbers you want to sum? ");
            int.TryParse(Console.ReadLine(), out numberOfNumbers);
            List<int> numberList = new List<int>();
            for(int i = 0; i < numberOfNumbers; i++)
            {
                Console.Write("Enter your number: ");
                int.TryParse(Console.ReadLine(), out temp);
                numberList.Add(temp);
            }
            Console.WriteLine($"Sum of {numberOfNumbers} numbers is {SumNNumbers(numberList)}");
            Console.WriteLine($"Recursion result is {RecursionSum(numberList, numberOfNumbers)}.");
        }

        static int SumNNumbers(List<int> _numberList)
        {
            int number, result = 0;
            for (int i = 0; i < _numberList.Count; i++)
                result += _numberList[i];
            return result;
        }
        static int RecursionSum(List<int> _numberList, int _numberOfNumbers)
        {
            if (_numberOfNumbers == 0)
                return 0;
            return _numberList[_numberOfNumbers -1] + RecursionSum(_numberList, _numberOfNumbers-1);
        }
    }
}