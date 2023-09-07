using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
namespace ReCapProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car1 = new Car { Id = 3, BrandId = 1, ColorId = 2, DailyPrice = 150000, Description = "XC 90 SUV", ModelYear = 2021 };

            //foreach (var car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(car.Description);
            //}

            carManager.AddCar(car1);
        }
    }
}
