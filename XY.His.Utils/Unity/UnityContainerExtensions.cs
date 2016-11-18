using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.Practices.Unity;

namespace XY.His.Utils.Unity
{
    public static class UnityContainerExtensions
    {
        public static void RegisterTypeInAssembly(this IUnityContainer unityContainer, Assembly fromAssembly, Assembly toAssembly, params Type[] excludeTypes)
        {
            var fromTypes = GetTypes(fromAssembly, EnumRegisterType.FromType);
            var toTypes = GetTypes(toAssembly, EnumRegisterType.ToType);

            foreach (var key in fromTypes.Keys)
            {                
                Type fromType = fromTypes[key];
                if (excludeTypes.Any()) 
                {
                    if (excludeTypes.Where(x => x.Name == fromType.Name).Any()) 
                        continue;
                }                
                
                foreach (var servieKey in toTypes.Keys)
                {
                    Type toType = toTypes[servieKey];
                    if (fromType.IsAssignableFrom(toType))
                    {
                        if (!unityContainer.IsRegistered(fromType))
                        {
                            unityContainer.RegisterType(fromType, toType);
                        }                        
                    }
                }
            }
        }

        static Dictionary<string, Type> GetTypes(Assembly assembly, EnumRegisterType registerType)
        {
            var types = new Dictionary<string, Type>();

            foreach (Type t in assembly.GetTypes())
            {
                if (registerType == EnumRegisterType.FromType)
                {
                    if (t.IsInterface)
                    {
                        if (!types.ContainsKey(t.FullName))
                        {
                            types.Add(t.FullName, t);
                        }
                    }
                }
                else if (registerType == EnumRegisterType.ToType)
                {
                    if (!t.IsInterface)
                    {
                        if (!types.ContainsKey(t.FullName))
                        {
                            types.Add(t.FullName, t);
                        }
                    }
                }
                else 
                {
                   
                }
            }

            return types;
        }

        internal enum EnumRegisterType
        {
            FromType = 0,
            ToType = 1,
        }
    }    
}
