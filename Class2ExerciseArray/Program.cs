using System;

namespace Class2ExerciseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize and fill array
            int[] numbers = { 1, 1, 2, 3, 5, 8 };

            // Loop through array and print each value
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
