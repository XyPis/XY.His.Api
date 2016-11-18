using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace XY.His.Utils.Extensions
{
    public static class ListExtension
    {
        /// <summary>
        /// 将子项的某一属性全Copy到数组
        /// </summary>
        /// <param name="ItemPropertyName"></param>
        /// <returns></returns>
        public static string[] PropertyCopyToArray<T>(this List<T> lst, string ItemPropertyName)
        {
            int length = lst.Count;
            string[] ary = new string[length];
            int icounter = 0;
            foreach (T info in lst)
            {
                object propertyValue = info.GetType().GetProperty(ItemPropertyName).GetValue(info, null);
                if (propertyValue == null) continue;
                string a1 = propertyValue.ToString();
                ary[icounter] = a1;
                icounter++;
            }
            return ary;
        }
        /// <summary>
        /// 过滤与指定条件不等的对象
        /// </summary>
        /// <param name="key">属性名</param>
        /// <param name="value">值，全匹配</param>
        /// <returns>过滤后的List</returns>
        public static List<T> Filter<T>(this List<T> lst, string key, string value)
        {
            List<T> list = new List<T>();
            foreach (T info in lst)
            {
                object propertyValue =Helpers.PropertyHelper.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                if (propertyValue.ToString() != value) list.Add((T)info);
            }
            return list;
        }

        /// <summary>
        ///  根据字段、值查询 集合里面相同的记录
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static List<T> Find<T>(this List<T> lst, string key, string value)
        {
            List<T> findLst = new List<T>();

            for (int i = 0; i < lst.Count; i++)
            {
                T info = lst[i];
                object propertyValue = Helpers.PropertyHelper.GetPropertyValue(info, key);
                if (propertyValue == null)
                {
                    continue;
                }
                if (propertyValue.ToString() == value)
                {
                    findLst.Add(info);
                }
            }
            return findLst;
        }
        /// <summary>
        ///  
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static void Remove<T>(this List<T> lst, string key, string value)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                T info = lst[i];
                object propertyValue = Helpers.PropertyHelper.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                if (propertyValue.ToString() == value)
                {
                    lst.Remove(info);
                    i--;
                }
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="lst"></param>
        /// <param name="key">属性名称</param>
        /// <returns></returns>
        public static int GetIntMax<T>(this List<T> lst, string key)
        {
            int max = 0;
            foreach (var info in lst)
            {
                object propertyValue = Helpers.PropertyHelper.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                if (max < Convert.ToInt32(propertyValue))
                    max = Convert.ToInt32(propertyValue);
            }
            return max;
        }

        public static double GetSum<T>(this List<T> lst, string key)
        {
            double intTotal = 0;
            foreach (T info in lst)
            {
                object propertyValue = Helpers.PropertyHelper.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                intTotal += Convert.ToDouble(propertyValue.ToString());
            }
            return intTotal;
        }

        public static Double GetDoubleMax<T>(this List<T> lst, string key)
        {
            Double max = Double.MinValue;
            foreach (T info in lst)
            {
                object propertyValue = Helpers.PropertyHelper.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                if (max < Convert.ToDouble(propertyValue))
                    max = Convert.ToDouble(propertyValue);
            }
            return max;
        }

        public static Double GetDoubleMin<T>(this List<T> lst, string key)
        {
            Double min = Double.MaxValue;
            foreach (T info in lst)
            {
                object propertyValue = Helpers.PropertyHelper.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                if (min > Convert.ToDouble(propertyValue))
                    min = Convert.ToDouble(propertyValue);
            }
            return min;
        }
        public static DateTime GetDateTimeMax<T>(this List<T> lst, string key)
        {
            DateTime max = DateTime.MinValue;
            foreach (T info in lst)
            {
                object propertyValue = Helpers.PropertyHelper.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                if (max < Convert.ToDateTime(propertyValue))
                    max = Convert.ToDateTime(propertyValue);
            }
            return max;
        }
        public static DateTime GetDateTimeMin<T>(this List<T> lst, string key)
        {
            DateTime min = DateTime.MaxValue;
            foreach (T info in lst)
            {
                object propertyValue = Helpers.PropertyHelper.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                if (min > Convert.ToDateTime(propertyValue))
                    min = Convert.ToDateTime(propertyValue);
            }
            return min;
        }

        /// <summary>
        /// 找出包含指定字符串的数据
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<T> FindInclude<T>(this List<T> lst, string key, string value)
        {
            List<T> list = new List<T>();
            foreach (T info in lst)
            {
                object propertyValue = Helpers.PropertyHelper.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                if (propertyValue.ToString().Contains(value)) list.Add((T)info.DeepClone());
            }
            return list;
        }

        public static int IndexOf<T>(this List<T> lst, string key, string value)
        {
            int i = 0;
            foreach (T info in lst)
            {
                object propertyValue = Helpers.PropertyHelper.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                if (propertyValue.ToString() == value)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        public static void Fill<T>(this List<T> lst, string key, object value)
        {
            if (lst == null) return;
            foreach (T info in lst)
            {
                Helpers.PropertyHelper.SetPropertyValue(info, key, value);
            }
        }

        /// <summary>
        /// 过滤是否包含与指定字符串的对象
        /// </summary>
        /// <param name="key">属性名</param>
        /// <param name="value">值，包含</param>
        /// <param name="equal">条件false为是否包含,true则不包含</param>
        /// <returns>过滤后的List</returns>
        public static List<M> FilterInclude<M>(this List<M> lst, string key, string value, bool equal) where M : class ,new()
        {
            List<M> list = new List<M>();
            foreach (var info in lst)
            {
                object propertyValue = Helpers.PropertyHelper.GetPropertyValue(info, key);
                if (propertyValue == null) continue;

                if (!equal)
                {
                    if (propertyValue.ToString().IndexOf(value) >= 0) list.Add(info);
                }
                else
                {
                    if ((propertyValue.ToString().IsNumeric()) && propertyValue.ToString().IndexOf(value) != 0) list.Add((M)info);
                    if ((propertyValue.ToString().IsNumeric()) && propertyValue.ToString().IndexOf(value) < 0) list.Add((M)info);
                }
            }
            return list;
        }
    }
}
