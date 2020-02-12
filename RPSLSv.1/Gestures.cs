using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSv._1
{
    public class Gestures
    {
        public string rock;
        public string paper;
        public string scissor;
        public string lizard;
        public string spock;


        public Gestures(string rock, string paper, string scissor, string lizard, string spock)
        {

            this.rock = "Rock";
            this.paper = "Paper";
            this.scissor = "Scissor";
            this.lizard = "Lizard";
            this.spock = "Spock";

            List<string> gestures = new List<string>();

            gestures.Add(rock);
            gestures.Add(paper);
            gestures.Add(scissor);
            gestures.Add(lizard);
            gestures.Add(spock);

            
        }


        //rock > scissors,Lizard
        //paper > rock, spock
        //scissor > paper, lizard
        //lizard > paper,spock
        //Spock > rock, scissors

       
        }







    }

}

