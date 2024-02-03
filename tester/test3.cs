/*
using System;
namespace tester
{
	public class test3
	{
        public static void Main(string[] args)
        {
			int fristnumber;
			int lastnumber;
			char operation;


			Console.Write("Please enter number #1 : ");
            fristnumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter number #2 : ");
			lastnumber = Convert.ToInt32(Console.ReadLine());

			Console.Write("Please select operation (+, -, *, /,)");
			operation = Convert.ToChar(Console.ReadLine());
			

			if (operation == '+')
			{
				Console.WriteLine("{0},{1} = {2}", fristnumber, lastnumber, fristnumber + lastnumber);
			}
			else if (operation == '-')
			{
				Console.WriteLine("{0},{1} = {2}", fristnumber, lastnumber, fristnumber - lastnumber);
			}
			else if (operation == '*')
			{
				Console.WriteLine("{0},{1} = {2}", fristnumber, lastnumber, fristnumber * lastnumber);
			}
			else if (operation == '/')
			{
				Console.WriteLine("{0},{1} = {2:N3}",fristnumber,lastnumber, (double)fristnumber / (double)lastnumber);
			}

			else Console.WriteLine("Wrong operation !!!");

        }
	}
}

*/