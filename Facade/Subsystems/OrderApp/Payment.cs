using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
	public class Payment
	{
		double _minPayment;
        public Payment(double minPayment)
        {
            _minPayment = minPayment;
        }
        public void MakePayment()
		{
			Console.WriteLine("Payment Done Successfully");
		}
	}
}
