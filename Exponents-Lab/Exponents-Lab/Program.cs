
//Exponents lab

bool valid = false;

while (!valid)
{
    //prompts user to enter an integer
    Console.WriteLine("Enter a positive integer: ");
    string userInputRaw = Console.ReadLine();

    int userInput;
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


//prompts user to continue