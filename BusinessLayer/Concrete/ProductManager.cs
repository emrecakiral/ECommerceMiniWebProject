using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productdal;

        public ProductManager(IProductDal productdal)
        {
            _productdal = productdal;
        }

        public Product GetByID(int id)
        {
           return _productdal.GetByID(id);
        }

        public List<Product> GetList()
        {
            return _productdal.GetAll();
        }

        public List<Product> GetProductListWithCategory()
        {
            return _productdal.GetListWithCategory();
        }

        public void ProductAdd(Product product)
        {
            _productdal.Insert(product);
        }

        public void ProductDelete(Product product)
        {
            _productdal.Delete(product);
        }

        public void ProductUpdate(Product product)
        {
            _productdal.Update(product);
        }
    }
}
