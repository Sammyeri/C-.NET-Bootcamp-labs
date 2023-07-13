
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