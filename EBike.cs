namespace InterfaceDemo
{
    public class Ebike : Cyclist, IElectricVehicle
    {
        public int Range {get; set; }
        public int ChargeTime { get; set; }

        public Ebike(): base()
        {
            
        }
    }
}