using System;

namespace _1._Class_Box_Data
{
    public class Program
    {
        public static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = new Box(length, width, height);

            Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}\nLateral Surface Area - {box.LateralSurfaceArea():f2}\nVolume - {box.Volume():f2}");
        }
    }
}
