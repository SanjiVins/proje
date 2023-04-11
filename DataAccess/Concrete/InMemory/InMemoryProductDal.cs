using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{Id=1,  Name="bardak", UnitPrice=15, UnitsInStock=15},
                new Product{Id=2,  Name="kamera", UnitPrice=500, UnitsInStock=3},
                new Product{Id=3,  Name="telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{Id=4,  Name="klavye", UnitPrice=150, UnitsInStock=65},
                new Product{Id=5,  Name="fare", UnitPrice=85, UnitsInStock=1},
                new Product{Id=6,  Name="deri çanta", UnitPrice=85, UnitsInStock=1},
            };
        }
        public List<Product> GetAll()
        {
            return _products;
        }
        public List<Product> GetAllByName(string name)
        {
           var result = _products.Where(p => p.Name.Contains(name)).ToList();
           return result;
        }
    }
}
