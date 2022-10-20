//Maddie Gowan
//10-19-2022
//Mini Challenge 8 - Redo
//In this project the user will pick a difficulty--easy, medium, or hard--and then 
//they will have to guess a number from that level's range. Their number of attempts/
//guesses will be counted, and revealed at the end when they find the correct answer.

//Review: Elizar Garcia, the game is great! Easy to understand and follow commads.
//Very well organized and easy to read. Very interactive for the user. The only thing
//I am seeing wrong with the coding is that its adding the total guess counts
//together after playing mulitple games. Other then that great job on the game!

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
