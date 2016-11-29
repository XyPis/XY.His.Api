using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using XY.His.Domain;

namespace XY.His.Service
{
    public static class DomainExtensions
    {
        public static T MapTo<T>(this EntityBase entity)
        {
            return (entity == null) ? default(T) : Mapper.Map<EntityBase, T>(entity);
        }

        public static IEnumerable<T> MapTo<T>(this IEnumerable<EntityBase> entities)
        {
            return (entities == null) ? new List<T>() : Mapper.Map<IEnumerable<EntityBase>, IEnumerable<T>>(entities);
        }

        public static void Validation(this EntityBase entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
        }

        public static void Validation(this IEnumerable<EntityBase> entities)
        {
            if (entities == null)
                throw new ArgumentNullException("entities");

            if (!entities.Any())
                throw new ArgumentOutOfRangeException("entities");
        }
    }
}
