using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulator");
            SinglePlayerGame.SnakeandLadderSinglePlayer();
            Console.ReadLine();
        }
    }
}
