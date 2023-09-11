using Core.Utilities.Abstract;
using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult AddCar(Customer customer);
        IResult DeleteCar(Customer customer);
        IResult UpdateCar(Customer customer);
        IDataResult<List<Customer>> GetAll();
        
    }
}
