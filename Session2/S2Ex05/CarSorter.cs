using System.Collections.Generic;

namespace S2Ex05
{
    public class CarSorter
    {
        public List<Car> CarsWithOneColor(List<Car> list, string color)
        {
            return list.FindAll(car => car.Color.Equals(color));
            
        }
        public List<Car> CarsWithTwoColor(List<Car> list, string color1,string color2)
        {
            return list.FindAll(car => car.Color.Equals(color1)|| car.Color.Equals(color2));
            
        }

        public List<Car> CarsWithEngineBiggerThan(List<Car> list, int value)
        {
            return list.FindAll(car => car.EngineSize > value);
        }
        
        public List<Car> CarsWithEngineBetween(List<Car> list, int lowerValue,int upperValue)
        {
            return list.FindAll(car => car.EngineSize > lowerValue && car.EngineSize<upperValue);
        }





        public List<Car> CarsWithTwoConditions(List<Car> list, string color, bool shifttype)
        {
            return list.FindAll(car => car.Color.Equals(color) && car.IsManualShift == shifttype);
        }











    }
}