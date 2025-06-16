namespace BankSystemFinalEx
{
    partial class HomeScreenForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreenForm));
            WelcomeLabel = new Label();
            SignUpBtn = new Button();
            SignInBtn = new Button();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.BackColor = SystemColors.InactiveCaption;
            WelcomeLabel.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            WelcomeLabel.Location = new Point(174, 33);
            WelcomeLabel.Margin = new Padding(2, 0, 2, 0);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(247, 54);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "IRON BANK";
            WelcomeLabel.Click += WelcomeLabel_Click;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = SystemColors.ActiveCaption;
            SignUpBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SignUpBtn.Location = new Point(234, 102);
            SignUpBtn.Margin = new Padding(2);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(113, 29);
            SignUpBtn.TabIndex = 1;
            SignUpBtn.Text = "Sign Up";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpButton_Click;
            // 
            // SignInBtn
            // 
            SignInBtn.BackColor = SystemColors.ActiveCaption;
            SignInBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SignInBtn.Location = new Point(234, 145);
            SignInBtn.Margin = new Padding(2);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(113, 29);
            SignInBtn.TabIndex = 2;
            SignInBtn.Text = "Sign In";
            SignInBtn.UseVisualStyleBackColor = false;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // HomeScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(560, 291);
            Controls.Add(SignInBtn);
            Controls.Add(SignUpBtn);
            Controls.Add(WelcomeLabel);
            Margin = new Padding(2);
            Name = "HomeScreenForm";
            Text = "Home";
            Load += HomeScreenForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeLabel;
        private Button SignUpBtn;
        private Button SignInBtn;
    }
}
