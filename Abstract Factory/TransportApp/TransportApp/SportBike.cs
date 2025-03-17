using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportApp.Interfaces;

namespace TransportApp
{
	public class SportBike : IBike
	{
		public void GetDetails()
		{
			Console.WriteLine("Fetching SportsBike Details..");
		}
	}
}
