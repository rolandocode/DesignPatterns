using BeberageApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeberageApp
{
	public class KiwiJuice : IJuice
	{
		public void Drink()
		{
			Console.WriteLine("Drinking Kiwi juice!");
		}
	}
}
