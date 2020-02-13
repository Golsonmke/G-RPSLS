using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSv._1
{
    public  class AI : Player
    {
        



        public AI()
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
            var list = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            var rnd = new Random();
            Console.WriteLine(list[rnd.Next(0, list.Count)]);



        }
        


    }
}