﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportApp.Interfaces;

namespace TransportApp
{
	public class RegularBike : IBike
	{
		public void GetDetails()
		{
			Console.WriteLine("Fetching RegularBike Details..");
		}
	}
}
