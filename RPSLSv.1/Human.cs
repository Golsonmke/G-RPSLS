using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSv._1
{
    public class Human : Player
    {

        


        public Human()
        {
            List<string> gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
            foreach (string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
        }



        public override void ChooseGesture()
        {

            string input;

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