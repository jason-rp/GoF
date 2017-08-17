using System;
using System.Collections.Generic;

namespace RP.GOF.ChainOfResposibility.Core.Validators.HotelBooking
{
    public class DateFromValidator : ValidatorBase
    {
        public override Dictionary<string, string> HandleValidation(Models.HotelBooking model)
        {
            if (model.DateFrom == DateTime.MinValue)
            {
                ErrorsResult.Add("v2","v2 result");
                return ErrorsResult;
            }
            if (Successor != null)
                return Successor.HandleValidation(model);
            return ErrorsResult;
        }
    }
}
