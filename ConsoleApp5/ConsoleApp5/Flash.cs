namespace ConsoleApp5
{
    public class Flash : Storage
    {
        public double speed = 5;
        public double memory_capacity;
        
        public override double GetVolume()
        {
            return memory_capacity;
        }
    }
}