using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceQuotation.Services
{
    public static class Debug
    {
        public static string varDump(object item = null)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(item).ToString();
        }
    }

}
