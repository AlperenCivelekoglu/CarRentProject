using Entities.Concrete;
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
        public static readonly string CarImageAddedSuccessfully;
        internal static readonly string ColorAdded;
        internal static readonly string ColorDeleted;
        internal static readonly string ColorShowed;
        internal static readonly string ColorUpdated;
        internal static readonly string CustomerAdded;
        internal static readonly string CustomerDeleted;
        internal static readonly string CustomerUpdated;
        internal static readonly string CarImageAdded;
        internal static readonly string CarImageDeleted;
        internal static readonly string CarImageUpdated;
        internal static readonly string AccesTokenCreated;
        internal static readonly string UserAlreadyExists;
        internal static readonly string UserRegisteredSuccesfully;
        internal static readonly User UserNotFound;
        internal static readonly User PasswordWrongError;
        internal static readonly string SuccesfulLogin;
        internal static readonly string? AuthorizationDenied;
    }
}
