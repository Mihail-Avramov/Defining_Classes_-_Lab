using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            List<Tire[]> tiresList = new List<Tire[]>();
            List<Engine> enginesList = new List<Engine>();
            List<Car> carsList = new List<Car>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tiresArguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Tire[] tires = new Tire[tiresArguments.Length / 2];
                
                for (int i = 0; i < tires.Length; i++)
                {
                    tires[i] = new Tire(int.Parse(tiresArguments[i * 2]), double.Parse(tiresArguments[i * 2 + 1]));
                }

                tiresList.Add(tires);
            }

            input = string.Empty;

            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] engineArguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine engine = new Engine(int.Parse(engineArguments[0]), double.Parse(engineArguments[1]));

                enginesList.Add(engine);
            }

            input = string.Empty;

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carArguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car newCar = new Car();
                newCar.Make = carArguments[0];
                newCar.Model = carArguments[1];
                newCar.Year = int.Parse(carArguments[2]);
                newCar.FuelQuantity = double.Parse(carArguments[3]);
                newCar.FuelConsumption = double.Parse(carArguments[4]);
                newCar.Engine = enginesList[int.Parse(carArguments[5])];
                newCar.Tires = tiresList[int.Parse(carArguments[6])];

                carsList.Add(newCar);
            }

            foreach (var car in carsList.Where(c => 
                         c.Year >= 2017 && 
                         c.Engine.HorsePower > 330 && 
                         c.Tires.Sum(t => t.Pressure) > 9 && 
                         c.Tires.Sum(t => t.Pressure) < 10))
            {
                car.Drive(20);
                Console.WriteLine(car.PrintSpecialCar());
            }

        }
    }
}