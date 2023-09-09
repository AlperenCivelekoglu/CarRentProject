using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MyEfDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (MyEfDatabaseContext context = new MyEfDatabaseContext())
            {
                var result = from co in context.Colors
                             join ca in context.Cars on co.Id equals ca.ColorId
                             join b in context.Brands on ca.BrandId equals b.Id
                             select new CarDetailDto { BrandName = b.Name, CarName = ca.Description, ColorName = co.Name, DailyPrice = ca.DailyPrice };
                return result.ToList();
            }
        }
    }
}
