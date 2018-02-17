using System.Collections.Generic;

namespace WebApplication4.Models
{
    public interface IPieRepository
    {
        //CRUD
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
        void Add(Pie pie);
        void Update(Pie pie);
        void Delete(Pie pie);
    }
}