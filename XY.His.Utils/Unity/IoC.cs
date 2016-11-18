using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Microsoft.Practices.Unity;
using log4net;

namespace XY.His.Utils.Unity
{
    public class IoC
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static T Resolve<T>()
        {
            try
            {
                return UnityContext.Instance.Resolve<T>();
            }
            catch (Exception ex)
            {
                Log.ErrorFormat("Resolve Type {0} Exception: {1}", typeof(T), ex.Message);
                throw;
            }
        }

        public static void RegisterType(Assembly fromAssembly, Assembly toAssembly, params Type[] excludeTypes)
        {
            UnityContext.Instance.RegisterTypeInAssembly(fromAssembly, toAssembly, excludeTypes);
        }

        public static void RegisterType<TFrom, TTo>(LifetimeManager lifetimeManager) where TTo : TFrom
        {
            UnityContext.Instance.RegisterType<TFrom, TTo>(lifetimeManager);
        }

        public static void RegisterType<TFrom, TTo>() where TTo : TFrom
        {
            UnityContext.Instance.RegisterType<TFrom, TTo>();
        }

        public static void RegisterType<TFrom, TTo>(params InjectionMember[] injectionMembers) where TTo : TFrom
        {
            UnityContext.Instance.RegisterType<TFrom, TTo>(injectionMembers);
        }
    }
}
