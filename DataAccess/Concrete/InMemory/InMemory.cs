using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemory : ICarDal
    {

        List<Car> _cars;

        public InMemory()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=183,ColorId=2,ModelYear=1999,DailyPrice=220,Description="Latest model Ssangyong"},
                new Car{CarId=2,BrandId=710,ColorId=2,ModelYear=2011,DailyPrice=360,Description="Latest model Citroen"},
                new Car{CarId=3,BrandId=142,ColorId=3,ModelYear=2018,DailyPrice=550,Description="Latest model Mercedes Benz"},
                new Car{CarId=4,BrandId=260,ColorId=3,ModelYear=2020,DailyPrice=790,Description="Latest model Chevrolet"},
                new Car{CarId=5,BrandId=312,ColorId=1,ModelYear=2022,DailyPrice=110,Description="Latest model Audi"},

            };
        }

        public void Add(Car car)
        {
           _cars.Add(car);  
        }

        public void Delete(Car car)
        {
           Car carDelete = carDelete = _cars.SingleOrDefault
                (c => c.CarId == car.CarId);
            _cars.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c=>c.CarId==CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = carUpdate = _cars.SingleOrDefault
                (c =>c.CarId==car.CarId);

            carUpdate.BrandId= car.BrandId;
            carUpdate.ColorId= car.ColorId;
            carUpdate.ModelYear= car.ModelYear;
            carUpdate.DailyPrice= car.DailyPrice;
            carUpdate.Description= car.Description;
            
        }
    }
}
