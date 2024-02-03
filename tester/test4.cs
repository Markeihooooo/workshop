//using System;
//namespace tester
//{
//	public class test4
//	{
//		public static void Main(string[] agrs)
//		{
//			int selectnumber;
//			int basenumber;
//			int heightnumber;
//			int radius;


//			Console.WriteLine("1: Rectangle \n2:Triangle \n3: Circle");

//			Console.Write("Please select shape to calculate area :");
//			selectnumber = Convert.ToInt32(Console.ReadLine());

//			if (selectnumber == 1)
//			{
//				Console.Write("Please enter base  :");
//				basenumber = Convert.ToInt32(Console.ReadLine());
//				Console.Write("please enter height : ");
//				heightnumber = Convert.ToInt32(Console.ReadLine());

//				Console.WriteLine("Area = {0}", basenumber * heightnumber);


//			}
//			else if (selectnumber == 2)
//			{
//				Console.Write("Please enter base  :");
//				basenumber = Convert.ToInt32(Console.ReadLine());
//				Console.Write("please enter height : ");
//				heightnumber = Convert.ToInt32(Console.ReadLine());

//				Console.WriteLine("Area = {0}", (0.5 * basenumber) * heightnumber);

//			}
//			else if (selectnumber == 3)
//			{
//				Console.Write("please enter height : ");
//				radius = Convert.ToInt32(Console.ReadLine());

//				Console.WriteLine("Area = {0:N2}", Math.PI * Math.Pow(radius, 2));

//			}
//			else Console.WriteLine("Selected number must be 1 - 3");
//		}
//	}
//}

