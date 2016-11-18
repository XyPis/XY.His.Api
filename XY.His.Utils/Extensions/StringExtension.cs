using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace XY.His.Utils.Extensions
{
    public static class StringExtension
    {
        public static bool IsNumeric(this string str)
        {
            return !Regex.IsMatch(str, @"[^\d]");
        }
        /// <summary>
        /// 不区分大小写，判断字符串值相等
        /// </summary>
        public static bool EqualsIgnoreCase(this string source, string value)
        {
            return EqualsIgnoreCase(source, value, false);
        }

        #region 私有方法
        private static bool EqualsIgnoreCase(this string source, string value, bool ignoreNullOrEmpty)
        {
            if (ignoreNullOrEmpty && string.IsNullOrEmpty(source) && string.IsNullOrEmpty(value)) return true;
            return string.Equals(source, value, StringComparison.CurrentCultureIgnoreCase);
        }
        #endregion
    }
}
