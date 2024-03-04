using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }

        else if (percentage >= 60)
        {
            letter = "c";
        }

        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter};");

        if (percentage >= 70)
        {
            Console.WriteLine($"Your passed the class with a {letter}");
        }

        else 
        {
            Console.WriteLine("Work harder nbext semester");
        }
    }  
}
