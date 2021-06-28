using System;

namespace ConsoleApp5
{
    class Program
    {
        static double TotalMemoryCapacity(DVD dvd, HDD hdd, Flash flash)
        {
            double total_volume = dvd.volume + hdd.volume + flash.memory_capacity;
            Console.WriteLine($"Общий объём памяти - {total_volume}");
            return total_volume;
        }
        static void Main(string[] args)
        {
            var dvd = new DVD();
            Console.WriteLine("Выберите тип диска");
            Console.WriteLine("1 - односторонний");
            Console.WriteLine("2 - двусторонний");
            dvd.GetVolume();
            var hdd = new HDD();
            Console.WriteLine("Введите кол-во разделов");
            hdd.num_of_sections = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите обьём разделов");
            hdd.vol_of_sections = Convert.ToInt32(Console.ReadLine());
            hdd.GetVolume();
            var flash = new Flash();
            Console.WriteLine("Введите объём памяти Flash-накопителя");
            flash.memory_capacity = Convert.ToInt32(Console.ReadLine());
            flash.GetVolume();
            TotalMemoryCapacity(dvd, hdd, flash); 
            
            Console.WriteLine("Выберите устройство для записи");
            Console.WriteLine("1 - HDD");
            Console.WriteLine("2 - Fash-накпитель");
            Console.WriteLine("3 - DVD");

            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            double time;
            double volume;

            switch (choice)
            {
                case 1:
                    volume = hdd.volume * 1024;
                    time = volume / hdd.speed;
                    Console.WriteLine($"{time} cек");
                    break;
                case 2:
                    volume = flash.memory_capacity * 8;
                    time = volume / flash.speed;
                    Console.WriteLine($"{time} cек");
                    break;
                case 3:
                    volume = dvd.volume * 8192;
                    time = volume / dvd.speed;
                    Console.WriteLine($"{time} cек");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR");
                    break;
                    
            }
        }
    }
}