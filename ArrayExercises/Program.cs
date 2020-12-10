using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 1, 2, 3, 5, 8 };

            for (int i =0; i < array1.Length; i++)
            {
                if (!Equals(array1[i] % 2, 0))
                {
                    Console.WriteLine(array1[i]);
                }
                
            }
        }
    }
}
