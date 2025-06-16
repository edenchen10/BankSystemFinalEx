namespace BankSystemFinalEx
{
    internal static class Program
    {
        public const string solutionPath = "..\\..\\..\\..";
        public const string usersPath = solutionPath + "\\BankingSystemUsers";
        public const string adminFilePath = usersPath + "\\Admin";
        public static Dictionary<string, Form> forms = new Dictionary<string, Form>();
        public static string currentSignedInAccountId = null;

        private static void createUsersFolderIfNotExists()
        {
            if (!Directory.Exists(usersPath))
            {
                Directory.CreateDirectory(usersPath);
            }
        }

        private static void createAdminUserIfNotExists()
        {
            if (!Directory.Exists(adminFilePath))
            {
                using (var sw = File.CreateText(adminFilePath))
                {
                    sw.AutoFlush = true;

                    if (sw == null)
                    {
                        throw new Exception("Unable to start system, failed to generate admin user");
                    }

                    // Create fake account with user name (id) admin and password admin
                    sw.WriteLine("Admin");
                    sw.WriteLine("Admin");
                    sw.WriteLine("Password");
                    sw.WriteLine("Admin");
                }
            }
        }

        private static void InitSystem()
        {
            createUsersFolderIfNotExists();
            createAdminUserIfNotExists();
        }

        private static void InitForms()
        {
            forms.Add("HomeScreen", new HomeScreenForm());
            forms.Add("SignIn", new SignInForm());
            forms.Add("SignUp", new SignUpForm());
            forms.Add("AccountDetails", new AccountDetailsForm());
            forms.Add("AdminAccount", new AdminAccountForm());

            forms["SignIn"].Hide();
            forms["SignUp"].Hide();
            forms["AccountDetails"].Hide();
            forms["AdminAccount"].Hide();
        }

        public static void switchToForm(string nextFormName, Form currentForm)
        {
            var nextForm = forms[nextFormName];

            nextForm.Location = currentForm.Location;
            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.Show();
            currentForm.Hide();
        }

        public static void switchToHomeScreen(Form callingForm)
        {
            switchToForm("HomeScreen", callingForm);
        }

        public static void switchToAccountDetailsScreen(Form callingForm)
        {
            // TODO Pass currently logged in user here to the form?
            switchToForm("AccountDetails", callingForm);
        }

        public static void switchToSignInForm(Form callingForm)
        {
            switchToForm("SignIn", callingForm);
        }

        public static void switchToSignUpForm(Form callingForm)
        {
            switchToForm("SignUp", callingForm);
        }

        public static void switchToAdminAccountForm(Form callingForm)
        {
            switchToForm("AdminAccount", callingForm);
        }

        public static void signOut(Form callingForm)
        {
            currentSignedInAccountId = null;
            switchToHomeScreen(callingForm);
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            InitSystem();
            InitForms();
            Application.Run(forms["HomeScreen"]);
        }
    }
}