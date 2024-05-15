using _1278941.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1278941.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseProductEntity
    {
        private readonly IList<T> products;
        public GenericRepository() 
        { 
            this.products = new List<T>();
        }

        public List<T> GetAll()
        {
            return this.products.ToList();
        }

        public T Get(int id)
        {
            return this.products.FirstOrDefault(x => x.Id == id);
        }

        public void Add(T entity)
        {
           this.products.Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                this.products.Add(entity);
            }
        }


        public void Update(T entity)
        {
           int i = this.products.IndexOf(entity);
            this.products.RemoveAt(i);
            this.products.Add(entity);
        }
        public void Delete(int id)
        {
           var entity= this.products.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                this.products.Remove(entity);
            }
        }
    }
}
