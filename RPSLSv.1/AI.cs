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
        public  override void ChooseGesture(Random random)
        {
            return random.Next(0, 5);
        }
        


    }
}