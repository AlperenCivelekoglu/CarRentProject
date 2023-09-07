using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _myCars;

        public InMemoryCarDal()
        {
            _myCars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 140000, ModelYear = 2023, Description = "Car1"},
                new Car { Id = 2, BrandId = 1, ColorId = 2, DailyPrice = 143000, ModelYear = 2023, Description = "Car2"},
                new Car { Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 160000, ModelYear = 2019, Description = "Car3"}
            };
        }
        public void Add(Car car)
        {
            _myCars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _myCars.SingleOrDefault(p=>p.Id == car.Id);

            _myCars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _myCars;
        }

        public List<Car> GetById(int id)
        {
            return _myCars.Where(p=>p.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _myCars.SingleOrDefault(p => p.Id == car.Id);

            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Id = car.Id;
        }
    }
}
