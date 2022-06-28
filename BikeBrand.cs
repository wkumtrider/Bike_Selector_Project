using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Selector_Project
{
    
    public class BikeBrand : BikeType
    {
        public string Trek { get; set; }
        public string Giant { get; set; }
        public string Pivot { get; set; }
        public string Ibis { get; set; }
        public string Transition { get; set; }
        public string Specialized { get; set; }
        public string Kona { get; set; }

        public void Display()
        {
            Console.WriteLine($"Brand: {Trek}, has XC Bikes, Brand: {Giant}, Brand: {Pivot}, Brand: {Ibis}, Brand: {Transition}, Brand: {Specialized}, Brand: {Kona}");
        }

    }
    
        
}
