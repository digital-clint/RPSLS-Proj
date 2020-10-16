using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            game.RunGame();
            Human playerOne = new Human();
            AI playerTwo = new AI();
            Console.WriteLine($"Welcome to the game {playerOne.name} and {playerTwo.name}.");


            Console.ReadLine();
        }
    }
}
