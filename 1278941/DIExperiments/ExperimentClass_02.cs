using _1278941.Factories;
using _1278941.Models;
using _1278941.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1278941.DIExperiments
{
    public class ExperimentClass_02
    {
        public void Run(IRepositoryFactory repositoryFactory)
        {
            IRepository<Category> category = repositoryFactory.CreateRepository<Category>();
            category.AddRange(new Category[]
            {
                new Category{ Id=1, Name="Bag"},
                new Category{ Id=2, Name="Belt"},
                new Category{ Id=3, Name="Shoe"},
                new Category{ Id=4, Name="Boots"},
                new Category{ Id=5, Name="Sock"}
            });
            //Get All Product:
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~GetAll~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            category.GetAll().ToList()
           .ForEach(c => Console.WriteLine($"Id: {c.Id}, Name: {c.Name}"));
            //Get Product By Id:
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Get~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            var cat = category.Get(3);
            Console.WriteLine($"Id: {cat.Id}, Name: {cat.Name}");
            //Update Product:
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Update~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            cat.Name = "Punjabi";
            category.Update(cat);
            category.GetAll().ToList()
           .ForEach(c => Console.WriteLine($"Id: {c.Id}, Name: {c.Name}"));
            //Delete Product:
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Delete~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            category.Delete(3);
            category.GetAll().ToList()
           .ForEach(c => Console.WriteLine($"Id: {c.Id}, Name: {c.Name}"));
            Console.WriteLine();
            Console.WriteLine("****************************!!!!!!!!!!!!!!!!!!!!!!!!!!!*****************************************");
            Console.WriteLine();
            IRepository<Product> product = repositoryFactory.CreateRepository<Product>();
            product.AddRange(new Product[]
              {
                new Product{ Id=1, Name="Clip Board", Price=110.00M, Stock=30, CategoryId=1},
                new Product{ Id=2, Name="Eraser", Price=17.00M, Stock=30, CategoryId=2},
                new Product{ Id=3, Name="Sharpener", Price=10.00M, Stock=30, CategoryId=3},
                new Product{ Id=4, Name="Pencil", Price=20.00M, Stock=30, CategoryId=4},
                new Product{ Id=5, Name="Book", Price=220.00M, Stock=30, CategoryId=5}
              });
            //Get All Product:
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^GetAll^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine();
            product.GetAll().ToList()
           .ForEach(p => Console.WriteLine($"Id:{p.Id}, Name: {p.Name}, Price: {p.Price}, Stock: {p.Stock}"));
            //Get Product By Id:
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Get^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine();
            var products = product.Get(2);
            Console.WriteLine($"Id:{products.Id}, Name: {products.Name}, Price: {products.Price}, Stock: {products.Stock}");
            //Update Product:
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Update^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine();
            products.Price = 1900;
            product.Update(products);
            product.GetAll().ToList()
           .ForEach(p => Console.WriteLine($"Id:{p.Id}, Name: {p.Name}, Price: {p.Price}, Stock: {p.Stock}"));
            //Delete Product:
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Delete^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine();
            product.Delete(2);
            product.GetAll().ToList()
           .ForEach(p => Console.WriteLine($"Id:{p.Id}, Name: {p.Name}, Price: {p.Price}, Stock: {p.Stock}"));

        }
    }
}
