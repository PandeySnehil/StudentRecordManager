using System;
using System.Collections.Generic;

class Program
{
    static List<string> students = new List<string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- Student Record Manager ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    ViewStudents();
                    break;
                case "3":
                    Console.WriteLine("Exiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(name))
        {
            students.Add(name);
            Console.WriteLine("Student added.");
        }
        else
        {
            Console.WriteLine("Name cannot be empty.");
        }
    }

    static void ViewStudents()
    {
        Console.WriteLine("\n--- Student List ---");
        if (students.Count == 0)
        {
            Console.WriteLine("No students added yet.");
        }
        else
        {
            foreach (string student in students)
            {
                Console.WriteLine("- " + student);
            }
        }
    }
}
