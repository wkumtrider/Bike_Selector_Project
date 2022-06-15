using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Selector_Project
{
    public class MenuOption
    {
        public MenuOption(string itemText)
        {
            ItemText = itemText.Trim();
        }
        public string ItemText { get; set; }
    }
}
