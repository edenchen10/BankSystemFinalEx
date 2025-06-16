namespace BankSystemFinalEx
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            SignUpMainLabel = new Label();
            SignUpSubLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            IdTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            ApplySignUpBtn = new Button();
            CancelSignUpBtn = new Button();
            SuspendLayout();
            // 
            // SignUpMainLabel
            // 
            SignUpMainLabel.AutoSize = true;
            SignUpMainLabel.BackColor = SystemColors.ButtonHighlight;
            SignUpMainLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            SignUpMainLabel.Location = new Point(178, 27);
            SignUpMainLabel.Margin = new Padding(2, 0, 2, 0);
            SignUpMainLabel.Name = "SignUpMainLabel";
            SignUpMainLabel.Size = new Size(228, 72);
            SignUpMainLabel.TabIndex = 0;
            SignUpMainLabel.Text = "Sign Up";
            // 
            // SignUpSubLabel
            // 
            SignUpSubLabel.AutoSize = true;
            SignUpSubLabel.BackColor = SystemColors.Window;
            SignUpSubLabel.Font = new Font("Segoe UI", 14F);
            SignUpSubLabel.Location = new Point(145, 108);
            SignUpSubLabel.Margin = new Padding(2, 0, 2, 0);
            SignUpSubLabel.Name = "SignUpSubLabel";
            SignUpSubLabel.Size = new Size(295, 25);
            SignUpSubLabel.TabIndex = 1;
            SignUpSubLabel.Text = "Please enter the following details:";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(162, 146);
            FirstNameTextBox.Margin = new Padding(2);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.PlaceholderText = "First Name";
            FirstNameTextBox.Size = new Size(106, 23);
            FirstNameTextBox.TabIndex = 2;
            FirstNameTextBox.WordWrap = false;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(162, 177);
            LastNameTextBox.Margin = new Padding(2);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.PlaceholderText = "Last Name";
            LastNameTextBox.Size = new Size(106, 23);
            LastNameTextBox.TabIndex = 2;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(300, 146);
            IdTextBox.Margin = new Padding(2);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.PlaceholderText = "ID";
            IdTextBox.Size = new Size(106, 23);
            IdTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(300, 174);
            PasswordTextBox.Margin = new Padding(2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.PlaceholderText = "Password";
            PasswordTextBox.Size = new Size(106, 23);
            PasswordTextBox.TabIndex = 2;
            // 
            // ApplySignUpBtn
            // 
            ApplySignUpBtn.Location = new Point(162, 231);
            ApplySignUpBtn.Name = "ApplySignUpBtn";
            ApplySignUpBtn.Size = new Size(94, 37);
            ApplySignUpBtn.TabIndex = 3;
            ApplySignUpBtn.Text = "OK";
            ApplySignUpBtn.UseVisualStyleBackColor = true;
            ApplySignUpBtn.Click += ApplySignUpBtn_Click;
            // 
            // CancelSignUpBtn
            // 
            CancelSignUpBtn.Location = new Point(308, 231);
            CancelSignUpBtn.Name = "CancelSignUpBtn";
            CancelSignUpBtn.Size = new Size(98, 37);
            CancelSignUpBtn.TabIndex = 3;
            CancelSignUpBtn.Text = "Cancel";
            CancelSignUpBtn.UseVisualStyleBackColor = true;
            CancelSignUpBtn.Click += CancelSignUpBtn_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(560, 355);
            Controls.Add(CancelSignUpBtn);
            Controls.Add(ApplySignUpBtn);
            Controls.Add(PasswordTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(SignUpSubLabel);
            Controls.Add(SignUpMainLabel);
            Margin = new Padding(2);
            Name = "SignUpForm";
            Text = "SignUpForm";
            Load += SignUpForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SignUpMainLabel;
        private Label SignUpSubLabel;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox IdTextBox;
        private TextBox PasswordTextBox;
        private Button ApplySignUpBtn;
        private Button CancelSignUpBtn;
    }
}