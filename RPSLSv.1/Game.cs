using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSv._1
{
    public class Game
    {
        Player player1;
        Player player2;
        private readonly Gestures Gestures;
        
        int player1score;
        int player2score;
        

        public Game()
        {
            player1score = 0;
            player2score = 0;

            
        }

        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("Rules: Rock crushes Scissors" + "\r\n" +
                "Scissors cuts Paper" + "\r\n" + "Paper covers Rock" + "\r\n" + "Rock crushes Lizard" +
               "\r\n" + "Spock smashes Scissors" + "\r\n" + "Scissors decapitates Lizard" + "\r\n" +
               "Lizard eats Paper" + "\r\n" + "Paper disproves Spock" + "\r\n" + "Spock vaporizes Rock" + "\r\n" + "DR Sheldon Cooper");
            Console.WriteLine("Best of Three round!");
            Console.Clear();
                 
        }
        public string GetNumberOfPlayers() //player one chooses to play against another Player or computer
        {
            Console.WriteLine("Choose");
            Console.WriteLine("1 or 2 players?");
            string numberOfPlayers = Console.ReadLine();
            return numberOfPlayers;
            
        }
        public void SetPlayers(string numberOfPlayers)
        {
            if (numberOfPlayers == "1")
            {
                
                player1 = new Human();
                player2 = new AI();
                Console.WriteLine("Player 1 vs. Computer!");
                
                
            }
            else if (numberOfPlayers == "2")
            {
                player1 = new Human();
                player2 = new Human();
                Console.WriteLine("Player 1 vs. Player 2");
            }
            else if (numberOfPlayers == "0")
            {
                player1 = new AI();
                player2 = new AI();
                Console.WriteLine("Computer vs. Computer!");
                Console.Clear();
                
            }

        }
        public void CompareGestures( Player player1, Player player2)
        {
            Console.WriteLine(player1.ChooseYourGesture());
            Console.WriteLine(Player2.ChooseYourGesture());

            if (player1 == "Rock" )
            {

            }
        }
        public void GetScore()
        {
           

        }
        public void RunGame()
        {
            DisplayRules();
            GetNumberOfPlayers();
            SetPlayers();

           
        }







    }
}
