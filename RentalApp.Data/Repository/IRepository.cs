

using RentalApp.Core.Common;

namespace RentalApp.Data.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        #region Sync Methods

        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
        IList<TEntity> DeleteList(IList<TEntity> entities);
        IEnumerable<TEntity> GetAll();
        IQueryable<TEntity> QueryAble();

        IQueryable<TEntity> QueryAble(Func<TEntity, bool> predicate);
        TEntity GetBy(Func<TEntity, bool> predicate);
        IList<TEntity> GetAllBy(Func<TEntity, bool> predicate);
        IQueryable<TEntity> GetAllByQ(Func<TEntity, bool> predicate);

        IQueryable<TEntity> Table { get; }

        #endregion

        #region Async Methods

        Task InsertAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task DeleteListAsync(IList<TEntity> entities);
        Task<IReadOnlyList<TEntity>> GetAllAsync();

        #endregion

    }
}
