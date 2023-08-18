
namespace RoshamBoLab
{
    public abstract class Player
    {
        public abstract string Name { get; set; }
        public abstract int RoshamboValue { get; set; } 

        public abstract void GenerateRoshambo();
    }
}
