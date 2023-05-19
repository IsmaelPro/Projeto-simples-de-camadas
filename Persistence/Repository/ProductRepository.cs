using Domain.Entities;
using Infra.Repository;
using Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class ProductRepository : IProductRepository
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> Get()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product Insert(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}