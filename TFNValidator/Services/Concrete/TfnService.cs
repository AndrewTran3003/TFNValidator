using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFNValidator.Data;
using TFNValidator.Helpers;
using TFNValidator.Services.Abstract;

namespace TFNValidator.Services.Concrete
{
    public class TfnService : ITfnService
    {
        private readonly RequestEntriesContext _context;
        public TfnService(RequestEntriesContext context)
        {
            _context = context;
        }
        public OperationResultMessage<object> ValidateTfnString(string tfnString)
        {
            string tfnTrimmed = StringHelper.RemoveWhiteSpace(tfnString);

            //Save the attemps and compare
            //Validate if the tfn only contains numbers
            //Use validator to make sure this is a valid tfn number
            return SuccessResponse();
        }
        private OperationResultMessage<object> SuccessResponse()
        {
            return new OperationResultMessage<object>(OperationResultMessageStatus.Success, "TFN number is valid", null);
        }
        private OperationResultMessage<object> ErrorResponse_InvalidTfn()
        {
            return ErrorResponse("Invalid TFN entered. The valid TFN should contain 8 or 9 numbers and white spaces");
        }
        private OperationResultMessage<object> ErrorResponse(string message)
        {
            return new OperationResultMessage<object>(OperationResultMessageStatus.Failure, message, null);
        }
    }
}
