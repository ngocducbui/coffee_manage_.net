using CoffeeManager.DAL;
using CoffeeManager.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManager.GUI
{
    public partial class TableGUI : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value;  }
        }

        public TableGUI(Account acc)
        {
            this.loginAccount = acc;
            InitializeComponent();
            loadTable();
            loadCategory();
            changeAccount();

        }
        void changeAccount()
        {
            if (LoginAccount.Type == 1)
            {
                adminToolStripMenuItem.Enabled = true;
            }
            else
            {
                adminToolStripMenuItem.Enabled = false;
            }
            accountInformationToolStripMenuItem.Text += " (" + loginAccount.DisplayName + ")";
        }
        void loadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cboCategory.DataSource = listCategory;
            cboCategory.DisplayMember = "Name";
        }
        void loadProduct(int idCategory)
        {
            List<Product> listProduct = ProductDAO.Instance.GetFoodByCategoryID(idCategory);
            cboProduct.DataSource = listProduct;
            cboProduct.DisplayMember = "Name";
        }
        void loadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach(Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                flpTable.Controls.Add(btn);
                btn.Text = item.Name+Environment.NewLine+item.Status ;
                btn.ForeColor = Color.Black;
                btn.Click += btn_Click;
                btn.Tag = item;
               // btn.Font = Font.Bold.ToString();

                if (item.Status == "Trống")
                {
                    btn.BackColor = Color.DimGray;
                }
                else
                {
                    btn.BackColor = Color.Aqua;
                }

            }
        }

        void ShowBill(int idTable)
        {
            lsvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(idTable);
            // List<BillInfo> listBillInfo = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetUncheckBillIDByTableID(idTable));
            float totalBill = 0;
            foreach(Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.ProductName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalBill += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            txtTotalBill.Text = totalBill.ToString("c",cultureInfo);
           
        }

        private void btn_Click(object sender, EventArgs e)
        {
            
            //Button b = sender as Button;
            //b.Controls.Clear();
            //b.BackColor = Color.Red;
            int tableId=((sender as Button).Tag as Table).Id ;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableId);
        }

        private void personalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProfileGUI f = new AccountProfileGUI(loginAccount);
            
            f.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminGUI f = new AdminGUI();
            f.loginAccount = LoginAccount;
            f.ShowDialog();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCategory = 0;
            ComboBox c = sender as ComboBox;
            if(c.SelectedItem== null)
            {
                return;
            }
            Category selected = c.SelectedItem as Category;
            idCategory = selected.Id;
            loadProduct(idCategory);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
            int idProduct = (cboProduct.SelectedItem as Product).Id;
            int count = (int)nmCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.Id);
                BillInforDAO.Instance.inserBillInfor(BillDAO.Instance.GetMaxIdBill(), idProduct, count);
            }
            else
            {
                BillInforDAO.Instance.inserBillInfor(idBill, idProduct, count);
            }
            ShowBill(table.Id);
            loadTable();
        }

        private void btnPayment_Click_1(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
            int discount = (int)nmDiscount.Value;
            double totalBill = Convert.ToDouble(txtTotalBill.Text.Split(' ')[0])*1000;
            double totablBillAfterDiscount = totalBill - (totalBill / 100) * discount;
            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Do you really want to pay for the table: {0}\n Total Bill: {1}  VNĐ\n Discount: {2}% \n The total amount to be paid is: {3} VNĐ" , table.Name,totalBill,discount,totablBillAfterDiscount) , "Payment", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill,discount, (float)totablBillAfterDiscount);
                    ShowBill(table.Id);
                    loadTable();
                }
            }
        }
    }
}
