using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        public Player playerOne;
        public Player playerTwo;
        public int numOfGamesToPlay;

        
        public void RunGame()
        {
            
            WelcomeMsg();
            HowManyGamesToPlay();
        }

        
        public void WelcomeMsg()
        {
            Console.WriteLine("WELCOME TO ROCK, PAPER, SCISSORS, LIZARD, SPOCK!");
            Console.WriteLine("THE RULES ARE BELOW: \n");
            Console.WriteLine(@"
                                        Rock crushes Scissors
                _______                 Scissors cuts Paper
            ---'   ____)____            Paper covers Rock
                      ______)           Rock crushes Lizard
                      _______)          Lizard poisons Spock
                     _______)           Spock smashes Scissors
            ---.__________)             Scissors decapitates Lizard
                                        Lizard eats Paper
                                        Paper disproves Spock
                                        Spock vaporizes Rock");
            Console.WriteLine();
            Console.WriteLine("Press ENTER TO CONTINUE");
            Console.ReadLine();
            Console.Clear();
        }


        public void HowManyGamesToPlay()
        {
            string userInputText;
            int userNumOfGameChoice;


            Console.WriteLine("What type of series would you like to play? ENTER the number of your choice.");
            Console.WriteLine("0) Best of 3 games");
            Console.WriteLine("1) Best of 5 games");
            Console.WriteLine("2) Best of 7 games");
            userInputText = Console.ReadLine();
            bool isValidNum = int.TryParse(userInputText, out userNumOfGameChoice);

            while ((isValidNum == false || userNumOfGameChoice != 0) && (isValidNum == false || userNumOfGameChoice != 1) && (isValidNum == false || userNumOfGameChoice != 2))
            {
                Console.WriteLine("You did not enter a valid number. PLEASE choose 0, 1 or 2!");
                Console.WriteLine("0) Best of 3 games");
                Console.WriteLine("1) Best of 5 games");
                Console.WriteLine("2) Best of 7 games");
                userInputText = Console.ReadLine();
                isValidNum = int.TryParse(userInputText, out userNumOfGameChoice);
            }

            numOfGamesToPlay = userNumOfGameChoice;
            switch (numOfGamesToPlay)
            {
                case 0:
                    Console.WriteLine("You have chosen to play a 3 game series!");
                    break;

                case 1:
                    Console.WriteLine("You have chosen to play a 5 game series!");
                    break;
                
                default:
                    Console.WriteLine("You have chosen to play a 7 game series!");
                    break;
            }


        }

    }
}
