using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Domain.Base
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
    }
}
