using Personal_Bookkeeping.Abstract.Common.IResults;
using System;
using System.Collections.Generic;

namespace Personal_Bookkeeping.Abstract.Holders
{
    public static class LogMessageHolder
    {
        public static List<String> Log = new List<string>();

        public static void AddLog(IResult result)
        {
            string message = string.Format("-> [{0}] - {1}",
                DateTime.Now, result.Message);
            Log.Add(message);
        }
        
    }
}
