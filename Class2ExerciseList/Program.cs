using System;

namespace Class2ExerciseLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int result = SumEvens(numbers);

            Console.WriteLine("The sum of the even numbers is: " + result);
            Console.ReadLine();
        }

        static int SumEvens(int[] integers)
        {
            int result = 0;

            foreach (int i in integers)
                if (i % 2 == 0)
                {
                    result += i;
                }

            return result;
        }
    }
}
