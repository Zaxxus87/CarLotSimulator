using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class CarLot
    {
        public List<Car> lotList;
        public static int numberOfCars;

        public CarLot()
        {
            lotList = new List<Car>();
            numberOfCars = 0;
        }

        public void AddCar(Car c)
        {
            lotList.Add(c);
            numberOfCars++;
        }

        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < lotList.Count; i++)
            {
                output += $"Car #{i + 1}\n";
                output += $"Make: {lotList[i].Make}\n";
                output += $"Model: {lotList[i].Model}\n";
                output += $"Year: {lotList[i].Year}\n\n";
            }
                
            return output;
        }
    }

}
