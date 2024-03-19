using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace TaxaApp.Code
{
    public class OptionForm
    {
        [Required(ErrorMessage ="Størelse skal vælges")]
        public VehicleSize Size { get; set; }

        [Required(ErrorMessage = "tidspunkt skal vælges")]
        public TimePeriod Period { get; set; }

        [Range(0, double.PositiveInfinity, ErrorMessage = "Der kan ikke være mindre end 0 cykler")]
        public int Bicycle { get; set; }
        
        [Range(0,double.PositiveInfinity, ErrorMessage ="Der kan ikke være mindre end 0 opbæringer")]
        public int Carry { get; set; }
        
        public bool Airport { get; set; }
        public bool Passengers { get; set; }
        public bool LiftCart { get; set; }
        public bool Øresund { get; set; }
        public bool Storebæltsbroen { get; set; }
    }
}
