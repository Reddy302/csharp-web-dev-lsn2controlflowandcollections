using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            static int AddEvenNumbers(List<int> nums)
            {
                int total = 0;
                foreach (int num in nums)
                {
                    if (Equals(num % 2, 0))
                    {
                        total += num;
                    }
                }

                return total;
            }

            List<int> numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            Console.WriteLine(AddEvenNumbers(numbers));


            static void PrintNumberLetterWords(List<string> words)
            {
                Console.WriteLine("What length of word would you like to search for? ");
                string input = Console.ReadLine();
                int wordLength = int.Parse(input);

                foreach (string word in words)
                {
                    if (Equals(word.Length, wordLength))
                    {
                        Console.WriteLine(word);
                    }
                }
            }


        }
    }
}
