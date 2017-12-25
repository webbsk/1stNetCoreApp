using System;
using logic;
using Wintellect.PowerCollections;

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
			
			var data = new Bag<int>() {1,2,3};
			foreach (var element in data)
			{
				Console.WriteLine(element);
			}
			Console.WriteLine("Done!");
			Console.ReadKey();
		}
	}
}
