using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using XY.His.Contract.Message;
using AutoMapper;

namespace XY.His.Service
{
    public static class DtoExtensions
    {
        public static T MapTo<T>(this DtoBase dto)
        {
            return (dto == null) ? default(T) : Mapper.Map<DtoBase, T>(dto);
        }

        public static IEnumerable<T> MapTo<T>(this IEnumerable<DtoBase> dtos)
        {
            return (dtos == null) ? new List<T>() : Mapper.Map<IEnumerable<DtoBase>, IEnumerable<T>>(dtos);
        }

        public static void Validation(this DtoBase dtos)
        {
            if (dtos == null)
                throw new ArgumentNullException("dto");
        }

        public static void Validation(this IEnumerable<DtoBase> dtos)
        {
            if (dtos == null)
                throw new ArgumentNullException("dtos");

            if (!dtos.Any())
                throw new ArgumentOutOfRangeException("dtos");
        }
    }
}
