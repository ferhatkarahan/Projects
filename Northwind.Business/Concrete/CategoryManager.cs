using Northwind.Business.Abstract;
using Northwind.Business.Utilities;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryServices
    {
        private ICatergoryDal _catergoryDal;
        public CategoryManager(ICatergoryDal catergoryDal)
        {
            _catergoryDal = catergoryDal;
        }

        public List<Category> GetAll()
        {
            
            return _catergoryDal.GetAll();
        }
        //public void Add(Category category)
        //{
        //    ValidationTools.Validate(new CategoryValidator(),category);
        //    _catergoryDal.AddProduct(category);
        //}
    }
}
