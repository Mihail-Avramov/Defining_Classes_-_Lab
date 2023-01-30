using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Engine treeLiterDiesel = new Engine(215, 3);
            Tire[] tires = new Tire[4]
            {
                new Tire(2020, 2),
                new Tire(2020, 2),
                new Tire(2020, 2),
                new Tire(2020, 2)
            };
            string make = "BMW";
            string model = "X3";
            int year = 2020;
            double fuelQuantity = 100;
            double fuelConsumption = 10;

            Car car1 = new Car();
            Car car2 = new Car(make, model,year);
            Car car3 = new Car(make, model,year,fuelQuantity, fuelConsumption);
            Car car4 = new Car(make, model, year, fuelQuantity, fuelConsumption, treeLiterDiesel, tires);

        }
    }
}