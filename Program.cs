// See https://aka.ms/new-console-template for more information

using System.Text.Json;

namespace Bike_Selector_Project
{ 
    public class Program
    { 
        public static void Main(string[] args)
        {
            // create a json file with a list of bikes
            InitInventory();            
            
            // read the list of bikes from the file (in the bin folder
            string jsonString = File.ReadAllText("Bikes.json");
            var bikes = JsonSerializer.Deserialize<List<BikeBrand>>(jsonString);
            
            foreach (var bike in bikes) bike.Display();
        }
        
        static void InitInventory()
        {
            var bikes = new List<BikeBrand>(); bikes.Add(new BikeBrand() { Trek = "Trek", Giant = "Giant", Pivot = "Pivot", Ibis = "Ibis"});
            bikes.Add(new BikeBrand() { Transition = "Transition", Specialized = "Specialized", Kona = "Kona"});

            string jsonString = JsonSerializer.Serialize(bikes);
            File.WriteAllText("Bikes.json", jsonString); // the file will be created in the bin folder

            MainMenu menu = new MainMenu();
            var options = menu.BuildMainMenu();
            menu.DisplayMainMenu(options);

            var bikeSelected = menu.GetMenuSelection(options);
            


        }
    }
}