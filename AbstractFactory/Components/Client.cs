
namespace Components
{
	using Models;

	public class Client
	{
		private AbstractWater abstractWater;
		private AbstractBottle abstractBottle;

		public Client(AbstractFactory factory)
		{
			abstractWater = factory.CreateWater();
			abstractBottle = factory.CreateBottle();
		}

		public void Run() 
		{
			abstractBottle.Interact(abstractWater);
		}
	}
}

