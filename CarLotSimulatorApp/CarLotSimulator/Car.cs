using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
   public class Car
    {
        public int Year(int date)
        {
            date = 2020;
        }
        public int date { get; set; }
       
        public string Make(string make)
        {
            make = "Chevorlet";
        }
        public string make { get; set; }

        public string Model(string model)
        {
            model = "Bronco";
        }
        public string model { get; set; }

        public string EngineNoise(string rumble)
        {
            rumble = "Boom";
        }
        public string rumble { get; set; }

        public string HonkNoise(string honk)
        {
            honk = "loud";
        }
        public string honk { get; set; }

        public bool IsDriveable(bool drive)
        {
            drive = true;
        }
        public bool drive { get; set; }

        public void MakeEngineNoise()
        {
            //rumble
        }

        public void MakeHonkNoise()
        {
            //honk
        }

        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        //Now that the Car class is created we can instanciate 3 new cars
        //Set the properties for each of the cars
        //Call each of the methods for each car
    }
}
