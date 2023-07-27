
//Student database lab

bool again = true;
Console.WriteLine("Welcome!");

while (again)
{


    //create name array, filled with students names

    string[] studentNames = new string[5] { "Jim", "Luna", "Jenny", "Carl", "Kat" };

    //create hometown array, filled with students hometown at same index as the students name

    string[] studentHometowns = new string[5] { "Austin, Texas", "Paris, France", "Lansing, Michigan", "Tokyo, Japan", "St. Paul, Minnesota" };

    //create favorite food array, filled with student favorite foods

    string[] studentFavoriteFoods = new string[5] { "Steak", "Gelato", "Pizza", "Roast Duck", "Chicken and Rice" };


    int userInput = 0;
    while (true)
    {
        Console.WriteLine("Would you like to look up a student (1) or see a list of students (2)?");
        string userInputRaw = Console.ReadLine();

        bool succeded = int.TryParse(userInputRaw, out userInput);

        if (succeded && userInput == 1)
        {
            break;
        }
        else if(succeded && userInput == 2)
        {
            foreach(string student in studentNames)
            {
                Console.WriteLine(student);
            }
            continue;
        }
        else
        {
            Console.WriteLine("Sorry, that is not a valid choice");
            continue;
        }
    }

    int userChoice = 0;
    //prompt user to asl about a particular student by number
    while (true)
    {


        Console.WriteLine($"Which student would you like to learn more about? Enter a number 1-{studentNames.Length}, or the student's name?");
        string userChoiceRaw = Console.ReadLine();

        //convert user input to integer
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
            if (studentNames.Contains(userChoiceRaw.Trim()))
            {
                Console.WriteLine($"The student {userChoiceRaw} is in the list!");
                foreach (string student in studentNames)
                {
                    if(student.ToLower() == userChoiceRaw.Trim().ToLower())
                    {
                        userChoice++;
                        break;
                    }
                    else
                    {
                        userChoice++;
                    }
                }

                break;
            }
            else
            {
                Console.WriteLine($"The student {userChoiceRaw} is not on the list.");
                continue;
            }
        }
    }
    //ask user which category to display, hometown or favorite food
    while (true)
    {
        Console.WriteLine("what would you like to know? Enter 'Hometwon' or Favorite food'");
        string chosenInfo = Console.ReadLine();

        //display relevant info
        if (chosenInfo.ToLower().Trim() == "hometown" || chosenInfo.ToLower().Trim() == "home" || chosenInfo.ToLower().Trim() == "town")
        {
            Console.WriteLine($"{studentNames[userChoice - 1]} is from {studentHometowns[userChoice - 1]}");
            break;
        }
        else if(chosenInfo.ToLower().Trim() == "favorite food" || chosenInfo.ToLower().Trim() == "favorite" || chosenInfo.ToLower().Trim() == "food")
        {
            Console.WriteLine($"{studentNames[userChoice - 1]}'s favorite food is {studentFavoriteFoods[userChoice - 1]}.");
            break;
        }
        else
        {
            Console.WriteLine("That category does not exist please try again.");
            continue;
        }
    }


    //ask if user would like to learn about another student
    while (true)
    {
        Console.WriteLine("Would you like to learn about anther student? (y/n)");
        ConsoleKeyInfo choice = Console.ReadKey();
        Console.WriteLine(" ");

        if(choice.KeyChar == 'y')
        {
            break;
        }
        else if (choice.KeyChar == 'n')
        {
            again = false;
            break;
        }
        else
        {
            Console.WriteLine($"Sorry, {choice.KeyChar} is not a valid option.");
            continue;
        }
    }
}