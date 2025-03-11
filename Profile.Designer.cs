namespace APU_Printing_Management_System
{
    partial class Profile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancelProfile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_save = new System.Windows.Forms.Label();
            this.btn_saveProfile = new System.Windows.Forms.Button();
            this.lbl_userID = new System.Windows.Forms.Label();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_pass2 = new System.Windows.Forms.TextBox();
            this.lbl_pass2 = new System.Windows.Forms.Label();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.lbl_role = new System.Windows.Forms.Label();
            this.lbl_requirement = new System.Windows.Forms.Label();
            this.lbl_requirement1 = new System.Windows.Forms.Label();
            this.lbl_requirement2 = new System.Windows.Forms.Label();
            this.lbl_requirement3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.btn_cancelProfile);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 50);
            this.panel1.TabIndex = 0;
            // 
            // btn_cancelProfile
            // 
            this.btn_cancelProfile.AutoSize = true;
            this.btn_cancelProfile.BackColor = System.Drawing.Color.Gold;
            this.btn_cancelProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelProfile.ForeColor = System.Drawing.Color.White;
            this.btn_cancelProfile.Location = new System.Drawing.Point(15, 8);
            this.btn_cancelProfile.Name = "btn_cancelProfile";
            this.btn_cancelProfile.Size = new System.Drawing.Size(90, 35);
            this.btn_cancelProfile.TabIndex = 2;
            this.btn_cancelProfile.Text = "Cancel";
            this.btn_cancelProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelProfile.UseVisualStyleBackColor = false;
            this.btn_cancelProfile.Click += new System.EventHandler(this.btn_cancelProfile_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.lbl_save);
            this.panel2.Controls.Add(this.btn_saveProfile);
            this.panel2.Location = new System.Drawing.Point(0, 675);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 50);
            this.panel2.TabIndex = 1;
            // 
            // lbl_save
            // 
            this.lbl_save.AutoSize = true;
            this.lbl_save.BackColor = System.Drawing.Color.Gold;
            this.lbl_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_save.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_save.Location = new System.Drawing.Point(125, 14);
            this.lbl_save.Name = "lbl_save";
            this.lbl_save.Size = new System.Drawing.Size(208, 20);
            this.lbl_save.TabIndex = 19;
            this.lbl_save.Text = "Changes Not Accepted •∩•";
            // 
            // btn_saveProfile
            // 
            this.btn_saveProfile.AutoSize = true;
            this.btn_saveProfile.BackColor = System.Drawing.Color.Gold;
            this.btn_saveProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveProfile.ForeColor = System.Drawing.Color.White;
            this.btn_saveProfile.Location = new System.Drawing.Point(15, 7);
            this.btn_saveProfile.Name = "btn_saveProfile";
            this.btn_saveProfile.Size = new System.Drawing.Size(90, 35);
            this.btn_saveProfile.TabIndex = 3;
            this.btn_saveProfile.Text = "Save";
            this.btn_saveProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saveProfile.UseVisualStyleBackColor = false;
            this.btn_saveProfile.Click += new System.EventHandler(this.btn_saveProfile_Click);
            // 
            // lbl_userID
            // 
            this.lbl_userID.AutoSize = true;
            this.lbl_userID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userID.Location = new System.Drawing.Point(25, 80);
            this.lbl_userID.Name = "lbl_userID";
            this.lbl_userID.Size = new System.Drawing.Size(67, 20);
            this.lbl_userID.TabIndex = 2;
            this.lbl_userID.Text = "UserID:";
            // 
            // txt_userID
            // 
            this.txt_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userID.Location = new System.Drawing.Point(105, 73);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.ReadOnly = true;
            this.txt_userID.Size = new System.Drawing.Size(220, 30);
            this.txt_userID.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(25, 200);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(300, 27);
            this.txt_name.TabIndex = 5;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(25, 170);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(90, 20);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Full Name:";
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(25, 290);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(300, 27);
            this.txt_phone.TabIndex = 7;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(25, 260);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(125, 20);
            this.lbl_phone.TabIndex = 6;
            this.lbl_phone.Text = "Phone Number:";
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(25, 380);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '•';
            this.txt_pass.Size = new System.Drawing.Size(300, 27);
            this.txt_pass.TabIndex = 9;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(25, 350);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(88, 20);
            this.lbl_pass.TabIndex = 8;
            this.lbl_pass.Text = "Password:";
            // 
            // txt_pass2
            // 
            this.txt_pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass2.Location = new System.Drawing.Point(25, 470);
            this.txt_pass2.Name = "txt_pass2";
            this.txt_pass2.PasswordChar = '•';
            this.txt_pass2.Size = new System.Drawing.Size(300, 27);
            this.txt_pass2.TabIndex = 11;
            this.txt_pass2.TextChanged += new System.EventHandler(this.txt_pass2_TextChanged);
            // 
            // lbl_pass2
            // 
            this.lbl_pass2.AutoSize = true;
            this.lbl_pass2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass2.Location = new System.Drawing.Point(25, 440);
            this.lbl_pass2.Name = "lbl_pass2";
            this.lbl_pass2.Size = new System.Drawing.Size(152, 20);
            this.lbl_pass2.TabIndex = 10;
            this.lbl_pass2.Text = "Confirm Password:";
            // 
            // txt_role
            // 
            this.txt_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_role.Location = new System.Drawing.Point(105, 109);
            this.txt_role.Name = "txt_role";
            this.txt_role.ReadOnly = true;
            this.txt_role.Size = new System.Drawing.Size(220, 30);
            this.txt_role.TabIndex = 13;
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.Location = new System.Drawing.Point(25, 116);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(48, 20);
            this.lbl_role.TabIndex = 12;
            this.lbl_role.Text = "Role:";
            // 
            // lbl_requirement
            // 
            this.lbl_requirement.AutoSize = true;
            this.lbl_requirement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_requirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_requirement.Location = new System.Drawing.Point(25, 530);
            this.lbl_requirement.Name = "lbl_requirement";
            this.lbl_requirement.Size = new System.Drawing.Size(179, 16);
            this.lbl_requirement.TabIndex = 14;
            this.lbl_requirement.Text = "Password Requirements:";
            // 
            // lbl_requirement1
            // 
            this.lbl_requirement1.AutoSize = true;
            this.lbl_requirement1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_requirement1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_requirement1.Location = new System.Drawing.Point(25, 550);
            this.lbl_requirement1.Name = "lbl_requirement1";
            this.lbl_requirement1.Size = new System.Drawing.Size(172, 16);
            this.lbl_requirement1.TabIndex = 15;
            this.lbl_requirement1.Text = "1. At least 8 characters long.";
            // 
            // lbl_requirement2
            // 
            this.lbl_requirement2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_requirement2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_requirement2.Location = new System.Drawing.Point(25, 570);
            this.lbl_requirement2.Name = "lbl_requirement2";
            this.lbl_requirement2.Size = new System.Drawing.Size(300, 35);
            this.lbl_requirement2.TabIndex = 16;
            this.lbl_requirement2.Text = "2. At least 1 uppercase letters, \r\n    1 lowercase letters, and 1 number.";
            // 
            // lbl_requirement3
            // 
            this.lbl_requirement3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_requirement3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_requirement3.Location = new System.Drawing.Point(25, 610);
            this.lbl_requirement3.Name = "lbl_requirement3";
            this.lbl_requirement3.Size = new System.Drawing.Size(300, 37);
            this.lbl_requirement3.TabIndex = 18;
            this.lbl_requirement3.Text = "3. Both the password and confirm password \r\n    fields value must be matched.";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(390, 565);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_requirement3);
            this.Controls.Add(this.lbl_requirement2);
            this.Controls.Add(this.lbl_requirement1);
            this.Controls.Add(this.lbl_requirement);
            this.Controls.Add(this.txt_role);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.txt_pass2);
            this.Controls.Add(this.lbl_pass2);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_userID);
            this.Controls.Add(this.lbl_userID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_saveProfile;
        private System.Windows.Forms.Button btn_cancelProfile;
        private System.Windows.Forms.Label lbl_userID;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_pass2;
        private System.Windows.Forms.Label lbl_pass2;
        private System.Windows.Forms.TextBox txt_role;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Label lbl_requirement;
        private System.Windows.Forms.Label lbl_requirement1;
        private System.Windows.Forms.Label lbl_requirement2;
        private System.Windows.Forms.Label lbl_requirement3;
        private System.Windows.Forms.Label lbl_save;
    }
}