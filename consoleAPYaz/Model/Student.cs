using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace consoleAPYaz.Model
{
    class Student:Person
    {
        int studentID;
        int programID;
        int semesterID;
        public Student()
        {

        }

        public Student(int studentID, string firstName, string lastName, string gender, 
            string email, string password, string address, DateTime dateOfBirth, 
            int departmentID, int programID, int semesterID)
            :base(firstName, lastName, gender,email, password, address, dateOfBirth,
            departmentID)
        {
            this.studentID = studentID;
            this.studentID = studentID;
            this.programID = programID;
            this.semesterID = semesterID;
        }

        public void Display()
        {
            Console.WriteLine($"ID = {studentID} \tName = {firstName} {lastName}\t Department = {departmentID}");
        }
    }
}
