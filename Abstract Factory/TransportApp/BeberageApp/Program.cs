// See https://aka.ms/new-console-template for more information
using BeberageApp;

Console.WriteLine("Hello, World!");


var healthyDrinks = new HealthyDrinks();
healthyDrinks.DrinkCoke().Drink();
healthyDrinks.DrinkJuice().Drink();

var unhealtyDrinks = new UnhealthyDrinks();
unhealtyDrinks.DrinkCoke().Drink();
unhealtyDrinks.DrinkJuice().Drink();