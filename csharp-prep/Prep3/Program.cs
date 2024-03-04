using System;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("What is the magic number?");
        string magic_number = Console.ReadLine();
        int guess = int.Parse(magic_number);
        Random randomGenerator = new Random();
        int rando = randomGenerator.Next(1,100);

        while (true)
        {
            if (guess > rando)
            {
                Console.WriteLine("Guess lower");
                magic_number = Console.ReadLine();
                guess = int.Parse(magic_number);
            }

            else if (guess < rando )
            {
                Console.WriteLine("Guess higher.");
                magic_number = Console.ReadLine();
                guess = int.Parse(magic_number);
            }
            else
            {
                Console.WriteLine("You guessed correctly!");
                break;
            }
        }
    }
}