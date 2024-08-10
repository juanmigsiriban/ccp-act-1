using System;
    public class Program{
    public static void Main(string[] args)
    {
        string name, course, major, studentNumber;

        while (true)
        {
            // Display prompts and get inputs
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                name = "NO INPUT";
            }

            Console.Write("Enter Student No.: ");
            studentNumber = Console.ReadLine();
            if (string.IsNullOrEmpty(studentNumber))
            {
                studentNumber = "NO INPUT";
            }

            Console.Write("Enter Course: ");
            course = Console.ReadLine();
            if (string.IsNullOrEmpty(course))
            {
                course = "NO INPUT";
            }

            Console.Write("Enter Major: ");
            major = Console.ReadLine();
            if (string.IsNullOrEmpty(major))
            {
                major = "NO INPUT";
            }

            Console.WriteLine("\n---STUDENT DETAILS---\n");
            Console.WriteLine($"You are: {name}");
            Console.WriteLine($"Your Student Number is:  {studentNumber}");
            Console.WriteLine($"You are enrolled in:  {course}");
            Console.WriteLine($"Your Major is: {major} \n");
            Console.WriteLine("--------------------\n");

            Console.Write("Do you want to continue? (YES/NO): ");
            string response = Console.ReadLine()?.Trim().ToUpper();

            if (response == "YES") {
                continue;
            } else if (response == "NO")
            {
                Console.WriteLine("Exiting the program...");
                break;
            } else
            {
                Console.WriteLine("Invalid input. Please type 'YES' or 'NO'.");
                continue;
            }
             
        }
        
    }
}
