using System;

namespace RpsGame
{
    public class Game
    {
        public string Player1 {get; set;}
        public string Player2 {get; set;}
        public Game(string player1input, string player2input)
        {
            Player1 = player1input;
            Player2 = player2input;
        }

        public string Gameplay()
        {
            if (Player1 == Player2)
            {
                return "It's a draw";
            }
            else if (Player1 == "rock")
            {
                if (Player2 == "scissors")
                {
                    return "Player 1 wins";
                }
                else 
                {
                    return "Player 2 wins";
                }   
            }
            else if (Player1 == "paper")
            {
                if (Player2 == "rock")
                {
                    return "Player1 wins";
                }
                else
                {
                    return "Player2 wins";
                }
            }
            else if (Player1 == "scissors")
            {
                if (Player2 == "paper")
                {
                    return "Player1 wins";
                }
                else
                {
                    return "Player2 wins";
                }
            }
            else 
            {
                return "Please enter only rock, paper, scissors";
            }
        }
    }
}
