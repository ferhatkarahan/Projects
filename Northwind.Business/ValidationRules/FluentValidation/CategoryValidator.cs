using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class CategoryValidator :AbstractValidator<Category>
    {
        public CategoryValidator() 
        {
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Kategori numarası boş olamaz. ");
            RuleFor(p => p.CategoryName).NotEmpty().WithMessage("Kategori Adı boş olamaz. ");
        }

    }
}
