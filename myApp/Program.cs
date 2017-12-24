using System;
using logic;

namespace myApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.Write("What's your name: ");
			var name = Console.ReadLine();
			var message = HelloWorld.GetMessage(name);
			Console.WriteLine(message);
		}
	}
}
