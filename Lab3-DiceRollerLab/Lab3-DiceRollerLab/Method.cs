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
}
