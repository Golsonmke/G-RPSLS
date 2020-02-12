using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSv._1
{
    public class AI : Player
    {
        


        public AI()
        {



        }
        public  void ChooseGesture(List<string> gestures)
        {
            foreach (string gesture in gestures)
            {
                Console.WriteLine(gesture);
                
                
            }
        }
        


    }
}