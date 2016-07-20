namespace Components
{
	using Models;
	using Bottles;
	using Water;

	public class CocaColaFactory : AbstractFactory
	{
		public override AbstractBottle CreateBottle()
		{
			return new CocaColaBottle();
		}

		public override AbstractWater CreateWater()
		{
			return new CocaColaWater();
		}
	}
}

