using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal=new ProductDal();    
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Products
            {
                Name=tbxName.Text,
                UnitPrice=Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount=Convert.ToInt32(tbxStockAmount.Text),

            });
            LoadProducts();
            MessageBox.Show("Added! ");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Products product = new Products()
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            };
            
            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Updated! ");
        }

      

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPrice.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmount.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Products 
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Deleted!  ");

        }
        private void SearchProducts(string key)
        {
            //dgwProducts.DataSource = _productDal.GetAll().Where(p=>p.Name.ToLower().Contains(key.ToLower())).ToList();
            dgwProducts.DataSource=_productDal.GetByName(key);
        }
        private void SearchProductsId(int key)
        {
            //dgwProducts.DataSource = _productDal.GetAll().Where(p=>p.Name.ToLower().Contains(key.ToLower())).ToList();
            if (key==0)
            {
                LoadProducts();
            }
            else
            {
            dgwProducts.DataSource = _productDal.GetById(key);

            }

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text); 
           
        }

        private void tbxId_TextChanged(object sender, EventArgs e)
        {
            if (tbxId.Text == "")
            {
                SearchProductsId(0);
            }
            else
            {
            SearchProductsId(Convert.ToInt32(tbxId.Text));

            }

        }
    }
}
