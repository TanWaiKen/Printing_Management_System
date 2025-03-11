namespace APU_Printing_Management_System
{
    partial class AdminEditUsersProfile
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
            this.components = new System.ComponentModel.Container();
            this.updateButton = new System.Windows.Forms.Button();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.phoneNumTextBox = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.detailsLabel2 = new System.Windows.Forms.Label();
            this.registeredUserIdLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.registeredUserIdComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.firstPageOfAdmin = new System.Windows.Forms.Panel();
            this.Profile_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.welcomeBackLabel = new System.Windows.Forms.Label();
            this.serviceRequestReportButton = new System.Windows.Forms.Button();
            this.yearlyReportButton = new System.Windows.Forms.Button();
            this.usersProfileButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.optionGroupBox = new System.Windows.Forms.GroupBox();
            this.registerRadioBtn = new System.Windows.Forms.RadioButton();
            this.editRadioBtn = new System.Windows.Forms.RadioButton();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.requirement = new System.Windows.Forms.Label();
            this.lbl_requirement1 = new System.Windows.Forms.Label();
            this.lbl_requirement3 = new System.Windows.Forms.Label();
            this.lbl_requirement2 = new System.Windows.Forms.Label();
            this.userProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userProfileBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.firstPageOfAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.optionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Beige;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Enabled = false;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateButton.Location = new System.Drawing.Point(843, 565);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(186, 59);
            this.updateButton.TabIndex = 40;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // roleComboBox
            // 
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.Enabled = false;
            this.roleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Worker",
            "Customer"});
            this.roleComboBox.Location = new System.Drawing.Point(1006, 475);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(217, 37);
            this.roleComboBox.TabIndex = 39;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(839, 195);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(106, 25);
            this.passwordLabel.TabIndex = 38;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(1006, 186);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(217, 34);
            this.passwordTextBox.TabIndex = 37;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLabel.Location = new System.Drawing.Point(839, 347);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(109, 25);
            this.fullNameLabel.TabIndex = 36;
            this.fullNameLabel.Text = "Full Name";
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.AutoSize = true;
            this.phoneNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumLabel.Location = new System.Drawing.Point(839, 411);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(124, 25);
            this.phoneNumLabel.TabIndex = 35;
            this.phoneNumLabel.Text = "Phone Num";
            // 
            // phoneNumTextBox
            // 
            this.phoneNumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumTextBox.Location = new System.Drawing.Point(1006, 406);
            this.phoneNumTextBox.Name = "phoneNumTextBox";
            this.phoneNumTextBox.ReadOnly = true;
            this.phoneNumTextBox.Size = new System.Drawing.Size(217, 34);
            this.phoneNumTextBox.TabIndex = 34;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(840, 481);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(55, 25);
            this.roleLabel.TabIndex = 33;
            this.roleLabel.Text = "Role";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameTextBox.Location = new System.Drawing.Point(1006, 338);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(217, 34);
            this.fullNameTextBox.TabIndex = 32;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLabel.Location = new System.Drawing.Point(839, 125);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(84, 25);
            this.userIdLabel.TabIndex = 31;
            this.userIdLabel.Text = "User ID";
            // 
            // detailsLabel2
            // 
            this.detailsLabel2.AutoSize = true;
            this.detailsLabel2.BackColor = System.Drawing.Color.Transparent;
            this.detailsLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsLabel2.Location = new System.Drawing.Point(943, 36);
            this.detailsLabel2.Name = "detailsLabel2";
            this.detailsLabel2.Size = new System.Drawing.Size(162, 51);
            this.detailsLabel2.TabIndex = 29;
            this.detailsLabel2.Text = "Details";
            // 
            // registeredUserIdLabel
            // 
            this.registeredUserIdLabel.AutoSize = true;
            this.registeredUserIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.registeredUserIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeredUserIdLabel.Location = new System.Drawing.Point(394, 271);
            this.registeredUserIdLabel.Name = "registeredUserIdLabel";
            this.registeredUserIdLabel.Size = new System.Drawing.Size(150, 42);
            this.registeredUserIdLabel.TabIndex = 43;
            this.registeredUserIdLabel.Text = "User ID";
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.Beige;
            this.loadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(403, 386);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(183, 54);
            this.loadButton.TabIndex = 44;
            this.loadButton.Text = "LOAD";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Beige;
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(602, 385);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(180, 54);
            this.removeButton.TabIndex = 45;
            this.removeButton.Text = "REMOVE";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // registeredUserIdComboBox
            // 
            this.registeredUserIdComboBox.AllowDrop = true;
            this.registeredUserIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.registeredUserIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeredUserIdComboBox.FormattingEnabled = true;
            this.registeredUserIdComboBox.Location = new System.Drawing.Point(403, 324);
            this.registeredUserIdComboBox.Name = "registeredUserIdComboBox";
            this.registeredUserIdComboBox.Size = new System.Drawing.Size(379, 33);
            this.registeredUserIdComboBox.TabIndex = 72;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Beige;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Enabled = false;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addButton.Location = new System.Drawing.Point(1037, 565);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(186, 59);
            this.addButton.TabIndex = 73;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // firstPageOfAdmin
            // 
            this.firstPageOfAdmin.BackColor = System.Drawing.Color.Tomato;
            this.firstPageOfAdmin.Controls.Add(this.Profile_btn);
            this.firstPageOfAdmin.Controls.Add(this.pictureBox1);
            this.firstPageOfAdmin.Controls.Add(this.usernameTextBox);
            this.firstPageOfAdmin.Controls.Add(this.welcomeBackLabel);
            this.firstPageOfAdmin.Controls.Add(this.serviceRequestReportButton);
            this.firstPageOfAdmin.Controls.Add(this.yearlyReportButton);
            this.firstPageOfAdmin.Controls.Add(this.usersProfileButton);
            this.firstPageOfAdmin.Controls.Add(this.logOutButton);
            this.firstPageOfAdmin.Location = new System.Drawing.Point(0, 0);
            this.firstPageOfAdmin.Name = "firstPageOfAdmin";
            this.firstPageOfAdmin.Size = new System.Drawing.Size(350, 720);
            this.firstPageOfAdmin.TabIndex = 77;
            // 
            // Profile_btn
            // 
            this.Profile_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile_btn.FlatAppearance.BorderSize = 0;
            this.Profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile_btn.ForeColor = System.Drawing.Color.White;
            this.Profile_btn.Location = new System.Drawing.Point(35, 347);
            this.Profile_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Profile_btn.Name = "Profile_btn";
            this.Profile_btn.Size = new System.Drawing.Size(317, 57);
            this.Profile_btn.TabIndex = 89;
            this.Profile_btn.Text = "Profile";
            this.Profile_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile_btn.UseVisualStyleBackColor = true;
            this.Profile_btn.Click += new System.EventHandler(this.Profile_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APU_Printing_Management_System.Properties.Resources.Screenshot_2024_06_06_083058;
            this.pictureBox1.Location = new System.Drawing.Point(-25, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.Tomato;
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameTextBox.Location = new System.Drawing.Point(29, 295);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(275, 27);
            this.usernameTextBox.TabIndex = 11;
            this.usernameTextBox.Text = "Username";
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // welcomeBackLabel
            // 
            this.welcomeBackLabel.AutoSize = true;
            this.welcomeBackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeBackLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeBackLabel.Location = new System.Drawing.Point(18, 253);
            this.welcomeBackLabel.Name = "welcomeBackLabel";
            this.welcomeBackLabel.Size = new System.Drawing.Size(288, 38);
            this.welcomeBackLabel.TabIndex = 10;
            this.welcomeBackLabel.Text = "Welcome Back !!!";
            // 
            // serviceRequestReportButton
            // 
            this.serviceRequestReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serviceRequestReportButton.FlatAppearance.BorderSize = 0;
            this.serviceRequestReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceRequestReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceRequestReportButton.ForeColor = System.Drawing.Color.White;
            this.serviceRequestReportButton.Location = new System.Drawing.Point(35, 547);
            this.serviceRequestReportButton.Name = "serviceRequestReportButton";
            this.serviceRequestReportButton.Size = new System.Drawing.Size(316, 57);
            this.serviceRequestReportButton.TabIndex = 9;
            this.serviceRequestReportButton.Text = "Service Req Report";
            this.serviceRequestReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceRequestReportButton.UseVisualStyleBackColor = true;
            this.serviceRequestReportButton.Click += new System.EventHandler(this.serviceRequestReportButton_Click);
            // 
            // yearlyReportButton
            // 
            this.yearlyReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearlyReportButton.FlatAppearance.BorderSize = 0;
            this.yearlyReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearlyReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyReportButton.ForeColor = System.Drawing.Color.White;
            this.yearlyReportButton.Location = new System.Drawing.Point(35, 481);
            this.yearlyReportButton.Name = "yearlyReportButton";
            this.yearlyReportButton.Size = new System.Drawing.Size(313, 57);
            this.yearlyReportButton.TabIndex = 7;
            this.yearlyReportButton.Text = "Yearly Report";
            this.yearlyReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yearlyReportButton.UseVisualStyleBackColor = true;
            this.yearlyReportButton.Click += new System.EventHandler(this.yearlyReportButton_Click);
            // 
            // usersProfileButton
            // 
            this.usersProfileButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.usersProfileButton.Enabled = false;
            this.usersProfileButton.FlatAppearance.BorderSize = 0;
            this.usersProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersProfileButton.ForeColor = System.Drawing.Color.White;
            this.usersProfileButton.Location = new System.Drawing.Point(35, 412);
            this.usersProfileButton.Name = "usersProfileButton";
            this.usersProfileButton.Size = new System.Drawing.Size(318, 57);
            this.usersProfileButton.TabIndex = 5;
            this.usersProfileButton.Text = "Modify Users Profile";
            this.usersProfileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersProfileButton.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.Tomato;
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(34, 614);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(316, 58);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // optionGroupBox
            // 
            this.optionGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.optionGroupBox.Controls.Add(this.registerRadioBtn);
            this.optionGroupBox.Controls.Add(this.editRadioBtn);
            this.optionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionGroupBox.Location = new System.Drawing.Point(403, 36);
            this.optionGroupBox.Name = "optionGroupBox";
            this.optionGroupBox.Size = new System.Drawing.Size(379, 198);
            this.optionGroupBox.TabIndex = 78;
            this.optionGroupBox.TabStop = false;
            this.optionGroupBox.Text = "Option:";
            // 
            // registerRadioBtn
            // 
            this.registerRadioBtn.AutoSize = true;
            this.registerRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerRadioBtn.Location = new System.Drawing.Point(69, 121);
            this.registerRadioBtn.Name = "registerRadioBtn";
            this.registerRadioBtn.Size = new System.Drawing.Size(178, 36);
            this.registerRadioBtn.TabIndex = 3;
            this.registerRadioBtn.TabStop = true;
            this.registerRadioBtn.Text = "REGISTER";
            this.registerRadioBtn.UseVisualStyleBackColor = true;
            this.registerRadioBtn.CheckedChanged += new System.EventHandler(this.registerRadioBtn_CheckedChanged);
            // 
            // editRadioBtn
            // 
            this.editRadioBtn.AutoSize = true;
            this.editRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRadioBtn.Location = new System.Drawing.Point(69, 51);
            this.editRadioBtn.Name = "editRadioBtn";
            this.editRadioBtn.Size = new System.Drawing.Size(98, 36);
            this.editRadioBtn.TabIndex = 2;
            this.editRadioBtn.Text = "EDIT";
            this.editRadioBtn.UseVisualStyleBackColor = true;
            this.editRadioBtn.CheckedChanged += new System.EventHandler(this.editRadioBtn_CheckedChanged_1);
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdTextBox.Location = new System.Drawing.Point(1006, 116);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.ReadOnly = true;
            this.userIdTextBox.Size = new System.Drawing.Size(217, 34);
            this.userIdTextBox.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(838, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 50);
            this.label1.TabIndex = 81;
            this.label1.Text = "Confirm\r\nPassword";
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox2.Location = new System.Drawing.Point(1006, 266);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.PasswordChar = '•';
            this.passwordTextBox2.ReadOnly = true;
            this.passwordTextBox2.Size = new System.Drawing.Size(217, 34);
            this.passwordTextBox2.TabIndex = 80;
            this.passwordTextBox2.TextChanged += new System.EventHandler(this.passwordTextBox2_TextChanged);
            // 
            // requirement
            // 
            this.requirement.AutoSize = true;
            this.requirement.Cursor = System.Windows.Forms.Cursors.Default;
            this.requirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requirement.Location = new System.Drawing.Point(398, 487);
            this.requirement.Name = "requirement";
            this.requirement.Size = new System.Drawing.Size(219, 20);
            this.requirement.TabIndex = 82;
            this.requirement.Text = "Password Requirements:";
            // 
            // lbl_requirement1
            // 
            this.lbl_requirement1.AutoSize = true;
            this.lbl_requirement1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_requirement1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_requirement1.Location = new System.Drawing.Point(399, 525);
            this.lbl_requirement1.Name = "lbl_requirement1";
            this.lbl_requirement1.Size = new System.Drawing.Size(172, 16);
            this.lbl_requirement1.TabIndex = 85;
            this.lbl_requirement1.Text = "1. At least 8 characters long.";
            // 
            // lbl_requirement3
            // 
            this.lbl_requirement3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_requirement3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_requirement3.Location = new System.Drawing.Point(400, 589);
            this.lbl_requirement3.Name = "lbl_requirement3";
            this.lbl_requirement3.Size = new System.Drawing.Size(372, 35);
            this.lbl_requirement3.TabIndex = 86;
            this.lbl_requirement3.Text = "3. Both the password and confirm password fields value must be matched.";
            // 
            // lbl_requirement2
            // 
            this.lbl_requirement2.AutoSize = true;
            this.lbl_requirement2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_requirement2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_requirement2.Location = new System.Drawing.Point(398, 556);
            this.lbl_requirement2.Name = "lbl_requirement2";
            this.lbl_requirement2.Size = new System.Drawing.Size(374, 16);
            this.lbl_requirement2.TabIndex = 87;
            this.lbl_requirement2.Text = "2. At least 1 uppercase letter, 1 lowercase letter, and 1 number.";
            // 
            // AdminEditUsersProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.lbl_requirement2);
            this.Controls.Add(this.lbl_requirement3);
            this.Controls.Add(this.lbl_requirement1);
            this.Controls.Add(this.requirement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(this.optionGroupBox);
            this.Controls.Add(this.firstPageOfAdmin);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.registeredUserIdComboBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.registeredUserIdLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.phoneNumLabel);
            this.Controls.Add(this.phoneNumTextBox);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.detailsLabel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminEditUsersProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Edit Users Profile";
            this.firstPageOfAdmin.ResumeLayout(false);
            this.firstPageOfAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.optionGroupBox.ResumeLayout(false);
            this.optionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label phoneNumLabel;
        private System.Windows.Forms.TextBox phoneNumTextBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Label detailsLabel2;
        private System.Windows.Forms.Label registeredUserIdLabel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button removeButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox registeredUserIdComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel firstPageOfAdmin;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label welcomeBackLabel;
        private System.Windows.Forms.Button serviceRequestReportButton;
        private System.Windows.Forms.Button yearlyReportButton;
        private System.Windows.Forms.Button usersProfileButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.GroupBox optionGroupBox;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.BindingSource userProfileBindingSource;
        private System.Windows.Forms.BindingSource userProfileBindingSource1;
        private System.Windows.Forms.RadioButton registerRadioBtn;
        private System.Windows.Forms.RadioButton editRadioBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.Label requirement;
        private System.Windows.Forms.Label lbl_requirement1;
        private System.Windows.Forms.Label lbl_requirement3;
        private System.Windows.Forms.Label lbl_requirement2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Profile_btn;
    }
}