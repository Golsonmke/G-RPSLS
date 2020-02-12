using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSv._1
{
    public class Player : Gestures
    {
        


        public Player()
        {




        }
           

        public void ChooseYourGesture(List<string> gestures)
        {
            foreach (string gesture in gestures)
            {
                Console.WriteLine("Choose your Gesture: ");
                gestures = Console.ReadLine();
            }

        }





    }


       
}    