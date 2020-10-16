using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {

        public Human()
        {
            PlayerName();
        }

        public override void PlayerName()
        {
            
                Console.WriteLine("What will this user's name be?: ");
                name = Console.ReadLine();

            
        }


        public override int ChooseGesture()
        {
            string userInputText;
            int userNumOfGesture;

            Console.WriteLine("ENTER the number of the gesture you would like to use: ");
            Console.WriteLine("0) Rock \n1)Paper \n2) Scissors \n3) Lizard \n4) Spock");
            userInputText = Console.ReadLine();
            bool isValidNum = int.TryParse(userInputText, out userNumOfGesture);

            while ((isValidNum == false || userNumOfGesture != 0) && (isValidNum == false || userNumOfGesture != 1) && (isValidNum == false || userNumOfGesture != 2)
                  && (isValidNum == false || userNumOfGesture != 3) && (isValidNum == false || userNumOfGesture != 4))
            {
                Console.WriteLine("You did not enter a valid number to choose gesture. PLEASE choose 0, 1, 2, 3 or 4!");
                Console.WriteLine("0) Rock \n1)Paper \n2) Scissors \n3) Lizard \n4) Spock");
                userInputText = Console.ReadLine();
                isValidNum = int.TryParse(userInputText, out userNumOfGesture);
            }

            return userNumOfGesture;
        }

    }
}
