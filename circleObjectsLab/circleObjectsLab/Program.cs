//circle objects lab

bool again = true;
while (again)
{
    Console.WriteLine("Welcome to the Circle Tester");
    double userInput = 0;
    while (true)
    {
        //prompt user to enter a radius, may contain decimals(use a double)
        Console.WriteLine("Enter Radius: ");
        string userInputRaw = Console.ReadLine();

        bool succeded = double.TryParse(userInputRaw, out userInput);

        if (succeded)
        {
            break;
        }
        else
        {
            //displays an error if user inputs invalid data, and asks again
            Console.WriteLine($"Sorry, {userInputRaw} is not a valid radius");
            continue;
        }

    }
       
    //when valid data entered, create instance of circle, then uses methods to display diameter, circumfrence and area



    //asks user if circle should grow

    //if yes, call grow method and display diameter, circumfrence and area
    //grow method should adjust radius to double its value

    //if user says no, display "goodbye" and the radius of the circle
}