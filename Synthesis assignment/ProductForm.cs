using BusinessLogic;
using BusinessLogic.Entities;
using DataAccessLayer;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synthesis_assignment
{
    public partial class ProductForm : Form
    {
        ProductManagement productmanagement;
        ProductDAL productdal;

        public ProductForm()
        {
            InitializeComponent();
            productdal = new ProductDAL();  
            productmanagement = new ProductManagement(productdal);
            cbxProductSub.DataSource = productmanagement.AddSubCategorytoList();
            cbUpdateSubCategory.DataSource=productmanagement.AddSubCategorytoList();
            //cbxCategory.DataSource=productmanagement.AddCategoryToList();
            FillCbx();
            FillDgv();
            
        }
        

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!String.IsNullOrEmpty(tbNameCategory.Text))
                {
                    Category category = new Category(tbNameCategory.Text);
                    if (productmanagement.CheckCategoryexist(category))
                    {
                        MessageBox.Show("Sorry this Category was exist");
                    }
                    else
                    {
                        productmanagement.AddCategory(category);
                        MessageBox.Show("Category successul added");
                        tbNameCategory.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the infomation");
                }
            }
            catch (Exception ex)
            {

            }
        }

        

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try {
                

                if(!String.IsNullOrEmpty(tbAnameCategory.Text)&& !String.IsNullOrEmpty(tbAPrice.Text)&& !String.IsNullOrEmpty(tbAUnit.Text)&& !String.IsNullOrEmpty(tbAQuantity.Text)&& cbxProductSub.SelectedIndex != -1)
                {
                    if (!productmanagement.CheckProductWasExist(new Product(tbAnameCategory.Text)))
                    {
                        decimal price = Convert.ToDecimal(tbAPrice.Text);
                        int quantity = Convert.ToInt32(tbAQuantity.Text);
                        Category category = productmanagement.GetSubCategoryID((Category)cbxProductSub.SelectedItem);
                        Product product = new Product(tbAnameCategory.Text, price, tbAUnit.Text, quantity);
                        productmanagement.AddProduct(product, category);
                        FillDgv();
                        tpProduct.SelectTab(tPInfor);
                    }
                    else
                    {
                        MessageBox.Show("Sorry this product was exist");
                    }

                    

                }
                else
                {
                    MessageBox.Show(" Sorry please fill all the information");
                }
            }
            catch 
            { 
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = tbSearch.Text;
                if (!String.IsNullOrEmpty(search))
                {
                    if (productmanagement.SearchProduct(new Product(search)))
                    {
                        dgvProduct.DataSource = productmanagement.GetAllProduct().Where(x => x.Name == search).Select(y => new Product(y.ID, y.SubCategory, y.Name, y.Price, y.Unit, y.Quantity)).ToList();
                        if (!productmanagement.GetAllProduct().Any(x => x.Name == search))
                        {
                            MessageBox.Show("Sorry we can't find this product");

                        }
                    }
                    else
                    {
                        dgvProduct.DataSource = null;
                        dgvProduct.DataSource = productmanagement.GetAllProduct();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FillDgv()
        {
            dgvProduct.DataSource = null;
            dgvProduct.DataSource = productmanagement.GetAllProduct();
            dgvProduct.ClearSelection();
            
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbIDProduct.Text);
                string name = tbUpdateName.Text;
                decimal price = Convert.ToDecimal(tbUpdataPrice.Text);
                int quantity = Convert.ToInt32(tbUpdateQuantity.Text);

                Category category = productmanagement.GetSubCategoryID((Category)cbUpdateSubCategory.SelectedItem);
                
                productmanagement.UpdateProduct(new Product(id, name, price, tbUpdateUnit.Text, quantity), category);
                MessageBox.Show("Your update was successed");
                FillDgv();
                 tpProduct.SelectTab(tPInfor);
                
                   

            }
            catch (Exception ex)
            {
                MessageBox.Show("please check the information ");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dgvProduct.CurrentCell.RowIndex;
                var selectedProduct = productmanagement.GetAllProduct()[selectedIndex];


                    tbIDProduct.Text = selectedProduct.ID.ToString();
                    tbUpdateName.Text = selectedProduct.Name;
                    tbUpdataPrice.Text = selectedProduct.Price.ToString();
                    tbUpdateUnit.Text = selectedProduct.Unit.ToString();
                    tbUpdateQuantity.Text = selectedProduct.Quantity.ToString();
                    //cbUpdateSubCategory.SelectedIndex = selectedProduct.SubCategory;
                    
                    tpProduct.SelectTab(tPUpdateProduct);
                
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dgvProduct.CurrentCell.RowIndex;
                var selectedProduct = productmanagement.GetAllProduct()[selectedIndex];
                DialogResult deleteProduct = MessageBox.Show("Do you want to remove this Product ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (deleteProduct == DialogResult.Yes)
                {
                    productmanagement.DeleteProduct(new Product(selectedProduct.ID));
                    MessageBox.Show("this Product was deleted ");
                    FillDgv();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddSubcategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbAddSubcategory.Text)) 
                { 
                    if(productmanagement.CheckSubcategoryWasExist(new Category(tbAddSubcategory.Text)))
                    {
                        MessageBox.Show("sorry this subcategory was exist");

                    }
                    else
                    {
                        string name = tbAddSubcategory.Text;
                        Category category = productmanagement.GetParentCategoryID((Category)cbxCategory.SelectedItem);
                        productmanagement.AddSubCategory(new Category(name,category));
                        MessageBox.Show("Add subcategory successed");
                        FillCbx();

                    }
                }
                else
                {
                    MessageBox.Show("please fill information ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        public void FillCbx()
        {
            cbxCategory.Items.Clear();
            cbxCategory.DataSource = productmanagement.AddCategoryToList();

        }
    }
}
