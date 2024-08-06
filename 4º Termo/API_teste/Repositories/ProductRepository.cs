using System;
using System.Collections.Generic;
using System.Linq;
using API_teste.Domains;
using API_teste.Interfaces;
using API_teste.Context;
using Microsoft.EntityFrameworkCore;

namespace API_teste.Repositories
{
    public class ProductRepository : IProductsRepository
    {
        private readonly API_testeContext _context = new API_testeContext();

      
        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void Post(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public Product GetById(Guid id)
        {
            return _context.Products.Find(id);
        }

        public void Put(Guid id, Product product)
        {
            var existingProduct = _context.Products.Find(id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                _context.SaveChanges();
            }
        }
    }
}
