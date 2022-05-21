using System;

namespace Minesweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // grid set up

            int[] minesweeperGrid = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // mines in an array
            int[] mines = { 5 };
            //string correctAnswerIs = mines.ToString();

           
            bool isCorrectGuess = false;

            Console.WriteLine("---NUMBER GUESSING GAME---");

            while (!isCorrectGuess) // while the player has not GUESSED the corrrect number, do:
            {
                Console.WriteLine("Guess a number between 1 and 10");
                string userGuess; // store player's guess in variable
                userGuess = Console.ReadLine(); // player to WRITE their guess in the console
                int userGuessNumber = Int32.Parse(userGuess); // player's guess is converted into a number

                if (!mines.Contains(userGuessNumber)) // if the player's guess is NOT in the mines array..
                {
                    Console.WriteLine("Keep guessing..."); // ask player to keep guessing
                }
                else // IF the player guesses the correct number, then..
                {
                    Console.WriteLine($"Your guess is CORRECT!");
                    isCorrectGuess = true;
                }
            }
            Console.WriteLine("\npress any key to exit the game :)");


        }
    }
}