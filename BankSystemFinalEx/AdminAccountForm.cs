using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Principal;

namespace BankSystemFinalEx
{
    public partial class AdminAccountForm : Form
    {
        private ListViewItem ClickedAccount;

        private static List<Account> getAllUsers()
        {
            List<Account> contents = new List<Account>();

            string[] usersFiles = Directory.GetFiles(Program.usersPath);

            foreach (string userPath in usersFiles)
            {
                string userId = Path.GetFileName(userPath);
                if (!userId.All(Char.IsDigit))
                {
                    continue;
                }

                try
                {
                    contents.Add(Account.FromId(userId));
                }
                catch
                {
                    // Do nothing
                }
            }
            return contents;
        }

        public AdminAccountForm()
        {
            InitializeComponent();
        }

        private void compensateBtn_Click(object sender, EventArgs e)
        {
            Account otherAccount;
            uint amountToSend = uint.Parse(compensateBox.Value.ToString());
            string selectedAccountId = accountsList.SelectedItems[0].Text;
            compensateBox.Value = 0;

            try
            {
                otherAccount = Account.FromId(selectedAccountId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error compensating account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                otherAccount.deposit(amountToSend);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error depositing money", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            updateAccountsList();
        }

        private void accountsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clickedAccount = (sender as ListView).SelectedItem;
        }

        private void updateAccountsList()
        {
            accountsList.Clear();
            setAccountList();
            long totalFunds = 0;

            var users = getAllUsers();
            foreach (var user in users)
            {
                var userItem = new ListViewItem(user.Id);
                userItem.SubItems.Add(user.FirstName);
                userItem.SubItems.Add(user.LastName);
                userItem.SubItems.Add(user.Balance.ToString());
                accountsList.Items.Add(userItem);

                totalFunds += user.Balance;
            }

            totalFundsLbl.Text = $"Total funds in bank: {totalFunds}";
        }

        private void accountsList_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                updateAccountsList();
            }
            else
            {
                ClickedAccount = null;
                accountsList.Clear();
            }
        }

        private void setAccountList()
        {
            accountsList.View = View.Details;

            accountsList.Columns.Add("ID", 120);
            accountsList.Columns.Add("Name", 120);
            accountsList.Columns.Add("Last Name", 120);
            accountsList.Columns.Add("Balance", 150);
        }

        private void AdminAccountForm_Load(object sender, EventArgs e)
        {
            updateAccountsList();
            compensateBox.Maximum = uint.MaxValue;
        }

        private void deleteUser(string userId)
        {
            File.Delete($"{Program.usersPath}\\{userId}");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string selectedAccountId = accountsList.SelectedItems[0].Text;
            deleteUser(selectedAccountId);
            updateAccountsList();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("You are about to delete all the users in the system, are you sure?", "Critical", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (var account in getAllUsers())
                {
                    deleteUser(account.Id);
                }
                updateAccountsList();
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Program.signOut(this);
        }
    }
}
