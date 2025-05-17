using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Choose 1 for Rock, 2 for Paper, 3 for Scissors: ");
        int  user = Convert.ToInt32(Console.ReadLine());
        Random random = new Random();
        int program = random.Next(1, 3);
        if (user == 1 && program == 2)
        {
            Console.WriteLine("Rock:Paper. "+"Program won with paper!");
        }
        else if (user == 2 && program == 3)
        {
            Console.WriteLine("Paper:Scissors. "+"Program won with scissors!");
        }
        else if (user ==3 && program == 1)
        {
            Console.WriteLine("Rock:Scissors. "+"Program won with rock!");
        }
        else if (program == 1 && user == 2)
        {
            Console.WriteLine("Rock:Paper. "+"You won with paper!");
        }
        else if (program == 2 && user == 3)
        {
            Console.WriteLine("Paper:Scissors. "+"You won with scissors!");
        }
        else if (program ==3 && user == 1)
        {
            Console.WriteLine("Rock:Scissors. "+"You won with rock!");
        }
        else
        {
            Console.WriteLine("Tie!");
        }
    }
}