using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XY.His.Utils.Helpers
{
    /// <summary>
    /// 日期工具类
    /// </summary>
    public static class DateTimeHelper
    {
        /// <summary>
        /// 取得某月的第一天
        /// </summary>
        /// <param name="datetime">要取得月份第一天的时间</param>
        /// <returns></returns>
        public static DateTime FirstDayOfMonth(DateTime datetime)
        {
            return datetime.AddDays(1 - datetime.Day);
        }

        /// <summary>
        /// 取得某月的最后一天
        /// </summary>
        /// <param name="datetime">要取得月份最后一天的时间</param>
        /// <returns></returns>
        public static DateTime LastDayOfMonth(DateTime datetime)
        {
            return datetime.AddDays(1 - datetime.Day).AddMonths(1).AddDays(-1);
        }

        /// <summary>
        /// 取得上个月第一天
        /// </summary>
        /// <param name="datetime">要取得上个月第一天的当前时间</param>
        /// <returns></returns>
        public static DateTime FirstDayOfPreviousMonth(DateTime datetime)
        {
            return datetime.AddDays(1 - datetime.Day).AddMonths(-1);
        }

        /// <summary>
        /// 取得上个月的最后一天
        /// </summary>
        /// <param name="datetime">要取得上个月最后一天的当前时间</param>
        /// <returns></returns>
        public static DateTime LastDayOfPrdviousMonth(DateTime datetime)
        {
            return datetime.AddDays(1 - datetime.Day).AddDays(-1);
        }

        /// <summary>
        /// 日期对应的周一
        /// </summary>
        /// <param name="someDate"></param>
        /// <returns></returns>
        public static DateTime GetMondayDate(DateTime someDate)
        {
            var day = (int)someDate.DayOfWeek;
            if (day == 0) day = 7;
            day--;
            return someDate.AddDays(-day);  
        }

        /// <summary>
        /// 日期对应的周日
        /// </summary>
        /// <param name="someDate"></param>
        /// <returns></returns>
        public static DateTime GetSundayDate(DateTime someDate)
        {
            var day = (int)someDate.DayOfWeek;
            if (day == 0) day = 7;
            return someDate.AddDays(7-day);  
        }

        /// <summary>
        /// 日期对应的下周周一
        /// </summary>
        /// <param name="someDate"></param>
        /// <returns></returns>
        public static DateTime GetNextWeekMondayDate(DateTime someDate)
        {
            return GetSundayDate(someDate).AddDays(1);
        }

        /// <summary>
        /// 日期对应的下周周日
        /// </summary>
        /// <param name="someDate"></param>
        /// <returns></returns>
        public static DateTime GetNextWeekSundayDate(DateTime someDate)
        {
            return GetSundayDate(someDate).AddDays(7);
        }
    }
}
