using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSv._1
{
    public class Game 
    {
        Player player1;
        Player player2;
        Player AI;

        List<string> gestures;

        public Game()
        {
           

            
        }

        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("Rules: Rock crushes Scissors" + "\r\n" +
                "Scissors cuts Paper" + "\r\n" + "Paper covers Rock" + "\r\n" + "Rock crushes Lizard" +
               "\r\n" + "Spock smashes Scissors" + "\r\n" + "Scissors decapitates Lizard" + "\r\n" +
               "Lizard eats Paper" + "\r\n" + "Paper disproves Spock" + "\r\n" + "Spock vaporizes Rock");
                 
        }
        public string GetNumberOfPlayers() //player one chooses to play against another Player or computer
        {

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
            }
            else if (numberOfPlayers == "2")
            {
                player1 = new Human();
                player2 = new Human();
            }
            else if (numberOfPlayers == "0")
            {
                player1 = new AI();
                player2 = new AI();
            }
                    

            

        }
        public void RunGame()
        {
            DisplayRules();
            string players = GetNumberOfPlayers();
        }







    }
}
