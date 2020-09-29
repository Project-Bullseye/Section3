using System;
using System.IO;

namespace Section3
{
    class Program
    {
        static public string documentPath = "myData.txt"; //need a more complete link for the myData.txt
        class Section3
        {
            static void Main(string[] args)
            {
                bool playAgain = true;
                while (playAgain)
                {
                    using (StreamReader sr = File.OpenText(documentPath))
                    {
                        StreamWriter sw = new StreamWriter(documentPath);
                        sw.WriteLine(score); // When other sections are being made, this score is for the myData.txt   AKA the key for keeping track of all score given.
                    }
                    Console.WriteLine("Do you want to go again?");
                    string loop = Console.ReadLine();
                    if (loop == "y")
                    {
                        playAgain = true;
                    }
                    else if (loop == "n")
                    {
                        playAgain = false;
                    }
                    else
                    {
                    }
                }
            }
        }
    }
}
