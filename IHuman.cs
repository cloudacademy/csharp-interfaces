namespace InterfaceDemo
{
    public interface IHuman : ITransportMode
    {
        int BMR {get; set; } //Basal metabolic rate

        double ITransportMode.EnergyConsumed(int elevation, int distance)
        {
            double hour = distance / AverageSpeed /1000;
            return BMR * AverageSpeed / 24 * hour;
        }
    }
}