// basic string processing lab


using System.Collections.Generic;

bool again = true;

while (again)
{
    //prompt user for a sentence

    Console.WriteLine("Enter a sentence: ");
    string userInput = Console.ReadLine();

    //split the sentence into individual words and display each on its own line

    string[] splitSentence = userInput.Split(" ");

    for (int i = 0; i < splitSentence.Length; i++)
    {
        Console.WriteLine(splitSentence[i]);
    }

    while (true)
    {

        Console.WriteLine("Would you like to continue (y/n)?");
        ConsoleKeyInfo choice = Console.ReadKey();
        Console.WriteLine(" ");

        if (choice.KeyChar == 'y')
        {
            break;
        }
        else if (choice.KeyChar == 'n')
        {
            Console.WriteLine("Goodbye!");
            again = false;
            break;
        }
        else
        {
            Console.WriteLine($"Sorry, {choice.KeyChar} is not a valid option");
        }
    }
}

List<string> sentenceBuilder = new List<string>();

bool againpt2 = true;

while (againpt2)
{
    //prompt user to enter a string
    Console.WriteLine("Enter some text: ");
    string userInput = Console.ReadLine();

    //store string in the list
    sentenceBuilder.Add(userInput);

    //display content of list with each element seperated by space
    Console.Write("You have entered: ");

    foreach (string word in sentenceBuilder)
    {
        Console.Write($"{word} ");
    }

    //ask if want to continue
    while (true)
    {
        Console.WriteLine(" ");
        Console.WriteLine("Would you like to continue (y/n)?");
        ConsoleKeyInfo choicept2 = Console.ReadKey();
        Console.WriteLine(" ");

        if (choicept2.KeyChar == 'y')
        {
            break;
        }
        else if (choicept2.KeyChar == 'n')
        {
            Console.WriteLine("Goodbye!");
            againpt2 = false;
            break;
        }
        else
        {
            Console.WriteLine($"Sorry, {choicept2.KeyChar} is not a valid option.");
        }
    }
}