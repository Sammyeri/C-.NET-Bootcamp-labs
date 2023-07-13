//Number Analyzer

//loop through prompt until user wants to stop
bool again = true;

do
{

    //prompt for user to input interger between 1 and 100 inclusive

    Console.WriteLine("Please input a number that is in the range 1 to 100");
    int userInput = int.Parse(Console.ReadLine());


    //display result based on integer input

    //if odd and less than 60 output "Odd and less than 60"
    if (userInput < 60 && userInput % 2 != 0)
    {
        Console.WriteLine("The number " + userInput + " is odd and less than 60");
    }
    //if even and in range of 2 - 24 print "Even and less than 25"
    else if (userInput > 1 && userInput < 25 && userInput % 2 == 0)
    {
        Console.WriteLine("The number " + userInput + " is even and less than 25");
    }
    //if even and in range of 26 - 60 print Even and between 26 and 60 inclusive
    else if (userInput > 25 && userInput < 61 && userInput % 2 == 0)
    {
        Console.WriteLine("The number " + userInput + " is even and betweeen 26 and 60 inclusive");
    }
    //if even and greater than 60, print Even and Greater than 60
    else if (userInput > 60 && userInput % 2 == 0)
    {
        Console.WriteLine("The number " + userInput + " is even and greater than 60");
    }
    //if odd and greater than 60, print Odd and greater than 60
    else
    {
        Console.WriteLine("The number " + userInput + " is odd and greater than 60");
    }

    //Ask if user wants to play again
    Console.WriteLine("If you would like to enter another number please type, yes. To stop please type stop.");
    string stop = Console.ReadLine();
    if(stop == "stop")
    {
        again = false;
    }

} while (again == true);