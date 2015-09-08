using System;

namespace MVCApplicationServiceLayer
{
    public class NumberConverter
    {
        public int ConvertNumber(string number)
        {
            return Convert.ToInt32(number);
        }
    }
}
