namespace Lab3_DiceRollerLab;

public class Method
{
    public static int roll(int n)
    {
        Random random = new Random();
        int roll = random.Next(1, n + 1);
        return roll;
    }

    public static int total(int dice1, int dice2)
    {
        return dice1 + dice2;
    }

    public static void message(int dice1, int dice2)
    {
        //snake eyes, 2 ones
        if (dice1 == 1 && dice2 == 1)
        {
            Console.WriteLine("Snake Eyes!");
        }
        //ace duece: 1 and 2
        else if (dice1 == 1 && dice2 == 2 || dice1 == 2 && dice2 == 1)
        {
            Console.WriteLine("Ace Duece!");
        }
        //Box cars: 2 6s
        else if (dice1 == 6 && dice2 == 6)
        {
            Console.WriteLine("Box Cars!");
        }
        else
        {
            Console.WriteLine(" ");
        }
    }

    public static void extraMessage(int dice1, int dice2)
    {
        int total = dice1 + dice2;

        //win: total of 7 or 11
        if (total == 7 || total == 11)
        {
            Console.WriteLine("A Winner Is You!");
        }
        //craps: total of 2, 3, 12
        else if (total == 2 || total == 3 || total == 12)
        {
            Console.WriteLine("Aw, craps! You lost!");
        }
        else
        {
            Console.WriteLine(" ");
        }
    }
}






