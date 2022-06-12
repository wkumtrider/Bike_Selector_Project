// See https://aka.ms/new-console-template for more information

namespace Bike_Selector_Project
{ 
    public class Program
    { 
        private static string Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            var options = menu.BuildMainMenu();
            menu.DisplayMainMenu(options);

            var bikeSelected = menu.GetMenuSelection(options);


            Console.WriteLine("What type of bike do you prefer?");
            Console.ReadLine();
        }
    }
}