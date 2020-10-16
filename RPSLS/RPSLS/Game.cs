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
        public bool gameOver;

        
        public void RunGame()
        {
            
            WelcomeMsg();
            numOfPlyers();
            ChooseTypeOfSeries();

            while (gameOver!= true)
            {
                CompareGestures();
                DisplayWinner();
            }

            PlayAgain();

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
        

        public void numOfPlyers()
        {
            string userInputText;
            int userNumOfPlayers;


            Console.WriteLine("How many user controlled players are there - 1 or 2?");
            userInputText = Console.ReadLine();
            bool isValidNum = int.TryParse(userInputText, out userNumOfPlayers);

            while ((isValidNum == false || userNumOfPlayers != 1) && (isValidNum == false || userNumOfPlayers != 2))
            {
                Console.WriteLine("You did not enter a valid number of players. PLEASE choose 1 or 2!");
                userInputText = Console.ReadLine();
                isValidNum = int.TryParse(userInputText, out userNumOfPlayers);
            }

            if (userNumOfPlayers == 1)
            {
                playerOne = new Human();
                playerTwo = new AI();
            }
            else
            {
                playerOne = new Human();
                playerTwo = new Human();
            }

            Console.WriteLine($"Welcome to the game {playerOne.name} and {playerTwo.name}.");
            Console.WriteLine("***********************************************************");
            Console.WriteLine();

        }

        public void ChooseTypeOfSeries()
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

            Console.WriteLine("***********************************************************");
            Console.WriteLine();

        }



        public void CompareGestures()
        {
            int playerOneNumChoice = 0;
            playerOneNumChoice = playerOne.ChooseGesture();
            int playerTwoNumChoice = 0;
            playerTwoNumChoice = playerTwo.ChooseGesture();

            Console.WriteLine("***********************************************************");
            Console.WriteLine();

            //Player Gesture Conditions in order of (WIN, LOSS, TIE) | 3 for every Gesture
            if (playerOneNumChoice == 0 && (playerTwoNumChoice == 2 || playerTwoNumChoice == 3))
            {
                playerOne.score++;
                Console.WriteLine($"{playerOne.name} wins this round!");
            }
            else if (playerOneNumChoice == 0 && (playerTwoNumChoice == 1 || playerTwoNumChoice == 4))
            {
                playerTwo.score++;
                Console.WriteLine($"{playerTwo.name} wins this round!");
            }
            else if (playerOneNumChoice == 0 && playerTwoNumChoice == 0)
            {
                Console.WriteLine($"Woah...it's a TIE! No points awarded this round!");
            }
            else if (playerOneNumChoice == 1 && (playerTwoNumChoice == 0 || playerTwoNumChoice == 4))
            {
                playerOne.score++;
                Console.WriteLine($"{playerOne.name} wins this round!");
            }
            else if (playerOneNumChoice == 1 && (playerTwoNumChoice == 2 || playerTwoNumChoice == 3))
            {
                playerTwo.score++;
                Console.WriteLine($"{playerTwo.name} wins this round!");
            }
            else if (playerOneNumChoice == 1 && playerTwoNumChoice == 1)
            {
                Console.WriteLine($"Woah...it's a TIE! No points awarded this round!");
            }
            else if (playerOneNumChoice == 2 && (playerTwoNumChoice == 1 || playerTwoNumChoice == 3))
            {
                playerOne.score++;
                Console.WriteLine($"{playerOne.name} wins this round!");
            }
            else if (playerOneNumChoice == 2 && (playerTwoNumChoice == 0 || playerTwoNumChoice == 4))
            {
                playerTwo.score++;
                Console.WriteLine($"{playerTwo.name} wins this round!");
            }
            else if (playerOneNumChoice == 2 && playerTwoNumChoice == 2)
            {
                Console.WriteLine($"Woah...it's a TIE! No points awarded this round!");
            }
            else if (playerOneNumChoice == 3 && (playerTwoNumChoice == 1 || playerTwoNumChoice == 4))
            {
                playerOne.score++;
                Console.WriteLine($"{playerOne.name} wins this round!");
            }
            else if (playerOneNumChoice == 3 && (playerTwoNumChoice == 0 || playerTwoNumChoice == 2))
            {
                playerTwo.score++;
                Console.WriteLine($"{playerTwo.name} wins this round!");
            }
            else if (playerOneNumChoice == 3 && playerTwoNumChoice == 3)
            {
                Console.WriteLine($"Woah...it's a TIE! No points awarded this round!");
            }
            else if (playerOneNumChoice == 4 && (playerTwoNumChoice == 0 || playerTwoNumChoice == 2))
            {
                playerOne.score++;
                Console.WriteLine($"{playerOne.name} wins this round!");
            }
            else if (playerOneNumChoice == 4 && (playerTwoNumChoice == 1 || playerTwoNumChoice == 3))
            {
                playerTwo.score++;
                Console.WriteLine($"{playerTwo.name} wins this round!");
            }
            else if (playerOneNumChoice == 4 && playerTwoNumChoice == 4)
            {
                Console.WriteLine($"Woah...it's a TIE! No points awarded this round!");
            }


        }

        public void DisplayWinner()
        {
            if (numOfGamesToPlay == 0 && playerOne.score == 2)
            {
                Console.WriteLine($"{playerOne.name} is the winner of this series!" );
                gameOver = true;
            }
            else if (numOfGamesToPlay == 0 && playerTwo.score == 2)
            {
                Console.WriteLine($"{playerTwo.name} is the winner of this series!");
                gameOver = true;
            }
            else if (numOfGamesToPlay == 1 && playerOne.score == 3)
            {
                Console.WriteLine($"{playerOne.name} is the winner of this series!");
                gameOver = true;
            }
            else if (numOfGamesToPlay == 1 && playerTwo.score == 3)
            {
                Console.WriteLine($"{playerTwo.name} is the winner of this series!");
                gameOver = true;
            }
            else if (numOfGamesToPlay == 2 && playerOne.score == 4)
            {
                Console.WriteLine($"{playerOne.name} is the winner of this series!");
                gameOver = true;
            }
            else if (numOfGamesToPlay == 2 && playerTwo.score == 4)
            {
                Console.WriteLine($"{playerTwo.name} is the winner of this series!");
                gameOver = true;
            }
            else
            {
                Console.WriteLine($"The series is currently {playerOne.name}: {playerOne.score} | {playerTwo.name}: {playerTwo.score}" );
            }

            Console.WriteLine();
            Console.WriteLine("***********************************************************");
            Console.WriteLine();
        }

        public void PlayAgain()
        {
            Console.WriteLine("Do you want to play again? Y or N");
            string playAgainText = Console.ReadLine();
            if (playAgainText.ToLower() == "y" || playAgainText.ToLower() == "yes")
            {
                gameOver = false;
                RunGame();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Hope you Enjoyed the Game!");
            }
        }

    }
}
