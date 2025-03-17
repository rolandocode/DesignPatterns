// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using OrderApp;

Console.WriteLine("Hello, World!");

var services = new ServiceCollection();

services.AddTransient<Invoice>();
services.AddTransient<Product>();
//This is how we can make a parametrized DI instance
services.AddTransient<Payment>(provider => new Payment(0.01));


services.AddTransient<OrderFacade>(prov =>
{
	var product = prov.GetRequiredService<Product>();
	var invoice = prov.GetRequiredService<Invoice>();
	var payment = prov.GetRequiredService<Payment>();
	long orderNumber = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

	return new OrderFacade(product, invoice, payment, orderNumber);
});

var serviceBuilder =  services.BuildServiceProvider();

var orderServiceFacade = serviceBuilder.GetService<OrderFacade>();
orderServiceFacade.PerformOrder();