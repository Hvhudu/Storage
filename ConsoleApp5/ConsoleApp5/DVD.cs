using System;
using System.Diagnostics;

namespace ConsoleApp5
{
    public class DVD : Storage
    {
        public double write_speed;
        public double reading_speed;
        public string type;
        public double volume;
        
        public override double GetVolume()
        {
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1 :
                    volume = 4.7;
                    break;
                case 2:
                    volume = 9;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR");
                    break;
            }
            Console.WriteLine(volume);
            return volume;
        }
    }
}