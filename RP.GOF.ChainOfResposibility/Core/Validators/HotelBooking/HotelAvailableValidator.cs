using RP.GOF.ChainOfResposibility.Models;
using System.Collections.Generic;

namespace RP.GOF.ChainOfResposibility.Core.Validators.HotelBooking
{
    public class HotelAvailableValidator : ValidatorBase
    {
        public override Dictionary<string, string> HandleValidation(Models.HotelBooking model)
        {
            if (model.HotelType == HotelType.OneBedroom)
            {
                ErrorsResult.Add("Test1","Result Err 1");
                return ErrorsResult;
            }

            if (Successor != null)
                return Successor.HandleValidation(model);
            return ErrorsResult;
        }
    }
}
