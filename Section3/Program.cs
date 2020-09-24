using System;
using System.IO;

namespace Section3
{
    class Program
    {
        static public string documentPath = "myData.txt"; //need a more complete link for the myData.txt
        static void Main(string[] args)
        {


            bool playAgain = true;
            while (playAgain)
            {




                //This might be where the rest of the code is


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
