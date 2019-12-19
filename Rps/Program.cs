using System;

namespace RpsGame
{
    public class Program
    {
        static void Main()
        {

            string player1 = CheckInput();
            string player2 = CheckInput();

            Console.WriteLine($"I am player1: {player1}");
            Console.WriteLine($"I am player2: {player2}");

            Game newGame = new Game(player1, player2);
            Console.WriteLine(newGame.Gameplay());
        }

        public static string CheckInput()
        {
            string player = "";
            Console.WriteLine("Please choose rock, paper, or scissors: ");
            player = Console.ReadLine();
            if (player != "rock" && player != "scissors" && player != "paper")
            {
                player = "";
                return CheckInput();
            }
            return player;
        }
    }
}

