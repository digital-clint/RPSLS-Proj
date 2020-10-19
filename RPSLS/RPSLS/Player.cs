using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        
        public string name;
        public int score;
        public string gestureUserChose;
        public List<string> gestures;

        public Player()
        {
            ListOfGestures();
            score = 0;
        }

        
        public void ListOfGestures()
        {
            gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }


        public abstract void PlayerName();
        public abstract int ChooseGesture(); 

    }
}
