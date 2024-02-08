using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesApplication
{
    public class SchoolView : View
    {
        private Dictionary<string, ClassRoom> _school = new Dictionary<string, ClassRoom>();
        public SchoolView()
        {
            this.Banner = "Currently Editing Classrooms.";
            this.AddMenuItem(new MenuItem("1", "Show Classrooms", this.ShowClassrooms));
            this.AddMenuItem(new MenuItem("2", "Add Classrooms", this.AddClassroom));
            this.AddMenuItem(new MenuItem("3", "Remove Classroom", this.RemoveClassroom));
            this.AddMenuItem(new MenuItem("4", "Classroom Details Menu", this.RunClassroomMenu));
            this.AddMenuItem(new MenuItem("99", "Exit Application", this.Exit));
        }

        private void ShowClassrooms()
        {
            foreach (ClassRoom classroom in this._school.Values)
            {
                Console.WriteLine(classroom.Name);
            }
        }
        private void AddClassroom()
        {
            Console.WriteLine("Please Enter the name of the Class Room you wish to add: ");
            string room = Console.ReadLine();
            this._school.Add(room, new ClassRoom(room));
            Console.WriteLine($"{room} was added.");
        }

        private void RemoveClassroom()
        {
            this.ShowClassrooms();
            Console.WriteLine("Please Enter the name of the classroom you wish to remove: ");
            string room = Console.ReadLine();
            this._school.Remove(room);
            Console.WriteLine($"{room} was removed.");
        }

        private void RunClassroomMenu()
        {
            this.ShowClassrooms();
            Console.WriteLine("Please Enter the name of the classroom you wish to see details of: ");
            string room = Console.ReadLine();
            ClassRoom cr = this._school[room];
            ClassroomView sm = new ClassroomView(cr);
            sm.Run();
        }
    }
}
