using Business.Abstract;
using Business.Constants;
using Core.Utilities.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpGet("GetByCarId")]
        public IActionResult GetAllImagesByCarId(int carId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("UploadImage")]
        public IActionResult UploadImage(IFormFile formFile,int carId)
        {
            var result = _carImageService.UploadCarImage(formFile, carId);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
