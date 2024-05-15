using _1278941.Models;
using _1278941.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1278941.Factories
{
    public interface IRepositoryFactory
    {
        IRepository<T> CreateRepository<T>() where T : BaseProductEntity;
    }
}
