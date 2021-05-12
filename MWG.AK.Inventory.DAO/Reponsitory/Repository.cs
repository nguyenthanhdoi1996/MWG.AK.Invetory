using Microsoft.EntityFrameworkCore;
using MWG.AK.Inventory.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.Reponsitory
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly InventoryContext masterContext;
        protected readonly DbSet<T> masterEntities;

        public Repository(InventoryContext context)
        {
            this.masterContext = context;
            masterEntities = context.Set<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return masterEntities.AsEnumerable<T>();
        }

        //public virtual T Get(long id)
        //{
        //    return masterEntities.SingleOrDefault(s => s.Id == id);
        //}

        public bool Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            masterEntities.Add(entity);
            return masterContext.SaveChanges() > 0;
        }

        public bool Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            masterEntities.Update(entity);
            return masterContext.SaveChanges() > 0;
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            masterEntities.Remove(entity);
            masterContext.SaveChanges();
        }

        public void DeleteAll(List<T> ts)
        {
            if (!ts.Any())
            {
                throw new ArgumentNullException(nameof(masterEntities));
            }
            masterEntities.RemoveRange(ts);
            masterContext.SaveChanges();
        }

        public virtual IQueryable<T> Queryable()
        {
            return masterEntities;
        }


        public void InsertRange(List<T> entitiesToAdd)
        {
            if (entitiesToAdd == null || entitiesToAdd.Count == 0)
            {
                throw new ArgumentNullException(nameof(entitiesToAdd));
            }
            masterEntities.AddRange(entitiesToAdd);
            int result = masterContext.SaveChanges();
        }
    }
}
