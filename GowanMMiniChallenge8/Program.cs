﻿//Maddie Gowan
//10-19-2022
//Mini Challenge #8 - Guess It
//This is a redo of a previous assignment

Console.Clear();

int easyLvl = 11;
int medLvl = 51;
int hardLvl = 101;
int winningNum = 0;
string option;
string userInput;
bool validNum = false;
int attempt = 0;
string userGuesses;
int userGuess = 0;


Console.WriteLine("This is a number guessing game!");
Console.Write("Would you like to play? Y or N: ");
string play = Console.ReadLine().ToUpper();


if (play != "Y" && play != "N")
{
    Console.WriteLine("Invalid response. Please try again.");
    Console.Write("Would you like to play? Y or N: ");
    play = Console.ReadLine().ToUpper();
}

while (play == "Y")
{
    Console.WriteLine("Which level would you like to play?");
    Console.WriteLine("Easy (1-10), Medium (1-50), or Hard (1-100)");
    option = Console.ReadLine().ToLower();

    while (option != "easy" && option != "medium" && option != "hard")
    {
        Console.WriteLine("Please enter a valid option");
        option = Console.ReadLine().ToLower();
    }

    Console.WriteLine("You chose " + option);

    Random rnd = new Random();

    if (option == "easy")
    {
        winningNum = rnd.Next(0, easyLvl);
    }
    if (option == "medium")
    {
        winningNum = rnd.Next(0, medLvl);
    }
    if (option == "hard")
    {
        winningNum = rnd.Next(0, hardLvl);
    }

    while (userGuess != winningNum)
    {
        Console.WriteLine("Take a guess!");
        userGuesses = Console.ReadLine();
        userGuess = Convert.ToInt32(userGuesses);

        if (userGuess > winningNum)
        {
            Console.WriteLine(userGuess + " is greater than the winning number.");
            attempt++;

        }
        if (userGuess < winningNum)
        {
            Console.WriteLine(userGuess + " is smaller than the winning number.");
            attempt++;

        }
    }
    if (userGuess == winningNum)
    {
        Console.WriteLine(userGuess + " was the winning number! Congratulations!");
        attempt++;
    }

    Console.WriteLine("It took you " + attempt + " guesses to reach the winning number.");

    Console.WriteLine("That was fun. Wanna play again? Y or N: ");
    play = Console.ReadLine().ToUpper();

}
if (play == "N")
{
    Console.WriteLine("Okay, goodbye.");
}
