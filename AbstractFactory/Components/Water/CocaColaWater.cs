using System;
namespace Components.Water
{
	using Models;

	public class CocaColaWater : AbstractWater
	{
		public CocaColaWater()
		{
			var rnd = new Random();
			WaterColor = "Lite Black";
			WaterSize = rnd.Next(0,20);
		}

		public override string WaterColor { get; set; }

		public override int WaterSize { get; set; }
	}
}

