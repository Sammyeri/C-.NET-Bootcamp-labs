﻿
//Exponents lab

bool valid = false;
int userInput = 0;

while (!valid)
{
    //prompts user to enter an integer
    Console.WriteLine("Enter a positive integer: ");
    string userInputRaw = Console.ReadLine();

    //only accepts positive, whole numbers as input, and maiximum number input is the largest that can still fit in int when cubed
    bool succeded = int.TryParse(userInputRaw, out userInput);
    if (succeded)
    {
        if(userInput > 1290)
        {
            Console.WriteLine($"Sorry {userInput} is too large to square and cube.");
        }
        else if(userInput > 0)
        {
            valid = true;
        }
        else
        {
            Console.WriteLine($"Sorry, {userInput} is not a positive integer.");
        }
    }
    else
    {
        Console.WriteLine($"Sorry, {userInputRaw} is not a valid integer.");
    }
}

//displays table of squares and budes from 1 to value entered
for (int i = 1; i <= userInput; i++)
{
    int square = i * i;
    int cube = i * i * i;

    Console.WriteLine($"Number: {i}");
    Console.WriteLine($"Squared: {square}");
    Console.WriteLine($"Cubed: {cube}");
}

//prompts user to continue