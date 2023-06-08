using System;

int numberOfInvokes =0;
int theSecretNumber = Roll();
string difficultyLevel;
int maxGuesses = 0;

int Roll() {
    Random rand = new Random();
    return rand.Next(1, 100);
}

Main();

void Main() {
Console.WriteLine("Choose your difficulty level:");
Console.WriteLine("Enter 1: Easy");
Console.WriteLine("Enter 2: Medium");
Console.WriteLine("Enter 3: Difficult");
Console.WriteLine("Enter 4: Cheater");
// Console.WriteLine("Can you guess the secret number?");
difficultyLevel = Console.ReadLine();

switch (difficultyLevel)
{
    case "1":
        maxGuesses = 8;
        break;
    case "2":
        maxGuesses = 6;
        break;
    case "3":
        maxGuesses = 4;
        break;
    case "4":
        maxGuesses = int.MaxValue;
        break;
    default:
        Console.WriteLine("You didn't enter 1, 2, or 3");
        break;

}
}


      for (int i=0; i < (maxGuesses); i++) {
numberOfInvokes += 1;
    string answer = Console.ReadLine();
    int pasedInput = int.Parse(answer);

Random rand = new Random();

int SecretNumber = theSecretNumber;
if (pasedInput == SecretNumber) 
{
    Console.WriteLine("You Guessed it!");
    break;
} else
{
    Console.WriteLine($"That's not the secret number. your guess: ({numberOfInvokes}/{maxGuesses})");
    if (pasedInput > SecretNumber) {
        Console.WriteLine("too high");
    } else {
        Console.WriteLine("too low");
    }
}
Console.WriteLine(SecretNumber);

}

// void Medium() {
//       for (int i=0; i < 6; i++) {
// numberOfInvokes += 1;
//     string answer = Console.ReadLine();
//     int pasedInput = int.Parse(answer);

// Random rand = new Random();

// int SecretNumber = theSecretNumber;
// if (pasedInput == SecretNumber) 
// {
//     Console.WriteLine("You Guessed it!");
//     break;
// } else
// {
//     Console.WriteLine($"That's not the secret number. your guess: ({numberOfInvokes}/4)");
//     if (pasedInput > SecretNumber) {
//         Console.WriteLine("too high");
//     } else {
//         Console.WriteLine("too low");
//     }
// }
// Console.WriteLine(SecretNumber);

// }
// }

// string Difficulty() {
// Console.WriteLine("Choose Your difficulty: Hard, Medium");
// string answer = Console.ReadLine().ToLower();

// if (answer == "hard")
// {
//     return Hard();
// }
// }
