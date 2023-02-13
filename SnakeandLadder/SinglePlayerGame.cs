using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    class SinglePlayerGame
    {
        public static void SnakeandLadderSinglePlayer()
        {
            int Position = 0;
            Console.WriteLine("Player Position: " + Position);
            Random random= new Random();
            int die = random.Next(1,7);
            Console.WriteLine("Random Number: " + die);

            Random random1= new Random();
            int Option = random1.Next(1,4);
            
            switch(Option)
            {
                case 1:
                    Console.WriteLine("No Play");
                    Position += 0;
                    Console.WriteLine("After getting NoPlay Player Position: " + Position);
                    break;
                case 2:
                    Console.WriteLine("Ladder");
                    Position += die;
                    Console.WriteLine("After getting ladder player Position: " + Position);
                    break;
                case 3:
                    Console.WriteLine("Snake");
                    Position -= die;
                    Console.WriteLine("After getting snake Player Position: " + Position);
                    break;
            }
        }
    }
}
