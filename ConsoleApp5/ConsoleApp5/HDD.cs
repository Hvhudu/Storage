namespace ConsoleApp5
{
    public class HDD : Storage
    {
        public double speed = 60;
        public int num_of_sections;
        public int vol_of_sections;
        public double volume;
        
        public override double GetVolume()
        {
            volume = num_of_sections * vol_of_sections;
            return volume;
        }
    }
}