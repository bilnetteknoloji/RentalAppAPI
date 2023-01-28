using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>
     where TEntity : class
    {
        public readonly RentalAppContext Context;
        private readonly DbSet<TEntity> _entities;

        #region ctor
        public Repository(RentalAppContext context)
        {
            Context = context;
            _entities = context.Set<TEntity>();
        }
        #endregion

        #region Sync Methods    

        private async Task<int> SaveChangesAsync()
        {
            return await Context.SaveChangesAsync();
        }

        private int SaveChanges()
        {
            return Context.SaveChanges();
        }
        #endregion

        #region Sync Methods              
        public TEntity Insert(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _entities.Add(entity);
            SaveChanges();
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _entities.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
            SaveChanges();

            return entity;
        }

        public TEntity Delete(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _entities.Attach(entity);
            Context.Entry(entity).State = EntityState.Deleted;
            SaveChanges();
            return entity;
        }

        public IList<TEntity> DeleteList(IList<TEntity> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            var result = new List<TEntity>();

            foreach (var item in entities)
            {
                result.Add(Delete(item));
            }

            return result;
        }

        public IEnumerable<TEntity> GetAll() =>
            _entities.AsNoTracking().AsEnumerable();

        public IQueryable<TEntity> QueryAble()
        {
            return _entities.AsQueryable();
        }

        public IQueryable<TEntity> QueryAble(Func<TEntity, bool> predicate)
        {
            return _entities.Where(predicate).AsQueryable();
        }

        public TEntity GetBy(Func<TEntity, bool> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            var result = _entities.FirstOrDefault(predicate);
            return result!;
        }

        public IList<TEntity> GetAllBy(Func<TEntity, bool> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            return _entities.Where(predicate).ToList();
        }

        public IQueryable<TEntity> GetAllByQ(Func<TEntity, bool> predicate)
        {
            return _entities.Where(predicate).AsQueryable();
        }


        #endregion

        #region Async Methods      

        public async Task InsertAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            await _entities.AddAsync(entity);
            await SaveChangesAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _entities.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
            await SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            _entities.Attach(entity);
            Context.Entry(entity).State = EntityState.Deleted;
            await SaveChangesAsync();
        }

        public async Task DeleteListAsync(IList<TEntity> entities)
        {
            if (entities == null)
                throw new ArgumentNullException("entity");

            foreach (var item in entities)
            {
                await DeleteAsync(item);
            }
        }

        public async Task<IReadOnlyList<TEntity>> GetAllAsync() =>
            await _entities.ToListAsync();

        #endregion



    }
}
