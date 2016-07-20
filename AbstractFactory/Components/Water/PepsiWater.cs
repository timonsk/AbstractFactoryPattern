using System;
namespace Components.Water
{
	using Models;

	public class PepsiWater: AbstractWater
	{
		public PepsiWater()
		{
			var rnd = new Random();
			WaterColor = "Dark Black";
			WaterSize = rnd.Next(0, 20);
		}

		public override string WaterColor { get; set; }

		public override int WaterSize { get; set; }
	}
}

