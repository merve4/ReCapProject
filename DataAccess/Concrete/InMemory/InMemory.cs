using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemory : ICarDal,IUserDal
    {

        List<Car> _cars;
        List<Users> _users;
       

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

        public void Add(Users user)
        {
            _users.Add(user);
        }

       

        public void Delete(Car car)
        {
          _cars.Remove(car);
        }

        public void Delete(Users user)
        {
            _users.Remove(user);
        }


        public Car Get()
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Users Get(Expression<Func<Users, bool>> filter)
        {
            throw new NotImplementedException();
        }

       

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Users> GetAll(Expression<Func<Users, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

       

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c=>c.CarId==CarId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
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

        public void Update(Users user)
        {
            Users userUpdate = userUpdate = _users.SingleOrDefault
                 (c => c.Id == user.Id);
            userUpdate.Id = user.Id;
            userUpdate.UserFirstName=user.UserFirstName;
            userUpdate.UserLastName=user.UserLastName;
            userUpdate.UserEmail=user.UserEmail;
            userUpdate.UserPassword=user.UserPassword;
            userUpdate.CompanyName=user.CompanyName;
        }

        
    }
}
