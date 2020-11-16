using System;

namespace Check_vowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine().ToLower();
            Console.WriteLine("There is {0} vowels", CountVowels(sentence));
        }
        static int CountVowels(string _sentence)
        {
            int vowelNum = 0;
            for(int i=0; i<_sentence.Length; i++)
            {
                if (_sentence[i] == 'a' || _sentence[i] == 'e' || _sentence[i] == 'i' || _sentence[i] == 'o' || _sentence[i] == 'u')
                    vowelNum++;
            }
            return vowelNum;
        }
    }
}
