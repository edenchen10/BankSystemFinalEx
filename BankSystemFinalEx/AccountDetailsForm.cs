using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemFinalEx
{
    public partial class AccountDetailsForm : Form
    {
        private Account CurAccount;

        public AccountDetailsForm()
        {
            InitializeComponent();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            CurAccount = null;
            Program.signOut(this);
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            var amount = uint.Parse(depositBox.Value.ToString());
            depositBox.Value = 0;

            try
            {
                CurAccount.deposit(amount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error depositing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            updateBalanceLabel();
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            var amount = uint.Parse(withdrawBox.Value.ToString());
            withdrawBox.Value = 0;

            try
            {
                CurAccount.withdraw(amount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error withdrawing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            updateBalanceLabel();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            Account otherAccount;
            uint amountToSend = uint.Parse(sendBox.Value.ToString());
            string otherAccountId = sendTextBox.Text;
            sendTextBox.Text = "";
            sendBox.Value = 0;

            try
            {
                otherAccount = Account.FromId(otherAccountId);
                CurAccount.withdraw(amountToSend);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error sending money", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                otherAccount.deposit(amountToSend);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error receiving money", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CurAccount.deposit(amountToSend);
                return;
            }
            updateBalanceLabel();
        }

        private void updateBalanceLabel()
        {
            balanceLbl.Text = "Balance: " + CurAccount.Balance.ToString();
        }

        private void AccountDetailsForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                CurAccount = Account.FromId(Program.currentSignedInAccountId);
                withdrawBox.Maximum = uint.MaxValue;
                depositBox.Maximum = uint.MaxValue;
                sendBox.Maximum = uint.MaxValue;
                titleLbl.Text = "Welcome " + CurAccount.FirstName + ", what would you like to do?";
                updateBalanceLabel();
            }
        }

        private void AccountDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
