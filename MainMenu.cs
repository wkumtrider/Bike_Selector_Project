using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Selector_Project
{
    public class MainMenu
    {
        public List<MenuOption> BuildMainMenu()
        {
            return new List<MenuOption>
           {
               new MenuOption ("Trek"),
               new MenuOption ("Giant"),
               new MenuOption ("Ibis"),
               new MenuOption ("Pivot"),
               new MenuOption ("Transition"),
               new MenuOption ("Specialized"),
               new MenuOption ("Kona"),
           };
        }

        
        public void DisplayMainMenu(List<MenuOption> options)
        {
            Console.Clear();
            Console.WriteLine("Please choose a bike brand from the menu below.");

            int menuOptionCount = 1;
            foreach(var option in options)
            {
                Console.WriteLine($"{menuOptionCount++}.{option.ItemText}");
            }

                        
            Console.WriteLine("To exit the database please type 'Exit' and press enter");

            
        }

        public int GetMenuSelection(List<MenuOption> options)
        {
            do
            {
                string userChoice = Console.ReadLine();
                userChoice = userChoice.ToLower();
                if (userChoice == "exit")
                {
                    Console.Clear ();
                    Console.WriteLine("Until Next Time");
                    Environment.Exit(0);
                }
                else
                {
                    if (int.TryParse(userChoice, out int selection) && selection > 0 && selection <= options.Count)
                    {
                        return selection;

                    }
                    Console.WriteLine("Invalid Option");
                }


            } while (true);

            
        }
    }
}
