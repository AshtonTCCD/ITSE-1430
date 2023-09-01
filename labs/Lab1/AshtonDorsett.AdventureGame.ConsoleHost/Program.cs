/*
 * Ashton Dorsett
 * ITSE 1430
 * Lab 1
 */

namespace Lab1
{
    public class Program
    {
        public static int posX = 0;
        public static int posY = 0;

        public static void Main(string[] args)
        {
            // Introduction message
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ITSE 1430 Adventure Game - Ashton Dorsett Fall 2023");
            Console.WriteLine("---------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You are deep in the woods, surrounded by trees and more trees.");
            Console.WriteLine("You do not remember walking this far out from your campsite.");
            Console.WriteLine("It is pitch black outside, likely past midnight.");
            Room1();
            Menu();

            while (true)
            {
                // Collect input from player
                Console.Write("> ");
                var input = Console.ReadLine();

                // Modify position based on input
                switch(input.ToLower())
                {
                    case "n":
                        if (posY == 0)
                        {
                            InvalidMove();
                            continue;
                        }
                        posY -= 1;
                        break;
                    case "w":
                        if (posX == 0)
                        {
                            InvalidMove();
                            continue;
                        }
                        posX -= 1;
                        break;
                    case "s":
                        if (posY == 2)
                        {
                            InvalidMove();
                            continue;
                        }
                        posY += 1;
                        break;
                    case "e":
                        if (posX == 2)
                        {
                            InvalidMove();
                            continue;
                        }
                        posX += 1;
                        break;
                    case "q":
                        // Ask player to quit
                        Console.Write("Really quit? (Y/N) ");
                        if (Console.ReadLine().ToLower() == "y") Environment.Exit(0);
                        Console.WriteLine("Not exiting.");
                        continue;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You have entered an invalid choice. Try again.");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("---------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;

                // Send player to the proper room
                if (posX == 0)
                {
                    if (posY == 0) Room1();
                    else if (posY == 1) Room4();
                    else if (posY == 2) Room7();
                }
                else if (posX == 1)
                {
                    if (posY == 0) Room2();
                    else if (posY == 1) Room5();
                    else if (posY == 2) Room8();
                }
                else if (posX == 2)
                {
                    if (posY == 0) Room3();
                    else if (posY == 1) Room6();
                    else if (posY == 2) Room9();
                }
                else
                {
                    Console.WriteLine("You are somewhere impossible.");
                    Environment.Exit(-1);
                }
                Menu();
            }
        }
        
        public static void Menu()
        {
            // Calculate random chance event
            var percentage = Random.Shared.Next(1, 101);
            if (percentage <= 5)
            {
                Console.WriteLine("There is an eerie gust of wind. The sound of the wind blowing through the trees is terrifying.");
            }

            // Print current position
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"\nYour current position is ({posX}, {posY})");
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Print menu options
            Console.WriteLine("---------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("N) Move north");
            Console.WriteLine("S) Move south");
            Console.WriteLine("E) Move east");
            Console.WriteLine("W) Move west");
            Console.WriteLine("Q) Exit game");
            Console.WriteLine("---------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void InvalidMove()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("There seems to be nothing but trees that way.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Room1()
        {
            Console.WriteLine("There is nothing but trees in almost every direction.");
            Console.Write("You can see a ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("light source");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" to the east and a ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("large tower");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" sticking up from the trees to the south.\n");
        }

        public static void Room2()
        {
            Console.WriteLine("You find a lantern on the ground next to a closed tent. It does not belong to you.");
            Console.WriteLine("You can only assume that there is somebody currently sleeping in the tent.");
            Console.Write("You see a ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("strange formation");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" to the south and a ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("clearing");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" to the east.\n");
        }
        public static void Room3()
        {
            Console.WriteLine("You walk into a clearing of the trees. Seeing such an empty area in this dense forest is very off-putting.");
            Console.WriteLine("You spend a few minutes resting in the clearing because it feels like the right thing to do.");
            Console.Write("There is a ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("light source");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" to the west and the faint ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("sound of running water");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" to the south.\n");
        }
        public static void Room4()
        {
            // TODO: Finish room
        }
        public static void Room5()
        {
            // TODO: Finish room
        }
        public static void Room6()
        {
            // TODO: Finish room
        }
        public static void Room7()
        {
            // TODO: Finish room
        }
        public static void Room8()
        {
            // TODO: Finish room
        }
        public static void Room9()
        {
            // TODO: Finish room
        }
    }
}