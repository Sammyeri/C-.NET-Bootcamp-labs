
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
//prompt user for number,

//for loop to output all from user number to 0,

//for loop from 0 to user number

//ask if they would like to continue


//part 3 and 4
//while loop, continues until correct code or attempts run out
//ask user for key code

//if correct print welcome message once correct key entered

//if wrong repeat

//if exceeded tries print warning message of too many attempts


// part 5, do above but with do-while loop



