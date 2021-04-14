using System;

namespace example_of_input_with_name_and_age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me about yourself.");
            Console.Write("Type your first name: ");

            string myFirstName;
            myFirstName = Console.ReadLine();

            Console.Write("Type your last name: ");
            string myLastName = Console.ReadLine();

            Console.Write("What year were you born? ");
            int myBirthYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);

            int myAge = DateTime.Now.Year - myBirthYear;
            Console.WriteLine("This year, you will be " + myAge + " years old.");

            int newAge = myAge + 5;
            Console.WriteLine("In 5 years, you will have " + newAge + " years.");
            Console.ReadLine();
        }
    }
}
