using BeberageApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeberageApp
{
	public class RegularCoke : ICoke
	{
		public void Drink()
		{
			Console.WriteLine("Dinking original mexican Coca cola");
		}
	}
}
