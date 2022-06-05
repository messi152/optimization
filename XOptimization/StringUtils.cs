using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOptimization
{
    class StringUtils
    {
        public static bool IsNotEmpty(String text)
        {
            return !("".Equals(text) || text == null);
        }
        public static string Trim(String text)
        {
            if (text == null) text = "";
            return text.Trim();
        }
    }
}
