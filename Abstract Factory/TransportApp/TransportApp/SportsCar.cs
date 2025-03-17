using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportApp.Interfaces;

namespace TransportApp
{
	public class SportsCar : ICar
	{
		public void GetDetails()
		{
			Console.WriteLine("Fetching SportsCar Details..");
		}
	}
}
