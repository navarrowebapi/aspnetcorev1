using System.Collections.Generic;

namespace WebApplication4.Models
{
    public interface IBeerRepository
    {
        IEnumerable<Beer> GetAllBeers();
        void Add(Beer beer);
    }
}
