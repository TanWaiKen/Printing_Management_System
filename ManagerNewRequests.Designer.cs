namespace APU_Printing_Management_System
{
    partial class ManagerNewRequests
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.lblManagerName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnNewJobs = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblNewJobsHeading = new System.Windows.Forms.Label();
            this.dgvNewRequests = new System.Windows.Forms.DataGridView();
            this.RequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AssignedTo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvNewJobs = new System.Windows.Forms.DataGridView();
            this.JobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPriorityAll = new System.Windows.Forms.RadioButton();
            this.radioButtonPriorityFalse = new System.Windows.Forms.RadioButton();
            this.radioButtonPriorityTrue = new System.Windows.Forms.RadioButton();
            this.comboBoxSearchColumn = new System.Windows.Forms.ComboBox();
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.lblSearchColumn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRequestID = new System.Windows.Forms.TextBox();
            this.pnlSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewJobs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlSideMenu.Controls.Add(this.lblManagerName);
            this.pnlSideMenu.Controls.Add(this.lblWelcome);
            this.pnlSideMenu.Controls.Add(this.pictureBox1);
            this.pnlSideMenu.Controls.Add(this.btnDashboard);
            this.pnlSideMenu.Controls.Add(this.btnLogOut);
            this.pnlSideMenu.Controls.Add(this.btnNewJobs);
            this.pnlSideMenu.Controls.Add(this.btnProfile);
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(349, 673);
            this.pnlSideMenu.TabIndex = 1;
            // 
            // lblManagerName
            // 
            this.lblManagerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerName.ForeColor = System.Drawing.Color.White;
            this.lblManagerName.Location = new System.Drawing.Point(-20, 308);
            this.lblManagerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagerName.Name = "lblManagerName";
            this.lblManagerName.Size = new System.Drawing.Size(363, 47);
            this.lblManagerName.TabIndex = 32;
            this.lblManagerName.Text = "managername";
            this.lblManagerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(-22, 272);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(367, 36);
            this.lblWelcome.TabIndex = 31;
            this.lblWelcome.Text = "WELCOME BACK";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APU_Printing_Management_System.Properties.Resources.Picture_1_6;
            this.pictureBox1.Location = new System.Drawing.Point(-18, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 399);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(367, 43);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(0, 593);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(367, 43);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnNewJobs
            // 
            this.btnNewJobs.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNewJobs.Enabled = false;
            this.btnNewJobs.FlatAppearance.BorderSize = 0;
            this.btnNewJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewJobs.ForeColor = System.Drawing.Color.White;
            this.btnNewJobs.Location = new System.Drawing.Point(0, 466);
            this.btnNewJobs.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewJobs.Name = "btnNewJobs";
            this.btnNewJobs.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnNewJobs.Size = new System.Drawing.Size(363, 43);
            this.btnNewJobs.TabIndex = 2;
            this.btnNewJobs.Text = "New Requests";
            this.btnNewJobs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewJobs.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(0, 531);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(367, 43);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblNewJobsHeading
            // 
            this.lblNewJobsHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewJobsHeading.Location = new System.Drawing.Point(390, 27);
            this.lblNewJobsHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewJobsHeading.Name = "lblNewJobsHeading";
            this.lblNewJobsHeading.Size = new System.Drawing.Size(376, 49);
            this.lblNewJobsHeading.TabIndex = 2;
            this.lblNewJobsHeading.Text = "New Requests";
            // 
            // dgvNewRequests
            // 
            this.dgvNewRequests.AllowUserToAddRows = false;
            this.dgvNewRequests.AllowUserToDeleteRows = false;
            this.dgvNewRequests.AllowUserToResizeColumns = false;
            this.dgvNewRequests.AllowUserToResizeRows = false;
            this.dgvNewRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNewRequests.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNewRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequestID,
            this.Created,
            this.Status,
            this.Priority,
            this.RequestedBy,
            this.JobDetail,
            this.AssignedTo});
            this.dgvNewRequests.Location = new System.Drawing.Point(397, 173);
            this.dgvNewRequests.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNewRequests.Name = "dgvNewRequests";
            this.dgvNewRequests.RowHeadersVisible = false;
            this.dgvNewRequests.RowHeadersWidth = 82;
            this.dgvNewRequests.Size = new System.Drawing.Size(852, 209);
            this.dgvNewRequests.TabIndex = 3;
            this.dgvNewRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewRequests_CellContentClick);
            // 
            // RequestID
            // 
            this.RequestID.DataPropertyName = "RequestID";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestID.DefaultCellStyle = dataGridViewCellStyle2;
            this.RequestID.HeaderText = "Request ID";
            this.RequestID.MinimumWidth = 10;
            this.RequestID.Name = "RequestID";
            this.RequestID.ReadOnly = true;
            // 
            // Created
            // 
            this.Created.DataPropertyName = "DateofCreation";
            this.Created.HeaderText = "Created";
            this.Created.MinimumWidth = 10;
            this.Created.Name = "Created";
            this.Created.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "RequestStatus";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 10;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Priority
            // 
            this.Priority.DataPropertyName = "Priority";
            this.Priority.HeaderText = "Priority";
            this.Priority.MinimumWidth = 10;
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            // 
            // RequestedBy
            // 
            this.RequestedBy.DataPropertyName = "CustomerName";
            this.RequestedBy.HeaderText = "Requested By";
            this.RequestedBy.MinimumWidth = 10;
            this.RequestedBy.Name = "RequestedBy";
            this.RequestedBy.ReadOnly = true;
            // 
            // JobDetail
            // 
            this.JobDetail.HeaderText = "Job(s)";
            this.JobDetail.MinimumWidth = 10;
            this.JobDetail.Name = "JobDetail";
            this.JobDetail.ReadOnly = true;
            this.JobDetail.Text = "See Details";
            this.JobDetail.UseColumnTextForButtonValue = true;
            // 
            // AssignedTo
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AssignedTo.DefaultCellStyle = dataGridViewCellStyle3;
            this.AssignedTo.HeaderText = "Assigned To";
            this.AssignedTo.MinimumWidth = 10;
            this.AssignedTo.Name = "AssignedTo";
            this.AssignedTo.ReadOnly = true;
            this.AssignedTo.Text = "Assign";
            this.AssignedTo.UseColumnTextForButtonValue = true;
            // 
            // dgvNewJobs
            // 
            this.dgvNewJobs.AllowUserToAddRows = false;
            this.dgvNewJobs.AllowUserToDeleteRows = false;
            this.dgvNewJobs.AllowUserToResizeColumns = false;
            this.dgvNewJobs.AllowUserToResizeRows = false;
            this.dgvNewJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNewJobs.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNewJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNewJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobID,
            this.ServiceType,
            this.Quantity});
            this.dgvNewJobs.Location = new System.Drawing.Point(397, 448);
            this.dgvNewJobs.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNewJobs.Name = "dgvNewJobs";
            this.dgvNewJobs.RowHeadersVisible = false;
            this.dgvNewJobs.RowHeadersWidth = 82;
            this.dgvNewJobs.Size = new System.Drawing.Size(852, 212);
            this.dgvNewJobs.TabIndex = 4;
            // 
            // JobID
            // 
            this.JobID.DataPropertyName = "JobID";
            this.JobID.HeaderText = "Job ID";
            this.JobID.MinimumWidth = 10;
            this.JobID.Name = "JobID";
            this.JobID.ReadOnly = true;
            // 
            // ServiceType
            // 
            this.ServiceType.DataPropertyName = "ServiceType";
            this.ServiceType.HeaderText = "Service Type";
            this.ServiceType.MinimumWidth = 10;
            this.ServiceType.Name = "ServiceType";
            this.ServiceType.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 10;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1158, 94);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 26);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1158, 129);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 26);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Date of Creation:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(686, 120);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowCheckBox = true;
            this.dateTimePicker.Size = new System.Drawing.Size(135, 22);
            this.dateTimePicker.TabIndex = 51;
            this.dateTimePicker.Value = new System.DateTime(2024, 5, 21, 23, 3, 19, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPriorityAll);
            this.groupBox1.Controls.Add(this.radioButtonPriorityFalse);
            this.groupBox1.Controls.Add(this.radioButtonPriorityTrue);
            this.groupBox1.Location = new System.Drawing.Point(868, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(259, 65);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Priority";
            // 
            // radioButtonPriorityAll
            // 
            this.radioButtonPriorityAll.AutoSize = true;
            this.radioButtonPriorityAll.Checked = true;
            this.radioButtonPriorityAll.Location = new System.Drawing.Point(187, 26);
            this.radioButtonPriorityAll.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPriorityAll.Name = "radioButtonPriorityAll";
            this.radioButtonPriorityAll.Size = new System.Drawing.Size(43, 20);
            this.radioButtonPriorityAll.TabIndex = 42;
            this.radioButtonPriorityAll.TabStop = true;
            this.radioButtonPriorityAll.Text = "All";
            this.radioButtonPriorityAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonPriorityFalse
            // 
            this.radioButtonPriorityFalse.AutoSize = true;
            this.radioButtonPriorityFalse.Location = new System.Drawing.Point(101, 26);
            this.radioButtonPriorityFalse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPriorityFalse.Name = "radioButtonPriorityFalse";
            this.radioButtonPriorityFalse.Size = new System.Drawing.Size(62, 20);
            this.radioButtonPriorityFalse.TabIndex = 1;
            this.radioButtonPriorityFalse.TabStop = true;
            this.radioButtonPriorityFalse.Text = "False";
            this.radioButtonPriorityFalse.UseVisualStyleBackColor = true;
            // 
            // radioButtonPriorityTrue
            // 
            this.radioButtonPriorityTrue.AutoSize = true;
            this.radioButtonPriorityTrue.Location = new System.Drawing.Point(21, 26);
            this.radioButtonPriorityTrue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPriorityTrue.Name = "radioButtonPriorityTrue";
            this.radioButtonPriorityTrue.Size = new System.Drawing.Size(56, 20);
            this.radioButtonPriorityTrue.TabIndex = 0;
            this.radioButtonPriorityTrue.TabStop = true;
            this.radioButtonPriorityTrue.Text = "True";
            this.radioButtonPriorityTrue.UseVisualStyleBackColor = true;
            // 
            // comboBoxSearchColumn
            // 
            this.comboBoxSearchColumn.FormattingEnabled = true;
            this.comboBoxSearchColumn.Items.AddRange(new object[] {
            "Request ID",
            "Requested By"});
            this.comboBoxSearchColumn.Location = new System.Drawing.Point(498, 91);
            this.comboBoxSearchColumn.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSearchColumn.Name = "comboBoxSearchColumn";
            this.comboBoxSearchColumn.Size = new System.Drawing.Size(145, 24);
            this.comboBoxSearchColumn.TabIndex = 49;
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.Location = new System.Drawing.Point(497, 133);
            this.textBoxKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(147, 22);
            this.textBoxKeyword.TabIndex = 48;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(428, 134);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(62, 16);
            this.lblKeyword.TabIndex = 47;
            this.lblKeyword.Text = "Keyword:";
            // 
            // lblSearchColumn
            // 
            this.lblSearchColumn.AutoSize = true;
            this.lblSearchColumn.Location = new System.Drawing.Point(389, 94);
            this.lblSearchColumn.Name = "lblSearchColumn";
            this.lblSearchColumn.Size = new System.Drawing.Size(101, 16);
            this.lblSearchColumn.TabIndex = 46;
            this.lblSearchColumn.Text = "Search Column:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 408);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Request ID: ";
            // 
            // txtRequestID
            // 
            this.txtRequestID.Location = new System.Drawing.Point(491, 404);
            this.txtRequestID.Margin = new System.Windows.Forms.Padding(4);
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.ReadOnly = true;
            this.txtRequestID.Size = new System.Drawing.Size(132, 22);
            this.txtRequestID.TabIndex = 54;
            // 
            // ManagerNewRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.txtRequestID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxSearchColumn);
            this.Controls.Add(this.textBoxKeyword);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.lblSearchColumn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvNewJobs);
            this.Controls.Add(this.dgvNewRequests);
            this.Controls.Add(this.lblNewJobsHeading);
            this.Controls.Add(this.pnlSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerNewRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager New Requests";
            this.pnlSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewJobs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnNewJobs;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label lblNewJobsHeading;
        private System.Windows.Forms.DataGridView dgvNewRequests;
        private System.Windows.Forms.DataGridView dgvNewJobs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblManagerName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPriorityAll;
        private System.Windows.Forms.RadioButton radioButtonPriorityFalse;
        private System.Windows.Forms.RadioButton radioButtonPriorityTrue;
        private System.Windows.Forms.ComboBox comboBoxSearchColumn;
        private System.Windows.Forms.TextBox textBoxKeyword;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Label lblSearchColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestedBy;
        private System.Windows.Forms.DataGridViewButtonColumn JobDetail;
        private System.Windows.Forms.DataGridViewButtonColumn AssignedTo;
    }
}