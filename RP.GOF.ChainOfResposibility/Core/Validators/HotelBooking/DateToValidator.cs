using System;
using System.Collections.Generic;

namespace RP.GOF.ChainOfResposibility.Core.Validators.HotelBooking
{
    public class DateToValidator : ValidatorBase
    {
        public override Dictionary<string, string> HandleValidation(Models.HotelBooking model)
        {
            if (model.DateTo == DateTime.MaxValue)
            {
                ErrorsResult.Add("v3 key","v3 value");
                return ErrorsResult;
            }
            if (Successor != null)
                return Successor.HandleValidation(model);

            return ErrorsResult;
        }
    }
}
