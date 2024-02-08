using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Manager_OO
{
    public class Assignment
    {
        public string Name { get; }

        private double _grade = 0;
        public bool CompletionStatus { get; private set; } = false;
        public double Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                _grade = value;
                if (Grade >= 0)
                {
                    CompletionStatus = true;
                    
                }
            }
        }
        public Assignment(string assignmentName)
        {
            this.Name = assignmentName;
        }
    }
}
