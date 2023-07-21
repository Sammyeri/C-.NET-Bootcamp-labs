
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

    string[] words = word.Split(" ");

    //translates text to pig latin
    foreach(string s in words)
    {
        if (s.ToLower()[0] == 'a' || s.ToLower()[0] == 'e' || s.ToLower()[0] == 'i' || s.ToLower()[0] == 'o' || s.ToLower()[0] == 'u')
        {
            Console.Write($"{s}way");
        }
        else
        {
            int count = 0;
            string temp = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    break;
                }
                else
                {
                    temp = temp + s[i];
                    count++;
                }
            }
            Console.Write(s.Substring(count) + temp + "ay");
        }
        Console.Write(" ");
    }
    Console.WriteLine(" ");

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