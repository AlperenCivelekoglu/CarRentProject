﻿using Core.Utilities.Abstract;
using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult AddRental(Rental rental);
        IResult DeleteRental(Rental rental);
        IResult UpdateRental(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int id);
    }
}
