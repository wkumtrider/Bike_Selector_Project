using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Selector_Project
{
    public class BikeType
    {
        public string XC { get; set; }
        public string AllMountain { get; set; }
        public string Enduro { get; set; }
        public string DownHill { get; set; }

        public void Display()
        {
            Console.WriteLine($"Up to 120mm travel, great for single track: {XC}, Up to 140mm travel, good for more technical trails: {AllMountain}, Brand: {Enduro}, Brand: {DownHill}");
        }
    }

}
