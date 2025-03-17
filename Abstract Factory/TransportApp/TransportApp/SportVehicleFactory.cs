using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportApp.Interfaces;

namespace TransportApp
{
	internal class SportVehicleFactory : IVehicleFactory
	{
		public IBike CreateBike()
		{
			return new SportBike();
		}

		public ICar CreateCar()
		{
			return new SportsCar();
		}
	}
}
