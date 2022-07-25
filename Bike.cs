using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Selector_Project
{
    public class Bike
    {
        public Bike(string bikeBrand, string bikeType, string bikeModel)
        {
            BikeBrand = bikeBrand;
            BikeType = bikeType;
            BikeModel = bikeModel;
        }

        public string BikeType { get; set; }
        public string BikeBrand { get; set; }
        public string BikeModel { get; set; }

    }
}
