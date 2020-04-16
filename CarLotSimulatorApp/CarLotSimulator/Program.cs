using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            //Bonus x2
            CarLot lot = new CarLot();


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car myFirstCar = new Car() ;
            lot.CarList.Add(myFirstCar);

            myFirstCar.Year  = 1987;
            myFirstCar.Make = "Lexus";
            myFirstCar.Model = "LS 400";
            myFirstCar.EngineNoise = "Purr";
            myFirstCar.HonkNoise = "BEEP BEEP";
            myFirstCar.IsDriveable = true;

            myFirstCar.MakeEngineNoise(myFirstCar.EngineNoise);
            myFirstCar.MakeHonkNoise(myFirstCar.HonkNoise);

            
            Car mySecondCar = new Car() { Year = 2003, Make = "Hyundai", Model = "Elantra", EngineNoise = "Pur Pur", HonkNoise = "Beepidy Beepidy", IsDriveable = true };
            lot.CarList.Add(mySecondCar);

            mySecondCar.MakeEngineNoise(mySecondCar.EngineNoise);
            mySecondCar.MakeHonkNoise(mySecondCar.HonkNoise);

            Car myThirdCar = new Car(2020, "Lexus", "LS 430", "VVVROOOOM", "Move b*&#^s", true); //inside paramater, just put values you want i.e. (2020, Lamburgini, etc.)
            lot.CarList.Add(myThirdCar);

            myThirdCar.MakeEngineNoise(myThirdCar.EngineNoise);
            myThirdCar.MakeHonkNoise(myThirdCar.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//
            foreach(var car in lot.CarList)                     //review video for any questions
            {
                Console.WriteLine();
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

        }
    }
   
}
