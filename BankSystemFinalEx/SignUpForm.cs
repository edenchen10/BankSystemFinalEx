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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void ApplySignUpBtn_Click(object sender, EventArgs e)
        {
            Account account;

            try
            {
                account = new Account(FirstNameTextBox.Text, LastNameTextBox.Text, IdTextBox.Text, PasswordTextBox.Text);
                account.create();
                Program.currentSignedInAccountId = account.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error creating account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clearBoxes();
            Program.switchToAccountDetailsScreen(this);
        }

        private void clearBoxes()
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            IdTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        private void CancelSignUpBtn_Click(object sender, EventArgs e)
        {
            clearBoxes();
            Program.switchToHomeScreen(this);
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
