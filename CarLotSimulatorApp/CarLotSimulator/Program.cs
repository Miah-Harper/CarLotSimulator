using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var carLot = new CarLot();


            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car


            Car myFirstCar = new Car("1999", "Pontiac", "Grand AM", "vroom!", "hooonk!", true);

            Car mySecondCar = new Car("2002" , "Honda" , "CRV", "vrooom" , "honk" , true);
            
            Car myThirdCar = new Car("2012" , "Toyota" , "RAV4", "vroom vroom" , "quack" , true);


            carLot.ParkingLot.Add(myFirstCar);

            carLot.ParkingLot.Add(mySecondCar);

            carLot.ParkingLot.Add(myThirdCar);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car


            Car myFourthCar = new Car("2000", "Nissan", "Ultima", "vroom" , "honk" , true);

            Car myFifthCar = new Car();
            myFifthCar.Year = "2003";
            myFifthCar.Make = "Honda";
            myFifthCar.Model = "Civic";
            myFifthCar.EngineNoise = "Vroom Vroom";
            myFifthCar.HonkNoise = "beep beep";
            myFifthCar.IsDriveable = true;

            carLot.ParkingLot.Add(myFourthCar);
            carLot.ParkingLot.Add(myFifthCar);

            


            Car mySixthCar = new Car() { Year = "1993", Make = "Toyota", Model = "Avalon", EngineNoise = "vrooom", HonkNoise = "broken", IsDriveable = false};
            carLot.ParkingLot.Add(mySixthCar);

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var car in carLot.ParkingLot)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                car.MakeEngineNoise();
                car.MakeHonkNoise();
                Console.WriteLine();



            }
        }
    }
}
