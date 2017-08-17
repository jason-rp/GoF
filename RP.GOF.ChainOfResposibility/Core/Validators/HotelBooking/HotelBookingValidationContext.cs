using System.Collections.Generic;

namespace RP.GOF.ChainOfResposibility.Core.Validators.HotelBooking
{
    public static class HotelBookingValidationContext
    {
        public static Dictionary<string, string> Validate(Models.HotelBooking model)
        {
            //hook up validation process
            //1. validate from date
            //2. validate to date
            //3. validate available rooms

            var dateFromValidator = new DateFromValidator();
            var dateToValidator = new DateToValidator();
            dateFromValidator.SetSuccessor(dateToValidator);
            var hotelAvailableValidator = new HotelAvailableValidator();
            dateToValidator.SetSuccessor(hotelAvailableValidator);

            return dateFromValidator.HandleValidation(model);
        }
    }
}
