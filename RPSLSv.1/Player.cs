using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSv._1
{
    public abstract class Player 
    {

        public string gesture;


        public Player()
        {
            List<string> gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
            foreach(string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
        }


        public abstract void ChooseGesture();
       

        
    }


       
}