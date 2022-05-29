using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car vehicle = new Car()
            {
                Brand = "Chevrolet",
                Model = "Malibu",
                CurrentFuel = "20",
                FuelFor1Km = "1",
                Millage = "20000"

            };
        }
        static int Drive(int distanceWanted, int CurrentFuel)
                        int FuelFor1Km;

        {
            if (distanceWanted* FuelFor1KM <= CurrentFuel)
                return Millage;
            return CurrentFuel;
            
        }
    }
}
