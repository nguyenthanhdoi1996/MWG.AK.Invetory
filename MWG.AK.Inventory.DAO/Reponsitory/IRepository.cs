using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.Reponsitory
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        //T Get(long id);
        bool Insert(T entity);
        void InsertRange(List<T> entities);

        bool Update(T entity);
        void Delete(T entity);

        void DeleteAll(List<T> entities);

        IQueryable<T> Queryable();

    }
}
