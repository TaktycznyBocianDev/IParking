namespace IParkingClient
{
    partial class CreateNewAccountForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            CreateBtn = new Button();
            UserNameBox = new TextBox();
            SurnameBox = new TextBox();
            PassBox = new TextBox();
            EmailBox = new TextBox();
            SecPassBox = new TextBox();
            CarColorBox = new TextBox();
            ModelBox = new TextBox();
            BrandBox = new TextBox();
            PlateBox = new TextBox();
            ShowPass = new CheckBox();
            ShowSecPass = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 55);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Dane użytkownika";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 112);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Imie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 165);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Nazwisko";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 219);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 268);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 4;
            label5.Text = "Hasło";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(135, 324);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 5;
            label6.Text = "Powtórz hasło";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(532, 55);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 6;
            label7.Text = "Dane auta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(506, 112);
            label8.Name = "label8";
            label8.Size = new Size(144, 20);
            label8.TabIndex = 7;
            label8.Text = "Numer Rejestracyjny";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(506, 165);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 8;
            label9.Text = "Marka";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(506, 219);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 9;
            label10.Text = "Model";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(506, 268);
            label11.Name = "label11";
            label11.Size = new Size(45, 20);
            label11.TabIndex = 10;
            label11.Text = "Kolor";
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new Point(670, 409);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(118, 29);
            CreateBtn.TabIndex = 11;
            CreateBtn.Text = "Stwórz Konto";
            CreateBtn.UseVisualStyleBackColor = true;
            // 
            // UserNameBox
            // 
            UserNameBox.Location = new Point(135, 135);
            UserNameBox.Name = "UserNameBox";
            UserNameBox.Size = new Size(125, 27);
            UserNameBox.TabIndex = 13;
            UserNameBox.TextChangedCompleteDelay = TimeSpan.Parse("00:00:01");
            UserNameBox.TextChanged += UserNameBox_TextChanged;
            // 
            // SurnameBox
            // 
            SurnameBox.Location = new Point(135, 188);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.Size = new Size(125, 27);
            SurnameBox.TabIndex = 14;
            SurnameBox.TextChangedCompleteDelay = TimeSpan.Parse("00:00:01");
            SurnameBox.TextChanged += SurnameBox_TextChanged;
            // 
            // PassBox
            // 
            PassBox.Location = new Point(135, 291);
            PassBox.Name = "PassBox";
            PassBox.Size = new Size(125, 27);
            PassBox.TabIndex = 16;
            PassBox.TextChangedCompleteDelay = TimeSpan.Parse("00:00:01");
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(135, 238);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(125, 27);
            EmailBox.TabIndex = 15;
            EmailBox.TextChangedCompleteDelay = TimeSpan.Parse("00:00:01");
            // 
            // SecPassBox
            // 
            SecPassBox.Location = new Point(135, 347);
            SecPassBox.Name = "SecPassBox";
            SecPassBox.Size = new Size(125, 27);
            SecPassBox.TabIndex = 17;
            SecPassBox.TextChangedCompleteDelay = TimeSpan.Parse("00:00:01");
            // 
            // CarColorBox
            // 
            CarColorBox.Location = new Point(506, 291);
            CarColorBox.Name = "CarColorBox";
            CarColorBox.Size = new Size(125, 27);
            CarColorBox.TabIndex = 21;
            CarColorBox.TextChangedCompleteDelay = TimeSpan.Parse("00:00:01");
            // 
            // ModelBox
            // 
            ModelBox.Location = new Point(506, 238);
            ModelBox.Name = "ModelBox";
            ModelBox.Size = new Size(125, 27);
            ModelBox.TabIndex = 20;
            ModelBox.TextChangedCompleteDelay = TimeSpan.Parse("00:00:01");
            // 
            // BrandBox
            // 
            BrandBox.Location = new Point(506, 188);
            BrandBox.Name = "BrandBox";
            BrandBox.Size = new Size(125, 27);
            BrandBox.TabIndex = 19;
            BrandBox.TextChangedCompleteDelay = TimeSpan.Parse("00:00:01");
            // 
            // PlateBox
            // 
            PlateBox.Location = new Point(506, 135);
            PlateBox.Name = "PlateBox";
            PlateBox.Size = new Size(125, 27);
            PlateBox.TabIndex = 18;
            PlateBox.TextChangedCompleteDelay = TimeSpan.Parse("00:00:01");
            // 
            // ShowPass
            // 
            ShowPass.AutoSize = true;
            ShowPass.Location = new Point(266, 294);
            ShowPass.Name = "ShowPass";
            ShowPass.Size = new Size(111, 24);
            ShowPass.TabIndex = 22;
            ShowPass.Text = "Pokaż Hasło";
            ShowPass.UseVisualStyleBackColor = true;
            ShowPass.CheckedChanged += ShowPass_CheckedChanged;
            // 
            // ShowSecPass
            // 
            ShowSecPass.AutoSize = true;
            ShowSecPass.Location = new Point(266, 347);
            ShowSecPass.Name = "ShowSecPass";
            ShowSecPass.Size = new Size(111, 24);
            ShowSecPass.TabIndex = 23;
            ShowSecPass.Text = "Pokaż Hasło";
            ShowSecPass.UseVisualStyleBackColor = true;
            ShowSecPass.CheckedChanged += ShowSecPass_CheckedChanged;
            // 
            // CreateNewAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ShowSecPass);
            Controls.Add(ShowPass);
            Controls.Add(CarColorBox);
            Controls.Add(ModelBox);
            Controls.Add(BrandBox);
            Controls.Add(PlateBox);
            Controls.Add(SecPassBox);
            Controls.Add(PassBox);
            Controls.Add(EmailBox);
            Controls.Add(SurnameBox);
            Controls.Add(UserNameBox);
            Controls.Add(CreateBtn);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateNewAccountForm";
            Text = "CreateNewAccountForm";
            Load += CreateNewAccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button CreateBtn;
        private TextBox UserNameBox;
        private TextBox SurnameBox;
        private TextBox PassBox;
        private TextBox EmailBox;
        private TextBox SecPassBox;
        private TextBox CarColorBox;
        private TextBox ModelBox;
        private TextBox BrandBox;
        private TextBox PlateBox;
        private CheckBox ShowPass;
        private CheckBox ShowSecPass;
    }
}