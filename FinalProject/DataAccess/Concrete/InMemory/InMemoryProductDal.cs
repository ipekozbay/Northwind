using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Product {ProductId = 1,CategoryId=1, ProductName="bardak",UnitsInStock=15,UnitPrice=15},
                new Product {ProductId = 2,CategoryId=2, ProductName="camera",UnitsInStock=3,UnitPrice=500},
                new Product {ProductId = 3,CategoryId=3, ProductName="telefon",UnitsInStock=2,UnitPrice=1500},
                new Product {ProductId = 4,CategoryId=4, ProductName="klavye",UnitsInStock=65,UnitPrice=150},
                new Product {ProductId = 5,CategoryId=5, ProductName="fare",UnitsInStock=1,UnitPrice=85}

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // language integrated query
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public List<Product> GetAllByCategory(int categoryId);
        {
            return public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        _products.Where(p=>p.CategoryId == categoryId).ToList();
        }
        
    }
}
