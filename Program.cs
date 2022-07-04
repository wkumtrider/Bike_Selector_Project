// See https://aka.ms/new-console-template for more information

using System.Text.Json;

namespace Bike_Selector_Project
{ 
    public class Program
    { 
        public static void Main(string[] args)
        {
            InitInventory();            
            
        }
        
        public static int InitInventory()
        {

            string jsonString = File.ReadAllText("Bikes.json");
            var bikes = JsonSerializer.Deserialize<List<Bike>>(jsonString);            

            MainMenu menu = new MainMenu();
            var options = menu.BuildMainMenu();
            menu.DisplayMainMenu(options);
            var bikeSelected = menu.GetMenuSelection(options);

            var bikeType = from type in bikes where type.BikeType == "XC" select type;
            
            foreach (var i in bikeType)
            {
                Console.WriteLine(i);
            }

            foreach (var bike in bikes)
            {
                Console.WriteLine(bike.BikeBrand);
                Console.WriteLine(bike.BikeType);
                Console.WriteLine(bike.BikeModel);
                Console.WriteLine("===========================");
            }
            Console.WriteLine($"You selected menu option {bikeSelected}");
            return bikeSelected;

            

        }
    }
}