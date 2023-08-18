using RoshamBoLab;

bool again = true;
HumanPlayer player;
int games = 0;
int wins = 0;
int losses = 0;
int draws = 0;

while (true)
{
    
    Console.WriteLine("Welcome, what is your name challenger?");
    string user = Console.ReadLine();
    if (user == null)
    {
        Console.WriteLine("You must have a name");
    }
    else
    {
         player = new HumanPlayer(user);
        break;

    }

}

while (again)
{
    games++;
    Player opposition;
    while (true)
    {
        Console.WriteLine("Who would you like to play against (Rock or Randy)? ");
        string opponent = Console.ReadLine();

        if (opponent == null)
        {
            Console.WriteLine("You must choose an opponent");
        }
        else
        {
            if(opponent.Trim().ToLower() == "rock")
            {
                RockPlayer rock = new RockPlayer("Rock");
                opposition = rock;
                break;
            }
            else if(opponent.Trim().ToLower() == "randy")
            {
                RandomPlayer randy = new RandomPlayer("Randy");
                opposition = randy;
                break;
            }
            else
            {
                Console.WriteLine($"Sorry, {opponent} is not a valid opponent");
            }
        }
    }

    player.GenerateRoshambo();
    opposition.GenerateRoshambo();

    if (player.RoshamboValue == 0)
    {
        Console.WriteLine("You chose Rock");
    }
    else if (player.RoshamboValue == 1)
    {
        Console.WriteLine("You chose Paper");
    }
    else
    {
        Console.WriteLine("You chose Scissors");
    }

    if(opposition.RoshamboValue == 0)
    {
        Console.WriteLine($"{opposition.Name} chose Rock");
    }
    else if(opposition.RoshamboValue == 1)
    {
        Console.WriteLine($"{opposition.Name} chose Paper");
    }
    else if(opposition.RoshamboValue == 2)
    {
        Console.WriteLine($"{opposition.Name} chose Scissors");
    }

    if (player.RoshamboValue == opposition.RoshamboValue)
    {
        Console.WriteLine("DRAW!!!");
        draws++;
    }
    else if(player.RoshamboValue == 0 && opposition.RoshamboValue == 2 || player.RoshamboValue == 1 && opposition.RoshamboValue == 0 || player.RoshamboValue == 2 && opposition.RoshamboValue == 1)
    {
        Console.WriteLine("A WINNER IS YOU!!!!");
        wins++;
    }
    else
    {
        Console.WriteLine("Better luck next time");
        losses++;
    }

    while (true)
    {
        Console.WriteLine("Would you like to play again (y/n)");
        ConsoleKeyInfo choice = Console.ReadKey();
        Console.WriteLine(" ");

        if(Char.ToLower(choice.KeyChar) == 'y')
        {
            break;
        }
        else if(Char.ToLower(choice.KeyChar) == 'n')
        {
            Console.WriteLine($"Out of {games} games you won {wins} games, lost {losses} games, and drew {draws} games");
            Console.WriteLine("Goddbye!");
            again = false;
            break;
        }
        else
        {
            Console.WriteLine($"Sorry, {choice.KeyChar} is not a valid option");
        }
    }

}