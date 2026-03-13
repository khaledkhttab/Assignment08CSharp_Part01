using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11
{
    public static class StringHelper
    {
        //public static bool IsLongerThan(string value, int length)
        //{
        //    if (value.Length > length)
        //    return true;

        //    return false;//
        //}

        // Extension Method : Extend string class 
        public static bool IsLongerThan(this string value, int length)
        {
            if (value.Length > length)
            return true;

            return false;
        }
    }
}
