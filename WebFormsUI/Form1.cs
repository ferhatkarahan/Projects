using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.EntityFramwork;
using Northwind.DataAccess.Concrete.NHiberNate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService= InstanceFactory.GetInstance<IProductService>();
            _categoryServices = InstanceFactory.GetInstance<ICategoryServices>();
        }

        ICategoryServices _categoryServices;
        IProductService _productService;
        private void Form1_Load(object sender, EventArgs e)
        {
            //dgwProduct.DataSource = _categoryServices.GetAll();
            LoadProducts();
            LoadCategories();
            LoadCategories2();
        }

        private void LoadCategories()
        {
            //dgwProduct.DataSource = _categoryServices.GetAll();
            cbxCategory.DataSource = _categoryServices.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
            
        }
        private void LoadCategories2()
        {
            //dgwProduct.DataSource = _categoryServices.GetAll();
            cbxCategoryId.DataSource = _categoryServices.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";

        }


        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductByCategory(Convert.ToInt32(cbxCategory.SelectedValue));

            }
            catch 
            {

                
            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductByProductName(tbxProductName.Text);

            }
            else
            {
                LoadProducts();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.AddProduct(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                    ProductName = tbxProductName2.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    QuantityPerUnit = tbxQuantityPerUnit.Text,
                    UnitsInStock = Convert.ToInt16(tbxStock.Text)
                });
                LoadProducts();
                MessageBox.Show("Ürün Eklendi. ");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.UpdateProduct(new Product
            {
                ProductId= Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                ProductName = tbxProductName2.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                QuantityPerUnit = tbxQuantityPerUnit.Text,
                UnitsInStock = Convert.ToInt16(tbxStock.Text)
                
            });
            LoadProducts();
            MessageBox.Show("Ürün Güncellendi. ");
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxCategoryId.SelectedValue = dgwProduct.CurrentRow.Cells[1].Value;
            tbxProductName2.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            tbxUnitPrice.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            tbxQuantityPerUnit.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            tbxStock.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.DeleteProduct(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    });
                    LoadProducts();
                    MessageBox.Show("Ürün Silindi. ");
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
