namespace BankSystemFinalEx
{
    partial class AccountDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountDetailsForm));
            titleLbl = new Label();
            depositBtn = new Button();
            withdrawBtn = new Button();
            sendBtn = new Button();
            LogoutBtn = new Button();
            depositBox = new NumericUpDown();
            withdrawBox = new NumericUpDown();
            sendBox = new NumericUpDown();
            sendTextBox = new TextBox();
            balanceLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)depositBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)withdrawBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sendBox).BeginInit();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.BackColor = Color.Transparent;
            titleLbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.Location = new Point(12, 9);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(369, 37);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "What would you like to do?";
            // 
            // depositBtn
            // 
            depositBtn.Location = new Point(12, 61);
            depositBtn.Name = "depositBtn";
            depositBtn.Size = new Size(75, 23);
            depositBtn.TabIndex = 2;
            depositBtn.Text = "Deposit";
            depositBtn.UseVisualStyleBackColor = true;
            depositBtn.Click += depositBtn_Click;
            // 
            // withdrawBtn
            // 
            withdrawBtn.Location = new Point(12, 90);
            withdrawBtn.Name = "withdrawBtn";
            withdrawBtn.Size = new Size(75, 23);
            withdrawBtn.TabIndex = 2;
            withdrawBtn.Text = "Withdraw";
            withdrawBtn.UseVisualStyleBackColor = true;
            withdrawBtn.Click += withdrawBtn_Click;
            // 
            // sendBtn
            // 
            sendBtn.Location = new Point(12, 119);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(75, 23);
            sendBtn.TabIndex = 2;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Location = new Point(473, 235);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(75, 23);
            LogoutBtn.TabIndex = 2;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // depositBox
            // 
            depositBox.Location = new Point(93, 61);
            depositBox.Name = "depositBox";
            depositBox.Size = new Size(120, 23);
            depositBox.TabIndex = 3;
            // 
            // withdrawBox
            // 
            withdrawBox.Location = new Point(93, 90);
            withdrawBox.Name = "withdrawBox";
            withdrawBox.Size = new Size(120, 23);
            withdrawBox.TabIndex = 4;
            // 
            // sendBox
            // 
            sendBox.Location = new Point(93, 119);
            sendBox.Name = "sendBox";
            sendBox.Size = new Size(120, 23);
            sendBox.TabIndex = 3;
            // 
            // sendTextBox
            // 
            sendTextBox.Location = new Point(218, 118);
            sendTextBox.Name = "sendTextBox";
            sendTextBox.PlaceholderText = "Receiver Account ID";
            sendTextBox.Size = new Size(122, 23);
            sendTextBox.TabIndex = 5;
            // 
            // balanceLbl
            // 
            balanceLbl.AutoSize = true;
            balanceLbl.Location = new Point(371, 61);
            balanceLbl.Name = "balanceLbl";
            balanceLbl.Size = new Size(51, 15);
            balanceLbl.TabIndex = 6;
            balanceLbl.Text = "Balance:";
            // 
            // AccountDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(560, 270);
            Controls.Add(balanceLbl);
            Controls.Add(sendTextBox);
            Controls.Add(withdrawBox);
            Controls.Add(sendBox);
            Controls.Add(depositBox);
            Controls.Add(sendBtn);
            Controls.Add(withdrawBtn);
            Controls.Add(LogoutBtn);
            Controls.Add(depositBtn);
            Controls.Add(titleLbl);
            Name = "AccountDetailsForm";
            Text = "Account Details";
            Load += AccountDetailsForm_Load;
            VisibleChanged += AccountDetailsForm_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)depositBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)withdrawBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)sendBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private Button depositBtn;
        private Button withdrawBtn;
        private Button sendBtn;
        private Button LogoutBtn;
        private NumericUpDown depositBox;
        private NumericUpDown withdrawBox;
        private NumericUpDown sendBox;
        private TextBox sendTextBox;
        private Label balanceLbl;
    }
}