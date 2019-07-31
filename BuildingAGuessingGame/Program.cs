using System;

namespace BuildingAGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            string secretWord = "alchemy";
            string guess = ""; //no vlaue for user input 
            int guessCount = 0;
            int guessLimit = 5;
            bool outOfGuesses = false; //will tell whether or not user is ouut of guesses 


            while (guess != secretWord && !outOfGuesses)// guess is not equal to secret word and user is not out of guesses 
            {

                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine(); //storing guess in guess variable
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true; // out of guesses changes to true 
                }
              
            }
            if (outOfGuesses )
            {
                Console.Write("You Lose!");
            }
            else
            {
                Console.Write("You Win!");
            }
            

            Console.ReadLine();
        }
    }
}
