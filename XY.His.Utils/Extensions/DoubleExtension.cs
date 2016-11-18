using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XY.His.Utils.Extensions
{
    public static class DoubleExtension
    {
        /// <summary>
        /// 四舍五入后取几位小数
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="digit">精度值</param>
        /// <returns></returns>
        public static double Round(this double sourceValue, int digit)
        {
            return Math.Round(sourceValue, digit);
        }

        //public static double Round2(this double value, int digit)
        //{
        //    bool valuebool = false;
        //    if (value < 0)
        //    {
        //        value = Math.Abs(value);
        //        valuebool = true;
        //    }
        //    value += 0.00001;
        //    double vt = Math.Pow(10, digit);
        //    double vx = value * vt;

        //    vx += 0.5;
        //    if (!valuebool)
        //        return (Math.Floor(vx) / vt);
        //    else return 0 - (Math.Floor(vx) / vt);
        //}
    }
}
