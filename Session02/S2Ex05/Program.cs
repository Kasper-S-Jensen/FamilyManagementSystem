using System;
using System.Collections.Generic;

namespace S2Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carlist = new List<Car>();
            Car car1 = new Car("red", 500, 200.0, true);
            Car car2 = new Car("blue", 400, 200.0, true);
            Car car3 = new Car("red", 300, 300.0, false);
            Car car4 = new Car("green", 200, 400.0, true);
            Car car5 = new Car("purple", 100, 500.0, false);
            carlist.Add(car1);
            carlist.Add(car2);
            carlist.Add(car3);
            carlist.Add(car4);
            carlist.Add(car5);

            CarSorter carSorter = new CarSorter();
            // foreach (var car in carSorter.CarsWithTwoColor(carlist, "red","blue"))
            // {
            //     Console.WriteLine(car.ToString());
            // }
            foreach (var car in carSorter.CarsWithTwoConditions(carlist, "red",true))
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}