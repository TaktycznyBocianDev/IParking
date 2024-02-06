namespace IParkingClient
{
    partial class LoginScreen
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
            LogBtn = new Button();
            AddNewUserBtn = new Button();
            label1 = new Label();
            LoginTxtBox = new TextBox();
            label2 = new Label();
            PassTxtBox = new TextBox();
            ShowPassChck = new CheckBox();
            SuspendLayout();
            // 
            // LogBtn
            // 
            LogBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LogBtn.Location = new Point(240, 289);
            LogBtn.Name = "LogBtn";
            LogBtn.Size = new Size(271, 54);
            LogBtn.TabIndex = 0;
            LogBtn.Text = "Zaloguj";
            LogBtn.UseVisualStyleBackColor = true;
            LogBtn.Click += LogBtn_Click;
            // 
            // AddNewUserBtn
            // 
            AddNewUserBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddNewUserBtn.Location = new Point(240, 347);
            AddNewUserBtn.Name = "AddNewUserBtn";
            AddNewUserBtn.Size = new Size(271, 31);
            AddNewUserBtn.TabIndex = 1;
            AddNewUserBtn.Text = "Nie masz jeszcze konta? Naciśnij tutaj!";
            AddNewUserBtn.UseVisualStyleBackColor = true;
            AddNewUserBtn.Click += AddNewUserBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(240, 75);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 2;
            label1.Text = "Super Fajny Login";
            // 
            // LoginTxtBox
            // 
            LoginTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginTxtBox.Location = new Point(240, 98);
            LoginTxtBox.Name = "LoginTxtBox";
            LoginTxtBox.Size = new Size(271, 27);
            LoginTxtBox.TabIndex = 3;
            LoginTxtBox.TextChangedCompleteDelay = TimeSpan.Parse("00:00:02");
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(240, 157);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 4;
            label2.Text = "Super Tajne Hasło";
            // 
            // PassTxtBox
            // 
            PassTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PassTxtBox.Location = new Point(240, 189);
            PassTxtBox.Name = "PassTxtBox";
            PassTxtBox.Size = new Size(271, 27);
            PassTxtBox.TabIndex = 5;
            PassTxtBox.TextChangedCompleteDelay = TimeSpan.Parse("00:00:02");
            // 
            // ShowPassChck
            // 
            ShowPassChck.AutoSize = true;
            ShowPassChck.Location = new Point(240, 222);
            ShowPassChck.Name = "ShowPassChck";
            ShowPassChck.Size = new Size(108, 24);
            ShowPassChck.TabIndex = 6;
            ShowPassChck.Text = "Pokaż hasło";
            ShowPassChck.UseVisualStyleBackColor = true;
            ShowPassChck.CheckedChanged += ShowPassChck_CheckedChanged;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 452);
            Controls.Add(ShowPassChck);
            Controls.Add(PassTxtBox);
            Controls.Add(label2);
            Controls.Add(LoginTxtBox);
            Controls.Add(label1);
            Controls.Add(AddNewUserBtn);
            Controls.Add(LogBtn);
            Name = "LoginScreen";
            Text = "LoginScreen";
            Load += LoginScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogBtn;
        private Button AddNewUserBtn;
        private Label label1;
        private TextBox LoginTxtBox;
        private Label label2;
        private TextBox PassTxtBox;
        private CheckBox ShowPassChck;
    }
}
