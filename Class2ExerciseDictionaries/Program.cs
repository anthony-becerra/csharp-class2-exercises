using System;
using System.Collections.Generic;

namespace Class2ExerciseDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                // Get student's name
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's ID
                    Console.Write("ID number: ");
                    int newID = int.Parse(Console.ReadLine());

                    // Add to dictionary
                    students.Add(newID, newStudent);
                }
            }
            while (newStudent != "");

            // Print students
            Console.WriteLine("\nStudent roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " - " + student.Value);
            }

            Console.ReadLine();
        }
    }
}
