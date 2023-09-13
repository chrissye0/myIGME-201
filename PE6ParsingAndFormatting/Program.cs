using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6ParsingAndFormatting
{
    // Author: Christine Espeleta
    // Purpose: Create a simple number game.
    // A random number between 0 to 100 inclusive is generated, and the user must guess it in 8 turns.
    // Restrictions: N/A
    internal class Program
    {
        // Purpose: Create a simple number game.
        // A random number between 0 to 100 inclusive is generated, and the user must guess it in 8 turns.
        // Restrictions: N/A
        static void Main(string[] args)
        {
            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);
            Console.WriteLine(randomNumber);

            // boolean to check if user made a correct guess and to indicate when to exit loop
            bool guessedRight = false;

            // initializing string variable and int variable to contain user's input
            string sInput = null;
            int nInput = 0;

            // initializing variable to track how many guesses the user has made
            // and incrementing it every time the user makes a guess
            int tries = 0;

            // repeat as long as the user hasn't guessed right and hasn't used all 8 tries
            while (!guessedRight && tries < 8)
            {
                Console.Write("Turn #" + (tries + 1) + " - Guess a number from 0 - 100: ");
                sInput = Console.ReadLine();
                try
                {
                    // try to parse string user input as an integer
                    nInput = int.Parse(sInput);
                    // input is out of range if the number is < 0 or > 100
                    // does not count toward the user's guesses
                    if (nInput < 0 || nInput > 100)
                    {
                        Console.WriteLine("Your guess is out of range.");
                    }
                    // if the user guesses correctly, let the user know by printing the result to the console
                    else if (nInput == randomNumber)
                    {
                        // have it count as a guess
                        tries += 1;
                        // if they made it in one guess
                        if (tries == 1)
                        {
                            Console.WriteLine("You guessed right! You won in " + tries + " turn.");
                        }
                        // if it took more than one guess
                        else
                        {
                            Console.WriteLine("You guessed right! You won in " + tries + " turns.");
                        }
                        // change boolean value to indicate the user is right and exit the loop
                        guessedRight = true;
                    }
                    // user guesses low, add 1 to guess count
                    else if (nInput < randomNumber)
                    {
                        Console.WriteLine("Your guess is low.");
                        tries += 1;
                    }
                    // user guesses high, add 1 to guess count
                    else if (nInput > randomNumber)
                    {
                        Console.WriteLine("Your guess is high.");
                        tries += 1;
                    }
                    // if the user hasn't guessed right and uses all 8 tries
                    // tell the user they ran out of attempts and what the answer is
                    if (tries == 8 && !guessedRight)
                    {
                        Console.WriteLine("You ran out of attempts. The answer is " + randomNumber);
                    }
                }
                catch
                {
                    // do nothing, run it back
                }
            }
        }
    }
}