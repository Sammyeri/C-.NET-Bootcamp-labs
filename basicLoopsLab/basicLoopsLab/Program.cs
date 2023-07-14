
//Basic Loops lab

//part 1
//do-while loop to output Hello World,
bool isRunning = true;
do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue? (y/n)");
    ConsoleKeyInfo userInput = Console.ReadKey();
    Console.WriteLine("");

    if(userInput.KeyChar == 'y')
    {
        isRunning = true;
    }
    else if(userInput.KeyChar == 'n')
    {
        isRunning = false;
    }
    else
    {
        Console.WriteLine("Sorry, " + userInput.KeyChar + " is not a valid response, please try again");
        
    }
} while (isRunning);
//after each Hello World ask user if they would like to continue.


//part 2
isRunning = true;
while (isRunning)
{
    //prompt user for number,
    Console.Write("Enter a positive whole number: ");
    string userInputpt2 = Console.ReadLine();
    int userNumberpt2;

    bool isSuccessfulpt2 = int.TryParse(userInputpt2, out userNumberpt2);

    if (!isSuccessfulpt2 || userNumberpt2 < 0)
    {
        Console.WriteLine("Sorry " + userInputpt2 + " is not a valid positivce whole number number, please try again");
        continue;
    }

//for loop to output all from user number to 0,
    for(int i = 0; i <= userNumberpt2; i++)
    {
        Console.Write(userNumberpt2 - i + " ");
        
    }
    
    Console.WriteLine("");
    
    //for loop from 0 to user number
    for (int i = 0; i <= userNumberpt2; i++)
    {
        Console.Write(i + " ");

    }

    Console.WriteLine("");

    //ask if they would like to continue
    Console.WriteLine("Would you like to continue? (y/n)");
    ConsoleKeyInfo userInputchoicept2 = Console.ReadKey();
    Console.WriteLine("");

    if (userInputchoicept2.KeyChar == 'y')
    {
        isRunning = true;
    }
    else if (userInputchoicept2.KeyChar == 'n')
    {
        isRunning = false;
    }
    else
    {
        Console.WriteLine("Sorry, " + userInputchoicept2.KeyChar + " is not a valid response, please try again");

    }

}


//part 3 and 4
//while loop, continues until correct code or attempts run out
bool enterKey = true;
int chances = 5;

while(enterKey)
{
//ask user for key code
    Console.WriteLine("Please insert the key code, you have " + chances + " chances remaining.");
    string userInputpt3 = Console.ReadLine();
    int userNumberpt3;
    bool succeededpt3 = int.TryParse(userInputpt3, out userNumberpt3);
    
    if (chances == 0)
    {
    //if exceeded tries print warning message of too many attempts
        Console.WriteLine("Sorry, but you have exceeded the number of attempts available, Goodbye!");
        break;
    }

    if (!succeededpt3)
    {
        chances--;
        Console.WriteLine("Sorry, " + userInputpt3 + " is not the correct key format");
        continue;
    }
    
    //if correct print welcome message once correct key entered
    if(userNumberpt3 == 13579 && chances > 0)
    {
        Console.WriteLine("Welcome!");
        break;
    }
    //if wrong repeat
    else
    {
        Console.WriteLine("That is not the correct key");
        chances--;
    }




}



// part 5, do above but with do-while loop



