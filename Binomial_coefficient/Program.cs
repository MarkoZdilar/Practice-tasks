using System;

namespace Permutations_and_combinations
{
    /*
        Permutation formula -> n!/(n−r)!
        finding permutation of n objects, using r at the time

        Combination formula(Unique permutations) - > n!/(r!(n−r)!

    */
    class Program
    {
        static void Main(string[] args)
        {
            int n, r;
            Console.Write("Please enter a number of objects (n): ");
            while(!int.TryParse(Console.ReadLine(), out n))
                Console.Write("Wrong input! Enter a number: ");
            Console.Write("Please enter size of a group of objects (r): ");
            while (!int.TryParse(Console.ReadLine(), out r))
                Console.Write("Wrong input! Enter a number: ");

            Console.WriteLine($"There is {Permutation(n,r)} permutations of {n} objects taking {r} at the time.");
            Console.WriteLine($"There is {Combination(n, r)} combinations of {n} objects taking {r} at the time.");
        }

        static int Permutation(int _n, int _r)
        {
            int result;
            result = Factorial(_n) / Factorial(_n - _r);
            return result;
        }
        static int Combination(int _n, int _r)
        {
            int result;
            result = Factorial(_n) / (Factorial(_r) * Factorial(_n - _r));
            return result;
        }
        static int Factorial(int _number)
        {
            int result = 1;
            for (int i = 1; i <= _number; i++)
                result *= i;
            return result;
        }
    }
}