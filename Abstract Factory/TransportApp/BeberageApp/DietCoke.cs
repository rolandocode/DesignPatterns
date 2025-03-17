using BeberageApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeberageApp
{
	public class DietCoke : ICoke
	{
		public void Drink()
		{
			Console.WriteLine("Drinking diet coke...");
		}
	}

}
