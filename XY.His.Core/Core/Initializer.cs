using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using Microsoft.Practices.Unity;
using XY.His.Utils.Unity;

namespace XY.His.Core
{   
    public class Initializer
    {
        public static void Init<TDbContext>(string connectionString) where TDbContext : DbContext
        {
            IoC.RegisterType<DbContext, TDbContext>(new InjectionConstructor(connectionString));
            IoC.RegisterType<IUnitOfWork, EFUnitOfWork<TDbContext>>();
        }
    }
}