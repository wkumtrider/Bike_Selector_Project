﻿using System;
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
               new MenuOption ("Pivot"),
               new MenuOption ("Ibis"),
               new MenuOption ("Transition"),
               new MenuOption ("Specialized"),
               new MenuOption ("Kona"),
           };
        }

        public void DisplayMainMenu(List<MenuOption> options)
        {
            Console.Clear();
            Console.WriteLine("Please choose a bike brand from the menu below to see availabe models for sale");
            Console.WriteLine("To exit the database please type 'Exit' and press enter");

            int menuOptionCount = 1;
            foreach(var option in options)
            {
                Console.WriteLine($"{menuOptionCount++}.{option.ItemText}");
            }
        }
    }
}
