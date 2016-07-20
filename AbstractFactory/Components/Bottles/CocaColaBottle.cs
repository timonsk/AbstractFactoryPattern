using System;
namespace Components.Bottles
{
	using Models;

	public class CocaColaBottle : AbstractBottle
	{
		public CocaColaBottle()
		{
			BottleSize = 10;
		}
		public override int BottleSize { get; set; }

		public override void Interact(AbstractWater water)
		{
			Console.WriteLine(string.Format("{0} size is:{1} and interacts with:{2}", this, BottleSize, water));
			if (water.WaterSize > BottleSize)
			{
				Console.WriteLine(string.Format("To mach water {0} for this bottle {1}", water.WaterSize, BottleSize));
			}
			else if (water.WaterSize < BottleSize)
			{
				Console.WriteLine(string.Format("Not enough water {0} for this bottle {1}", water.WaterSize, BottleSize));
			}
			else
			{
				Console.WriteLine("Excellent! This is what we need!");
			}
		}
	}
}

