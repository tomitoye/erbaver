using System;

namespace erbaverproject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Spliting the difficulty levels into their own methods made it easy for me to navigate and debug my program.  
            Console.Clear();
            
            string name = "";
            while(true)
            {

                if(name == "")
                {
                    Console.Write("Please enter your name... => ");
                    name = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            //kept my progams main menu in a loop so my program won't exit without it being instructed to.
            bool showMain = true;

            while(showMain)
            {
                showMain = MainMenu(name);
            }
            Console.WriteLine();
            Console.WriteLine("GoodBye!");
            Console.ReadKey();
        }

        private static bool MainMenu(string name)
        {
            //Collecting user input to decide the game's difficulty.
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Welcome to my guessing game, " +name+ "!");
            Console.WriteLine();
            Console.WriteLine(" Type and enter your difficulty level to begin.");
            Console.WriteLine("1) Easy \n2) Mid \n3) Hard \nType \"Quit\" to Exit out of this Application. ");
            Console.WriteLine();
            Console.Write("Answer => ");
            string level = Console.ReadLine();
            level = level.ToLower();

            if (level == "easy"|| level == "1")
            {
                Easy();
                return true;
            }

            else if(level == "mid"|| level == "2")
            {
                Mid();
                return true;
            }

            else if(level == "hard"|| level == "3")
            {
                Hard();
                return true;
            }

            else if(level == "quit")
            {
                return false;
            }
            else if(level == "")
            {
                Console.WriteLine("You didn't type anything...");
                Console.WriteLine();
                Console.Write("Press any key to try again... ");
                Console.ReadKey();
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, That's not a part of my program!?");
                Console.WriteLine();
                Console.Write("Press any key to go back... ");
                Console.ReadKey();
                return true;
            }

        }

        //Easy Mode section of the game.
        private static void Easy()
        {
            Console.Clear();
            Random easyRand = new Random();
            string correctGuess = Convert.ToString(easyRand.Next(1, 10)), guess = "";
            int totalGuess = 6, guessCount = 0, trial= 6;
            bool outOfGuess = false;
            Console.WriteLine("You picked Easy mode. \nThe rules are simple, you have just 6 trials to guess a number from 1 to 10. ");
            
            while (guess != correctGuess && !outOfGuess )
            {
                string sswitch = trial > 1 ? "trials": "trial";

                if(guessCount < totalGuess)
                {
                    Console.WriteLine();
                    Console.WriteLine("You have "+ trial +" "+ sswitch +" left");
                    Console.Write("Guess the number... => ");
                    guess = Console.ReadLine();
                    guessCount++;
                    trial--;
                }
                else
                {
                    outOfGuess = true;
                }
            }

            if(outOfGuess)
            {
                Console.WriteLine();
                Console.WriteLine("Oh, You Failed!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You Won! and it took you... " + guessCount + " guesses.");
            }
            Console.WriteLine();
            Console.Write("Press any key to go back to the main menu... ");
            Console.ReadKey();
        }

        //Intermediate Mode section of the game.
        private static void Mid()
        {
            Console.Clear();
            Random midRand = new Random();
            string correctGuess = Convert.ToString(midRand.Next(1, 10)), guess = "";
            int totalGuess = 4, guessCount = 0, trial= 4;
            bool outOfGuess = false;
            Console.WriteLine("You picked Intermediate Mode. \nThe rules kind of simple, you have just 4 trials to guess a number from 1 to 20. ");
            
            while (guess != correctGuess && !outOfGuess )
            {
                string sswitch = trial > 1 ? "trials": "trial";

                if(guessCount < totalGuess)
                {
                    Console.WriteLine();
                    Console.WriteLine("You have "+ trial +" "+ sswitch +" left");
                    Console.Write("Guess the number... => ");
                    guess = Console.ReadLine();
                    guessCount++;
                    trial--;
                }
                else
                {
                    outOfGuess = true;
                }
            }

            if(outOfGuess)
            {
                Console.WriteLine();
                Console.WriteLine("Ops, You Failed,try again later.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("wow! You Won! and it took you... " + guessCount + " guesses.");
            }
            Console.WriteLine();
            Console.Write("Press any key to go back to the main menu... ");
            Console.ReadKey();
        }

        //Hard Mode section of the game.
        private static void Hard()
        {
            Console.Clear();
            Random hardRand = new Random();
            string correctGuess = Convert.ToString(hardRand.Next(1, 10)), guess = "";
            int totalGuess = 3, guessCount = 0, trial= 3;
            bool outOfGuess = false;
            Console.WriteLine("You picked Hard Mode. \nThe rules are difficult, you have just 3 trials to guess a number from 1 to 50. ");
            
            while (guess != correctGuess && !outOfGuess )
            {
                string sswitch = trial > 1 ? "trials": "trial";

                if(guessCount < totalGuess)
                {
                    Console.WriteLine();
                    Console.WriteLine("You have "+ trial +" "+ sswitch +" left");
                    Console.Write("Guess the number... => ");
                    guess = Console.ReadLine();
                    guessCount++;
                    trial--;
                }
                else
                {
                    outOfGuess = true;
                }
            }

            if(outOfGuess)
            {
                Console.WriteLine();
                Console.WriteLine("Oh, You Failed.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You Won! and it took you... " + guessCount + " guesses.");
            }
            Console.WriteLine();
            Console.Write("Press any key to go back to the main menu... ");
            Console.ReadKey();
        }
    }
}
