using System;

namespace Section3
{
    class Program
    {
        static void Main(string[] args)
        {

            bool playAgain = true;

            while (playAgain)
            {







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
