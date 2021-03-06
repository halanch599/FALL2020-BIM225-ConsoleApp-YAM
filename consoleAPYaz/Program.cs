﻿using consoleAPYaz.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;

namespace consoleAPYaz
{
    //value type
    // stack
    //new gerekyok
    //struct Point
    //{
    //    int x;
    //    int y;
    //    float z;

    //    //public Point( int x, int y)
    //    //{
    //    //    this.x = x;
    //    //    this.y = y;
    //    //}
    //    public int X { get => x; set => x = value; }
    //    public int Y { get => y; set => y = value; }
    //    //public void Display()
    //    //{
    //    //    Console.WriteLine($"X = {X} Y = {Y}");
    //    //}
    //}
    // reference type
    // new keywrod
    //

    public interface IBank
    {
        //signature : return type, name, methodparameters
        bool Deposit(int AccountNo, float Amount);
        void Withdraw(int AccountNo, float Amount);
        bool TransferMoney(int SenderAccountNo, int ReceiverAccountNo, float Amount);
    }

   public class Account
    {
        int accountNo;
        string name;
        float balance;

        public Account()
        {

        }
        public Account(int accountNo, string name, float balance)
        {
            this.AccountNo = accountNo;
            this.Name= name;
            this.Balance = balance;
        }

        public int AccountNo { get => accountNo; set => accountNo = value; }
        public string Name { get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty.");
                }
                name = value;
            }
        
        }
        public float Balance { get => balance;

            set
            {
                if (value<0)
                {
                    throw new Exception("Balance cannot be negative.");
                }
                balance = value;
            }

        }

        public void Display()
        {
            Console.WriteLine($"Acc. NO = {AccountNo}, Name = {Name}, Balance={Balance}");
        }
        public void Display(Account acc)
        {
            Console.WriteLine($"Acc. NO = {acc.AccountNo} \tName = {acc.Name}\t Balance={acc.Balance}");
        }
    }
    class IsBank : IBank
    {
        List<Account> dbAccount;
        public IsBank()
        {
            dbAccount = new List<Account>();
        }
        public void CreateAccount(string name,float amount=0.0f)
        {
            try
            {
                Account account = new Account(dbAccount.Count + 1, name, amount);
                dbAccount.Add(account);
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating account. \n" + ex.Message);
            }
        }

        private int SearchByAccountNo(int AccNo)
        {
            try
            {
                int Index= -1;

                for (int i = 0; i < dbAccount.Count; i++)
                {
                    if (dbAccount[i].AccountNo==AccNo)
                    {
                        Index = i;
                        break;
                    }
                }

                return Index;
            }
            catch (Exception)
            {
                throw new Exception("Error in Search by Account.");
            }
        }
        public void Display()
        {
            try
            {
                foreach (Account account in dbAccount)
                {
                    account.Display();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in displaying account details.");
            }
        }
        public bool Deposit(int AccountNo, float Amount)
        {
            try
            {
                var index = SearchByAccountNo(AccountNo);
                if (index<0)
                {
                    throw new Exception("Account No is invalid.");
                }

                if (Amount<0)
                {
                    throw new Exception("Amount cannot be negative.");
                }

                dbAccount[index].Balance += Amount;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public bool TransferMoney(int SenderAccountNo, int ReceiverAccountNo, float Amount)
        {
            try
            {
                var indexSender = SearchByAccountNo(SenderAccountNo);
                var indexReceiver = SearchByAccountNo(ReceiverAccountNo);

                if (indexSender < 0 || indexReceiver<0)
                {
                    throw new Exception("Sener/Receiver Account No is invalid.");
                }

                if (Amount < 0)
                {
                    throw new Exception("Sender amount cannot be negative.");
                }

                if (dbAccount[indexSender].Balance < Amount)
                {
                    throw new Exception("Sender amount cannot be less than Balance.");
                }

                dbAccount[indexSender].Balance -= Amount;
                dbAccount[indexReceiver].Balance += Amount;

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Withdraw(int AccountNo, float Amount)
        {
            try
            {
                var index = SearchByAccountNo(AccountNo);
                if (index < 0)
                {
                    throw new Exception("Account No is invalid.");
                }

                if (Amount < 0)
                {
                    throw new Exception("Amount cannot be negative.");
                }

                if (dbAccount[index].Balance<Amount)
                {
                    throw new Exception("Amount cannot be less than Balance.");
                }

                dbAccount[index].Balance -= Amount;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    class AkBank : IBank
    {
        public bool Deposit(int AccountNo, float Amount)
        {
            throw new NotImplementedException();
        }

        public bool TransferMoney(int SenderAccountNo, int ReceiverAccountNo, float Amount)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(int AccountNo, float Amount)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        // Fibonacci Series
        // 1 1 2 3 5 8 13 21
        static void Main(string[] args)
        {

            try
            {
                //poymorphism

                //Student s = new Student();
                //s.Login("std","123");

                //Employee e = new Employee();
                //e.Login("admin","123");


                Student s = new Student();
                s.FirstName = "Ali";
                s.Login("", "");
                s.Logout(s);


                Employee e = new Employee();
                e.FirstName = "Habib";
                e.Logout(e);

                //Person p = new Person();   // Abstract 

                //Person p1 = new Student();
                //p1.FirstName = "Ali";

                //Person p2 = new Employee();
                //p2.FirstName = "Habib";


                //IsBank isBank = new IsBank();
                //isBank.CreateAccount("Ali Oguz",300);
                //isBank.CreateAccount("Anila Qazi", 100);
                //isBank.CreateAccount("Nisar Ali", 600);
                //isBank.Display();

                ////isBank.Deposit(1, 500);
                ////isBank.Withdraw(1, 100);
                //Console.WriteLine();

                ////isBank.Display();

                //Console.WriteLine();
                //if(isBank.TransferMoney(3, 1, 200))
                //    Console.WriteLine("Transfer completed successfully.");
                //else
                //    Console.WriteLine("Transfer was not successfull.");
                //isBank.Display();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




            Console.ReadLine();


            //Point p  = new Point();
            //p.X = 10;
            //p.Y = 20;
            // p.Display();

            //Person p = new Person();
            //p.FirstName = "Ali";
            //p.LastName = "Halid";

            //p.AddressTest = new Person.addressTest("Street 121", "Halkali", "Turkey");
            //Console.WriteLine(p.Name);
            //Console.WriteLine(p.Name.Length);
            //p.AddressTest.City = "Istanbul";
            //Console.WriteLine(p.AddressTest.Address);

            //Student s = new Student(1,"ali","halid","Male","ali@izu,edu.tr","123",
            //    "Halkali Campus",DateTime.Now,101,1,5);
            //s.Display();
            //s.FirstName = "Muhammad Ali";
            //Console.WriteLine(s.FirstName);
            //Employee e = new Employee();
            // var result =  e.Login("admin@izu.edu.tr", "123");
            //var tax = e.CalculateTax(1);
            // Student snew = new Person();

            //Course c1 = new Course(201, "Visual Programming", 4);
            //Department department = new Department(201, "Software Engineering");
            //department.Display();
            // Week 5-2

            // object oriented programming
            // class

            //Student s1 = new Student();
            ////s1.studentID = 10;
            //s1.firstName = "Ali";
            //s1.lastName = "Halid";
            ////s1.gender = "Male";

            //Student s2 = new Student();
            //s2.studentID = 11;
            //s2.firstName = "Anil";
            //s2.lastName = "Khan";
            //s2.gender = "Female";

            ////Student s3 = new Student(1, "Ali", "Halid", "Male");
            ////Student s4 = new Student(2, "Anila", "Khan", "Female");


            //Console.WriteLine($"Id= {s1.studentID}," +
            //    $"Name = {s1.firstName} {s1.lastName},Gender={s1.gender}");

            //Console.WriteLine($"Id= {s2.studentID}," +
            //   $"Name = {s2.firstName} {s2.lastName},Gender={s2.gender}");








            // Exception Handle
            // bir try ile birden fazla catch olabilir
            // try enaz bir catch lazim
            // try catch

            //string path1 = @"F:\test.txt";

            //try
            //{
            //    //var data = File.ReadAllText(path1);
            //  string []data=  File.ReadAllLines(path1);
            //    // Research about following 
            //    //File.WriteAllText
            //    //File.WriteAllLines
            //    //File.WriteAllBytes  

            //    foreach (var str in data)
            //    {
            //        Console.WriteLine(str);
            //    }
            //    //Console.WriteLine(data);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //if (File.Exists(path1))
            //{
            //    File.Delete(path1);
            //    //throw new Exception("This document is used by another program.");
            //}

            //StreamWriter writer = new StreamWriter(path1,true);

            //try
            //{
            //    writer.WriteLine("Welcome to IZU");
            //    writer.WriteLine("Welcome to Visual Programming");
            //    writer.WriteLine("Please do your home work.");
            //    writer.WriteLine("Do your project proposal.");
            //    writer.Flush();
            //    Console.WriteLine("Filed written successfully.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error:" + ex.Message);
            //}
            //finally
            //{
            //    writer.Close();
            //}
            //    string path = @"F:\data.txt";
            //    StreamReader reader = new StreamReader(path);
            //try
            //{
            //    while (reader.Peek()>=0)
            //    {
            //        Console.WriteLine(reader.ReadLine());
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    reader.Close();
            //}
            //try
            //{
            //    int[] ar = new int[] { 1, 2, 3 };
            //    ar[10] = 10;
            //    string str = "15X";
            //    int num = int.Parse(str);

            //    Console.WriteLine(num);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    //Console.WriteLine("Bi hata oldu.");
            //}


























            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(1);
            //// String List

            //List<string> students = new List<string> {
            //"Ali Halid", "Husain Khan", "Donald Trump"
            //};

            //if (SearByName(students,"khAn"))
            //{
            //    Console.WriteLine("Yes Found");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found.");
            //}
            //if (students.Contains("Donald Trump"))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No.");
            //}

            //DisplayList(students);
            //// Int List:
            //List<int> nums = new List<int>();
            //nums.Add(10);
            //nums.Add(2);
            //nums.Add(15);
            //nums.Add(4);
            //nums.Add(1);


            //int[] elements = new int[]{100,54,80 };
            //nums.AddRange(elements);

            ////Console.WriteLine("Average:" + nums.Average());
            ////Console.WriteLine("Contains:" + nums.Contains(100));
            ////Console.WriteLine("Max:" + nums.Max());
            ////Console.WriteLine("Min:" + nums.Min());
            ////Console.WriteLine("Sum:" + nums.Sum());

            //DisplayList(nums);
            //nums.Sort();
            //DisplayList(nums);
            //for (int i = 0; i < nums.Count; i++)
            //{
            //    //Console.Write(" ");
            //    Console.Write(nums[i] + " ");
            //}
            //nums.Add(elements[0]);
            //nums.Add(elements[1]);
            //nums.Add(elements[2]);

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    //Console.Write(" ");
            //    Console.Write(nums[i] +" ");
            //}

            //Console.WriteLine("");
            ////nums.Remove(100);
            //// lambda Expression
            ////var count = nums.RemoveAll(x => x > 50);
            ////nums.RemoveAt(3);
            //nums.RemoveRange(0, 3);

            ////nums.Reverse();
            //for (int i = 0; i < nums.Count; i++)
            //{
            //    Console.Write(nums[i] + " ");
            //}


            //int[]array =  nums.ToArray();

            //var array = nums.ToArray();

            //Console.WriteLine(nums.Count);

            //nums.Clear();

            //Console.WriteLine(nums.Count);

            //nums.Add(100);
            //Console.WriteLine(nums.Count);

            // Loops for, while , do-while, foreach

            // arrays


            //// array initialization
            //int[] nums = new int[] {45,65,45,78,90,56,77 };
            //int count = nums.Length-1;
            //int sum = 0;
            //while (count>-1)
            //{
            //    //Console.WriteLine(nums[count]);
            //    sum += nums[count];
            //    count--;
            //}
            //Console.WriteLine("Total Marks = {0}, Average = {1} ",
            //    sum,(float)sum/nums.Length);
            //foreach (int n in nums)
            //{
            //    Console.WriteLine(n);
            //}
            //int[] nums = new int[5];
            //nums[0] = 50;
            //nums[1] = 10;
            //nums[2] = 95;
            //nums[3] = -9;
            //nums[4] = 5;
            // break continue
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    //if (nums[i]<0)
            //    //{
            //    //    break;
            //    //}

            //    if (nums[i] < 0)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(nums[i]);
            //    //else
            //    //{
            //    //    continue;
            //    //}
            //    //if (nums[i] % 2 == 0)
            //    //{
            //    //    Console.WriteLine(nums[i]);
            //    //}
            //}
            //// if -else

            //int Days = 3;

            //// switch
            //switch (Days)
            //{
            //    case 0:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 1:
            //    case 5:
            //        Console.WriteLine("Tuesaday & Saturday");
            //        break;
            //    case 3:
            //    case 4:
            //        Console.WriteLine("Wednesday & Thursday");
            //        break;
            //    default:
            //        Console.WriteLine("Holiday.");
            //        break;
            //}
            // Ternary operator

            //var result = x % 2 == 0 ? "Even" : "Odd";
            //Console.WriteLine(result);
            //if (x%2==0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}
            //Console.WriteLine("Welcome to Console Application.");
            // case sensitive
            //int x = 10, X = 20;
            //int y = x + X;
            //float a = 1.05f;
            //double score = 150.36;

            //Console.WriteLine(y);
            //Console.WriteLine(a);
            //Console.WriteLine(score);

            //Console.WriteLine("Int = {0}, Float = {1}, Double ={2}",y,a,score);

            //Console.WriteLine("Enter Your Name:");
            //string email = "akhtar@izu.edu.tr";
            //int indexAt = email.IndexOf("@");

            //var sub = email.Substring(indexAt + 1,3);
            //Console.WriteLine(sub);


            //Console.WriteLine(email.IndexOf('@'));
            //Console.WriteLine(email.LastIndexOf('@'));


            //int indexLastAt = email.LastIndexOf('@');

            //if ((indexAt==-1)|| (indexAt != indexLastAt) )
            //{
            //    Console.WriteLine("Incorrect Email format");
            //}
            //else
            //{
            //    Console.WriteLine("Email is correct.");
            //}
            //Console.WriteLine(email[email.Length-1]);

            //if(email.Contains("@") && email.Contains(".") )
            //{
            //    Console.WriteLine("Correct");
            //}
            //if (name.EndsWith("key"))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}



            //string newName = name.Replace("P", "X");
            //Console.WriteLine(newName);


            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.ToLower());



            //if (name.Contains("A") || name.Contains("a"))
            //if (name.ToUpper().Contains("KISTAN") )
            //{
            //    Console.WriteLine("Var");
            //}
            //else
            //{
            //    Console.WriteLine("Yok");
            //}
            //name = Console.ReadLine();


            //if (name.Length<6)
            //{
            //    Console.WriteLine("Please enter more than 6 characters.");
            //}
            //else
            //{
            //    Console.WriteLine(name);
            //}

        }

        ////// method overloading
        ////static void DisplayList(List<int> list)
        ////{
        ////    for (int i = 0; i < list.Count; i++)
        ////    {
        ////        Console.Write(list[i] + " ");
        ////    }
        ////    Console.WriteLine("");
        ////}

        ////static void DisplayList(List<string> list)
        ////{
        ////    foreach (string name in list)
        ////    {
        ////        //Console.WriteLine("Welcome, " + name.ToUpper());
        ////        Console.WriteLine($"Welcome,  {name.ToUpper()}");
        ////        //Console.WriteLine("Welcome, {0}",name.ToUpper());
        ////    }
        ////}

        ////static bool SearByName(List<string> list,string name)
        ////{
        ////    bool result = false;
        ////    foreach (string str in list)
        ////    {
        ////        if (str.ToLower().Contains(name.ToLower()))
        ////        {
        ////            result = true;
        ////            break;
        ////        }
        ////    }

        ////    return result;
        ////}
        ////static void Fibonacci(List<int> list)
        ////{

        ////}
    }
}
