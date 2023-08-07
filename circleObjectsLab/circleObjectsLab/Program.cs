//circle objects lab

using circleObjectsLab;

bool again = true;
while (again)
{
    Console.WriteLine("Welcome to the Circle Tester");
    double userInput = 0;
    while (true)
    {
        //prompt user to enter a radius, may contain decimals(use a double)
        Console.Write("Enter Radius: ");
        string userInputRaw = Console.ReadLine();
        Console.WriteLine(" ");

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
    Circle circle = new Circle(userInput);
    Console.WriteLine($"Diamter: {circle.CalculateDiameter()}");
    Console.WriteLine($"Circumfrence: {circle.CalculateCircumfrence()}");
    Console.WriteLine($"Area: {circle.CalculateArea()}");


    //asks user if circle should grow

    //if yes, call grow method and display diameter, circumfrence and area
    //grow method should adjust radius to double its value

    //if user says no, display "goodbye" and the radius of the circle
}