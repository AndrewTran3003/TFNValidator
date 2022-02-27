using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFNValidator.Model;

namespace TFNValidator.Helpers
{
    public static class LinkedValueHelper
    {
        public static bool IsLinked(string tfnTrimmed1, string tfnTrimmed2)
        {
            int count = 0;
            for (int i = 0; i < tfnTrimmed1.Length; i++)
            {
                int i2 = i;
                foreach (char t in tfnTrimmed2)
                {
                    if (tfnTrimmed1[i2] != t)
                    {
                        count = 0;
                        continue;
                    }
                    i2++;
                    count++;
                    if (count == 4)
                    {
                        return true;
                    }
                    if (i2 == tfnTrimmed1.Length)
                    {
                        return false;
                    }
                }
            }
            
            return false;
        }

        public static bool IsEntryWithin30SecondsFromNow(RequestEntry entry)
        {
            return entry.DateSubmitted <= DateTime.Now && entry.DateSubmitted >= DateTime.Now.AddSeconds(-30);
        }
    }
}
