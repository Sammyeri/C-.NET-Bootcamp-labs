
//Pig latin lab


bool again = false;

while (!again)
{

    string word = "";
    bool valid = false;

    while (!valid)
    {
        //prompt user for a word
        Console.WriteLine("Please enter a word you would like translated.");
        word = Console.ReadLine();

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
    word = word.Trim();

    //translates text to pig latin

    if (word.ToLower()[0] == 'a' || word.ToLower()[0] == 'e' || word.ToLower()[0] == 'i' || word.ToLower()[0] == 'o' || word.ToLower()[0] == 'u')
    {
        Console.WriteLine($"{word}way");
    }
    else
    {
        int count = 0;
        string temp = "";
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
            {
                break;
            }
            else
            {
                temp = temp + word[i];
                count++;
            }
        }
        Console.WriteLine(word.Substring(count) + temp + "ay");
    }

    //displays result

    //ask if want to translate another word
    while (true)
    {
        Console.WriteLine("Translate another line? (y/n) ");
        ConsoleKeyInfo choice = Console.ReadKey();
        Console.WriteLine(" ");

        if(choice.KeyChar == 'y')
        {
            break;
        }
        else if (choice.KeyChar == 'n')
        {
            again = true;
            break;
        }
        else
        {
            Console.WriteLine($"Sorry, {choice.KeyChar} is not a valid choice. ");
        }
    }
}