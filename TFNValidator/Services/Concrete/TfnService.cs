using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFNValidator.Data;
using TFNValidator.Helpers;
using TFNValidator.Repositories.Abstract;
using TFNValidator.Services.Abstract;

namespace TFNValidator.Services.Concrete
{
    public class TfnService : ITfnService
    {
        private readonly IRequestEntriesRepository _requestEntriesRepository;
        private readonly ILinkedValueValidator _linkedValueValidator;
        private readonly ITfnValidatorFactory _tfnFactory;
        public TfnService(IRequestEntriesRepository requestEntriesRepository,
                            ILinkedValueValidator linkedValueValidator,
                            ITfnValidatorFactory tfnFactory)
        {
            _requestEntriesRepository = requestEntriesRepository;
            _linkedValueValidator = linkedValueValidator;
            _tfnFactory = tfnFactory;
        }
        public OperationResultMessage<object> ValidateTfnString(string tfnString)
        {
            if (!ContainsOnlyNumbersAndWhiteSpace())
            {
                return ErrorResponse_OnlyAcceptsNumbersAndWhiteSpaces();
            }
            string tfnTrimmed = StringHelper.RemoveWhiteSpace(tfnString);
            AddToRequestEntries();
            if (LinkedRequestDetectedWithin30Seconds())
            {
                return ErrorResponse_MultipleAttempsOfSimilarValue();
            }
            ITfnValidator validator = GetValidator();
            if (ValidatorNotFound())
            {
                return ErrorResponse_InvalidTfn();
            }
            if (!IsValidTfn())
            {
                return ErrorResponse_InvalidTfn();
            }
            return SuccessResponse();

            //Helper methods

            bool ValidatorNotFound()
            {
                return validator == null;
            }
            ITfnValidator GetValidator()
            {
                return _tfnFactory.GetValidator(tfnTrimmed);
            }
            bool IsValidTfn()
            {
                return validator.Validate(tfnTrimmed);
            }
            bool ContainsOnlyNumbersAndWhiteSpace()
            {
                return DigitHelper.ContainsOnlyNumberAndWhiteSpace(tfnString);
            }
            bool LinkedRequestDetectedWithin30Seconds()
            {
                return _linkedValueValidator.Validate(_requestEntriesRepository.GetRequestEntriesLast30Seconds());
            }
            void AddToRequestEntries()
            {
                _requestEntriesRepository.Add(tfnTrimmed);
            }
            OperationResultMessage<object> SuccessResponse()
            {
                return new OperationResultMessage<object>(OperationResultMessageStatus.Success, "TFN number is valid", null);
            }
            OperationResultMessage<object> ErrorResponse_InvalidTfn()
            {
                return ErrorResponse("Invalid TFN entered. The valid TFN should contain 8 or 9 numbers and white spaces");
            }
            OperationResultMessage<object> ErrorResponse_OnlyAcceptsNumbersAndWhiteSpaces()
            {
                return ErrorResponse("Invalid TFN entered. The validator only accepts numbers and whitespaces");
            }
            OperationResultMessage<object> ErrorResponse_MultipleAttempsOfSimilarValue()
            {
                return ErrorResponse("The validator does not allow multiple attemps for similar values");
            }
            OperationResultMessage<object> ErrorResponse(string message)
            {
                return new OperationResultMessage<object>(OperationResultMessageStatus.Failure, message, null);
            }
        }

    }
}
