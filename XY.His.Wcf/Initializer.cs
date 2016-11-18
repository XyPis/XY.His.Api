using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using System.Reflection;
using log4net;
using System.Data.Entity;
using XY.His.Contract.Service;
using XY.His.Core;
using XY.His.Utils.AutoMapper;
using XY.His.Utils.Unity;
using XY.His.Service.Gbl;
using XY.His.Contract.Service.Gbl;

namespace XY.His.Wcf
{
    public class Initializer
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private const string ConnectionString = "HIS";

        public static void Init()
        {
            Core.Initializer.Init<XyDbContext>(ConnectionString);

            var fromAssembly = typeof(IGblSettingService).Assembly;
            var toAssembly = typeof(GblSettingService).Assembly;

            IoC.RegisterType(fromAssembly, toAssembly, new Type[] { });

            AutoMapperBootStrapper.Initialize(new Assembly[]
            {
                typeof(GblSettingService).Assembly
            });

            IoC.RegisterType<ICommandWrapper, CommandWrapper>();
        }
    }
}