using System;
using System.Collections.Generic;

namespace Class2ExerciseListAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            string newWord;

            Console.WriteLine("Enter list of words");
            do
            {
                newWord = Console.ReadLine();
                if (newWord != "")
                {
                    words.Add(newWord);
                }
            }
            while (newWord != "");


            Console.WriteLine("\nHere are the words you wrote that are 5 characters long:");
            FiveCharsLong(words);
            Console.ReadLine();

        }

        static void FiveCharsLong(List<string> words)
        {
            foreach (string word in words)
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
        }
    }
}
