using System;

namespace Myproject
{
	public class Student
	{
		int rollUpdated, totalUpdated;
		string nameUpdated, genderUpdated;
		public int Roll { get; set; }
		public int Total { get; set; }
		public string Name { get; set; }
		public string Gender{ get; set; }

		public void GetDetails()
		{
			
			Console.WriteLine("Enter the Roll No:");
			Roll = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the Name:");
			Name = Console.ReadLine();
			Console.WriteLine("Enter the Gender:");
			Gender = Console.ReadLine();
			Console.WriteLine("Enter the Total Marks:");
			Total = int.Parse(Console.ReadLine());
			Console.WriteLine("Successfully Added the details:");
		}
		public void DisplayDetails()
		{
			Console.WriteLine("Roll No:"+ Roll);
			Console.WriteLine("Name:" + Name);
			Console.WriteLine("Gender:" + Gender);
			Console.WriteLine("Total Marks:" + Total);
		}
		public void UpdateDetails()
		{
			Console.WriteLine("Enter the value to update Name/Gender/Roll/Total");
			String valueToEdit = Console.ReadLine();
            if (valueToEdit == "Roll")
            {
				Console.WriteLine("Enter the new Roll number");
				rollUpdated = int.Parse(Console.ReadLine());
				Roll = rollUpdated;
			}
			else if(valueToEdit == "Name")
            {
				Console.WriteLine("Enter the new Roll number");
				nameUpdated = Console.ReadLine();
				Name = nameUpdated;
			}
			else if (valueToEdit == "Gender")
			{
				Console.WriteLine("Enter the new Gender");
				genderUpdated = Console.ReadLine();
				Gender = genderUpdated;
			}
			else if (valueToEdit == "Total")
			{
				Console.WriteLine("Enter the new Totalmark");
				totalUpdated = int.Parse(Console.ReadLine());
				Total = totalUpdated;
			}
		}
		public void DeleteDetails()
		{
			Console.WriteLine("Enter the value to Delete Name/Gender/Roll/Total");
			//String valueToDelete = Console.ReadLine();
			/*if (valueToDelete == "Name")
            {
				Name.Remove();

            }*/

		}

	}
}

