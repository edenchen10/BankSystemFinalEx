namespace BankSystemFinalEx
{
    partial class SignInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            SignInUsernameTextBox = new TextBox();
            SignInPasswordTextBox = new TextBox();
            ApplyLoginBtn = new Button();
            CancelSignInBtn = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(193, 36);
            label1.Name = "label1";
            label1.Size = new Size(153, 54);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            // 
            // SignInUsernameTextBox
            // 
            SignInUsernameTextBox.Location = new Point(218, 109);
            SignInUsernameTextBox.Name = "SignInUsernameTextBox";
            SignInUsernameTextBox.PlaceholderText = "Username (ID)";
            SignInUsernameTextBox.Size = new Size(100, 23);
            SignInUsernameTextBox.TabIndex = 1;
            // 
            // SignInPasswordTextBox
            // 
            SignInPasswordTextBox.Location = new Point(218, 138);
            SignInPasswordTextBox.Name = "SignInPasswordTextBox";
            SignInPasswordTextBox.PasswordChar = '*';
            SignInPasswordTextBox.PlaceholderText = "Password";
            SignInPasswordTextBox.Size = new Size(100, 23);
            SignInPasswordTextBox.TabIndex = 1;
            // 
            // ApplyLoginBtn
            // 
            ApplyLoginBtn.Location = new Point(199, 220);
            ApplyLoginBtn.Name = "ApplyLoginBtn";
            ApplyLoginBtn.Size = new Size(75, 23);
            ApplyLoginBtn.TabIndex = 2;
            ApplyLoginBtn.Text = "Login";
            ApplyLoginBtn.UseVisualStyleBackColor = true;
            ApplyLoginBtn.Click += ApplyLoginBtn_Click;
            // 
            // CancelSignInBtn
            // 
            CancelSignInBtn.Location = new Point(289, 220);
            CancelSignInBtn.Name = "CancelSignInBtn";
            CancelSignInBtn.Size = new Size(75, 23);
            CancelSignInBtn.TabIndex = 2;
            CancelSignInBtn.Text = "Cancel";
            CancelSignInBtn.UseVisualStyleBackColor = true;
            CancelSignInBtn.Click += CancelSignInBtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.White;
            checkBox1.Location = new Point(324, 138);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(107, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "show password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(560, 270);
            Controls.Add(checkBox1);
            Controls.Add(CancelSignInBtn);
            Controls.Add(ApplyLoginBtn);
            Controls.Add(SignInPasswordTextBox);
            Controls.Add(SignInUsernameTextBox);
            Controls.Add(label1);
            Name = "SignInForm";
            Text = "LoginForm";
            Load += SignInForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SignInUsernameTextBox;
        private TextBox SignInPasswordTextBox;
        private Button ApplyLoginBtn;
        private Button CancelSignInBtn;
        private CheckBox checkBox1;
    }
}