using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI : Player
    {
        public AI()
        {
            PlayerName();
        }

        public override void PlayerName()
        {
            List<string> randomNamesForAI = new List<string> { "The Terminator", "Sonny", "R2D2" };

            Random randomNum = new Random();
            name = randomNamesForAI[randomNum.Next(0, 3)];
            Console.WriteLine($"The computer's name is {name}.");
        }

        public override int ChooseGesture()
        {
            
            int userNumOfGesture;
            Random randomNum = new Random();
            userNumOfGesture = randomNum.Next(0, 5);

            return userNumOfGesture;
        }
    }
}
