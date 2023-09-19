using Core.Utilities;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult AddCarImage(CarImage carImage);
        IResult DeleteCarImage(CarImage carImage);
        IResult UpdateCarImage(CarImage carImage);
        IResult UploadCarImage(IFormFile formfile, int CarId);
    }
}
