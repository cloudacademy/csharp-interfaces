using System;

namespace InterfaceDemo
{
    public class Trip
    {
        public int Distance {get; set;}
        public int ElevationGain {get; set;}
        public ITransportMode TransportMode {get; set;}

        public override string ToString()
        {
            return $"{TransportMode.GetType().ToString()} - Distance: {Distance} meters; Gradient: {(((double)ElevationGain / (double)Distance) * 100):0.##}%; Duration: {ElapsedTime().ToString()}; Energy: {EnergyConsumed():0.###} {TransportMode.EnergyMeasure.ToString()}";
        }

        public TimeSpan ElapsedTime()
        {
            double elapsedTime =  Distance / TransportMode.AverageSpeed;
            int elapsedHours = Convert.ToInt32(Math.Truncate(elapsedTime));
            int elapsedMinutes = Convert.ToInt32(Math.Round((elapsedTime - elapsedHours) * 60, 0));
            return new TimeSpan(elapsedHours, elapsedMinutes, 0);
        }
        public double EnergyConsumed()
        {
            return TransportMode.EnergyConsumed(ElevationGain, Distance);
        }

        public double CO2Emiited(double energy)
        {
            return TransportMode.CO2Emissions(energy);
        }

        public Trip()
        {}

        public Trip (int distance, int elevation)
        {
            Distance = distance;
            ElevationGain = elevation;
        }

    }
}