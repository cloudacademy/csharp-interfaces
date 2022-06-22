namespace InterfaceDemo
{
    public class PetrolCar : IIceVehicle
    {
        public EnergyType EnergyMeasure {get {return EnergyType.NewtonMeter;} }         
        public double CO2 {  get;set;  }
        public double KmPerLitre { get;set;  }
        public int Weight { get;set;  }   
        public double AverageSpeed { get;set;  }      
        public double DragCoEfficient {  get;set; }    

        public PetrolCar()
        {
            AverageSpeed = 50000;
            Weight = 1400;
        }           
    }
}