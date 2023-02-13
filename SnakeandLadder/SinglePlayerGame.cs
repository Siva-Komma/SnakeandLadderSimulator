using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    class SinglePlayerGame
    {
        public static void SnakeandLadderSinglePlayer()
        {
            int Position = 0,count=0,position1=0;
            String Player1 = "Siva", Player2 = "Jyothi";
            bool turn = true;
            Console.WriteLine("Player1: {0} and Position: {1} " ,Player1 ,Position);
            Console.WriteLine("Player2: {0} and Position: {1} ", Player2, position1);
            while (Position < 100 && position1<100)
            {
                Random random = new Random();
                int die = random.Next(1, 7);
                Console.WriteLine("Random Number: " + die);
                count++;

                Random random1 = new Random();
                int Option = random1.Next(1, 4);
                if (turn == true)
                {
                    if (Position < 100)
                    {
                        switch (Option)
                        {
                            case 1:
                                Console.WriteLine("No Play");
                                Position += 0;
                                turn = false;
                                Console.WriteLine("After getting NoPlay Player1 Position: " + Position);
                                break;
                            case 2:
                                Console.WriteLine("Ladder");
                                Position += die;
                                if (Position > 100)
                                {
                                    Position = Position - die;
                                    Console.WriteLine("After getting ladder player1 position more than 100th position: " + Position);
                                }
                                else
                                {
                                    Console.WriteLine("After getting ladder player1 Position: " + Position);
                                }
                                turn= true;
                                break;
                            case 3:
                                Console.WriteLine("Snake");
                                Position -= die;
                                if (Position <= 0)
                                {
                                    Position = 0;
                                    Console.WriteLine("After getting snake and Position less than zero then Player1 Position: " + Position);
                                }
                                else
                                {
                                    Console.WriteLine("After getting snake Player1 Position: " + Position);
                                }
                                turn = false;
                                break;
                        }
                    }
                }
                else
                {
                    if(position1<100)
                    {
                        switch (Option)
                        {
                            case 1:
                                Console.WriteLine("No Play");
                                position1 += 0;
                                turn = true;
                                Console.WriteLine("After getting NoPlay Player2 Position: " + position1);
                                break;
                            case 2:
                                Console.WriteLine("Ladder");
                                position1 += die;
                                if (position1 > 100)
                                {
                                    position1 = position1 - die;
                                    Console.WriteLine("After getting ladder player2 position more than 100th position: " + position1);
                                }
                                else
                                {
                                    Console.WriteLine("After getting ladder player2 Position: " + position1);
                                }
                                turn = false;
                                break;
                            case 3:
                                Console.WriteLine("Snake");
                                position1 -= die;
                                if (position1 <= 0)
                                {
                                    position1 = 0;
                                    Console.WriteLine("After getting snake and Position less than zero then Player2 Position: " + position1);
                                }
                                else
                                {
                                    Console.WriteLine("After getting snake Player2 Position: " + position1);
                                }
                                turn = false;
                                break;
                        }
                    }

                }
            }
            Console.WriteLine("Player1 Position " + Position);
            Console.WriteLine("Player2 Position " + position1);
            if (Position > position1)
            {
                Console.WriteLine("Player1 {0} won the match", Player1);
            }
            else
            {
                Console.WriteLine("Player2 {0} won the match", Player2);
            }
            Console.WriteLine("\nNumber of time the die rolled is: " + count);
        }
    }
}
