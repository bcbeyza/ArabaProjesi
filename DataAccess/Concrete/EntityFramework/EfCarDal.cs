using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context=new RentACarContext())
            {

                var result = from a in context.Cars
                             join b in context.Brands
                             on a.BrandId equals b.Id
                             join c in context.Colors
                             on a.ColorId equals c.Id
                             select new CarDetailDto()
                             {
                                 BrandName=b.BrandName,CarName=a.CarName,ColorName=c.ColorName,DailyPrice=a.DailyPrice
                             };
                return result.ToList();



            }
        }
    }
}
