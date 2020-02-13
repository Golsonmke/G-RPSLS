using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSv._1
{
    public class AI : Player
    {
        
        int Score;

        public AI()
        {
           
              
            

        }
        public  void ChooseGesture(int min, int max)
        {
            string gesture;

            gesture = random.Next(0, 4);
            Console.WriteLine("Computer chose"  + gesture);
            Console.WriteLine("Please press Enter key.");


        }
        


    }
}