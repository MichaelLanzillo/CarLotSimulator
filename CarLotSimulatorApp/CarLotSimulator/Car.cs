using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
   public class Car
    {
        public int Year { get; set; }       
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }       
        public bool IsDriveable { get; set; }           //= true/false;

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);        
        }

        public void MakeHonkNoise(string honkNoise)             //check video
        {
            Console.WriteLine(honkNoise);          
        }

        public Car()
        {

        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable) // isDriveable = true/false
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;

        }
        
    }
   
}
