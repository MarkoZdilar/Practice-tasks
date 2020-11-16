using System;

namespace Leap_year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert year: ");
            Console.WriteLine(CheckYear(Convert.ToInt32(Console.ReadLine())));
        }
        static string CheckYear(int _year)
        {
            string yesMessage = $"{_year} is a leap year.";
            string noMessage = $"{_year} isn't a leap year.";
            if (_year % 4 == 0)
            {
                if(_year % 400 == 0)
                {
                    return yesMessage;
                }
                if(_year % 100 == 0)
                {
                    return noMessage;
                }
                return yesMessage;
            }
            return noMessage;
        }
    }
}
