namespace APU_Printing_Management_System
{
    partial class CustomerOrderPage
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
            this.text1 = new System.Windows.Forms.Label();
            this.UnpaidRequestTable = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Order_btn = new System.Windows.Forms.Button();
            this.PrintingService_btn = new System.Windows.Forms.Button();
            this.CustomerProfile_btn = new System.Windows.Forms.Button();
            this.Pay_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.LogOut_btn = new System.Windows.Forms.Button();
            this.lbl_customerName = new System.Windows.Forms.Label();
            this.We = new System.Windows.Forms.Label();
            this.Total_lbl = new System.Windows.Forms.Label();
            this.ToReceive_Table = new System.Windows.Forms.DataGridView();
            this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printingServiceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printingServiceDataSet = new APU_Printing_Management_System.PrintingServiceDataSet();
            this.History_btn = new System.Windows.Forms.Button();
            this.requestTableAdapter = new APU_Printing_Management_System.PrintingServiceDataSetTableAdapters.RequestTableAdapter();
            this.jobTableAdapter = new APU_Printing_Management_System.PrintingServiceDataSetTableAdapters.JobTableAdapter();
            this.DateTime_ctrl = new System.Windows.Forms.DateTimePicker();
            this.UrgentRequest_cb = new System.Windows.Forms.CheckBox();
            this.sideBar_picb = new System.Windows.Forms.PictureBox();
            this.requestBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKJobRequestID2EA5EC27BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKJobRequestID2EA5EC27BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.notify_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UnpaidRequestTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToReceive_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingServiceDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideBar_picb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKJobRequestID2EA5EC27BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKJobRequestID2EA5EC27BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(388, 9);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(109, 25);
            this.text1.TabIndex = 24;
            this.text1.Text = "To Pay 🛒";
            // 
            // UnpaidRequestTable
            // 
            this.UnpaidRequestTable.AllowUserToAddRows = false;
            this.UnpaidRequestTable.AllowUserToOrderColumns = true;
            this.UnpaidRequestTable.AllowUserToResizeColumns = false;
            this.UnpaidRequestTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UnpaidRequestTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnpaidRequestTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected});
            this.UnpaidRequestTable.Location = new System.Drawing.Point(393, 53);
            this.UnpaidRequestTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnpaidRequestTable.MultiSelect = false;
            this.UnpaidRequestTable.Name = "UnpaidRequestTable";
            this.UnpaidRequestTable.RowHeadersWidth = 51;
            this.UnpaidRequestTable.RowTemplate.Height = 24;
            this.UnpaidRequestTable.Size = new System.Drawing.Size(852, 209);
            this.UnpaidRequestTable.TabIndex = 23;
            this.UnpaidRequestTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UnpaidRequestTable_CellContentClick);
            this.UnpaidRequestTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.UnpaidRequestTable_CellValueChanged);
            // 
            // Selected
            // 
            this.Selected.HeaderText = "Selected";
            this.Selected.MinimumWidth = 6;
            this.Selected.Name = "Selected";
            // 
            // Order_btn
            // 
            this.Order_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.Order_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.Order_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Order_btn.Enabled = false;
            this.Order_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Order_btn.FlatAppearance.BorderSize = 0;
            this.Order_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Order_btn.Location = new System.Drawing.Point(35, 502);
            this.Order_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Order_btn.Name = "Order_btn";
            this.Order_btn.Size = new System.Drawing.Size(275, 34);
            this.Order_btn.TabIndex = 38;
            this.Order_btn.Text = "Order >";
            this.Order_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Order_btn.UseVisualStyleBackColor = false;
            // 
            // PrintingService_btn
            // 
            this.PrintingService_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.PrintingService_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.PrintingService_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PrintingService_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintingService_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PrintingService_btn.FlatAppearance.BorderSize = 0;
            this.PrintingService_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintingService_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintingService_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintingService_btn.Location = new System.Drawing.Point(35, 446);
            this.PrintingService_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintingService_btn.Name = "PrintingService_btn";
            this.PrintingService_btn.Size = new System.Drawing.Size(275, 34);
            this.PrintingService_btn.TabIndex = 37;
            this.PrintingService_btn.Text = "Printing Service";
            this.PrintingService_btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PrintingService_btn.UseVisualStyleBackColor = false;
            this.PrintingService_btn.Click += new System.EventHandler(this.printingService_btn_Click);
            // 
            // CustomerProfile_btn
            // 
            this.CustomerProfile_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.CustomerProfile_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.CustomerProfile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CustomerProfile_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerProfile_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CustomerProfile_btn.FlatAppearance.BorderSize = 0;
            this.CustomerProfile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerProfile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerProfile_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerProfile_btn.Location = new System.Drawing.Point(35, 393);
            this.CustomerProfile_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerProfile_btn.Name = "CustomerProfile_btn";
            this.CustomerProfile_btn.Size = new System.Drawing.Size(275, 34);
            this.CustomerProfile_btn.TabIndex = 36;
            this.CustomerProfile_btn.Text = "Profile";
            this.CustomerProfile_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerProfile_btn.UseVisualStyleBackColor = false;
            this.CustomerProfile_btn.Click += new System.EventHandler(this.CustomerProfile_btn_Click);
            // 
            // Pay_btn
            // 
            this.Pay_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.Pay_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pay_btn.Location = new System.Drawing.Point(513, 323);
            this.Pay_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pay_btn.Name = "Pay_btn";
            this.Pay_btn.Size = new System.Drawing.Size(101, 36);
            this.Pay_btn.TabIndex = 40;
            this.Pay_btn.Text = "Pay";
            this.Pay_btn.UseVisualStyleBackColor = false;
            this.Pay_btn.Click += new System.EventHandler(this.Pay_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.Delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_btn.Location = new System.Drawing.Point(393, 323);
            this.Delete_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(101, 36);
            this.Delete_btn.TabIndex = 41;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "To Receive 📋";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(981, 329);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(68, 25);
            this.text2.TabIndex = 45;
            this.text2.Text = "Total:";
            // 
            // LogOut_btn
            // 
            this.LogOut_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.LogOut_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.LogOut_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogOut_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOut_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LogOut_btn.FlatAppearance.BorderSize = 0;
            this.LogOut_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOut_btn.Location = new System.Drawing.Point(35, 605);
            this.LogOut_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOut_btn.Name = "LogOut_btn";
            this.LogOut_btn.Size = new System.Drawing.Size(275, 34);
            this.LogOut_btn.TabIndex = 46;
            this.LogOut_btn.Text = "Log Out";
            this.LogOut_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOut_btn.UseVisualStyleBackColor = false;
            this.LogOut_btn.Click += new System.EventHandler(this.LogOut_btn_Click);
            // 
            // lbl_customerName
            // 
            this.lbl_customerName.BackColor = System.Drawing.Color.YellowGreen;
            this.lbl_customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_customerName.Location = new System.Drawing.Point(3, 317);
            this.lbl_customerName.Name = "lbl_customerName";
            this.lbl_customerName.Size = new System.Drawing.Size(307, 38);
            this.lbl_customerName.TabIndex = 48;
            this.lbl_customerName.Text = "User";
            this.lbl_customerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // We
            // 
            this.We.AutoSize = true;
            this.We.BackColor = System.Drawing.Color.YellowGreen;
            this.We.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.We.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.We.Location = new System.Drawing.Point(48, 272);
            this.We.Name = "We";
            this.We.Size = new System.Drawing.Size(224, 36);
            this.We.TabIndex = 47;
            this.We.Text = "Welcome Back";
            // 
            // Total_lbl
            // 
            this.Total_lbl.BackColor = System.Drawing.Color.YellowGreen;
            this.Total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_lbl.Location = new System.Drawing.Point(1055, 329);
            this.Total_lbl.Name = "Total_lbl";
            this.Total_lbl.Size = new System.Drawing.Size(168, 30);
            this.Total_lbl.TabIndex = 49;
            this.Total_lbl.Text = "-";
            // 
            // ToReceive_Table
            // 
            this.ToReceive_Table.AllowUserToAddRows = false;
            this.ToReceive_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ToReceive_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToReceive_Table.Location = new System.Drawing.Point(393, 446);
            this.ToReceive_Table.Name = "ToReceive_Table";
            this.ToReceive_Table.ReadOnly = true;
            this.ToReceive_Table.RowHeadersWidth = 51;
            this.ToReceive_Table.RowTemplate.Height = 24;
            this.ToReceive_Table.Size = new System.Drawing.Size(852, 215);
            this.ToReceive_Table.TabIndex = 50;
            // 
            // requestBindingSource
            // 
            this.requestBindingSource.DataMember = "Request";
            this.requestBindingSource.DataSource = this.printingServiceDataSetBindingSource;
            // 
            // printingServiceDataSetBindingSource
            // 
            this.printingServiceDataSetBindingSource.DataSource = this.printingServiceDataSet;
            this.printingServiceDataSetBindingSource.Position = 0;
            // 
            // printingServiceDataSet
            // 
            this.printingServiceDataSet.DataSetName = "PrintingServiceDataSet";
            this.printingServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // History_btn
            // 
            this.History_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.History_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.History_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.History_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.History_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.History_btn.FlatAppearance.BorderSize = 0;
            this.History_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.History_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.History_btn.Location = new System.Drawing.Point(35, 553);
            this.History_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.History_btn.Name = "History_btn";
            this.History_btn.Size = new System.Drawing.Size(275, 34);
            this.History_btn.TabIndex = 51;
            this.History_btn.Text = "History";
            this.History_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.History_btn.UseVisualStyleBackColor = false;
            this.History_btn.Click += new System.EventHandler(this.History_btn_Click);
            // 
            // requestTableAdapter
            // 
            this.requestTableAdapter.ClearBeforeFill = true;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // DateTime_ctrl
            // 
            this.DateTime_ctrl.CustomFormat = "dd / MM / yyyy || HH:mm";
            this.DateTime_ctrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime_ctrl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTime_ctrl.Location = new System.Drawing.Point(880, 280);
            this.DateTime_ctrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTime_ctrl.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DateTime_ctrl.Name = "DateTime_ctrl";
            this.DateTime_ctrl.Size = new System.Drawing.Size(289, 27);
            this.DateTime_ctrl.TabIndex = 53;
            this.DateTime_ctrl.Value = new System.DateTime(2024, 5, 28, 17, 25, 5, 0);
            this.DateTime_ctrl.Visible = false;
            // 
            // UrgentRequest_cb
            // 
            this.UrgentRequest_cb.AutoSize = true;
            this.UrgentRequest_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrgentRequest_cb.Location = new System.Drawing.Point(393, 280);
            this.UrgentRequest_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UrgentRequest_cb.Name = "UrgentRequest_cb";
            this.UrgentRequest_cb.Size = new System.Drawing.Size(419, 24);
            this.UrgentRequest_cb.TabIndex = 52;
            this.UrgentRequest_cb.Text = "Urgent Requests (charge 30% surcharge fee) ";
            this.UrgentRequest_cb.UseVisualStyleBackColor = true;
            this.UrgentRequest_cb.CheckedChanged += new System.EventHandler(this.UrgentRequest_cb_CheckedChanged);
            // 
            // sideBar_picb
            // 
            this.sideBar_picb.Image = global::APU_Printing_Management_System.Properties.Resources.side_bar;
            this.sideBar_picb.Location = new System.Drawing.Point(-3, 0);
            this.sideBar_picb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideBar_picb.Name = "sideBar_picb";
            this.sideBar_picb.Size = new System.Drawing.Size(349, 673);
            this.sideBar_picb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sideBar_picb.TabIndex = 39;
            this.sideBar_picb.TabStop = false;
            // 
            // notify_lbl
            // 
            this.notify_lbl.AutoSize = true;
            this.notify_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notify_lbl.ForeColor = System.Drawing.Color.Red;
            this.notify_lbl.Location = new System.Drawing.Point(877, 282);
            this.notify_lbl.Name = "notify_lbl";
            this.notify_lbl.Size = new System.Drawing.Size(260, 18);
            this.notify_lbl.TabIndex = 56;
            this.notify_lbl.Text = "*3 business days for (non-urgent)";
            // 
            // CustomerOrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.notify_lbl);
            this.Controls.Add(this.DateTime_ctrl);
            this.Controls.Add(this.UrgentRequest_cb);
            this.Controls.Add(this.History_btn);
            this.Controls.Add(this.ToReceive_Table);
            this.Controls.Add(this.Total_lbl);
            this.Controls.Add(this.lbl_customerName);
            this.Controls.Add(this.We);
            this.Controls.Add(this.LogOut_btn);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Pay_btn);
            this.Controls.Add(this.Order_btn);
            this.Controls.Add(this.PrintingService_btn);
            this.Controls.Add(this.CustomerProfile_btn);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.UnpaidRequestTable);
            this.Controls.Add(this.sideBar_picb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CustomerOrderPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Order Page";
            this.Load += new System.EventHandler(this.cartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnpaidRequestTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToReceive_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingServiceDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideBar_picb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKJobRequestID2EA5EC27BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKJobRequestID2EA5EC27BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.DataGridView UnpaidRequestTable;
        private System.Windows.Forms.Button Order_btn;
        private System.Windows.Forms.Button PrintingService_btn;
        private System.Windows.Forms.Button CustomerProfile_btn;
        private System.Windows.Forms.PictureBox sideBar_picb;
        private System.Windows.Forms.Button Pay_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Button LogOut_btn;
        private System.Windows.Forms.Label lbl_customerName;
        private System.Windows.Forms.Label We;
        private System.Windows.Forms.Label Total_lbl;
        private System.Windows.Forms.DataGridView ToReceive_Table;
        private System.Windows.Forms.BindingSource requestBindingSource2;
        private System.Windows.Forms.Button History_btn;
        private System.Windows.Forms.BindingSource printingServiceDataSetBindingSource;
        private PrintingServiceDataSet printingServiceDataSet;
        private System.Windows.Forms.BindingSource requestBindingSource;
        private PrintingServiceDataSetTableAdapters.RequestTableAdapter requestTableAdapter;
        private System.Windows.Forms.BindingSource fKJobRequestID2EA5EC27BindingSource;
        private PrintingServiceDataSetTableAdapters.JobTableAdapter jobTableAdapter;
        private System.Windows.Forms.BindingSource fKJobRequestID2EA5EC27BindingSource1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DateTimePicker DateTime_ctrl;
        private System.Windows.Forms.CheckBox UrgentRequest_cb;
        private System.Windows.Forms.Label notify_lbl;
    }
}