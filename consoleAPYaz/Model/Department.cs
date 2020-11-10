using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAPYaz.Model
{
    class Department
    {
        int departmentID;
        string name;

        public Department(int departmentID, string name)
        {
            this.departmentID = departmentID;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine($"ID = {departmentID}, Name  = {name}");
        }
    }
}
