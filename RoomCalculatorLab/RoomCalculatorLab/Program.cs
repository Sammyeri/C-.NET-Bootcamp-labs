
//Room Calculator Lab

//prompts the user for length and width of the classroom
Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

Console.Write("Enter Length: ");
double length = double.Parse(Console.ReadLine());

Console.Write("Enter Width: ");
double width = double.Parse(Console.ReadLine());

//displays the area and perimeter of that classroom

double area = length * width;
double perimeter = 2 * (length + width);

Console.WriteLine("Area: " + area);
Console.WriteLine("Perimeter: " + perimeter);

//classifies room as small(<=250 sqft), medium (250 - 650sqt), or large( >= 650sqft)

if(area <= 250)
{
    Console.WriteLine("This is a small-sized room.");
}
else if (area > 250 && area < 650)
{
    Console.WriteLine("This is a medium-sized room.");
}
else
{
    Console.WriteLine("This is a large-sized room.");
}

Console.WriteLine("Thank you for using the Room Detail Generator");