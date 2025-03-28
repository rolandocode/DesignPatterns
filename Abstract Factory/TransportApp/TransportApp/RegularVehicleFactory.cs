﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportApp.Interfaces;

namespace TransportApp
{
	public class RegularVehicleFactory : IVehicleFactory
	{
		public IBike CreateBike()
		{
			return new RegularBike();
		}

		public ICar CreateCar()
		{
			return new RegularCar();
		}
	}
}
