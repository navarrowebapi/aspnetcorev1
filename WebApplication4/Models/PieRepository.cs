using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication4.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        //Injeção de Dependência por construtor
        //Registrado na classe Startup.cs em ConfigureServices
        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _appDbContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _appDbContext.Pies.FirstOrDefault(c => c.Id == pieId);
        }

        public void Add(Pie pie)
        {
            if (pie == null)
            {
                throw new ArgumentException("entidade não instanciada");
            }

            _appDbContext.Add(pie);
            _appDbContext.SaveChanges();
        }

        public void Update(Pie entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _appDbContext.SaveChanges();
        }

        public void Delete(Pie entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _appDbContext.Pies.Remove(entity);
            _appDbContext.SaveChanges();
        }
    }
}
