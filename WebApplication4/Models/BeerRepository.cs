using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public class BeerRepository : IBeerRepository
    {
        private readonly AppDbContext _appDbContext;

        //Injeção de Dependência por construtor
        //Registrado na classe Startup.cs em ConfigureServices
        public BeerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public IEnumerable<Beer> GetAllBeers()
        {
            return _appDbContext.Beers;
        }

        public void Add(Beer beer)
        {
            if (beer == null)
            {
                throw new ArgumentException("entidade não instanciada");
            }

            _appDbContext.Add(beer);
            _appDbContext.SaveChanges();
        }
    }
}
