using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Базовый класс для всех сущностей
    /// </summary>

    public abstract class BaseEntity
    {
        /// <summary>
        /// идентификатор для сущностей
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// todo описать
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            
            if(obj is not BaseEntity entity)
            {
                return false;
            }

            if (entity.Id != Id)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            // todo переопределить и понять зачем
            throw new NotImplementedException();
        }
    }
}
