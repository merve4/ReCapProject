// See https://aka.ms/new-console-template for more information

using Business.Abstract;
using Business.Concrete;
using Business.Constants;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System.Net.Http.Headers;

//veritabanına ekleme-silme-güncelleme başarılı

//AddUpdateDelete();


//CategoryQuery();

Rentals rentals = new Rentals()
{
    RentalId = 1,
    CarId = 1,
    CustomerId = 1,
    RentDate = DateTime.Now,
    ReturnDate = DateTime.Now,
};

Rentals rentals1 = new Rentals()
{
    RentalId = 2,
    CarId = 2,
    CustomerId = 2,
    RentDate = DateTime.Now,
    ReturnDate = DateTime.Now,
};
RentalManager rentalManager = new RentalManager(new EfRentalDal());
rentalManager.Add(rentals);
rentalManager.Add(rentals1);

var result=rentalManager.GetAll();
if (result.Success == true)
{
    foreach (var rent in result.Data)
    {
        Console.WriteLine(rent.CarId+" "+rent.RentalId+" "+rent.CustomerId+" "+rent.RentDate+" "+rent.ReturnDate);
    }
}
else
{
    Console.WriteLine(Messages.RentalError);
}



CarManager carManager = new CarManager(new EfCarDal());
foreach (var car in carManager.GetCarDetails().Data)
{
    Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
}



static void AddUpdateDelete()
{
    CarManager carManager = new CarManager(new EfCarDal());

    CarDbContext carDbContext = new CarDbContext();
    carManager.Update(new Car
    {
        BrandId = 10,
        CarName = "Ferrari",
        CarId = 10,
        ColorId = 10,
        DailyPrice = 10000,
        Description = "4-door, automatic, air-conditioned, adjustable seat",
        ModelYear = 2018

    });
    foreach (var car in carManager.GetAll().Data)
    {
        Console.WriteLine(car.CarName);
        Console.WriteLine(car.CarId);
        Console.WriteLine(car.Description);
        Console.WriteLine(car.DailyPrice);
    }
}

static void CategoryQuery()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}


//foreach (var cars in carDbContext.Brands)
//{

//    Console.WriteLine("Car BrandName:"+""+cars.BrandName);
//    Console.WriteLine("Car BrandId: "+ ""+cars.BrandId);

//    ; }








