namespace BankSystemFinalEx
{
    partial class AdminAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAccountForm));
            compensateBox = new NumericUpDown();
            compensateBtn = new Button();
            titleLbl = new Label();
            accountsList = new ListView();
            deleteBtn = new Button();
            totalFundsLbl = new Label();
            resetBtn = new Button();
            LogoutBtn = new Button();
            pictureAdmin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)compensateBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureAdmin).BeginInit();
            SuspendLayout();
            // 
            // compensateBox
            // 
            compensateBox.Location = new Point(110, 73);
            compensateBox.Name = "compensateBox";
            compensateBox.Size = new Size(120, 23);
            compensateBox.TabIndex = 7;
            // 
            // compensateBtn
            // 
            compensateBtn.Location = new Point(21, 73);
            compensateBtn.Name = "compensateBtn";
            compensateBtn.Size = new Size(83, 23);
            compensateBtn.TabIndex = 6;
            compensateBtn.Text = "Compensate";
            compensateBtn.UseVisualStyleBackColor = true;
            compensateBtn.Click += compensateBtn_Click;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.Location = new Point(23, 19);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(202, 37);
            titleLbl.TabIndex = 9;
            titleLbl.Text = "Welcome Lord";
            // 
            // accountsList
            // 
            accountsList.Location = new Point(36, 194);
            accountsList.Name = "accountsList";
            accountsList.Size = new Size(527, 85);
            accountsList.TabIndex = 10;
            accountsList.UseCompatibleStateImageBehavior = false;
            accountsList.SelectedIndexChanged += accountsList_SelectedIndexChanged;
            accountsList.VisibleChanged += accountsList_VisibleChanged;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(21, 102);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(83, 23);
            deleteBtn.TabIndex = 11;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // totalFundsLbl
            // 
            totalFundsLbl.AutoSize = true;
            totalFundsLbl.Location = new Point(192, 176);
            totalFundsLbl.Name = "totalFundsLbl";
            totalFundsLbl.Size = new Size(38, 15);
            totalFundsLbl.TabIndex = 12;
            totalFundsLbl.Text = "label1";
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(21, 131);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(83, 23);
            resetBtn.TabIndex = 13;
            resetBtn.Text = "Delete All";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Location = new Point(21, 160);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(83, 23);
            LogoutBtn.TabIndex = 14;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // pictureAdmin
            // 
            pictureAdmin.Image = (Image)resources.GetObject("pictureAdmin.Image");
            pictureAdmin.Location = new Point(435, 28);
            pictureAdmin.Name = "pictureAdmin";
            pictureAdmin.Size = new Size(128, 126);
            pictureAdmin.TabIndex = 15;
            pictureAdmin.TabStop = false;
            // 
            // AdminAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(600, 308);
            Controls.Add(pictureAdmin);
            Controls.Add(LogoutBtn);
            Controls.Add(resetBtn);
            Controls.Add(totalFundsLbl);
            Controls.Add(deleteBtn);
            Controls.Add(accountsList);
            Controls.Add(titleLbl);
            Controls.Add(compensateBox);
            Controls.Add(compensateBtn);
            Name = "AdminAccountForm";
            Text = "Admin Account";
            Load += AdminAccountForm_Load;
            ((System.ComponentModel.ISupportInitialize)compensateBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown compensateBox;
        private Button compensateBtn;
        private Label titleLbl;
        private ListView accountsList;
        private Button deleteBtn;
        private Label totalFundsLbl;
        private Button resetBtn;
        private Button LogoutBtn;
        private PictureBox pictureAdmin;
    }
}