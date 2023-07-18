
//Basic For-loops Lab

//prompt user to enter a number

Console.WriteLine("Please input a whole number.");
string userInput = Console.ReadLine();

int userNumber = 0;
bool passed = int.TryParse(userInput, out userNumber);

int total = 0;

if (passed)
{
    if(userNumber > 0)
    {
        for(int i = 0; i < userNumber; i++)
        {
            total += i;
        }
        Console.WriteLine(total);
    }
    else
    {
        for(int j = 0; j > userNumber; j--)
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
//use for loop to calculate the sum of all the numbers from 1 to the chosen number