using System;
using System.Collections.Generic;
using System.Text;

namespace MyTemplates
{
    class Tools
    {
        public string ReplaceUserStringWithActualOption(string whichKind, List<string> list)
        {
            // since I am a terrible speller this helps find a close match of variety
            int matchPoint = 0;

            for (int i = 1; i <= list.Count; i++)
            {
                string temp = whichKind.Remove(i).ToLower();
                int matches = 0;
                for (int j = 0; j < list.Count; j++)
                {
                    if (temp.Equals(list[j].Remove(i).ToLower()))
                    {
                        matches++;
                    }
                }

                if (matches == 1)
                {
                    matchPoint = i;
                    foreach (string item in list)
                    {
                        if (whichKind.Remove(matchPoint).ToLower().Equals(item.Remove(matchPoint).ToLower()))
                        {
                            whichKind = item;
                        }
                    }
                    break;
                }
            }
            return whichKind;
        }

        public int NumberCheck()
        {
            bool error;
            int definitelyNumber;
            do
            {
                error = false;
                string checkIsNumber = Console.ReadLine();
                if (!int.TryParse(checkIsNumber, out definitelyNumber))
                {
                    Console.WriteLine("You must enter a number.");
                    Console.WriteLine("Try again.");
                    error = true;
                }
            } while (error);

            return definitelyNumber;
        }

        public void SaveToFile(string text)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Alex\Desktop\test.txt"))
            {
                file.WriteLine(text);
            }
        }

        public string LoadFromFile()
        {
            using (System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Alex\Desktop\test.txt"))
            {
                string text = file.ReadLine();

                return text;
            }
        }
    }
}
