using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static readonly string CarNameInvalid = "Invalid car name";
        public static readonly string PriceZero = "Price can not be equal to 0";
        public static readonly string CarUpdated = "Successfully updated";
        public static readonly string CarDeleted = "Succesfully deleted";
        
        //              Rental
        public static readonly string RentalAdded = "Rental Successfully added";
        public static readonly string RentalUpdated = "Rental Successfully deleted";
        public static readonly string RentalDeleted = "Rental Successfully updated";
        //              Brand
        public static readonly string BrandAdded = "Brand Successfully added";
        public static readonly string BrandUpdated = "Brand Successfully updated";
        public static readonly string BrandDeleted = "Brand Successfully deleted";
        //              User
        public static readonly string UserAdded = "User Successfully added";
        public static readonly string UserUpdated = "User Successfully updated";
        public static readonly string UserDeleted = "User Successfully deleted";

    }
}
