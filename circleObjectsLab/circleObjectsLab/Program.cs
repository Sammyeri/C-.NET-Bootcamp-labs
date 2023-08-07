//circle objects lab

using circleObjectsLab;

Console.WriteLine("Welcome to the Circle Tester");

bool again = true;

while (again)
{
    double userInput = 0;
    while (true)
    {
        //prompt user to enter a radius, may contain decimals(use a double)
        Console.Write("Enter Radius: ");
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


        Circle circle = new Circle(userInput);

        //when valid data entered, create instance of circle, then uses methods to display diameter, circumfrence and area
        Console.WriteLine($"Diamter: {circle.CalculateDiameter()}");
        Console.WriteLine($"Circumfrence: {circle.CalculateCircumfrence()}");
        Console.WriteLine($"Area: {circle.CalculateArea()}");

    //asks user if circle should grow
    while (true)
    {
        
        
        Console.WriteLine("Should the cirlce grow? (y/n)");
        ConsoleKeyInfo choice = Console.ReadKey();
        Console.WriteLine(" ");

        //if yes, call grow method and display diameter, circumfrence and area
        //grow method should adjust radius to double its value
        if(Char.ToLower(choice.KeyChar) == 'y')
        {
            circle.Grow();
            Console.WriteLine("The circle is magically growing.");

            Console.WriteLine(" ");

            Console.WriteLine($"Diamter: {circle.CalculateDiameter()}");
            Console.WriteLine($"Circumfrence: {circle.CalculateCircumfrence()}");
            Console.WriteLine($"Area: {circle.CalculateArea()}");

            continue;
        }
        //if user says no, display "goodbye" and the radius of the circle
        else if (Char.ToLower(choice.KeyChar) == 'n')
        {
            again = false;
            Console.WriteLine($"Goodbye. The circle's final radius is {circle.GetRadius()}");
            break;
        }
        else
        {
            Console.WriteLine($"Sorry, {choice.KeyChar} is not a valid choice");
        }
    }
}