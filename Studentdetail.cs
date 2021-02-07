using System;
using System.Linq;
using System.Collections.Generic;

namespace Myproject 
{
	class Studentdetails
    {
        public static void Main(string[] args)
        {
            Student std = new Student();
            int Menu;
            Console.WriteLine("Enter the menu");
            Console.WriteLine("1.Add Details/n");
            Console.WriteLine("2.Print student Details/n");
            Console.WriteLine("3.Edit student Details/n");
            Console.WriteLine("4.Detele Student Detail/n");
            Menu = Convert.ToInt32(Console.ReadLine());
            switch (Menu)
            {

                case 1:
                    std.GetDetails();
                    std.DisplayDetails();
                    std.UpdateDetails();
                    std.DisplayDetails();
                    break;

                case 2:
                    std.DisplayDetails();
                    break;

                case 3:
                    std.UpdateDetails();
                    break;

                case 4:
                    std.DeleteDetails(); ;
                    break;

                default:
                    Console.WriteLine("No menu found");
                    break;
            }
             
        }
    }
}
