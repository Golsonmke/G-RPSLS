using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSv._1
{
    public class Human : Player
    {
        
        int score;

        public Human()
        {


        }
        public override void ChooseYourGesture()
        {
            
            Console.WriteLine("Choose your Gesture");
            gesture = Console.ReadLine();


        }
    }
}