namespace InterfaceDemo
{
    public interface IIceVehicle : ITransportMode
    {
        double CO2 {get; set;}

        double KmPerLitre {get; set;}
    }
}