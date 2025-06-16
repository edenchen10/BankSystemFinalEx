using System.Windows.Forms;

namespace BankSystemFinalEx
{
    public partial class HomeScreenForm : Form
    {
        public HomeScreenForm()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Program.switchToSignUpForm(this);
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            Program.switchToSignInForm(this);
        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void HomeScreenForm_Load(object sender, EventArgs e)
        {

        }
    }
}
