// See https://aka.ms/new-console-template for more information

//using Newtonsoft.Json;
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
            string JsonFile = "C:/Users/jmcca/Code_LVL_2022/Bike_Selector_Project/Bike_Selector_Project/Bikes.json";

            string jsonString = File.ReadAllText(JsonFile);
            List<Bike> bikes =JsonSerializer.Deserialize<List<Bike>>(jsonString);

            MainMenu menu = new MainMenu();
            var options = menu.BuildMainMenu();
            menu.DisplayMainMenu(options);
            var bikeSelected = menu.GetMenuSelection(options);

            do
            {
                switch (bikeSelected)
                {
                    case 1:
                        var trek = bikes.Where(b => b.BikeBrand == "Trek");
                        foreach (var b in trek)
                        Console.WriteLine($"Trek has the {b.BikeType} {b.BikeModel} available.");
                        break;
                    case 2:
                        var giant = bikes.Where(b => b.BikeBrand == "Giant");
                        foreach (var b in giant)
                        Console.WriteLine($"Giant has the {b.BikeType} {b.BikeModel} available.");
                        break;
                    case 3:
                        var ibis = bikes.Where(b => b.BikeBrand == "Ibis");
                        foreach (var b in ibis)
                        Console.WriteLine($"Ibis has the {b.BikeType} {b.BikeModel} available.");
                        break;
                    case 4:
                        var pivot = bikes.Where(b => b.BikeBrand == "Pivot");
                        foreach (var b in pivot)
                        Console.WriteLine($"Pivot has the {b.BikeType} {b.BikeModel} available.");
                        break;
                    case 5:
                        var transition = bikes.Where(b => b.BikeBrand == "Transition");
                        foreach (var b in transition)
                        Console.WriteLine($"Transition has the {b.BikeType} {b.BikeModel} available.");
                        break;
                    case 6:
                        var specialized = bikes.Where(b => b.BikeBrand == "Specialized");
                        foreach (var b in specialized)
                        Console.WriteLine($"Specialized has the {b.BikeType} {b.BikeModel} available.");
                        break;
                    case 7:
                        var kona = bikes.Where(b => b.BikeBrand == "Kona");
                        foreach (var b in kona)
                        Console.WriteLine($"Kona has the {b.BikeType} {b.BikeModel} available.");
                        break;

                }

                Console.WriteLine("\n Do you want to add a bike to the list or exit (Enter Yes or Exit)?");
                string AddBike = Console.ReadLine();
                if (AddBike.ToLower() == "yes")
                {
                    Console.WriteLine("What is the brand of the bike?");
                    string bikeBrand = Console.ReadLine();
                    
                    Console.WriteLine("What is the bike type?");
                    string bikeType = Console.ReadLine();

                    Console.WriteLine("What is the bike model?");
                    string bikeModel = Console.ReadLine();

                    bikes.Add(new Bike(bikeBrand, bikeType, bikeModel));

                    string bikeJsonList = JsonSerializer.Serialize<List<Bike>>(bikes);
                    File.WriteAllText(JsonFile, bikeJsonList);
                    
                }
                else
                {
                    { Environment.Exit(0); }
                };

                
            }while (true);
            return 0;
        }

    }
}