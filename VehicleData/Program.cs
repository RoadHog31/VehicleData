using System;

namespace VehicleData
{
    public class Vehicle
    {
        public string model;        //Name of the model
        public string manufacturer; //Name of the manufacturer
        public int numOfDoors;      //The number of doors on the vehicle
        public int numOfWheels;     //The number of wheels on the vehicle
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Build car1.
            Vehicle car1 = new Vehicle();
            car1.manufacturer = "Audi"; car1.model = "A4";

            //Make car2 the same as car1.
            Vehicle car2 = car1;

            //Initial state.
            Console.WriteLine("a. car1 is an " + car1.manufacturer + " " + car1.model);
            Console.WriteLine("b. car2 is an " + car2.manufacturer + " " + car2.model);

            //Changing car1 changes car2.
            car1.manufacturer = "Ford"; car1.model = "Focus";
            Console.WriteLine("c. car1 is an " + car1.manufacturer + " " + car1.model);
            Console.WriteLine("d. car2 is an " + car2.manufacturer + " " + car2.model);

            //Changing car2 changes car1.
            car2.manufacturer = "Nissan"; car2.model = "Qashqai";
            Console.WriteLine("e. car1 is an " + car1.manufacturer + " " + car1.model);
            Console.WriteLine("f. car2 is an " + car2.manufacturer + " " + car2.model);

            //Deleting car1 leaves car2.
            car1 = null;
            Console.WriteLine("g. car2 is an " + car2.manufacturer + " " + car2.model);

            //Wait for the user to acknowledge the results. 
            Console.WriteLine("Press enter to terminate...");
            Console.Read();
         }
    }
}