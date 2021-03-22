using System;


//namespace
namespace first_see_sharp
{
    //main class
    class Program
    {
        //entry point method
        static void Main(string[] args)
        {
            // set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Seth Mcfeeters";


            //change text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("App titile: {0}. App Version: {1}. App Author: {2}.", appName, appVersion, appAuthor);
            Console.ResetColor();

            //ask users name
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);

            //set correct number
            //int correctNumber = 7;

            while (true) {

            // create a new random object
            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            //init guess var
            int guess = 0;

            
            Console.WriteLine("Guess a number between one and ten.");
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You must enter a number");
                        Console.ResetColor();
                        continue;
                    }

                    //cast into guess
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        if (correctNumber > guess)
                        {
                            //if guess does not equal correct number change font color to red and give error message
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("sorry, the number is not {0}, it's higher. try again...", input);
                            Console.ResetColor();
                        }
                        else
                        {
                            //if guess does not equal correct number change font color to red and give error message
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("sorry, the number is not {0}, it's lower, try again...", input);
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        // else change font color to green and congratulate them for guessing the number.
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You guessed it! {0} was the number!", correctNumber);
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}
