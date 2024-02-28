using DevFramework.Core.Aspect.Postsharp;
using DevFramework.Core.Aspect.Postsharp.AuthorizationAspects;
using DevFramework.Core.Aspect.Postsharp.LogAspects;
using DevFramework.Core.Aspect.Postsharp.PerformanceAspect;
using DevFramework.Core.Aspect.Postsharp.TransactionAspects;
using DevFramework.Core.Aspect.Postsharp.ValidationAspects;
using DevFramework.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.ValidationRules.FluentValidation;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concrete;
using PostSharp.Aspects.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private  IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
                _productDal = productDal;
        }

        [FluentValidationAspect(typeof(ProductValidatior))]
        [PerformanceCounterAspect(2)]
        public Product Add(Product product)
        {
            return _productDal.Add(product);    
        }

        public void Delete(int id)
        {
             _productDal.Delete(GetById(id));
        }

        [LogAspect(typeof(DatabaseLogger))]
        [LogAspect(typeof(FileLogger))]
        [SecuredOperation(Roles="Admin,Editor")]
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }
        [TransactionScopeAspect]
        public void TransactionalOperation(Product product1,Product product2)
        {
            _productDal.Add(product1);
            //Business Codes
            _productDal.Update(product2);
        }

        [FluentValidationAspect(typeof(ProductValidatior))]
        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
    }
}
