using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFNValidator.Helpers;
using TFNValidator.Model;
using TFNValidator.Services.Abstract;

namespace TFNValidator.Services.Concrete
{
    public class LinkedValidator : ILinkedValidator
    {
        public bool Validate(List<RequestEntry> recentRequests)
        {
            int count = 0;
            for(int i = 0; i < recentRequests.Count - 1; i++)
            {
                for (int j = i + 1; j < recentRequests.Count; j++)
                {
                    if (IsLinked(recentRequests[i],recentRequests[j]))
                    {
                        count++;
                    }
                    if (count == 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private bool IsLinked(RequestEntry request1, RequestEntry request2)
        {
            return LinkedValueHelper.IsLinked(request1.Value, request2.Value);
        }
    }
}
