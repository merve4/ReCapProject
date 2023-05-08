using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rentals,CarDbContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result=from r in context.Rentals
                           join c in context.Cars
                           on r.CarId equals c.CarId
                           join u in context.Users
                           on r.CustomerId equals u.Id
                           join b in context.Brands
                           on c.BrandId equals b.BrandId
                           join clr in context.Colors
                           on c.ColorId equals clr.ColorId
                select new RentalDetailDto {CarName=c.CarName,ModelYear=c.ModelYear.ToString(),BrandId=b.BrandId.ToString(), RentDate=r.RentDate,ReturnDate=r.ReturnDate,Description=c.Description };
                return result.ToList();
            }
        }
    }
}



