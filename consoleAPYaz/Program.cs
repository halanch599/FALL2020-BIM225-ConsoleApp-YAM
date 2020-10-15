using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAPYaz
{
    class Program
    {
        static void Main(string[] args)
        {


            // Loops for, while , do-while, foreach

            // arrays
            

            // array initialization
            int[] nums = new int[] {45,65,45,78,90,56,77 };
            int count = nums.Length-1;
            int sum = 0;
            while (count>-1)
            {
                //Console.WriteLine(nums[count]);
                sum += nums[count];
                count--;
            }
            Console.WriteLine("Total Marks = {0}, Average = {1} ",
                sum,(float)sum/nums.Length);
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

            Console.ReadLine();
        }
    }
}
