using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Daniel";
            char initial = 'A';
            int age = 26;
            bool married = true;
            double previousWages = 20.00;
            decimal currentWages = 0.00000001m;
            Console.WriteLine("Hello World!\nThis is my assignment for Variables for TrueCoders!");
            Console.WriteLine($"My name is {name} {initial}. I am {age} years old, and it's {married} that I'm married.");
            Console.WriteLine($"I used to make ${previousWages}/hr but now my wife will only pay me ${currentWages}/hr");
            Console.WriteLine("\n\n\n\n\n\nJust Kidding! Don't tell my wife I said that haha!");
        }
    }
}
