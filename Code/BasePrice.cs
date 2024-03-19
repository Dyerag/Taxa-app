using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.Metadata;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace TaxaApp.Code
{
    public class BasePrice
    {
        public int StartingPrice { get; set; } 
        public double PerKm { get; set; }
        public double PerMin { get; set; }

        public BasePrice()
        {
            //prices();
        }

        public void prices()
        {
            VehicleSize size = new VehicleSize();
            TimePeriod timePeriod = new TimePeriod();
            size = VehicleSize.Normal;
            timePeriod = TimePeriod.Day;
            switch (size, timePeriod)
            {
                case (VehicleSize.Normal, TimePeriod.Day):
                    StartingPrice = 37;
                    PerKm = 12.75;
                    PerMin = 5.75;
                    break;

                case (VehicleSize.Normal, TimePeriod.Night):
                    StartingPrice = 47;
                    PerKm = 16;
                    PerMin = 7;
                    break;

                case (VehicleSize.Large, TimePeriod.Day):
                    StartingPrice = 77;
                    PerKm = 17;
                    PerMin = 5.75;
                    break;

                case (VehicleSize.Large, TimePeriod.Night):
                    StartingPrice = 87;
                    PerKm = 19;
                    PerMin = 7;
                    break;
            }
        }
    }
}
