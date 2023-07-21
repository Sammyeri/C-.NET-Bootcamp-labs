
//Pig latin lab

bool valid = false;
while (!valid)
{
    //prompt user for a word
    Console.WriteLine("Please enter a word you would like translated.");
    string word = Console.ReadLine();

    if (word != "")
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] != ' ')
            {
                valid = true;
            }
        }
        if (!valid)
        {
            Console.WriteLine($"Sorry, {word} is not a valid word");
        }
    }
    else
    {
        Console.WriteLine($"Sorry, {word} is not a valid word");
    }
}


//translates text to pig latin

//displays result

//ask if want to translate another word