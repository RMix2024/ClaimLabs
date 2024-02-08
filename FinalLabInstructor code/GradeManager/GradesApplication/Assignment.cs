using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesApplication
{
    public class Assignment : IComparable<Assignment>
    {
        public string Name { get; }
        double _grade = 0;
        public double Grade 
        {
            get 
            {
                return _grade;
            }
            set
            {
                this.IsComplete = true;
                _grade = value;
            }
        } 
        public bool IsComplete { get; private set; } = false;

        public Assignment(string name)
        {
            this.Name = name;
        }

        public Assignment(string name, double grade)
        {
            this.Name = name;
            this.Grade = grade;
        }

        static public bool operator <(Assignment one, Assignment two)
        {
            return one.Grade < two.Grade;
        }

        static public bool operator >(Assignment one, Assignment two)
        {
            return one.Grade > two.Grade;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Assignment Details");
            sb.AppendLine($"Name:  {this.Name}");
            sb.AppendLine($"Grade:  {this.Grade}");
            sb.AppendLine($"IsComplete:  {this.IsComplete}");
            return sb.ToString();
        }

        public int CompareTo(Assignment other)
        {
            if (other == null) return 1;
            return this.Grade.CompareTo(other.Grade);
        }
    }
}
