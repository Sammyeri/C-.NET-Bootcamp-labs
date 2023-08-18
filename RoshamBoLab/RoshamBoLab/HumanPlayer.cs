

namespace RoshamBoLab
{
    public class HumanPlayer : Player
    {
        public override string Name { get; set; }
        public override int RoshamboValue { get; set; }

        public HumanPlayer(string name)
        {
            this.Name = name;
        }

        public override void GenerateRoshambo()
        {
            while (true)
            {

                Console.WriteLine("Please select your choice, (rock, paper, scissors)");
                string userInputRaw = Console.ReadLine();

                if (string.IsNullOrEmpty(userInputRaw))
                {
                    Console.WriteLine("You must make a choice");
                }
                else
                {
                    if (userInputRaw.Trim().ToUpper() == Choices.ROCK.ToString() || userInputRaw.Trim().ToLower() == "r")
                    {
                        this.RoshamboValue = 0;
                        break;
                    }
                    else if (userInputRaw.Trim().ToUpper() == Choices.PAPER.ToString() || userInputRaw.Trim().ToLower() == "p")
                    {
                        this.RoshamboValue = 1;
                        break;
                    }
                    else if (userInputRaw.Trim().ToUpper() == Choices.SCISSORS.ToString() || userInputRaw.Trim().ToLower() == "s")
                    {
                        this.RoshamboValue= 2;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, {userInputRaw} is not a valid chioce");
                    }

                }
            }
        }
    }
}
