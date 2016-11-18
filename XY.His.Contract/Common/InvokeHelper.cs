using System;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Collections.Generic;

namespace XY.His.Common
{
    public static class InvokeHelper
    {
        private static Dictionary<string, Assembly> assemblies = new Dictionary<string, Assembly>();
      
        public static object InvokeMethod(string assemblyName, string className, string methodName, object[] args)
        {
            if (!assemblies.ContainsKey(assemblyName))
            {
                lock (assemblies)
                {
                    if (!assemblies.ContainsKey(assemblyName))
                    {
                        Assembly assembly = Assembly.Load(assemblyName);
                        assemblies.Add(assemblyName, assembly);
                    }
                }
            }

            Type type = assemblies[assemblyName].GetType(className);
            return InvokeMethod(type, methodName, args);
        }       
        
        public static object InvokeMethod(Type type, string methodName, object[] args)
        {
            object result = null;
            string errMsg = string.Empty;
            
            MethodInfo mi = type.GetMethod(methodName, GetParameterTypes(args));
            if (mi == null)
            {
                errMsg = string.Format("No method named '{0}' was found in type '{1}'", methodName, type.Name);
                //TODO: dragon luo
                throw new Exception(errMsg);
                //throw new InvokeException("Can not found methodName:" + methodName);
            }
            
            try
            {
                result = Execute(type, mi, methodName, args);
            }
            //catch (InvokeException e)
            catch (Exception e)
            {
                //TODO: dragon luo
                //throw new InvokeException(e.Message);
                errMsg = GetErrMessage(e);
                throw new Exception(errMsg);
            }
            return result;
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
            
            object instance = null;
            if (!method.IsStatic)
            {
                instance = Activator.CreateInstance(type);
            }

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

        private static string GetErrMessage(Exception ex)
        {
            string errMsg = string.Empty;
            Exception innerException = ex.GetInnerException();
            if (innerException != null)
            {
                errMsg = string.Format("{0}: \n{1}", innerException.Message, ex.StackTrace);
            }

            return errMsg;
        }

        public static Exception GetInnerException(this Exception ex)
        {
            if (ex.InnerException == null) return ex;

            return ex.InnerException.GetInnerException();
        }
    }
}