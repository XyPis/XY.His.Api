using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Reflection;
using System.Transactions;
using System.Linq.Expressions;
using System.Data.Objects.SqlClient;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using log4net;
using XY.His.Contract.Message.Gbl;
using XY.His.Contract.Service.Gbl;
using XY.His.Domain.Gbl;

namespace XY.His.Service.Gbl
{
    public class GblSettingService : AbstractService<GblSetting, GblSettingDto>, IGblSettingService
    {        
    }
}
