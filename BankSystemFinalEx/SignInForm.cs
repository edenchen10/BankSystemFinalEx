using BankSystemFinalEx.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemFinalEx
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        public static void validateUserExists(string id)
        {
            var userFilePath = Program.usersPath + "\\" + id;
            if (!File.Exists(userFilePath))
            {
                throw new UserNotExist(id);
            }
        }

        public static void validatePasswordIsCorrect(string id, string password)
        {
            Account account = Account.FromId(id);
            if (!password.Equals(account.Password))
            {
                throw new InvalidAccountDetail("Incorrect password!");
            }
        }

        private void validateInput()
        {
            Account.validateId(SignInUsernameTextBox.Text);
            Account.validatePassword(SignInPasswordTextBox.Text);
        }

        private void CancelSignInBtn_Click(object sender, EventArgs e)
        {
            Program.switchToHomeScreen(this);
        }

        private void validateAdminInput(string username, string password)
        {
            if (!File.Exists(Program.adminFilePath))
            {
                throw new Exception("Admin file not found, restart the program to recreate one");
            }

            var adminCreds = File.ReadLines(Program.adminFilePath);
            if (!adminCreds.ElementAt(2).Equals(password))
            {
                throw new InvalidAccountDetail("password is incorrect!");
            }
        }

        private void clearBoxes()
        {
            SignInUsernameTextBox.Text = "";
            SignInPasswordTextBox.Text = "";
        }

        private void ApplyLoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SignInUsernameTextBox.Text.Equals("Admin"))
                {
                    validateAdminInput(SignInUsernameTextBox.Text, SignInPasswordTextBox.Text);
                    Program.switchToAdminAccountForm(this);
                    Program.currentSignedInAccountId = "Admin";
                    clearBoxes();
                    return;
                }

                validateInput();
                validateUserExists(SignInUsernameTextBox.Text);
                validatePasswordIsCorrect(SignInUsernameTextBox.Text, SignInPasswordTextBox.Text);
                Program.currentSignedInAccountId = SignInUsernameTextBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error signing into account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clearBoxes();
            Program.switchToAccountDetailsScreen(this);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                SignInPasswordTextBox.PasswordChar = '*';
            }
            else
            {
                SignInPasswordTextBox.PasswordChar = '\0';
            }

        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
