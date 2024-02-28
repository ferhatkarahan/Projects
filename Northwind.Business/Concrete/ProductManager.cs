using FluentValidation;
using Northwind.Business.Abstract;
using Northwind.Business.Utilities;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFramwork;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void AddProduct(Product product)
        {
            ValidationTools.Validate1(new ProductValidator(),product);
            _productDal.AddProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            try
            {
                _productDal.DeleteProduct(product);
            }
            catch (Exception)
            {

                throw new Exception("Silme Gerçekleşmedi. ");
            }
            
        }

        public List<Product> GetAll() 
        {
           return  _productDal.GetAll();
        }

        public List<Product> GetProductByCategory(int categoryId)
        {
            return _productDal.GetAll(p=>p.CategoryId==categoryId);
        }

        public List<Product> GetProductByProductName(string searchKey)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(searchKey.ToLower()));
        }

        public void UpdateProduct(Product product)
        {
            _productDal.UpdateProduct(product);
        }
    }
}
