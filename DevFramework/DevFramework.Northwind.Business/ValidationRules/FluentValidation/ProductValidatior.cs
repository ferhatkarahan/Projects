﻿using DevFramework.Northwind.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidatior :AbstractValidator<Product>
    {
        public ProductValidatior()
        {
             RuleFor(p=>p.ProductId).NotEmpty();
             RuleFor(p=>p.CategoryId).NotEmpty();
             RuleFor(p=>p.ProductName).NotEmpty();
             RuleFor(p=>p.UnitPrice).NotEmpty();
             RuleFor(p=>p.QuantityPerUnit).NotEmpty();

            RuleFor(p => p.ProductName).Length(2,20);
            //RuleFor(p => p.ProductName).Must(StartswithA);


        }

        //private bool StartswithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
