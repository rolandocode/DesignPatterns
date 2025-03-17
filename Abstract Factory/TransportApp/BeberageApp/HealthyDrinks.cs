using BeberageApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeberageApp
{
	public class HealthyDrinks : IHealthyDrinks
	{
		public ICoke DrinkCoke()
		{
			return new DietCoke();
		}

		public IJuice DrinkJuice()
		{
			return new KiwiJuice();
		}
	}
}
