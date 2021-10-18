using Microsoft.EntityFrameworkCore;
using MySocialNetwork.Core.Entities;
using MySocialNetwork.Core.Interfaces;
using MySocialNetwork.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly SocialMediaContext _context;
        protected DbSet<T> _entities;
        public BaseRepository(SocialMediaContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public async Task<T> GetById(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task Insert(T entity)
        {
            await _entities.AddAsync(entity);

        }

        public void Update(T entity)
        {
            _entities.Update(entity);

        }

        public async Task Delete(int id)
        {
            T Entity = await GetById(id);
            _entities.Remove(Entity);

        }

    }
}
