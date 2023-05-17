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
    public partial class AccountProfileGUI : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public AccountProfileGUI(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txtUserName.Text = LoginAccount.UserName;
            txtDisplayName.Text = LoginAccount.DisplayName;
            

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateAccount();
        }
        void updateAccount()
        {
            string displayName = txtDisplayName.Text;
            string passWord = txtPassWord.Text;
            string newPass = txtNewPassWord.Text;
            string reEnter = txtReEnter.Text;
            string userName = txtUserName.Text;

            if (!newPass.Equals(reEnter)){
                MessageBox.Show("Passwords do not match. Please re-enter!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, passWord, newPass))
                {
                    MessageBox.Show("Update succesfully");
                }
                else
                {
                    MessageBox.Show("Wrong password!");
                }
            }
        }
    }
}
