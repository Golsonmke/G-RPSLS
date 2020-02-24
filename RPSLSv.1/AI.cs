using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSv._1
{
    public  class AI : Player
    {
        



        public AI()
        {

           





        }
        public override void ChooseGesture()
        {
            var list = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            var rnd = new Random();
            Console.WriteLine("Computer chose: " + list[rnd.Next(0, list.Count)]);



        }
        


    }
}