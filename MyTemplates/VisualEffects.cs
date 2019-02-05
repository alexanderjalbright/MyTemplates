using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyTemplates
{
    class VisualEffects
    {
        static void ImageScrollUp()
        {
            List<string> imageLines = new List<string>();

            // Repeat to display specific image
            imageLines.Add("");
            
            Console.Clear();

            // Scrolling Title
            for (int frame = 0; frame < imageLines.Count * 2 + 1; frame++)
            {
                // Print blank spaces first
                for (int lineHead = frame; lineHead < imageLines.Count; lineHead++)
                {
                    Console.WriteLine("");
                }

                // print lines of image
                
                if (frame < imageLines.Count)
                {
                    // Make image come up to center from below
                    for (int lineBody = 0; lineBody < frame; lineBody++)
                    {
                        Console.WriteLine(imageLines[lineBody]);
                    }
                }
                else
                {
                    //make image leave from center going up
                    for (int lineBody = frame - imageLines.Count; lineBody < imageLines.Count; lineBody++)
                    {
                        Console.WriteLine(imageLines[lineBody]);
                    }
                }

                for (int lineFoot = imageLines.Count; lineFoot < frame; lineFoot++)
                {
                    // only necessary if you want to reveal some text after the image
                    /*
                    if (lineFoot == imageLines.Count + ((imageLines.Count - (imageLines.Count % 2)) / 2))
                    {
                        Console.WriteLine("Created By Team MVP: Alex Albright, Sabrina Andrews, and Mary McGeary");
                    }
                    else
                    {
                    */
                        Console.WriteLine("");
                    //}
                }

                if (frame == imageLines.Count)
                {
                    Thread.Sleep(2000);
                }
                else if (frame == imageLines.Count * 2)
                {
                    Thread.Sleep(2000);
                }
                else
                {
                    Thread.Sleep(100);
                }

                Console.Clear();
            }       
        }

        static void FadeAwayText(string text)
        {
            //string text = "";
            Random randomNum = new Random();

            for (int frame = text.Length; frame > 0; frame--)
            {
                //Optional, for placing the line in the center of the screen
                /* 
                for (int lineHead = 0; lineHead < Console.WindowHeight(); lineHead++)
                {
                    Console.WriteLine("");
                }
                */


                int maxLimit = text.Length - 1;
                int minLimit = frame - 1;
                int letter = randomNum.Next(0, maxLimit);

                text = text.Replace(text[letter], ' ');
                text = text.Replace(text[minLimit], ' ');
                Console.WriteLine(text);

                if (frame != 1)
                {
                    Thread.Sleep(10);
                }
                else
                {
                    Thread.Sleep(500);
                }

                Console.Clear();
            }
        }
    }
}
