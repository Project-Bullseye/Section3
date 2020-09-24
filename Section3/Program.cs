using System;
using System.IO;

namespace Section3
{
    class Program
    {
        static public string documentPath = "myData.txt";
        static void Main(string[] args)
        {


            bool playAgain = true;
            while (playAgain)
            {




                //This might be where the rest of the code is


                using (StreamReader sr = File.OpenText(documentPath))
                {
                    StreamWriter sw = new StreamWriter(documentPath);
                    sw.WriteLine(score);
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
