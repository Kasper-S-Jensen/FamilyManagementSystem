using System.Collections.Generic;

namespace S2Ex05
{
    public class Car
    {
        public string Color { get; set; }
        public int EngineSize { get; set; }
        public double FuelEconomy { get; set; }
        public bool IsManualShift { get; set; }

        public Car(string color, int engineSize, double fuelEconomy, bool isManualShift)
        {
            Color = color;
            EngineSize = engineSize;
            FuelEconomy = fuelEconomy;
            IsManualShift = isManualShift;
        }


        public override string ToString()
        {
            return $"Color: {Color} Enginesize: {EngineSize} Fueleconomy {FuelEconomy} Ismanualshift {IsManualShift}";
        }
    }
}