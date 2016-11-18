using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace XY.His.Utils.Extensions
{
    public static class DataTableExtension
    {
        /// <summary>
        /// DataTable转化成对应结构对象集合
        /// </summary>
        /// <typeparam name="T">要转化成的类型</typeparam>
        /// <param name="tb"></param>
        /// <returns></returns>
        public static List<T> DataTableToList<T>(this DataTable tb) where T : class,new()
        {
            List<T> newListObj = new List<T>();
            if (tb == null) return newListObj;
            try
            {
                BindingFlags BINDING_FLAGS = BindingFlags.Instance | BindingFlags.Public
                                            | BindingFlags.GetProperty | BindingFlags.SetProperty
                                            | BindingFlags.GetField | BindingFlags.SetField;

                PropertyInfo[] newObjProperties = typeof(T).GetProperties(BINDING_FLAGS);
                //先找出DataTable与Model的列匹配
                Dictionary<string, Type> ht = FindSameColomnName(tb, newObjProperties);
                foreach (DataRow dr in tb.Rows)
                {
                    T newObject = new T();
                    foreach (var p in newObjProperties)
                    {
                        if (ht.ContainsKey(p.Name))
                        {
                            if (ht[p.Name] != typeof(byte[]))
                            {
                                string strValue = dr[p.Name].ToString();
                                if (ht[p.Name] == typeof(string))
                                {
                                    p.SetValue(newObject, strValue, null);
                                }
                                else if (p.PropertyType == typeof(long))
                                {
                                    long value;
                                    long.TryParse(strValue, out value);
                                    p.SetValue(newObject, value, null);
                                }
                                else if (p.PropertyType == typeof(decimal))
                                {
                                    decimal value;
                                    decimal.TryParse(strValue, out value);
                                    p.SetValue(newObject, value, null);
                                }
                                else if (p.PropertyType == typeof(int))
                                {
                                    int value;
                                    int.TryParse(strValue, out value);
                                    p.SetValue(newObject, value, null);
                                }
                                else if (p.PropertyType == typeof(DateTime))
                                {
                                    DateTime value;
                                    DateTime.TryParse(strValue, out value);
                                    p.SetValue(newObject, value, null);
                                }
                                else if (p.PropertyType == typeof(float))
                                {
                                    float value;
                                    float.TryParse(strValue, out value);
                                    p.SetValue(newObject, value, null);
                                }
                                else if (p.PropertyType == typeof(double))
                                {
                                    double value;
                                    double.TryParse(strValue, out value);
                                    p.SetValue(newObject, value, null);
                                }
                                else if (p.PropertyType == typeof(bool))
                                {
                                    bool value;
                                    int result = 0;
                                    if (int.TryParse(strValue, out result))
                                    {
                                        if (result > 0)
                                            p.SetValue(newObject, true, null);
                                        else
                                            p.SetValue(newObject, false, null);
                                    }
                                    else
                                    {
                                        bool.TryParse(strValue, out value);
                                        p.SetValue(newObject, value, null);
                                    }
                                }
                                else
                                {
                                    p.SetValue(newObject, strValue, null);
                                }
                            }
                            else
                            {
                                if (dr[p.Name].GetType().Name != "DBNull")
                                    p.SetValue(newObject, dr[p.Name], null);
                            }
                        }
                    }
                    newListObj.Add(newObject);
                }

            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return newListObj;
        }

        #region 私有方法
        /// <summary>
        /// 查找DataTable和实体之间相同的属性名称，返回一个HashTabel，key：model的列名，value：model列类型
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="props"></param>
        /// <returns></returns>
        private static Dictionary<string, Type> FindSameColomnName(DataTable tb, PropertyInfo[] props)
        {
            Dictionary<string, Type> ht = new Dictionary<string, Type>();
            foreach (DataColumn dc in tb.Columns)
            {
                var prop = props.FirstOrDefault(t => t.Name.EqualsIgnoreCase(dc.ColumnName));
                if (prop == null) continue;
                ht.Add(prop.Name, prop.PropertyType);
            }
            return ht;
        }
        #endregion
    }
}
