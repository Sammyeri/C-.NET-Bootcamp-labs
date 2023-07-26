
//Student database lab

//create name array, filled with students names

string[] studentNames = new string[5] { "Jim", "Luna", "Jenny", "Carl", "Kat" };

//create hometown array, filled with students hometown at same index as the students name

string[] studentHometowns = new string[5] { "Austin, Texas", "Paris, France", "Lansing, Michigan", "Tokyo, Japan", "St. Paul, Minnesota" };

//create favorite food array, filled with student favorite foods

string[] studentFavoriteFoods = new string[5] { "Steak", "Gelato", "Pizza", "Roast Duck", "Chicken and Rice" };

Console.WriteLine("Welcome!");

//prompt user to asl about a particular student by number
while (true)
{


    Console.WriteLine($"Which student would you like to learn more about? Enter a number 1-{studentNames.Length}");
    string userChoiceRaw = Console.ReadLine();

    //convert user input to integer
    int userChoice = 0;
    bool succeded = int.TryParse(userChoiceRaw, out userChoice);

    //find and print student's name

    if (succeded && userChoice > 0 && userChoice <= studentNames.Length)
    {
        Console.WriteLine($"Student {userChoice} is {studentNames[userChoice - 1]}.");
        break;
    }
    else if (succeded)
    {
        Console.WriteLine($"Sorry, {userChoice} is not in the range provided.");
        continue;
    }
    else
    {
        Console.WriteLine($"Sorry, {userChoiceRaw} is not a valid number");
        continue;
    }
}
//ask user which category to display, hometown or favorite food

//display relevant info

//ask if user would like to learn about another student