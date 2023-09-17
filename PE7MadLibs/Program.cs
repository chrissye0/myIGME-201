using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PE7MadLibs
{
    // Author: Christine Espeleta
    // Purpose: Create a Mad Libs game that asks for user input.
    // Restrictions: The program adds a space after every user input.
    // The program also doesn't check for blank user inputs.
    internal class Program
    {
        // Purpose: Create a Mad Libs game that asks for user input.
        // Restrictions: The program adds a space after every user input.
        // The program also doesn't check for blank user inputs.
        static void Main(string[] args)
        {
            // creating file reader
            StreamReader input = null;

            // initializing variables to read data from file
            // resultString is a string array
            string[] resultString = null;
            // creating string variables where each will represent a line from the file
            string line1 = null;
            string line2 = null;
            string line3 = null;
            string line4 = null;
            string line5 = null;
            string line6 = null;

            // check to see if user wants to play
            string gameState = null;
            bool playing = false;

            // check for story number
            int? storyNum = null;
            bool bValid = false;

            while (!playing)
            {
                try
                {
                    Console.Write("Do you want to play MadLibs? ");
                    gameState = Console.ReadLine();
                    // not case sensitive
                    gameState = gameState.ToLower();
                    // play game if user says yes
                    if (gameState == "yes")
                    {
                        playing = true;
                    }
                    // exit the game if the user says no
                    else if (gameState == "no")
                    {
                        Console.WriteLine("Goodbye.");
                        Environment.Exit(0);
                    }
                }
                catch
                {
                    // keep trying until the user says yes or no
                }
            }

            try
            {
                // read data from Mad Libs template
                input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");
                // read lines in order and set them to line variables
                line1 = input.ReadLine();
                line2 = input.ReadLine();
                line3 = input.ReadLine();
                line4 = input.ReadLine();
                line5 = input.ReadLine();
                line6 = input.ReadLine();
            }
            // reply with error message if program can't find file
            catch (Exception e)
            {
                Console.WriteLine("Error with file: " + e.Message);
            }
            // will always run
            finally
            {
                if (input != null)
                {
                    input.Close();
                }
            }

            // choose story depending on user input
            while (!bValid)
            {
                try
                {
                    // try to ask user for a story number from 1 to 6
                    Console.Write("Pick a story from 1 to 6. ");
                    storyNum = int.Parse(Console.ReadLine());
                    switch (storyNum)
                    {
                        // use story 1 if user inputs 1
                        case 1:
                            resultString = (line1.Split(' '));
                            bValid = true;
                            break;
                        // use story 2 if user inputs 2
                        case 2:
                            resultString = (line2.Split(' '));
                            bValid = true;
                            break;
                        // use story 3 if user inputs 3
                        case 3:
                            resultString = (line3.Split(' '));
                            bValid = true;
                            break;
                        // use story 4 if user inputs 4
                        case 4:
                            resultString = (line4.Split(' '));
                            bValid = true;
                            break;
                        // use story 5 if user inputs 5
                        case 5:
                            resultString = (line5.Split(' '));
                            bValid = true;
                            break;
                        // use story 6 if user inputs 6
                        case 6:
                            resultString = (line6.Split(' '));
                            bValid = true;
                            break;
                        default:
                            bValid = false;
                            break;
                    }
                }
                catch
                {
                    // keep trying until the user enters a valid input
                }
            }

            for (int i = 0; i < resultString.Length; i++)
            {
                // create new line if file reads \n
                if (resultString[i] == @"\n")
                {
                    resultString[i] = "\n";
                }
                else
                {
                    // check for times when user needs to make an input
                    if (resultString[i].Contains('{'))
                    {
                        // replace underscores with spaces
                        resultString[i] = resultString[i].Replace('_', ' ');
                        // get rid of { and }
                        resultString[i] = resultString[i].Replace('{'.ToString(), string.Empty);
                        resultString[i] = resultString[i].Replace('}'.ToString(), string.Empty);

                        // move commas over
                        if (resultString[i].Contains(','))
                        {
                            resultString[i] = resultString[i].Replace(','.ToString(), string.Empty);
                            if (resultString[i + 1] != @"\n")
                            {
                                resultString[i + 1] = ", " + resultString[i + 1];
                            }
                        }

                        // ask user for input and store input
                        Console.WriteLine(resultString[i]);
                        resultString[i] = Console.ReadLine();
                    }

                    // add space
                    resultString[i] = resultString[i] + " ";
                }

            }
            // print out everything to the console
            for (int i = 0; i < resultString.Length; i++)
            {
                Console.Write(resultString[i]);
            }
        }
    }
}