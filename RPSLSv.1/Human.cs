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
                    Console.WriteLine("You chose Rock");
                    this.gesture = "Rock";
                    break;
                case "Paper":
                    Console.WriteLine("You chose Paper");
                    break;
                case "Scissors":
                    Console.WriteLine("You chose Scissors");
                    break;
                case "Lizard":
                    Console.WriteLine("You chose Lizard");
                    break;
                case "Spock":
                    Console.WriteLine("You chose Spock");
                    break;
                default:
                    Console.WriteLine("Not a vailed Gesture");
                    break;
                    

            }


        }
    }
}