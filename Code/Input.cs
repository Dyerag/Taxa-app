namespace TaxaApp.Code
{

    public class Input
    {
        public VehicleSize Size { get; set; } = VehicleSize.Default;
        public Time Period { get; set; } = Time.Default;
        public int Bicycle { get; set; }
        public int Carry { get; set; }
        public bool Airport { get; set; }
        public bool Passengers { get; set; }
        public bool LiftCart { get; set; }
        public bool Øresund { get; set; }
        public bool Storebæltsbroen { get; set; }
    }
}
