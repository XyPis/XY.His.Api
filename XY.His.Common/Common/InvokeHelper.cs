using System;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Collections.Generic;

namespace XY.His.Common
{
    public static class InvokeHelper
    {
        private static Dictionary<string, Assembly> assemblyList = new Dictionary<string, Assembly>();
      
        public static object InvokeMethod(string assem, string type, string methodName, object[] args)
        {
            if (!assemblyList.ContainsKey(assem))
            {
                lock (assemblyList)
                {
                    if (!assemblyList.ContainsKey(assem))
                    {
                        Assembly ass = Assembly.Load(assem);
                        assemblyList.Add(assem, ass);
                    }
                }
            }

            Assembly assembly = assemblyList[assem];
            Type t = assembly.GetType(type);
            return InvokeMethod(t, methodName, args);
        }
       
        public static object InvokeMethod(string type, string methodName, object[] args)
        {
            Type t = Type.GetType(type);
            return InvokeMethod(t, methodName, args);
        }
        
        public static object InvokeMethod(Type type, string methodName, object[] args)
        {
            MethodInfo m = type.GetMethod(methodName, GetParameterTypes(args));
            if (m == null)
            {
                //TODO: dragon luo
                throw new Exception("Can not found methodName:" + methodName);
                //throw new InvokeException("Can not found methodName:" + methodName);
            }

            object obj = null;
            try
            {
                obj = Execute(type, m, methodName, args);
            }
            //catch (InvokeException e)
            catch (Exception e)
            {
                //TODO: dragon luo
                //throw new InvokeException(e.Message);
                throw new Exception(e.Message);
            }
            return obj;
        }

        private static Type[] GetParameterTypes(object[] args)
        {
            Type[] types = new Type[args.Length];

            for (int i = 0; i < types.Length; i++)
            {
                types[i] = args[i] == null ? null : args[i].GetType();
            }

            return types;
        }

        private static object Execute(Type type, MethodInfo method, string methodName, object[] args)
        {
            //校验名称是否匹配
            if (string.Compare(method.Name, methodName, false, CultureInfo.InvariantCulture) != 0)
            {
                //TODO: dragon luo
                throw new Exception(method.DeclaringType + "." + method.Name + ": Method Name Doesn't Match!");
                //throw new InvokeException(method.DeclaringType + "." + method.Name + ": Method Name Doesn't Match!", ReturnType.InvokeError);
            }

            //参数数目错误
            ParameterInfo[] param = method.GetParameters();
            if (param.Length != args.Length)
            {
                //TODO: dragon luo
                throw new Exception(method.DeclaringType + "." + method.Name + ": Method Signatures Don't Match!");
                //throw new InvokeException(
                //    method.DeclaringType + "." + method.Name + ": Method Signatures Don't Match!",
                //    ReturnType.InvokeError);
            }
            //修改参数类型和方法相匹配
            object[] newArgs = new object[args.Length];
            for (int index = 0; index < args.Length; index++)
            {
                try
                {
                    if (param[index].ParameterType.IsSubclassOf(typeof(IConvertible)))
                    {
                        newArgs[index] = Convert.ChangeType(args[index], param[index].ParameterType);
                    }
                    else
                    {
                        newArgs[index] = args[index];
                    }
                }
                catch (Exception e)
                {
                    //TODO: dragon luo
                    throw new Exception(method.DeclaringType + "." + method.Name + ": Argument Conversion Failed");

                    //throw new InvokeException(
                    //    method.DeclaringType + "." + method.Name + ": Argument Conversion Failed", e,
                    //    ReturnType.InvokeError);
                }
            }

            //调用方法
            object instance = null;
            if (!method.IsStatic)
            {
                instance = Activator.CreateInstance(type);
            }

            //返回对象
            return method.Invoke(instance, newArgs);
        }
      
        public static void InvokeEvent(string assem, string typeName, string eventName, object sender)
        {
            Assembly assembly = Assembly.Load(assem);
            Type type = assembly.GetType(typeName);
            InvokeEvent(type, eventName, sender);
        }
       
        public static void InvokeEvent(Type type, string eventName, object sender)
        {
            MethodInfo eventMethod = type.GetMethod(eventName);
            object instance = null;
            if (!eventMethod.IsStatic)
            {
                instance = Activator.CreateInstance(type);
            }
            try
            {
                eventMethod.Invoke(instance, new object[] { sender, new EventArgs() });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}