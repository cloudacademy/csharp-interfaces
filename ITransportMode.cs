namespace InterfaceDemo
{

public enum EnergyType : ushort {
        Unknown = 0,
        Calorie = 1,
        NewtonMeter = 2
    }

    public interface ITransportMode
    {
        EnergyType EnergyMeasure{get;}
        int Weight {get; set;}
        double DragCoEfficient {get; set;}
        double AverageSpeed {get;set;}
        double CO2Emissions (double energyConsumed)
        {
            return 0;
        }

        public double EnergyConsumed(int elevation, int distance)
        {
            return (Weight * 9.8 * elevation) / distance;
        }
    }
}