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
            string JsonFile = @"./Bikes.json";

            string jsonString = File.ReadAllText(JsonFile);
            List<Bike> bikes = JsonSerializer.Deserialize<List<Bike>>(jsonString);

            MainMenu menu = new MainMenu();
            var options = menu.BuildMainMenu();
            menu.DisplayMainMenu(options);
            var bikeSelected = menu.GetMenuSelection(options);

            //Console.WriteLine($"You selected menu option {bikeSelected}");
            //return bikeSelected;
            do
            {
                switch (bikeSelected)
                {
                    case 1:
                        var trek = bikes.Where(b => b.BikeBrand == "Trek");//.Select(b => b.BikeModel).ToList();
                        foreach (var b in trek)
                        Console.WriteLine($"Trek has the {b.BikeType} {b.BikeModel} available.");
                        break;
                    case 2:
                        var giant = bikes.Where(b => b.BikeBrand == "Giant");//.Select(b => b.BikeModel).ToList();
                        foreach (var b in giant)
                        Console.WriteLine($"Giant has the {b.BikeType} {b.BikeModel} available.");
                        break;
                    case 3:
                        var ibis = bikes.Where(b => b.BikeBrand == "Ibis");//.Select(b => b.BikeModel).ToList();
                        foreach (var b in ibis)
                        Console.WriteLine($"Ibis has the {b.BikeType} {b.BikeModel} available.");
                        break;
                    case 4:
                        var pivot = bikes.Where(b => b.BikeBrand == "Pivot");//.Select(b => b.BikeModel).ToList();
                        foreach (var b in pivot)
                        Console.WriteLine($"Pivot has the {b.BikeType} {b.BikeModel} available.");
                        break;
                    case 5:
                        var transition = bikes.Where(b => b.BikeBrand == "Transition");//.Select(b => b.BikeModel).ToList();
                        foreach (var b in transition)
                        Console.WriteLine($"Transition has the {b.BikeType} {b.BikeModel} available.");
                        break;
                    case 6:
                        var specialized = bikes.Where(b => b.BikeBrand == "Specialized");//.Select(b => b.BikeModel).ToList();
                        foreach (var b in specialized)
                        Console.WriteLine($"Specialized has the {b.BikeType} {b.BikeModel} available.");
                        break;
                    case 7:
                        var kona = bikes.Where(b => b.BikeBrand == "Kona");//.Select(b => b.BikeModel).ToList();
                        foreach (var b in kona)
                        Console.WriteLine($"Kona has the {b.BikeType} {b.BikeModel} available.");
                        break;

                }

                return 0;
            }while (true);

        }
    }
}