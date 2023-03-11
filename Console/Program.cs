// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new InMemory());
foreach (var cars in carManager.GetAll())
{
  
    Console.WriteLine("Car BrandId:"+""+cars.BrandId);
    Console.WriteLine("Car Description:"+""+cars.Description);
    Console.WriteLine("------------------"); ;
; }


