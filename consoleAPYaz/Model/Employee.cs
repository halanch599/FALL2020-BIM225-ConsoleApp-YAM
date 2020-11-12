using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAPYaz.Model
{
    // bi object ve birden fazla parent: Multiple Inheritance
    //C# multiple inheritance izin verimiyor
    // multi-level inheritance
    class Employee:Manager
    {
        public  int employeeID;
        public float salary;
        public string role;
        public float tax;
        public Employee()
        {
            //Console.WriteLine("In Employee Constructor.");
        }

        public double CalculateTax(int employeeID)
        {
            Random r = new Random();
            return r.NextDouble()%100.0f;
        }
    }
    
}
