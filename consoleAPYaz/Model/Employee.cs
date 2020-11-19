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
   public class Employee:Person
    {
        int employeeID;
        float salary;
        string role;
        float tax;
        public Employee()
        {
            //Console.WriteLine("In Employee Constructor.");
        }

        public Employee(string firstName, string lastName, string gender, string email, 
            string password, string address, DateTime dateOfBirth, int departmentID,
            int employeeID, float salary, string role, float tax) 
            : base(firstName, lastName, gender, email, password, address, dateOfBirth, departmentID)
        {
            this.EmployeeID = employeeID;
            this.Salary = salary;
            this.Role = role;
            this.Tax = tax;
        }

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public float Salary { get => salary; set => salary = value; }
        public string Role { get => role; set => role = value; }
        public float Tax { get => tax; set => tax = value; }

        //public override void Login(string email, string password)
        //{
        //    try
        //    {
        //        if (email == "admin" && password == "123")
        //        {
        //            Console.WriteLine("Welcome, Admin.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Username or password is incorrect.");

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error in Login.");
        //    }
        //}
    }
    
}
