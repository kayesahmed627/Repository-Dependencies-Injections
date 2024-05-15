using _1278941.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1278941.Repositories
{
    public interface IRepository<T> where T : BaseProductEntity
    {
        List<T> GetAll();
        T Get(int id);
        void Add (T entity);
        void AddRange(IEnumerable<T> entities);
        void Update (T entity);
        void Delete (int id);
    }
}
