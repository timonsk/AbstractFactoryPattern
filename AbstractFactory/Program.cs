using System;
using Models;
using Components;

namespace AbstractFactory
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var clientCocaCola = new Client(new CocaColaFactory());
			var clientPepsi = new Client(new PepsiFactory());

			clientCocaCola.Run();
			clientPepsi.Run();

			Console.ReadKey();
		}
	}
}
