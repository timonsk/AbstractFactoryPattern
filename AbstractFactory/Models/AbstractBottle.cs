using System;
namespace Models
{

	public abstract class AbstractBottle 
	{
		public abstract int BottleSize { get; set; }
		public abstract void Interact(AbstractWater water);
	}
}
