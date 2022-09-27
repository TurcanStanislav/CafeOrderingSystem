using Business.Domain.Cooks.Repository;
using System.Collections.Generic;
using CookEntity = Business.Domain.Cooks.Cook;

namespace Business.Repository.Cook
{
    public class CookRepository : ICookRepository
    {
        public IEnumerable<CookEntity> GetAll()
        {
            return new List<CookEntity>
                    {
                        new CookEntity { Name = "Boris Fooler" },
                        new CookEntity { Name = "Elena Rotaru" },
                        new CookEntity { Name = "Gill Lorance" }
                    };
        }
    }
}
