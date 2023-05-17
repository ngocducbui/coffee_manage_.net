using CoffeeManager.DAL;
using CoffeeManager.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManager.GUI
{
    public partial class AdminGUI : Form
    {
        BindingSource productList = new BindingSource();
        BindingSource accountList = new BindingSource();
        BindingSource categoryList = new BindingSource();

        public Account loginAccount;
        public AdminGUI()
        {
            InitializeComponent();
            dtgvProducts.DataSource = productList;
            dtgvAccounts.DataSource = accountList;
            dtgvCategory.DataSource = categoryList;
            loadBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoaDateTime();
            LoadListProduct();
            loadAccount();
            addBinding();
            loadCategoryIntoComboBox(cboCategoryProduct);
            addAccountBingding();
            binddingCategory();
            loadCategory();
        }
        void addAccountBingding()
        {
            txtUserNameAccount.DataBindings.Add(new Binding("Text",dtgvAccounts.DataSource,"UserName", true, DataSourceUpdateMode.Never));
            txtDisplayNameAccount.DataBindings.Add(new Binding("Text", dtgvAccounts.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmTypeAccount.DataBindings.Add(new Binding("Value", dtgvAccounts.DataSource, "Type", true, DataSourceUpdateMode.Never));
          //  txtUserNameAccount.DataBindings.Add(new Binding("Text", dtgvAccounts.DataSource, "Price", true, DataSourceUpdateMode.Never));

        }
        void loadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.getListAccount();
        }
        void LoaDateTime()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);

        }
        void loadBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetListBillByDate(checkIn,checkOut);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private void btnLoadProducts_Click(object sender, EventArgs e)
        {
            LoadListProduct();
        }
        void LoadListProduct()
        {
            productList.DataSource = ProductDAO.Instance.getListProduct();
            dtgvProducts.Columns["Id"].Visible = false;
        }
        void addBinding()
        {
            txtProductsName.DataBindings.Add(new Binding("Text", dtgvProducts.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtProductsID.DataBindings.Add(new Binding("Text", dtgvProducts.DataSource, "Id", true, DataSourceUpdateMode.Never));
            nmPriceProducts.DataBindings.Add(new Binding("Value", dtgvProducts.DataSource, "Price", true, DataSourceUpdateMode.Never));

        }
        void loadCategoryIntoComboBox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        private void txtProductsID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvProducts.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvProducts.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    cboCategoryProduct.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cboCategoryProduct.Items)
                    {
                        if (item.Id == cateogory.Id)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cboCategoryProduct.SelectedIndex = index;
                }
            }
            catch { }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string name = txtProductsName.Text;
            int categoryId = (cboCategoryProduct.SelectedItem as Category).Id;
            float price = (float)nmPriceProducts.Value;
            if (ProductDAO.Instance.inserProduct(name, categoryId, price))
            {
                MessageBox.Show("Add product successfully.");
                LoadListProduct();
            }
            else
            {
                MessageBox.Show("Add product failed");
            }
        }

        private void btnUpdateProdcuts_Click(object sender, EventArgs e)
        {
            string name = txtProductsName.Text;
            int categoryId = (cboCategoryProduct.SelectedItem as Category).Id;
            float price = (float)nmPriceProducts.Value;
            int id = Convert.ToInt32(txtProductsID.Text);
            if (ProductDAO.Instance.updateProduct(id,name, categoryId, price))
            {
                MessageBox.Show("Update product successfully.");
                LoadListProduct();
            }
            else
            {
                MessageBox.Show("Update product failed");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtProductsID.Text);
            if (ProductDAO.Instance.deleteProduct(id))
            {
                MessageBox.Show("Delete product successfully.");
                LoadListProduct();
            }
            else
            {
                MessageBox.Show("Delete product failed");
            }

        }

        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            loadAccount();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserNameAccount.Text;
            string displayName = txtDisplayNameAccount.Text;
            int type = (int)nmTypeAccount.Value;
            addAccount(userName, displayName, type);
        }
        void addAccount(string userName, string displayName, int type)
        {
           if(AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Add account successfully");
                loadAccount();
            }
            else
            {
                MessageBox.Show("Add account failed");
            }
        }
        void updateAccount(string userName, string displayName,int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Update account successfully");
                loadAccount();
            }
            else
            {
                MessageBox.Show("Update account failed");
            }
        }
        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserNameAccount.Text;
            string displayName = txtDisplayNameAccount.Text;
            int type = (int)nmTypeAccount.Value;
            updateAccount(userName,displayName,type);
        }

        void deleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Can't delete account worth logging in!");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName)){
                MessageBox.Show("Delete account successfully");
                loadAccount();
            }
            else
            {
                MessageBox.Show("Delete account failed");
            }
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserNameAccount.Text;
            deleteAccount(userName);
        }
        void resetPassWord(string userName)
        {
            
            if (AccountDAO.Instance.resetPassWord(userName))
            {
                MessageBox.Show("Reset password successfully");
                
            }
            else
            {
                MessageBox.Show("Reset password failed");
            }
        }
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = txtUserNameAccount.Text;
            resetPassWord(userName);
        }
        void loadCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();

        }
        void binddingCategory()
        {
            txtIDCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txtNameCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));


        }
        void addCategory(string name)
        {
            
            if (CategoryDAO.Instance.addCategory(name))
            {
                MessageBox.Show("Add category successfully");
                loadCategory();
            }
            else
            {
                MessageBox.Show("Add category failed");
            }
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txtNameCategory.Text;
            addCategory(name);
        }
        void updateCategory(int id,string name)
        {
            if (CategoryDAO.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("Update category successfully");
                loadCategory();
            }
            else
            {
                MessageBox.Show("Update category failed");

            }
        }
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDCategory.Text);
            string name = txtNameCategory.Text;
            updateCategory(id,name);
        }
        void deleleCategory(int id)
        {
            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Delete category successfully");
                loadCategory();
            }
            else
            {
                MessageBox.Show("Delete category failed");

            }
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDCategory.Text);

            deleleCategory(id);
        }

        private void btnViewCategory_Click(object sender, EventArgs e)
        {
            loadCategory();
        }
        List<Product> SearchProduct(string name)
        {
            List<Product> listProduct = ProductDAO.Instance.SearchProductByName(name);
            return listProduct;
        }
        private void btnSearchProducts_Click(object sender, EventArgs e)
        {
          productList.DataSource=  SearchProduct(txtSearch.Text);
        }
    }
}
