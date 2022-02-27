using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFNValidator.Helpers
{
    public enum OperationResultMessageStatus
    {
        Success,
        Failure
    }
    public class OperationResultMessage<T> where T: class
    {
        public OperationResultMessageStatus Status { get; }
        public string Message { get; }
        public T Result { get; }
        public OperationResultMessage(OperationResultMessageStatus status, string message,T result)
        {
            Status = status;
            Message = message;
            Result = result;
        }
    }
}
