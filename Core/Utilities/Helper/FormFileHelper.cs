using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helper
{
    public class FormFileHelper
    {
        public IResult Delete(string imagePath)
        {
            File.Delete(Path.Combine("images", imagePath));
            return new SuccessResult();
        }

        public static IDataResult<string> SaveFile(IFormFile formFile)
        {
            if (formFile == null || formFile.Length == 0)
            {
                return new ErrorDataResult<string>(null, $"{formFile.FileName} bulunamadı."); //Validasyon taşınacak
            }

            string fileExtension = Path.GetExtension(formFile.FileName);

            var guid = Guid.NewGuid();

            string fileName = $"{guid}{fileExtension}";
            string filePath = Path.Combine("images", fileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                formFile.CopyTo(fileStream);
            }

            var toReturn = new SuccessDataResult<string>(fileName, "File saved succesfully");
            return toReturn;
        }
    }
}
