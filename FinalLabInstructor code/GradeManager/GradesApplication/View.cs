using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesApplication
{
    public class View
    {
        private Dictionary<string, MenuItem> _menu = new Dictionary<string, MenuItem>();
        protected bool IsSubMenu { get; set; } = false;
        protected string Banner { get; set; }
        public virtual void Run()
        {
            if (this.IsSubMenu) this.AddMenuItem( new MenuItem("0", "Exit this menu", () => { }));
            while (true)
            {
                try
                {
                    string selection = this.GetMenuSelection();
                    if (IsSubMenu && selection == "0") return;
                    _menu[selection].MenuAction();
                    this.Pause();
                }
                catch(Exception ex) 
                {
                    Console.WriteLine("Please enter a valid selection.");
                    this.Pause();
                }
            }
        }

        protected virtual void Pause()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        protected virtual void ShowMenu()
        {
            Console.Clear();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Banner);
            sb.AppendLine();
            foreach(MenuItem mi in this._menu.Values)
            {
                sb.AppendLine($"{mi.MenuSelector}. {mi.Description}");
            }
            sb.AppendLine("Please select a valid option.");
            Console.WriteLine(sb.ToString());
        }

        protected virtual void Exit()
        {
            System.Environment.Exit(0);
        }

        protected void AddMenuItem(MenuItem item)
        {
            this._menu.Add(item.MenuSelector, item);
        }
        private string GetMenuSelection()
        {
            Console.Clear();
            this.ShowMenu();
            return Console.ReadLine();
        }
    }
}
