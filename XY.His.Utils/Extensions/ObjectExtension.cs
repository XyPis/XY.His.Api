using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace XY.His.Utils.Extensions
{
    public static class ObjectExtension
    {
        /// <summary>
        /// 深拷贝
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static object DeepClone(this object obj)
        {
            object cloneObj;
            using (MemoryStream ms = new MemoryStream())
            {
                IFormatter bf = new BinaryFormatter(null,
                   new StreamingContext(StreamingContextStates.Clone));
                bf.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                cloneObj = bf.Deserialize(ms);
                ms.Close();
            }
            return cloneObj;
        }

        /// <summary>
        /// 转化成对应结构对象
        /// </summary>
        /// <typeparam name="M">要转化成的类型</typeparam>
        /// <param name="thisObj"></param>
        /// <returns></returns>
        public static T ConvertTo<T>(this object thisObj) where T : class, new()
        {
            if (thisObj == null) return null;
            BindingFlags BINDING_FLAGS
            = BindingFlags.Instance | BindingFlags.Public
            | BindingFlags.GetProperty | BindingFlags.SetProperty
            | BindingFlags.GetField | BindingFlags.SetField;
            T newObject = new T();
            PropertyInfo[] newObjProperties = newObject.GetType().GetProperties(BINDING_FLAGS);
            PropertyInfo[] curObjProperties = thisObj.GetType().GetProperties(BINDING_FLAGS);
            try
            {
                foreach (var pro in curObjProperties)
                {

                    var newPro = newObjProperties.FirstOrDefault(t => t.Name == pro.Name);
                    if (newPro != null)
                    {
                        if (newPro.GetType() == pro.GetType())
                        {
                            object value = pro.GetValue(thisObj, null);
                            newPro.SetValue(newObject, value, null);
                        }
                    }

                }
            }
            catch { }

            return newObject;
        }
    }
}
