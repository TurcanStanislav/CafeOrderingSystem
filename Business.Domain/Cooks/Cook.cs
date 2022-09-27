using Business.Domain.Dishes;
using System.Collections.Generic;

namespace Business.Domain.Cooks
{
    public class Cook
    {
        public string Name { get; set; }
        public IList<Dish> Dishes { get; set; } = new List<Dish>();
    }
}
