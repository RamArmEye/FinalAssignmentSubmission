using System;
using CodeFirstConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== Final Assignment Submission =====");

        using (var context = new StudentContext())
        {
            context.Database.EnsureCreated();

            string input;
            do
            {
                Console.Write("Enter student name (or type 'exit' to finish): ");
                input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input) && input.ToLower() != "exit")
                {
                    var student = new Student { Name = input };
                    context.Students.Add(student);
                    context.SaveChanges();
                    Console.WriteLine($"Student '{input}' added successfully!\n");
                }

            } while (input.ToLower() != "exit");

            Console.WriteLine("\n===== Check SQL SERVER: dbo.Students Table Created =====");
        }
    }
}

