using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSv._1
{
    public class Human : Player
    {

        


        public Human()
        {
            
            
        }



        public override void ChooseGesture()
        {

            string input;

           
            input = Console.ReadLine();

            switch (input)
            {
                case "Rock":
                case "rock":
                    Console.WriteLine("Player: " + input);
                    this.gesture = "Rock";
                    break;
                case "Paper":
                case "paper":
                    Console.WriteLine("Player: " + input);
                    this.gesture = "Paper";
                    break;
                case "Scissors":
                case "scissors":
                    Console.WriteLine("Player: " + input);
                    this.gesture = "Scissors";
                    break;
                case "Lizard":
                case "lizard":
                    Console.WriteLine("Player: " + input);
                    this.gesture = "Lizard";
                    break;
                case "Spock":
                case "spock":
                    Console.WriteLine("Player: " + input);
                    this.gesture = "Spock";
                    break;
                default:
                    Console.WriteLine("Not a vailed Gesture");
                    break;
                    

            }


        }
    }
}