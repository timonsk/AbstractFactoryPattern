
namespace Components
{
	using Models;
	using Bottles;
	using Water;

	public class PepsiFactory : AbstractFactory
	{
		public override AbstractBottle CreateBottle()
		{
			return new PepsiBottle();
		}

		public override AbstractWater CreateWater()
		{
			return new PepsiWater();
		}
	}
}

