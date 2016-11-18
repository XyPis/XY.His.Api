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
using XY.His.Contract.Message.IN;
using XY.His.Contract.Service.IN;
using XY.His.Domain.IN;

namespace XY.His.Service.IN
{
    public class INHosInfoService : AbstractService<InHosInfo, InHosInfoDto>, IINHosInfoService
    {
    }
}
