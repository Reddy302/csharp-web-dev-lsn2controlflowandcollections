using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, string> students = new Dictionary<double, string>();
            double newStudentID;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            string idInput;
            // Get student names ad IDs 
            do
            {
                Console.WriteLine("ID Number: ");
                idInput = Console.ReadLine();
                string nameInput;
                
                if (!Equals(idInput, ""))
                {
                    newStudentID = double.Parse(idInput);
                    Console.WriteLine("Name: ");
                    nameInput = Console.ReadLine();
                    string newStudentName = nameInput;
                    students.Add(newStudentID, newStudentName);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }

            } while (!Equals(idInput, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<double, string> student in students)
            {
                Console.WriteLine($"({student.Key}) {student.Value}");
            }

        }
    }
}
