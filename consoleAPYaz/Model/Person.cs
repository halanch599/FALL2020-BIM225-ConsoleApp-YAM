using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAPYaz.Model
{
    public abstract class Person
    {
        //protected shows only in child and parent classes
        private string firstName;
        private string lastName;
        private string gender;
        private string email;
        private string password;
        private string address;// street City state Zip Code Country
        private DateTime dateOfBirth;
        private int departmentID;

        public addressTest AddressTest { get; set; }
        public class addressTest
        {
            private string street;
            private string city;
            private string zip;
            private string country;

            public addressTest(string street, string city, string country, string zip = "")
            {
                this.street = street;
                this.city = city;
                this.zip = zip;
                this.country = country;
            }
            public string Address {
                get
                    { 
                        return street + " " + city + " " + zip + " " + Country;
                    }
            }
            public string Street { get => street; set => street = value; }
            public string City { get => city; set => city = value; }
            public string Zip { get => zip; set => zip = value; }
            public string Country { get => country; set => country = value; }
        }
        // properties

        public string   Name
        {
            get { return firstName + " " + lastName; }
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Address { get => address; set => address = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public int DepartmentID { get => departmentID; set => departmentID = value; }


        //public string getFirstName()
        //{
        //    return firstName;
        //}
        //public void setFirstName(string val)
        //{
        //    if (val=="")
        //    {
        //        throw new Exception("Please enter some string");
        //    }
        //    firstName = val;
        //}
        public Person()
        {
            //Console.WriteLine("In Person Constructor.");
        }

        public Person(string firstName, string lastName, string gender, 
            string email, string password, string address, DateTime dateOfBirth, 
            int departmentID)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.Email = email;
            this.Password = password;
            this.Address = address;
            this.DateOfBirth = dateOfBirth;
            this.DepartmentID = departmentID;
        }

        //public abstract void Login(string email, string password);
        public virtual  void Login(string email, string password)
        {
            if (email=="admin" && password=="123")
            {
                Console.WriteLine("Welcome, Admin.");
            }
            //if (email == "std" && password == "123")
            //{
            //    Console.WriteLine("Welcome, Student.");
            //}
        }

        public void Logout(Person p)
        {
            try
            {
                if (p is Employee)
                {
                    Console.WriteLine($"Thank you {p.firstName}. You are Employee.");
                }
                if (p is Student)
                {
                    Console.WriteLine($"Thank you {p.firstName}. You are Student.");
                }
            }
            catch (Exception )
            {
                throw new Exception("Error in logout.");
            }
        }
    }
}
