using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAPYaz.Model
{
    class Course
    {
        private int courseID;
        private string name;
        private int credit;

        public Course(int courseID, string name, int credit)
        {
            this.courseID = courseID;
            this.name = name;
            this.credit = credit;
        }
    }
}
