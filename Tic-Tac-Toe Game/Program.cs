using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game
{
    
    class Program
    {
        public static string[,] numbers = new string[,]
           {
                {" "," "," "},
                {" "," "," "},
                {" "," "," "}
           };
        static void Main(string[] args)
        {

            Display();

            Player1();
            
            Player2();

            Player1();

            Player2();

            Player1();

            if (Player1Wins())
            {
                Console.WriteLine("\n\nPlayer 1 Won");
            }            
                        
            else
            {
                Player2();

                if (Player2Wins())
                {
                    Console.WriteLine("\n\nPlayer 2 Won");
                }

                else
                {
                    Player1();

                    if (Player1Wins())
                    {
                        Console.WriteLine("\n\nPlayer 1 Won");
                    }

                    else
                    {
                        Player2();

                        if (Player2Wins())
                        {
                            Console.WriteLine("\n\nPlayer 2 Won");
                        }

                        else
                        {
                            Player1();

                            if (Player1Wins())
                            {
                                Console.WriteLine("\n\nPlayer 1 Won");
                            }
                        }                        
                    }                   
                }                
            }

            if (Player1Wins().Equals(false) && Player2Wins().Equals(false))
            {
                Console.WriteLine("\n\nDraw");
            }                                                            

            Console.ReadLine();
        }
        public static void Display()
        {
                        
            Console.Write("     |     |     \n");
            Console.Write("  " + numbers[0, 0] + "  |");
            Console.Write("  " + numbers[0, 1] + "  |");
            Console.Write("  " + numbers[0, 2]);

            Console.Write("\n_____|_____|_____");
            Console.Write("\n     |     |     ");
            Console.WriteLine("");

            Console.Write("  " + numbers[1, 0] + "  |");
            Console.Write("  " + numbers[1, 1] + "  |");
            Console.Write("  " + numbers[1, 2]);

            Console.Write("\n_____|_____|_____");
            Console.Write("\n     |     |     ");
            Console.WriteLine("");


            Console.Write("  " + numbers[2, 0] + "  |");
            Console.Write("  " + numbers[2, 1] + "  |");
            Console.Write("  " + numbers[2, 2]);
            Console.Write("\n     |     |     ");
        }

        public static void Player1()
        {
            
            Console.Write("\n\nPlayer 1: Choose your field: ");
            string player1Field = Console.ReadLine();

            switch (player1Field)
            {
                case "1":
                    if (numbers[0, 0] == "O" || numbers[0, 0] == "X")
                    {
                        Console.Clear();
                        Display();
                        Console.WriteLine("\n\nField Taken! Choose another.");
                        Player1();
                    }
                    else
                    {
                        numbers[0, 0] = "O";
                        Console.Clear();
                        Display();
                    }                    
                    break;

                case "2":
                    if (numbers[0, 1] == "O" || numbers[0, 1] == "X")
                    {
                        Console.Clear();
                        Display();
                        Console.WriteLine("\n\nField Taken! Choose another.");
                        Player1();
                    }
                    else
                    {
                        numbers[0, 1] = "O";
                        Console.Clear();
                        Display();
                    }
                    break;

                case "3":
                    if (numbers[0, 2] == "O" || numbers[0, 2] == "X")
                    {
                        Console.Clear();
                        Display();
                        Console.WriteLine("\n\nField Taken! Choose another.");
                        Player1();
                    }
                    else
                    {
                        numbers[0, 2] = "O";
                        Console.Clear();
                        Display();
                    }
                    break;

                case "4":
                    if (numbers[1, 0] == "O" || numbers[1, 0] == "X")
                    {
                        Console.Clear();
                        Display();
                        Console.WriteLine("\n\nField Taken! Choose another.");
                        Player1();
                    }
                    else
                    {
                        numbers[1, 0] = "O";
                        Console.Clear();
                        Display();
                    }
                    break;

                case "5":
                    if (numbers[1, 1] == "O" || numbers[1, 1] == "X")
                    {
                        Console.Clear();
                        Display();
                        Console.WriteLine("\n\nField Taken! Choose another.");
                        Player1();
                    }
                    else
                    {
                        numbers[1, 1] = "O";
                        Console.Clear();
                        Display();
                    }
                    break;

                case "6":
                    if (numbers[1, 2] == "O" || numbers[1, 2] == "X")
                    {
                        Console.Clear();
                        Display();
                        Console.WriteLine("\n\nField Taken! Choose another.");
                        Player1();
                    }
                    else
                    {
                        numbers[1, 2] = "O";
                        Console.Clear();
                        Display();
                    }
                    break;

                case "7":
                    if (numbers[2, 0] == "O" || numbers[2, 0] == "X")
                    {
                        Console.Clear();
                        Display();
                        Console.WriteLine("\n\nField Taken! Choose another.");
                        Player1();
                    }
                    else
                    {
                        numbers[2, 0] = "O";
                        Console.Clear();
                        Display();
                    }
                    break;

                case "8":
                    if (numbers[2, 1] == "O" || numbers[2, 1] == "X")
                    {
                        Console.Clear();
                        Display();
                        Console.WriteLine("\n\nField Taken! Choose another.");
                        Player1();
                    }
                    else
                    {
                        numbers[2, 1] = "O";
                        Console.Clear();
                        Display();
                    }
                    break;

                case "9":
                    if (numbers[2, 2] == "O" || numbers[2, 2] == "X")
                    {
                        Console.Clear();
                        Display();
                        Console.WriteLine("\n\nField Taken! Choose another.");
                        Player1();
                    }
                    else
                    {
                        numbers[2, 2] = "O";
                        Console.Clear();
                        Display();
                    }
                    break;

                default:                                                           
                    Console.Clear();
                    Display();
                    Console.WriteLine("\n\nInput a digit between 1 and 9!");                    
                    Player1();
                    break;                    
            }
        }
        public static void Player2()
        {
           
            Console.Write("\n\nPlayer 2: Choose your field: ");
            string player1Field = Console.ReadLine();

            switch (player1Field)
            {
                case "1":
                    if (numbers[0, 0] == "O" || numbers[0, 0] == "X")
                    {
                        Console.Clear();
                        Display();
                        Console.WriteLine("\n\nField Taken! Choose another.");
                        Player2();
                    }
                    else
                    {
                        numbers[0, 0] = "X";
                        Console.Clear();
                        Display();
                    }
                    break;

                case "2":
                    if (numbers[0, 1] == "O" || numbers[0, 1] == "X")
                    {
                        Console.Clear();
                        Display();
                        Console.WriteLine("\n\nField Taken! Choose another.");
                        Player2();
                    }
                    else
                    {
                        numbers[0, 1] = "X";
                        Console.Clear();
                        Display();
                    }
                    break;

                case "3":
                    if (numbers[0, 2] == "O" || numbers[0, 2] == "X")
                    {
                        Console.Clear();
                        Display();
                        Console.WriteLine("\n\nField Taken! Choose another.");
                        Player2();
                    }
                    else
                    {
                        numbers[0, 2] = "X";
                        Console.Clear();
                        Display();
                    }
                    break;

                case "4":
                    if (numbers[1, 0] == "O" || numbers[1, 0] == "X")
                    {
                        Console.Clear();
                        Display();
                        Console.WriteLine("\n\nField Taken! Choose another.");
                        Player2();
                    }
                    else
                    {
                        numbers[1, 0] = "X";
                        Console.Clear();
                        Display();
                    }
                    break;

                case "5":
                    if (numbers[1, 1] == "O" || numbers[1, 1] == "X")
                    {
                        Console.Clear();
                        Display();
                        Console.WriteLine("\n\nField Taken! Choose another.");
                        Player2();
                    }
                    else
                    {
                        numbers[1, 1] = "X";
                        Console.Clear();
                        Display();
                    }
                    break;

                case "6":
                    if (numbers[1, 2] == "O" || numbers[1, 2] == "X")
                    {
                        Console.Clear();
                        Display();
                        Console.WriteLine("\n\nField Taken! Choose another.");
                        Player2();
                    }
                    else
                    {
                        numbers[1, 2] = "X";
                        Console.Clear();
                        Display();
                    }
                    break;

                case "7":
                    if (numbers[2, 0] == "O" || numbers[2, 0] == "X")
                    {
                        Console.Clear();
                        Display();
                        Console.WriteLine("\n\nField Taken! Choose another.");
                        Player2();
                    }
                    else
                    {
                        numbers[2, 0] = "X";
                        Console.Clear();
                        Display();
                    }
                    break;

                case "8":
                    if (numbers[2, 1] == "O" || numbers[2, 1] == "X")
                    {
                        Console.Clear();
                        Display();
                        Console.WriteLine("\n\nField Taken! Choose another.");
                        Player2();
                    }
                    else
                    {
                        numbers[2, 1] = "X";
                        Console.Clear();
                        Display();
                    }
                    break;

                case "9":
                    if (numbers[2, 2] == "O" || numbers[2, 2] == "X")
                    {
                        Console.Clear();
                        Display();
                        Console.WriteLine("\n\nField Taken! Choose another.");
                        Player2();
                    }
                    else
                    {
                        numbers[2, 2] = "X";
                        Console.Clear();
                        Display();
                    }
                    break;

                default:
                    Console.Clear();
                    Display();
                    Console.WriteLine("\n\nInput a digit between 1 and 9!");
                    Player2();
                    break;
            }
        }

        public static bool Player1Wins()
        {
            if (numbers[0,0] == "O" && numbers[0,1] == "O" && numbers[0,2] == "O")
            {
                return true;
            }
            if (numbers[1, 0] == "O" && numbers[1, 1] == "O" && numbers[1, 2] == "O")
            {
                return true;
            }
            if (numbers[2, 0] == "O" && numbers[2, 1] == "O" && numbers[2, 2] == "O")
            {
                return true;
            }
            if (numbers[0, 0] == "O" && numbers[1, 0] == "O" && numbers[2, 0] == "O")
            {
                return true;
            }
            if (numbers[0, 1] == "O" && numbers[1, 1] == "O" && numbers[2, 1] == "O")
            {
                return true;
            }
            if (numbers[0, 2] == "O" && numbers[1, 2] == "O" && numbers[2, 2] == "O")
            {
                return true;
            }
            if (numbers[0, 0] == "O" && numbers[1, 1] == "O" && numbers[2, 2] == "O")
            {
                return true;
            }
            if (numbers[0, 2] == "O" && numbers[1, 1] == "O" && numbers[2, 0] == "O")
            {
                return true;
            }

            return false;
        }

        public static bool Player2Wins()
        {
            if (numbers[0, 0] == "X" && numbers[0, 1] == "X" && numbers[0, 2] == "X")
            {
                return true;
            }
            if (numbers[1, 0] == "X" && numbers[1, 1] == "X" && numbers[1, 2] == "X")
            {
                return true;
            }
            if (numbers[2, 0] == "X" && numbers[2, 1] == "X" && numbers[2, 2] == "X")
            {
                return true;
            }
            if (numbers[0, 0] == "X" && numbers[1, 0] == "X" && numbers[2, 0] == "X")
            {
                return true;
            }
            if (numbers[0, 1] == "X" && numbers[1, 1] == "X" && numbers[2, 1] == "X")
            {
                return true;
            }
            if (numbers[0, 2] == "X" && numbers[1, 2] == "X" && numbers[2, 2] == "X")
            {
                return true;
            }
            if (numbers[0, 0] == "X" && numbers[1, 1] == "X" && numbers[2, 2] == "X")
            {
                return true;
            }
            if (numbers[0, 2] == "X" && numbers[1, 1] == "X" && numbers[2, 0] == "X")
            {
                return true;
            }

            return false;
        }
    }
}
