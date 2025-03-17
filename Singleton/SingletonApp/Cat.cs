using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
	public class Cat : ICat
	{
		private static ICat _instance;

		public static ICat Instance
		{
			get
			{
				if (_instance == null)
					return _instance = new Cat(); ;

				return _instance;

			}
		}

		public void move()
		{
			Console.WriteLine("Meow meeeeow!");
		}
	}
}
