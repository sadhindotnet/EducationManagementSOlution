using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Base
{
    public interface IGenericRepository<T> where T : class
    {
		//Task<IEnumerable<T>> getDATA();
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();

        Task<IEnumerable<T> >GetAll(Expression<Func<T, bool>>? predicate, string? includeProperties);
        //IEnumerable<T> GetAllbyParent(Expression<Func<T, bool>> predicate);
        T GetT(Expression<Func<T, bool>> predicate);
         Task  Add(T entity);
        Task Add(List<T> entity);
        void Delete(T entity);
        Task  DeletebyID(int id);
        void DeleteRange(IEnumerable<T> entitylist);
        void Update(T entity);
    }
}
