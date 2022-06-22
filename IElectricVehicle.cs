namespace InterfaceDemo
{
    public interface IElectricVehicle: ITransportMode
    {
        int Range { get; set; }

        int ChargeTime { get; set; }
    }
}