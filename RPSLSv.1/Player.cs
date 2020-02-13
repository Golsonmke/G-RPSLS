using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSv._1
{
    public abstract class Player 
    {

        public int score;
        public string gesture;
        

        public Player()
        {
            score = 0;


        }
      

        public  void ChooseYourGesture()
        {
            string input;
            
              List<string> gesture = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
          
            Console.WriteLine("Choose Your Option: \n Rock, Paper, Scissors, Lizard, or Spock");
             input = Console.ReadLine();
           
            switch (input)
            {
                case "Rock":
                    Console.WriteLine("You chose Rock");
                    break;
                case "Paper":
                    Console.WriteLine("You chose Paper");
                    break;
                case "Scissors":
                    Console.WriteLine("You chose Scissors");
                    break;
                case "Lizard":
                    break;
                case "Spock":
                    Console.WriteLine("You chose Spock");
                    break;
                default:
                    Console.WriteLine("Not a vailed Gesture");
                    ChooseYourGesture();
                    break;
                       

            }


                        
        }





    }


       
}