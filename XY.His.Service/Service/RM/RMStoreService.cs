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
using XY.His.Contract.Message.RM;
using XY.His.Contract.Service.RM;
using XY.His.Domain.RM;

namespace XY.His.Service.RM
{
    public class RMStoreService : AbstractService<Rmstore, RmStoreDto>, IRMStoreService
    {
    }
}
