//Number Analyzer

//prompt for user to input interger between 1 and 100 inclusive

Console.WriteLine("Please input a number that is in the range 1 to 100");
int userInput = int.Parse(Console.ReadLine());


//display result based on integer input

//if odd and less than 60 output "Odd and less than 60"
if (userInput < 60 && userInput%2 != 0)
{
    Console.WriteLine("The number " + userInput + " is odd and less than 60");
}
//if even and in range of 2 - 24 print "Even and less than 25"
else if(userInput > 1 && userInput < 25 && userInput%2 == 0)
{
    Console.WriteLine("The number " + userInput + " is even and less than 25");
}
//if even and in range of 26 - 60 print Even and between 26 and 60 inclusive

//if even and greater than 60, print Even and Greater than 60

//if odd and greater than 60, print Odd and greater than 60