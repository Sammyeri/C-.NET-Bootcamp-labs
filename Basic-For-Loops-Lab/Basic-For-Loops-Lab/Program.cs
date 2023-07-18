
//Basic For-loops Lab
bool continuing = true;
while (continuing)
{



    //prompt user to enter a number

    Console.WriteLine("Please input a whole number.");
    string userInput = Console.ReadLine();

    int userNumber = 0;
    bool passed = int.TryParse(userInput, out userNumber);

    int total = 0;

    //use for loop to calculate the sum of all the numbers from 1 to the chosen number
    if (passed)
    {
        if (userNumber > 0)
        {
            for (int i = 1; i <= userNumber; i++)
            {
                total += i;
            }
            Console.WriteLine(total);
        }
        else
        {
            for (int j = -1; j >= userNumber; j--)
            {
                total += j;
            }
            Console.WriteLine(total);
        }
    }
    else
    {
        Console.WriteLine($"Sorry {userInput} is not a valid whole number");

    }
    
    while(continuing)
    {
        Console.WriteLine("Would you like to continue(y/n)");
        ConsoleKeyInfo again = Console.ReadKey();
        Console.WriteLine(" ");

        if(again.KeyChar == 'y')
        {
            continuing = true;
            break;
        }
        else if(again.KeyChar == 'n')
        {
            continuing = false;
        }
        else
        {
            Console.WriteLine($"Sorry, {again.KeyChar} is not a valid option");
        }
    }
}