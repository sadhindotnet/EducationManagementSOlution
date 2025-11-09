

using EducationManagement_DLL.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EducationManagement_DLL.Infrastructures.Base
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly SchoolContext _context;
        private DbSet<T> _dbset;
        
     
        public GenericRepository(SchoolContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
            
        }
        public virtual async Task  Add(T entity)
        {
            await  _dbset.AddAsync(entity);
        }
        public async Task Add(List<T> entity)
        {
            await _dbset.AddRangeAsync(entity);
        }

        public void Delete(T entity)
        {
            _dbset.Remove(entity);
        }

        public async Task DeletebyID(int id)
        {
            var entity = _dbset.Find(id) ;
            if(entity!=null)
            { 
                _dbset.Remove(entity); 
            }
        }
        public void DeleteRange(IEnumerable<T> entitylist)
        {
            _dbset.RemoveRange(entitylist);
        }
        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _dbset.ToListAsync();
        }
        public virtual async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? predicate,
            string? includeProperties)
        {
            IQueryable<T> query = _dbset;
            try
            {
                if (predicate != null)
                {
                    query = query.Where(predicate);
                }
                if (includeProperties != null)
                {
                    foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        query = query.Include(item);
                    }
                }
                return await query.ToListAsync();
            }
            catch (Exception ex)
            {
                return await query.ToListAsync();
            }
        }

        public async Task<T> GetById(int id)
        {
            return await _dbset.FindAsync(id);
        }

        public async Task<T> GetT(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return await _dbset.Where(predicate).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                //return null;
                throw new Exception($"Error fetching data: {ex.Message}", ex);

            }
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            //_context.Entry(entity).State = EntityState.Detached;
        }

      
    }
}
