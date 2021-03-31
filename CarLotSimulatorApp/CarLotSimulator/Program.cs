using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new CarLot();
            var c1 = new Car();
            c1.Year = 2020;
            c1.Make = "Ford";
            c1.Model = "Focus";
            c1.HonkNoise = "Beep";
            c1.EngineNoise = "Vroom";
            cars.AddCar(c1);

            var c2 = new Car(2019,"Dodge", "Colt", "epp", "BrrBrr");
            cars.AddCar(c2);

            var c3 = new Car()
            {
            Year = 2018,
            Make = "Toyota",
            Model = "Camery",
            HonkNoise = "meep",
            EngineNoise = "chukachuka"
            };
            cars.AddCar(c3);

            c1.MakeEngineNoise();
            c1.MakeHonkNoise();

            c2.MakeEngineNoise();
            c2.MakeHonkNoise();

            c3.MakeEngineNoise();
            c3.MakeHonkNoise();

            Console.WriteLine(cars);
            Console.WriteLine($"Number of Cars in Lot: {CarLot.numberOfCars}");
            
        }
    }
}
