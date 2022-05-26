using System;

namespace Minesweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ** DECLARING 2D ARRAY
            int[,] minesweeperGrid = new int[10, 10];

            // ** FUCTION **
            // Randomly generate 2 numbers to become coordinates (x & y) that HOLDS a mine
            Random rnd = new Random();

            int mineCount = 0;
            int totalMinesNeeded = 10;

            // while 0 < 10
            while (mineCount < totalMinesNeeded)
            {
                // random num x = 8
                int x = rnd.Next(0, 10);
                // random num y = 3
                int y = rnd.Next(0, 10);
                
                // if minesweeperGrid[8,3] is 0..
                // if the mine cell at [8,3] is equal to 0 (i.e. not mine)
                if (minesweeperGrid[x, y] == 0) // if it generates, 8,3 again, it will be falsey (entire block will be skipped)
                {
                    // Q: what does this line do? does it make [8,3] 1?
                    // then we're making it a mine, therefore assigning '1'
                    minesweeperGrid[x, y] = 1;

                    // increase mineCount
                    mineCount++;
                }
            }

            // ** FUNCTION **
            // Iterate over your 2D array (display)

            for (int i = 0; i < minesweeperGrid.GetLength(0); i++)
            {
                for (int j = 0; j < minesweeperGrid.GetLength(1); j++)
                {
                    Console.Write(minesweeperGrid[i, j] + " ");
                }
                Console.WriteLine();
            }

            // ** FUNCTION **
            // User input will be represented as 'coordinates' of the grid
            // If they uncover a '1', they hit a mine and game ends.

            string[] userGuessCoordinates;
            string userGuessRow;
            string userGuessColumn;
            bool isMine = false;

            while (!isMine)
            {
                Console.WriteLine("\nAdd in your coordinates in the format: ROW, COLUMN");
                userGuessCoordinates = Console.ReadLine().Split(',');
                int userGuessRowNumber = Int32.Parse(userGuessCoordinates[0]);
                int userGuessColumnNumber = Int32.Parse(userGuessCoordinates[1]);
                int userGuess = (minesweeperGrid[userGuessRowNumber, userGuessColumnNumber]);

                // storing result of the bool expression in a var:
                bool userGuessResult = userGuess == 1;

                if (userGuessResult)
                {
                    Console.WriteLine("~BOOM~ YOU HIT A MINE!\n\nGAME OVER");
                    break;
                }
                else
                {
                    int surroundingMinesCount = 0;
                    for (int i = -1; i < 2; i++)
                    {
                        for (int j = -1; j < 2; j++)
                        {
                            int x = userGuessRowNumber + i;
                            int y = userGuessColumnNumber + j;

                            #region newNotes
                            //if (minesweeperGrid[x,y] == 1)
                            //{
                            //    Console.WriteLine(surroundingMinesCount);
                            //        surroundingMinesCount++;
                            //} 
                            #endregion

                            if (x >= 0 && y >= 0 && x < 10 && y < 10 && minesweeperGrid[x,y] == 1)
                            {

                                surroundingMinesCount++;
                            }
                        }
                    }
                    Console.WriteLine(surroundingMinesCount);

                    #region noteForCount
                    // this is reseting the count
                    // not keeping the count in memory
                    //surroundingMinesCount = 0; 
                    #endregion
                }
            }

        }
    }
}
            // Determine how many mines are adjacent to the userGuess
            // userGuess input is a coordinate e.g. [5,4] (this is an int)
            // Problem to solve: How do you count adjacent mines?

            // ** FUNCTION **
                    // Why you would add the checks in here:
                    // Since it is a 'safe' cell, you want to 
                    // advise the user how many mines they are next to
                    // if there is a mine, count it and return to user
                    // if there are no mines, show count as 0

            //Console.WriteLine("Row 2, Column 3:", (minesweeperGrid[2, 3]));
            //Console.WriteLine(minesweeperGrid[1, 4]);
            //Console.WriteLine(minesweeperGrid[6, 5]);
            //Console.WriteLine(minesweeperGrid[7, 3]);

                    //// left (x-1, y)
                    //int xLeft = userGuessRowNumber - 1;
                    //int yLeft = userGuessColumnNumber;

                    ////Q. Why can't i console the VALUE of this grid coordinate?
                    //int xYLeftValue = (minesweeperGrid[xLeft, yLeft]);
                    //Console.WriteLine(xYLeftValue);


                    //// this will print out the array coordinates
                    //Console.WriteLine($"Coordinates to your left = {xLeft}, {yLeft}");
                    //Console.WriteLine("SAFE, guess another coordinate");

                    //// how do you check the array coordinate's values?
                    // myArray[i,j]

                    //value of xLeft and yLeft:
                    //Console.WriteLine("value of your left coordinate:", xYLeft);

                    //if (minesweeperGrid[xLeft, yLeft] == 1)
                    //{
                    //    minesNearYouCount++;
                    //    Console.WriteLine("You have {0} mine(s) next to you", minesNearYouCount);
                    //}

            //for (int i = 0; i < 10; i++)
            //{
            //    int x = rnd.Next(0, 10);
            //    int y = rnd.Next(0, 10);

            //    minesweeperGrid[x, y] = 1;

            //}

            //if (minesweeperGrid[x, y] == 1)

            //    while (!isMine)
            //    {
            //        Console.WriteLine("\nAdd in your coordinates in the format: ROW, COLUMN");
            //        userGuessCoordinates = Console.ReadLine().Split(',');
            //        int userGuessRowNumber = Int32.Parse(userGuessCoordinates[0]);
            //        int userGuessColumnNumber = Int32.Parse(userGuessCoordinates[1]);
            //        int userGuess = (minesweeperGrid[userGuessRowNumber, userGuessColumnNumber]);

            //        if (userGuess == 0)
            //        {
            //            Console.WriteLine("SAFE. Guess another coordinate");
            //        }
            //        else
            //        {
            //            Console.WriteLine("BOOM! You hit a mine! GAME OVER");
            //        }
            //    }

            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    int minePerRow = 0;

            //    // working on the values of each row
            //    for (int j = 0; j < 10; j++)
            //    {
            //        // why its limiting '1'
            //        if (mineCount < 10 && minePerRow < 1)
            //        {
            //            // we don't know YET if the value is 0 or 1
            //            //minesweeperGrid[i, j] = rnd.Next(2);

            //            // examining the value if it is 1. If it is 1, increase the count.
            //            if (minesweeperGrid[i, j] == 1)
            //            {
            //                mineCount++;
            //                minePerRow++;
            //            }
            //        }
            //        else
            //        {
            //            minesweeperGrid[i, j] = 0;
            //        }
            //        //looping on each column of each row
            //        Console.Write($"{minesweeperGrid[i, j]},");
            //    }
            //    //each row
            //    Console.WriteLine(String.Empty);
            //}





            // **TEST FUNCTION**
            //{
            //    Random r = new Random();
            //    int[,] newArray = new int[10, 10];
            //    for (int i = 0; i < 10; i++)
            //    {
            //        for (int j = 0; j < 10; j++)
            //        {
            //            newArray[i, j] = r.Next(2);
            //            Console.Write(newArray[i, j] + " ");
            //        }

            //        Console.WriteLine(String.Empty);
            //    }


            //while (!isMine)
            //{
            //    Console.WriteLine("Add in your coordinates (row,column)");
            //    userGuessCoordinates = Console.ReadLine().Split(',');
            //    int userGuessRowNumber = Int32.Parse(userGuessCoordinates[0]);
            //    int userGuessColumnNumber = Int32.Parse(userGuessCoordinates[1]);
            //    int userGuess = (minesweeperGrid[userGuessRowNumber, userGuessColumnNumber]);

            //    // change to == 0. You don't need randomNumberForMine anymore..
            //    if (userGuess != randomNumberForMine)
            //    {
            //        Console.WriteLine("SAFE");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You hit a MINE! GAME OVER!");
            //        break;
            //    }

            //}
            //---FUNCTION: Generate random numbers so you will have your mines. The value of these mines needs to be 'marked' on the grid as mines.
            //Random generateRandomNum = new Random();
            // THIS IS WORKING!!! TEST
            //bool isMine = false;

            //string[] userGuessCoordinates;
            //string userGuessColumn;
            //string userGuessRow;


            //int randomNumberForMine = generateRandomNum.Next(0, 100);
            //Console.WriteLine(randomNumberForMine);




            // test 2D arrays for the grid:
            //int[,] minesweeperGrid = new int[10, 10]
            //{
            //    {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            //    {11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
            //    {21, 22, 23, 24, 25, 26, 27, 28, 29, 30 },
            //    {31, 32, 33, 34, 35, 36, 37, 38, 39, 40 },
            //    {41, 42, 43, 44, 45, 46, 47, 48, 49, 50 },
            //    {51, 52, 53, 54, 55, 56, 57, 58, 59, 60 }, //row 5
            //    {61, 62, 63, 64, 65, 66, 67, 68, 69, 70 },
            //    {71, 72, 73, 74, 75, 76, 76, 78, 79, 80 },
            //    {81, 82, 83, 84, 85, 86, 87, 88, 89, 90 },
            //    {91, 92, 93, 94, 95, 96, 97, 98, 99, 100 },

            //};

            ////---FUNCTION: Randomly assign values 0 and 1 into the 2D array.
            //// 0 = not a mine
            //// 1 = mine
            // QUESTION/PROBLEM: How do you generate 10 random numbers that will NOT repeat? For example, do NOT generate number 7 and 7. Potentially use try/catch method?

            //int randomNumberForMine = 15;

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

            //** FUNCTION ** 
            // Generate values 1 and 0 on a 2D array
            // 1 = mines (10 generated)
            // 2 = not a mine

            //Random rnd = new Random();
            //int[,] minesweeperGrid = new int[10, 10];
            //int mineCount = 0;

            //// Problem to solve: How do you mark numbers greater than 9 as mines?

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        // limit mine count to be 10
            //        if (mineCount < 10 )
            //        {
            //            // generate numbers between 0 - 19
            //            minesweeperGrid[i, j] = rnd.Next(20);

            //            // condition to say: IF the number is greater than 9, mark this as a mine (i.e. 1)
            //            if (minesweeperGrid[i, j] > 9)
            //            {
            //                mineCount++;
            //                minesweeperGrid[i, j] = 500; // apply mine | Q. string or int..
            //            }
            //            else
            //            {
            //                minesweeperGrid[i, j] = 0;
            //            }

            //            //looping on each column of each row
            //            Console.Write($"{minesweeperGrid[i, j]},");
            //        }

            //        Console.WriteLine(String.Empty);
            //    }



            // ********** Code only generating 0 and 1:
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

