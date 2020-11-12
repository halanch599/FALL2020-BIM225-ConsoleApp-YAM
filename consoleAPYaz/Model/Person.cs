using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAPYaz.Model
{
    class Person
    {
        //protected shows only in child and parent classes
        protected string firstName;
        protected string lastName;
        protected string gender;
        protected string email;
        protected string password;
        protected string address;
        protected DateTime dateOfBirth;
        protected int departmentID;

        // properties
       
        public string FirstName
        {
            get { return firstName; }
            set {

                if (value == "")
                {
                    throw new Exception("Please enter some string");
                }
                firstName = value; 
            }
        }

        public string getFirstName()
        {
            return firstName;
        }
        public void setFirstName(string val)
        {
            if (val=="")
            {
                throw new Exception("Please enter some string");
            }
            firstName = val;
        }
        public Person()
        {
            //Console.WriteLine("In Person Constructor.");
        }

        public Person(string firstName, string lastName, string gender, 
            string email, string password, string address, DateTime dateOfBirth, 
            int departmentID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.email = email;
            this.password = password;
            this.address = address;
            this.dateOfBirth = dateOfBirth;
            this.departmentID = departmentID;
        }

        public bool Login(string email, string password)
        {
            return true;
        }
    }
}
