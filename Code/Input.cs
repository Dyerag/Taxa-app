using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace TaxaApp.Code
{
    public partial class Input
    {
        public VehicleSize Size { get; set; } = VehicleSize.Default;
        public TimePeriod Period { get; set; } = TimePeriod.Default;
        public int Bicycle { get; set; }
        public int Carry { get; set; }
        public bool Airport { get; set; }
        public bool Passengers { get; set; }
        public bool LiftCart { get; set; }
        public bool Øresund { get; set; }
        public bool Storebæltsbroen { get; set; }
    }
}
