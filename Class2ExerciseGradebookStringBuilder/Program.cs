﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2ExerciseGradebookStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create lists
            List<string> students = new List<string>();
            List<double> grades = new List<double>();
            string newStudent;
            StringBuilder myString = new StringBuilder();

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    students.Add(newStudent);
                }
            }
            while (newStudent != "");

            // Get student grades
            foreach (string student in students)
            {
                Console.WriteLine("Number grade for " + student + ": ");
                double newGrade = double.Parse(Console.ReadLine());
                grades.Add(newGrade);
            }

            // Print class roster
            Console.WriteLine("\nClass roster:");
            for (int i = 0; i < students.Count; i++)
            {
                myString.Append(students[i] + " (" + grades[i] + ")\n");
            }

            Console.WriteLine(myString);

            double sum = grades.Sum();
            double avg = sum / grades.Count;
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        }
    }
}
