using QuanLyGhiDanh.AppDBContext;
using QuanLyGhiDanh.Entitys;
using System.Linq.Expressions;

namespace QuanLyGhiDanh.Repository_.IBase
{
    public class IBaseRepository<T> where T : class
    {
        protected readonly DBContext _context;

        protected IBaseRepository()
        {
            _context = new DBContext();
        }

        public IQueryable<T?> GetAll()
        {
            try
            {
                return _context.Set<T>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting entity: {ex.Message}", ex);
            }
        }

        public async Task<T?> GetById(string id)
        {
            try
            {
                var entity = await _context.Set<T>().FindAsync(id);
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting entity: {ex.Message}", ex);
            }
        }

        public async Task Add(T entity)
        {
            try
            {
                await _context.Set<T>().AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting entity: {ex.Message}", ex);
            }
        }

        public async Task Update(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting entity: {ex.Message}", ex);
            }
        }

        public async Task Delete(T id)
        {
            try
            {
                var item = await _context.Set<T>().FindAsync(id);
                if (item != null)
                {
                    _context.Set<T>().Remove(item);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting entity: {ex.Message}", ex);
            }
        }

    }
}
