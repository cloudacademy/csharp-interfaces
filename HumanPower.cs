namespace InterfaceDemo
{
    public class HumanPower : IHuman
    {
        public EnergyType EnergyMeasure {get {return EnergyType.Calorie;} } 
        public int Weight {get; set;}
        public double DragCoEfficient { get; set;}
        public int Age { get;set; }    
        public int BMR {get; set;}  //Basal metabolic rate
        public int CaloriesConsumed {  get;set;  }
        public double AverageSpeed {  get;set; }

        public HumanPower()
        {
            AverageSpeed = 5000;
        }
        public HumanPower(int bmr)
        {
            BMR = bmr;
            AverageSpeed = 5000;
        }        
    }

     public class Walker: HumanPower
    {
        public Walker():base()
        {
        }
        public Walker(int bmr):base(bmr)
        {
        }        
    }

    public class Runner : HumanPower
    {
        public Runner() : base()
        {
            AverageSpeed = 10;
        }
        public Runner(int bmr):base(bmr)
        {
            AverageSpeed = 10;
        }        
    }
    public class Cyclist : HumanPower
    {
        public Cyclist() : base()
        {
            AverageSpeed = 25000;
        }

        public Cyclist(int bmr):base(bmr)
        {
            AverageSpeed = 25000;            
        }
    }    

}