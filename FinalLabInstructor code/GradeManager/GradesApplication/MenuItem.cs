using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesApplication
{
    public class MenuItem
    {
        public Action MenuAction { get; set; }
        public string MenuSelector { get; set; }
        public string Description { get; set; }

        public MenuItem(string menuSelector, string description, Action menuAction)
        {
            this.MenuSelector = menuSelector;
            this.Description = description;
            this.MenuAction = menuAction;
        }
    }
}
