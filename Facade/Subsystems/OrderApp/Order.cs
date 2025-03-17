using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
	public class OrderFacade
	{

		private Product _product;
		private Invoice _invoice;
		private Payment _payment;
		private long _orderNumber;

        public OrderFacade(Product product, Invoice invoice, Payment payment, long orderNumber)
        {
			_product = product;
			_invoice = invoice;
			_payment = payment;
        }

        public void PerformOrder()
		{
			Console.WriteLine("Place Order Started");
			//Get the Product Details
			_product.GetProductDetails();
			//Make the Payment
			_payment.MakePayment();
			//Send the Invoice
			_invoice.SendInvoice();
			Console.WriteLine("Order Placed Successfully");
		}
	}
}
