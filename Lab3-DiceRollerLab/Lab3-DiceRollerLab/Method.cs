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
        if(dice1 == 1 && dice2 == 1)
        {
            Console.WriteLine("Snake Eyes!");
        }
        else if (dice1 == 1 && dice2 == 2 || dice1 == 2 && dice2 == 1)
        {
            Console.WriteLine("Ace Duece!");
        }
        else if (dice1 == 6 && dice2 == 6)
        {
            Console.WriteLine("Box Cars!");
        }
        else
        {
            Console.WriteLine(" ");
        }
    }
}
