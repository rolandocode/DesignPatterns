using BeberageApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeberageApp
{
	public class UnhealthyDrinks : IUnhealthyDrinks
	{
		public ICoke DrinkCoke()
		{
			return new RegularCoke();
		}

		public  IJuice DrinkJuice()
		{
			return new PineappleWithRedbullJuice();
		}
	}
}
