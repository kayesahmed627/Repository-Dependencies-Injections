using _1278941.Models;
using _1278941.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1278941.Factories
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public IRepository<T> CreateRepository<T>() where T : BaseProductEntity
        {
            return new GenericRepository<T>();
        }
    }
}
