﻿using System;
namespace Models
{
	public abstract class AbstractFactory
	{
		public abstract AbstractWater CreateWater();
		public abstract AbstractBottle CreateBottle();
	}
}

