using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace XY.His.Utils.Helpers
{
    public static class PropertyHelper
    {
        /// <summary>
        /// 根据类的实例设置类的属性。
        /// </summary>
        /// <param name="classInstance">将要设置的类的实例。</param>
        /// <param name="propertyName">将要设置属性名。</param>
        /// <param name="propertSetValue">将要设置属性值。</param>
        public static void SetPropertyValue(object classInstance, string propertyName, object propertSetValue)
        {
            classInstance.GetType().InvokeMember(propertyName, BindingFlags.SetProperty,
                                          null, classInstance, new object[] { Convert.ChangeType(propertSetValue, propertSetValue.GetType()) });
        }

        /// <summary>
        /// 根据类的实例获取类的属性。
        /// </summary>
        /// <param name="classInstance">将要获取的类的实例</param>
        /// <param name="propertyName">将要设置的属性名。</param>
        /// <returns>返回获取的类的属性。</returns>
        public static object GetPropertyValue(object classInstance, string propertyName)
        {
            return classInstance.GetType().InvokeMember(propertyName, BindingFlags.GetProperty,
                                                          null, classInstance, new object[] { });
        }

        /// <summary>
        /// 判断指定对象实例是否存在该属性
        /// </summary>
        public static bool HasProperty(object target, string propertyName)
        {
            if (target == null || propertyName == null)
            {
                return false;
            }

            PropertyInfo[] names = target.GetType().GetProperties().ToArray();
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Name == propertyName.Trim())
                {
                    return true;
                }
            }
            return false;

        }
    }
}
