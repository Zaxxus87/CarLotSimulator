﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; } = true;

        public Car()
        {

        }

        public Car(int year, string make, string model, string honkNoise, string engineNoise)
        {
            Year = year;
            Make = make;
            Model = model;
            HonkNoise = honkNoise;
            EngineNoise = engineNoise;
            
        }
        public void MakeEngineNoise()
        {
            Console.WriteLine($"{EngineNoise}! {EngineNoise}!");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"{HonkNoise}! {HonkNoise}!");
        }
        

        

    }
}
