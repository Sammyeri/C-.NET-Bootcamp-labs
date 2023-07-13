
//Room Calculator Lab

//prompts the user for length, width and height of the classroom
Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

Console.Write("Enter Length: ");
double length = double.Parse(Console.ReadLine());

Console.Write("Enter Width: ");
double width = double.Parse(Console.ReadLine());

Console.Write("Enter height: ");
double height = double.Parse(Console.ReadLine());

//displays the area, perimeter, volume, and surface area of that classroom

double area = length * width;
double perimeter = 2 * (length + width);
double volume = length * width * height;
double surfaceArea = 2 * area + 2 * (length * height) + 2 * (width * height);


Console.WriteLine("Area: " + area);
Console.WriteLine("Perimeter: " + perimeter);
Console.WriteLine("Volume: " + volume);
Console.WriteLine("Surface Area: " + surfaceArea);

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