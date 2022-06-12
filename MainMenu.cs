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
               new MenuOption ("XC"),
               new MenuOption ("All Mountain"),
               new MenuOption ("Enduro"),
               new MenuOption ("Down Hill"),
           };
        }

        public void DisplayMainMenu(List<MenuOption> options)
        {
            Console.Clear();
            Console.WriteLine("Please choose the type of bike you are interet")
        }
    }
}
