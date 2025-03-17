// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using SingletonApp;

Console.WriteLine("Hello, World!");


CarEngine.Instance.Run();


Cat.Instance.move();
Cat.Instance.move();