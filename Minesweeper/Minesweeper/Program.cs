using System;

namespace Minesweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // test 2D arrays for the grid:
            int[,] minesweeperGrid = new int[10, 10]
            {
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
                {21, 22, 23, 24, 25, 26, 27, 28, 29, 30 },
                {31, 32, 33, 34, 35, 36, 37, 38, 39, 40 },
                {41, 42, 43, 44, 45, 46, 47, 48, 49, 50 },
                {51, 52, 53, 54, 55, 56, 57, 58, 59, 60 }, //row 5
                {61, 62, 63, 64, 65, 66, 67, 68, 69, 70 },
                {71, 72, 73, 74, 75, 76, 76, 78, 79, 80 },
                {81, 82, 83, 84, 85, 86, 87, 88, 89, 90 },
                {91, 92, 93, 94, 95, 96, 97, 98, 99, 100 },

            };

            //---FUNCTION: Generate random numbers so you will have your mines. The value of these mines needs to be 'marked' on the grid as mines.
            //Random generateRandomNum = new Random();
            //int randomNumberForMine = generateRandomNum.Next(0, 100);
            //Console.WriteLine(randomNumberForMine);

            // QUESTION/PROBLEM: How do you generate 10 random numbers that will NOT repeat? For example, do NOT generate number 7 and 7. Potentially use try/catch method?

            int randomNumberForMine = 15;

            //bool isMine;
            //foreach (int i in minesweeperGrid) 
            //{
            //    if (i == randomNumberForMine)
            //    {
            //        isMine = true;
            //        //Console.WriteLine("You hit a mine!!!!!!");
            //    }
            //    else
            //    {
            //        isMine = false;
            //        //Console.WriteLine("Not a mine");
            //    }

            //};




            // QUESTION/PROBLEM: How do you check a value of a 2D array?
            //Console.WriteLine(minesweeperGrid[5, 3]);

            //---FUNCTION: User enters coordinates
            //string[] userGuessCoordinates;
            //string userGuessColumn;
            //string userGuessRow;

            //Console.WriteLine("Add in your coordinates (row,column)");
            //userGuessCoordinates = Console.ReadLine().Split(',');
            //int userGuessRowNumber = Int32.Parse(userGuessCoordinates[0]);
            //int userGuessColumnNumber = Int32.Parse(userGuessCoordinates[1]);

            //--- FUNCTION: Coordinates entered by user is checked in the minesweeperGrid and the value is returned.
            //Console.WriteLine(minesweeperGrid[userGuessRowNumber, userGuessColumnNumber]);
            //int userGuess = (minesweeperGrid[userGuessRowNumber, userGuessColumnNumber]);

            // SCENARIO: if userGuess value is 15, and equals to the randomNumberforMine(15), then ...


            //if (userGuess == randomNumberForMine)
            //{
            //    Console.WriteLine("You hit a MINE! ~GAME OVER ~");
            //}
            //else
            //{
            //    Console.WriteLine("NOT a mine. Enter your next coordinates");
            //}


            // THIS IS WORKING!!!
            bool isMine = false;

                string[] userGuessCoordinates;
                string userGuessColumn;
                string userGuessRow;

            while (!isMine)
            {


                Console.WriteLine("Add in your coordinates (row,column)");
                userGuessCoordinates = Console.ReadLine().Split(',');
                int userGuessRowNumber = Int32.Parse(userGuessCoordinates[0]);
                int userGuessColumnNumber = Int32.Parse(userGuessCoordinates[1]);
                int userGuess = (minesweeperGrid[userGuessRowNumber, userGuessColumnNumber]);

                if (userGuess != randomNumberForMine)
                {
                    Console.WriteLine("SAFE");
                }
                else
                {
                    Console.WriteLine("You hit a MINE! GAME OVER!");
                    break;
                }

            }


        }
    }
}


            //if (userGuess == randomNumberForMine)
            //{
            //    Console.WriteLine("YOU HIT A MINE! GAME OVER!");
            //}
            //else
            //{
            //    Console.WriteLine("SAFE - you did NOT hit a mine. Continue guessing");
            //}


            //bool isCorrectGuess = false;

            //while (!isCorrectGuess == false) // while the player has not GUESSED the correct number, DO:
            //{

            //    // Issue: If the user guess is NOT correct, then continue guessing. How do we escape from this loop..
            //    if (userGuess == randomNumberForMine)
            //    {
            //        Console.WriteLine("YOU HIT A MINE! GAME OVER!");
            //        isCorrectGuess = true;

            //    }
            //    else
            //    {
            //        Console.WriteLine("SAFE - you did NOT hit a mine. Continue guessing");

            //    }

            //}






            //QUESTION/PROBLEM: How can you change the value in a 2D grid.



            //--- FUNCTION: Checking if the mine exists in the grid

            //bool isMine = false;

            //foreach (int i in minesweeperGrid) //for each index in the array...
            //{
            //    if (i == randomNumberForMine)
            //    {
            //        isMine = true;
            //        Console.WriteLine("You hit a mine!!!!!!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not a mine");
            //    }

            //};





            //string outputString = Convert.ToString(userGuessRowNumber);

            //Console.WriteLine($"Coordinates entered: {userGuessRowNumber},{userGuessColumnNumber}");


            //userGuessColumn = Console.ReadLine();
            //userGuessRow = Console.ReadLine();

            //int userGuessColumnNumber = Int32.Parse(userGuessColumn);
            //int userGuessRowNumber = Int32.Parse(userGuessRow);





            // QUESTION/PROBLEM: How do you check if a 2D array contains a value (randomNumberForMine)?


            // FUNCTION: Checking if the mine exists in the grid

            //bool isMine = false;

            //foreach (int i in minesweeperGrid) //for each index in the array...
            //{
            //    if (i == randomNumberForMine)
            //    {
            //        isMine = true;
            //        Console.WriteLine("You hit a mine!!!!!!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not a mine");
            //    }

            //};


            // set up user guess:

            //Console.WriteLine("Guess a number between 1 and 10");
            //string userGuess; // store player's guess in variable
            //userGuess = Console.ReadLine(); // player to WRITE their guess in the console
            //int userGuessNumber = Int32.Parse(userGuess); // player's guess is converted into a number




            // grid set up

            // int[] minesweeperGrid = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // mines in an array
            //int[] mines = { 5 };
            //string correctAnswerIs = mines.ToString();


            //bool isCorrectGuess = false;

            //Console.WriteLine("---NUMBER GUESSING GAME---");

            //while (!isCorrectGuess) // while the player has not GUESSED the corrrect number, do:
            //{
            //    Console.WriteLine("Guess a number between 1 and 10");
            //    string userGuess; // store player's guess in variable
            //    userGuess = Console.ReadLine(); // player to WRITE their guess in the console
            //    int userGuessNumber = Int32.Parse(userGuess); // player's guess is converted into a number

            //    if (!mines.Contains(userGuessNumber)) // if the player's guess is NOT in the mines array..
            //    {
            //        Console.WriteLine("Keep guessing..."); // ask player to keep guessing
            //    }
            //    else // IF the player guesses the correct number, then..
            //    {
            //        Console.WriteLine($"Your guess is CORRECT!");
            //        isCorrectGuess = true;
            //    }
            //}
            //Console.WriteLine("\npress any key to exit the game :)");

