using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string seuss = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            string[] seussWords = seuss.Split(" ");
            Console.WriteLine(string.Join(" ", seussWords));

            string[] seussSentences = seuss.Split(". ");
            Console.WriteLine(seussSentences[0]);
            Console.WriteLine(string.Join(". ", seussSentences));
        }
    }
}
