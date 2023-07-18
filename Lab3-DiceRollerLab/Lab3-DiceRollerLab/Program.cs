
//Dice Roller Lab

//ask user to enter dice size, make sure to only take positive whole numbers
using Lab3_DiceRollerLab;

bool passed = false;

int diceSize = 0;
while (!passed)
{
    Console.WriteLine("What size of dice would you like to roll today?");
    string userInputSize = Console.ReadLine();

    passed = int.TryParse(userInputSize, out diceSize);

    if (passed && diceSize > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine($"Sorry, {userInputSize} is not a vaild dice size. ");
        passed = false;
        continue;
    }
}
//prompt user to roll the dice
bool readyRoll = false;
while (!readyRoll) 
{
    Console.WriteLine("Roll the dice? (y/n)");
    ConsoleKeyInfo userReady = Console.ReadKey();
    Console.WriteLine(" ");

    if(userReady.KeyChar == 'y')
    {
        break;
    }
    else if(userReady.KeyChar == 'n')
    {
        continue;
    }
    else
    {
        Console.WriteLine($"Sorry, {userReady.KeyChar} is not a valid choice.");
    }
}
//roll 2 dice
int dice1 = Method.roll(diceSize);
int dice2 = Method.roll(diceSize);


//display results of each and total
int total = Method.total(dice1, dice2);

Console.WriteLine($"Dice 1: {dice1}");
Console.WriteLine($"Dice 2: {dice2}");
Console.WriteLine($"Total: {total}");
//for 6 sided only put extra messages
if(diceSize == 6)
{
    Method.message(dice1, dice2);
}
//snake eyes, 2 ones

//ace duece: 1 and 2

//Box cars: 2 6s

//win: total of 7 or 11

//craps: total of 2, 3, 12

//asks if user wants to roll again