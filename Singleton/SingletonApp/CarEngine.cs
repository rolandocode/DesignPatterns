using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
	public class CarEngine
	{
		private static CarEngine _instance;
		private static CarEngine _instance2;
   
        public static CarEngine Instance
		{
			get
			{
				if (_instance == null)
					_instance = new CarEngine();

				return _instance;
			}
		}

		public void Run()
		{
			Console.WriteLine("Run ruuuun!");
		}

	}
}
