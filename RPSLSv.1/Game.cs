﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSv._1
{
    public class Game
    {

        Player player1;
        Player player2;



        int player1Score;
        int player2Score;
        int p1RoundScore;
        int p2RoundScore;

        public Game()
        {
            player1Score = 0;
            player2Score = 0;
            p1RoundScore = 0;
            p2RoundScore = 0;
            
        }
        
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("Rules: Rock crushes Scissors" + "\r\n" +
                "Scissors cuts Paper" + "\r\n" + "Paper covers Rock" + "\r\n" + "Rock crushes Lizard" +
               "\r\n" + "Spock smashes Scissors" + "\r\n" + "Scissors decapitates Lizard" + "\r\n" +
               "Lizard eats Paper" + "\r\n" + "Paper disproves Spock" + "\r\n" + "Spock vaporizes Rock" + "\r\n" + "-DR Sheldon Cooper");
            Console.WriteLine("Best of Three rounds!");
           
                 
        }
        public void GetNumberOfPlayers() //player one chooses to play against another Player or computer
        {
            Console.WriteLine("Choose");
            Console.WriteLine("1 or 2 players?");
            string numberOfPlayers;
            numberOfPlayers = Console.ReadLine();


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
        
        //rock > scissors,Lizard
        //paper > rock, spock
        //scissor > paper, lizard
        //lizard > paper,spock
        //Spock > rock, scissors
        // What are the Out comes of the Game? Win Lose and Tie.
        public void CompareGestures( ) //Loop if Tied
        
        {
            
            string gesture;
            gesture = Console.ReadLine();
            Console.WriteLine(player1.gesture);
            Console.WriteLine(player2.gesture);
            
            
            if ((player1.gesture == "Rock" && player2.gesture == "Rock") || (player1.gesture == "Paper" && player2.gesture == "Paper") || (player1.gesture == "Scissor" && player2.gesture == "Scissor") || (player1.gesture == "Lizard" && player2.gesture == "Lizard") || (player1.gesture == "Spock" && player1.gesture == "Spock"))
            {
                Console.WriteLine("It's a TIE!");
            }
            else if ((player1.gesture == "Rock" && player2.gesture == "Scissor" ) || (player1.gesture == "Rock" && player2.gesture == "Lizard") || (player1.gesture == "Paper" && player2.gesture == "Rock") || (player1.gesture == "Paper" && player2.gesture == "Spock") || (player1.gesture == "Scissors" && player2.gesture == "Paper") || (player1.gesture == "Scissors"  && player2.gesture == "Lizard") || (player1.gesture == "Lizard" && player2.gesture == "Spock") || (player1.gesture == "Lizard" && player2.gesture == "Paper") || ( player1.gesture == "Spock" && player2.gesture == "Scissors") || (player1.gesture == "Spock"  && player2.gesture == "Rock"))
            {
                Console.WriteLine("Player1 WINS!!");
                player1Score++;
            }
            else
            {
                Console.WriteLine("Player 2 WINS!");
                player2Score++;
                    
            
            }
           
           
        }
        public void DisplayWinner()
        {
            if (p1RoundScore >= 2)
            {
                Console.WriteLine("Player 1 WINS!");

            }
            else if (p2RoundScore >= 2)
            {
                Console.WriteLine("Player 2 WINS");
            }


        }
        public void DisplayGestures()
        {
           List<string> gestures = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            foreach(string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
        }

        public void RunGame()
        {
            DisplayRules();
            GetNumberOfPlayers();
            DisplayGestures();
            player1.ChooseGesture();
            player2.ChooseGesture();
            CompareGestures();
            DisplayWinner();







        }




    }
}
