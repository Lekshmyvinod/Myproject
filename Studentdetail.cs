using System;
using System.Linq;
using System.Collections.Generic;

namespace Myproject 
{
	public class Student
    {
        string name, gender;
        int roll,total;
        List<Dictionary<string, string>> students = new List<Dictionary<string, string>>();
        List<Dictionary<string, int>> studentint = new List<Dictionary<string, int>>();
        public void GetDetails()
        {

            Console.WriteLine("Enter the Roll No:");
            roll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of student");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Gender of student");
            gender = Console.ReadLine();
            Console.WriteLine("Enter the totalmark");
            total = Convert.ToInt32(Console.ReadLine());
            students.Add(new Dictionary<string, string>());
            studentint.Add(new Dictionary<string, int>());
            studentint[0].Add("Roll Number", roll);
            students[0].Add("Name", name);
            students[0].Add("Gender", gender);
            studentint[0].Add("Total marks", total);
            Console.WriteLine("Successfully Added Student details");
            for (int i = 0; i < students.Count; i++)
            {

                Console.WriteLine(students[i]["Name"]);
                Console.WriteLine(students[i]["Gender"]);
            }
        }
         public void DisplayDetails()
        {

            for (int i = 0; i < students.Count; i++)
            {
                
                Console.WriteLine(students[i]["Name"]);
                Console.WriteLine(students[i]["Gender"]);
            }

        } 
    }
    class Studentdetails
    {
        public static void Main(string[] args)
        {
            Student std = new Student();
            int Menu;
            Console.WriteLine("Enter the menu");
            Console.WriteLine("1.Add Details/n");
            Console.WriteLine("2.Print student Details/n");
            Console.WriteLine("3.Detele Student Detail/n");
            Console.WriteLine("4.Edit student Details");
            Menu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Menu);
            switch (Menu)
            {

                case 1:
                    std.GetDetails();
                    break;

                case 2:
                    std.DisplayDetails();
                    break;

                case 3:
                    Console.WriteLine("case 3");
                    break;

                case 4:
                    Console.WriteLine("case 4");
                    break;

                default:
                    Console.WriteLine("No menu found");
                    break;
            }
             
        }
    }
}
