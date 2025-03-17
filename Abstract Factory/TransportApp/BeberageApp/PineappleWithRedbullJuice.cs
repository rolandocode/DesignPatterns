using BeberageApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeberageApp
{
	public class PineappleWithRedbullJuice : IJuice
	{
		public void Drink()
		{
			Console.WriteLine("Dinking juice with redbull... and I have a high hearbeat!!");
		}
	}
}
