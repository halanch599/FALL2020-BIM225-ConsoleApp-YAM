using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAPYaz.Model
{
    class Course
    {
        int courseID;
        string name;
        int credit;

        public Course(int courseID, string name, int credit)
        {
            this.courseID = courseID;
            this.name = name;
            this.credit = credit;
        }
    }
}
