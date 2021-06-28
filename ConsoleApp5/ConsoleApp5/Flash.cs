namespace ConsoleApp5
{
    public class Flash : Storage
    {
        public double speed;
        public double memory_capacity;
        
        public override double GetVolume()
        {
            return memory_capacity;
        }
    }
}