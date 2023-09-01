

Console.WriteLine("Please enther the wprd you would like to reverse: ");
string userInput = Console.ReadLine();

Console.WriteLine(Reverser(userInput.Trim()));

 static string Reverser (string input)
{
    if(input.Contains(" "))
    {
        string[] tempStrings = input.Split(' ');
        for(int i = 0; i < tempStrings.Length; i++) 
        {
            string reversed ="";
            char[] temp = new char[tempStrings[i].Length];
            for(int j = 0; j < temp.Length; j++)
            {
                temp[(temp.Length -1) - j] = tempStrings[i][j];
                 reversed = String.Join("", temp);
                
            }

                tempStrings[i] = reversed;    
        }

        string reversedSentence = String.Join(" ", tempStrings);
        return reversedSentence;
    }
    else
    {
        char[] temp = new char[input.Length];
        for (int j = 0; j < input.Length; j++)
        {
            temp[(input.Length - 1) - j] = input[j];
        }

        string reversed = String.Join("", temp);
        return reversed;
    }


    
}
