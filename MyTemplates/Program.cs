﻿using System;
using System.Collections.Generic;

namespace MyTemplates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void MainMenu()
        {
            bool run = true;
            do
            {   
                Console.Clear();
                Console.WriteLine("Main Menu:");
                Console.WriteLine("Press 1 to ");
                Console.WriteLine("Press Q to Quit");


                ConsoleKeyInfo keyPressed = Console.ReadKey();

                switch (keyPressed.Key)
                {                
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        /*
                        if(something is not true)
                        {
                            Console.WriteLine("Incorrect entry.");
                            break;
                        }
                        else
                        {
                            // Whatever its supposed to do
                        }
                        */
                        break;
                    case ConsoleKey.Q:
                        run = false;
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        break;
                }
            } while (run);
        }

        static void ContinueIfNoError()
        {
            bool error = false;
            do
            {
                
            } while (error);
        }

        static bool TryAgain()
        {
            Console.WriteLine("\nPlease try again.");

            return true;
        }

        static void Pause()
        {
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        public int VisualMenu(List<string> menuItemsAlpha, string menuName)
        {
            int longestString = 0;

            for (int i = 0; i < menuItemsAlpha.Count; i++)
            {
                if (menuItemsAlpha[i].Length > longestString)
                {
                    longestString = menuItemsAlpha[i].Length;
                }
            }

            for (int i = 0; i < menuItemsAlpha.Count; i++)
            {
                menuItemsAlpha[i] = menuItemsAlpha[i].PadRight(longestString + 3);
                menuItemsAlpha[i] = menuItemsAlpha[i].PadLeft(menuItemsAlpha[i].Length + 3);
            }

            int highlight = 0;
            bool run = true;
            do
            {
                List<char[]> menuHolder = new List<char[]>();

                for (int i = 0; i < menuItemsAlpha.Count; i++)
                {
                    menuHolder.Add(" ".PadLeft(menuItemsAlpha[i].Length).ToCharArray());
                    menuHolder.Add(menuItemsAlpha[i].ToCharArray());
                }

                menuHolder.Add(" ".PadLeft(menuItemsAlpha[0].Length).ToCharArray());

                for (int j = highlight; j < highlight + 3; j++)
                {
                    for (int i = 1; i < menuHolder[0].Length - 1; i++)
                    {
                        if (j % 2 == 1)
                        {
                            menuHolder[j][1] = '*';
                            menuHolder[j][menuHolder[0].Length - 2] = '*';
                        }
                        else
                        {
                            menuHolder[j][i] = '*';
                        }
                    }
                }

                // Prints out menu
                Console.Clear();

                Console.WriteLine("");
                // Experimenting with chaining methods...sorry
                string titleBar = menuName.ToUpper().PadLeft(menuName.Length + 1).PadRight(Console.WindowWidth - "VIRTUAL PETS AMOK ".Length) + "VIRTUAL PETS AMOK ";
                Console.WriteLine(titleBar);


                string line = "".PadRight(Console.WindowWidth).Replace(" ", "_");
                Console.WriteLine(line);

                for (int i = 0; i < menuHolder.Count; i++)
                {
                    Console.WriteLine(menuHolder[i]);
                }

                Console.WriteLine(line);

                Console.WriteLine("Use UP and DOWN arrow keys to navigate, and ENTER to select.");

                ConsoleKeyInfo keyPressed = Console.ReadKey();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (highlight > 0)
                            highlight -= 2;
                        break;
                    case ConsoleKey.DownArrow:
                        if (highlight < menuHolder.Count - 3)
                            highlight += 2;
                        break;
                    case ConsoleKey.Enter:
                        run = false;
                        break;
                    default:
                        break;
                }
            } while (run);

            return (highlight / 2) + 1;
        }
    }
}
