

namespace RoshamBoLab
{
    public class RandomPlayer : Player
    {
        public override string Name { get; set; }
        public override int RoshamboValue { get; set; }

        public RandomPlayer(string name)
        {
            this.Name = name;
        }

        public override void GenerateRoshambo()
        {
            Random random = new Random();
            this.RoshamboValue = random.Next(0, 3);
        }
    }
}
