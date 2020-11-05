using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAPYaz
{
    // public her baska sinif object kulanabilir
    // private: kimse bu sinifin object kullanamaz
    class Student
    {
        //data
        //default private
        public int studentID;
        public string firstName;
        public string lastName;
        public string gender;
        //methods
        //constructor
        //compiler default constructor ekliyor
        //parameter constructor

        public Student()
        {

        }
        public Student(int id,string fname,string lname,string gen)
        {
            studentID = id;
            firstName = fname;
            lastName = lname;
            gender = gen;
        }
    }
}
