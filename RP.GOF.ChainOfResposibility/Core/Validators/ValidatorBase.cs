using System.Collections.Generic;

namespace RP.GOF.ChainOfResposibility.Core.Validators
{
    public abstract class ValidatorBase
    {
        protected ValidatorBase Successor { get; private set; }
        protected Dictionary<string, string> ErrorsResult { get; set; }

        protected ValidatorBase()
        {
            ErrorsResult = new Dictionary<string, string>();
        }

        public abstract Dictionary<string, string> HandleValidation(Models.HotelBooking model);

        public void SetSuccessor(ValidatorBase successor)
        {
            Successor = successor;
        }
    }
}
