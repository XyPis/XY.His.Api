using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XY.His.Utils.Extensions
{
    public static class TypeExtension
    {
        /// <summary>
        /// 获取去掉可空类型（Nullable<>）的类型.
        /// </summary>
        /// <param name="type">当前类型的实例对象.</param>
        /// <returns>去掉可空类型（Nullable<>）的类型.</returns>
        public static Type GetNoneNullableType(this Type type)
        {
            if (IsNullable(type))
                return Nullable.GetUnderlyingType(type);
            return type;
        }

        /// <summary>
        /// 获取可空类型（Nullable<>）的类型.
        /// </summary>
        /// <param name="type">当前类型的实例对象.</param>
        /// <returns>可空类型（Nullable<>）的类型.</returns>
        public static Type GetNullableType(this Type type)
        {
            if (!IsNullable(type) && type.IsValueType)
                return typeof(Nullable<>).MakeGenericType(type);
            return type;
        }

        /// <summary>
        /// 获取一个值, 通过该值指示当前类型是否为可空类型（Nullable<>）.
        /// </summary>
        /// <param name="type">当前类型的实例对象.</param>
        /// <returns>
        ///   <c>true</c> 表示为可空类型（Nullable<>）; 否则返回 <c>false</c>.
        /// </returns>
        public static bool IsNullable(this Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
        }
    }
}
