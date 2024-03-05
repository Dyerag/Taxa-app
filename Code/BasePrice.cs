using Microsoft.AspNetCore.Http.Metadata;

namespace TaxaApp.Code
{
    public class BasePrice
    {
        public int StartingPrice { get; set; }
        public double PerKm { get; set; }
        public double PerMin { get; set; }

        public BasePrice(VehicleSize size, Time period)
        {
            switch (size, period)
            {
                case (VehicleSize.Normal, Time.Day):
                    StartingPrice = 37;
                    PerKm = 12.75;
                    PerMin = 5.75;
                    break;

                case (VehicleSize.Normal, Time.Night):
                    StartingPrice = 47;
                    PerKm = 16;
                    PerMin = 7;
                    break;

                case (VehicleSize.Large, Time.Day):
                    StartingPrice = 77;
                    PerKm = 17;
                    PerMin = 5.75;
                    break;

                case (VehicleSize.Large, Time.Night):
                    StartingPrice = 87;
                    PerKm = 19;
                    PerMin = 7;
                    break;
            }
        }
    }
}
