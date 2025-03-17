using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp.Interfaces
{
	public interface IVehicleFactory
	{
		IBike CreateBike();
		ICar CreateCar();
	}
}
