using Core.Entities.Common;
using DAL.Context;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        readonly AppDBContext _context;

        public Repository(AppDBContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public IQueryable<TEntity> GetAll()
        {
            return Table;
        }

        public TEntity GetbyId(int id)
        {
            return Table.FirstOrDefault(x => x.Id == id);
        }
    }
}
