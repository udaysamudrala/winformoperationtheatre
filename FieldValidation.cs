using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class FieldValidation
    {
        //public  Boolean isString(String field)
        //{
        //    String str = field.ToUpper();
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (((str[i]) >=65 && str[i] <= 95)) return false;
        //    }
        //    return true;
        //}
        public Boolean isNumber(String field)
        {
            for (int i = 0; i < field.Length; i++)
            {
                if ((field[i] >= 48 && field[i] <= 58)) return false;
            }
            return true;
        }
    }
}

