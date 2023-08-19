using Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntiyFramwork
{
    public class EfEntityRepository<Tentity, Tcontext> : IEntityRepository<Tentity>
        where Tentity : class, IEntity, new()
        where Tcontext : DbContext, new()
    {
        public void Add(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public List<Tentity> GetAll()
        {
            using (var context = new Tcontext())
            {
                return context.Set<Tentity>().ToList();
            }
        }

        public List<Tentity> GetById(Expression<Func<Tentity, bool>> filter)
        {
            using (var context = new Tcontext())
            {
                return context.Set<Tentity>().Where(filter).ToList();
            }
        }

        public void Update(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
