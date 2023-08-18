
namespace RoshamBoLab
{
    public class RockPlayer : Player
    {
        public override string Name { get ; set ; }
        public override int RoshamboValue { get; set ; }

        public RockPlayer(string name)
        {
            this.Name = name;
        }

        public override void GenerateRoshambo()
        {
            this.RoshamboValue = 0;
        }
    }
}
