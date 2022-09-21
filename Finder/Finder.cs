//this one is the ui
using System;
using System.Collections.Generic;
using Calculator.Models;

namespace Calculator
{
	public class Program
	{
		public static void Main()
    {
      Console.WriteLine("Enter a Month, Day, and Year in numbers and get the day of the week for that day");
      Console.WriteLine("Month:");
      int m = Int32.Parse(Console.ReadLine());
      Console.WriteLine("Day:");
      int d = Int32.Parse(Console.ReadLine());
      Console.WriteLine("Year:");
      int y = Int32.Parse(Console.ReadLine());
      Voodoo variable = new Voodoo();
      Console.WriteLine(variable.findDay(m, d, y));
    }
  }
}