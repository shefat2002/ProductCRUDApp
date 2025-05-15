﻿using Microsoft.EntityFrameworkCore;
using ProductCRUDApp.Repository.RepositoryInterface;
using SimpleCRUDApp.Data;
using System.Linq.Expressions;

namespace WebApplicationProduct.Features.DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();

        }
        public async Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] Includes)
        {
            IQueryable<T> query = _dbSet;
            foreach (var item in Includes)
            {
                query = query.Include(item);
            }
            return await query.FirstOrDefaultAsync(e => EF.Property<int>(e, "Id") == id);
            //return await _context.Set<T>().FindAsync(id);

        }
        public async Task Update(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }


    }
}
