using HarshilBooks.DataAccess.Repository.IRepository;
using HarshilBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HarshilBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}