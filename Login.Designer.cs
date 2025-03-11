namespace APU_Printing_Management_System
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_logIn = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_prompt = new System.Windows.Forms.Label();
            this.lbl_userID = new System.Windows.Forms.Label();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_invalid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::APU_Printing_Management_System.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1262, 673);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_logIn
            // 
            this.btn_logIn.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_logIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_logIn.Location = new System.Drawing.Point(865, 500);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(250, 40);
            this.btn_logIn.TabIndex = 1;
            this.btn_logIn.Text = "Log In";
            this.btn_logIn.UseVisualStyleBackColor = false;
            this.btn_logIn.Click += new System.EventHandler(this.btn_logIn_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(862, 125);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(129, 46);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Hello!";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_prompt
            // 
            this.lbl_prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prompt.Location = new System.Drawing.Point(867, 185);
            this.lbl_prompt.Name = "lbl_prompt";
            this.lbl_prompt.Size = new System.Drawing.Size(250, 45);
            this.lbl_prompt.TabIndex = 3;
            this.lbl_prompt.Text = "Enter the credentials below to log into your account.";
            // 
            // lbl_userID
            // 
            this.lbl_userID.AutoSize = true;
            this.lbl_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userID.Location = new System.Drawing.Point(865, 265);
            this.lbl_userID.Name = "lbl_userID";
            this.lbl_userID.Size = new System.Drawing.Size(85, 25);
            this.lbl_userID.TabIndex = 5;
            this.lbl_userID.Text = "UserID:";
            // 
            // txt_userID
            // 
            this.txt_userID.BackColor = System.Drawing.Color.White;
            this.txt_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userID.Location = new System.Drawing.Point(865, 300);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(250, 30);
            this.txt_userID.TabIndex = 6;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(865, 400);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '•';
            this.txt_password.Size = new System.Drawing.Size(250, 30);
            this.txt_password.TabIndex = 8;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(865, 365);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(113, 25);
            this.lbl_password.TabIndex = 7;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_invalid
            // 
            this.lbl_invalid.ForeColor = System.Drawing.Color.Red;
            this.lbl_invalid.Location = new System.Drawing.Point(890, 460);
            this.lbl_invalid.Name = "lbl_invalid";
            this.lbl_invalid.Size = new System.Drawing.Size(200, 32);
            this.lbl_invalid.TabIndex = 9;
            this.lbl_invalid.Text = "Invalid UserID or Password. \r\nPlease try again!\r\n";
            this.lbl_invalid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_invalid.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.lbl_invalid);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_userID);
            this.Controls.Add(this.lbl_userID);
            this.Controls.Add(this.lbl_prompt);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_logIn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(-10, 0);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_logIn;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_prompt;
        private System.Windows.Forms.Label lbl_userID;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_invalid;
    }
}