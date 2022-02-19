using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> { 
                new Product {ProductId = 1,CategoryId=1, ProductName="bardak",UnistInStock=15,UnitPrice=15},
                new Product {ProductId = 2,CategoryId=2, ProductName="camera",UnistInStock=3,UnitPrice=500},
                new Product {ProductId = 3,CategoryId=3, ProductName="telefon",UnistInStock=2,UnitPrice=1500},
                new Product {ProductId = 4,CategoryId=4, ProductName="klavye",UnistInStock=65,UnitPrice=150},
                new Product {ProductId = 5,CategoryId=5, ProductName="fare",UnistInStock=1,UnitPrice=85}

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            
        }
    }
}
