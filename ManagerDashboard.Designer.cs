namespace APU_Printing_Management_System
{
    partial class ManagerDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblJobNew = new System.Windows.Forms.Label();
            this.lblJobAssigned = new System.Windows.Forms.Label();
            this.lblJobWorkInProgress = new System.Windows.Forms.Label();
            this.lblRequestCompleted = new System.Windows.Forms.Label();
            this.lblNewCount = new System.Windows.Forms.Label();
            this.lblAssignedCount = new System.Windows.Forms.Label();
            this.lblWorkInProgressCount = new System.Windows.Forms.Label();
            this.lblCompletedCount = new System.Windows.Forms.Label();
            this.lblDashboardHeading = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlJobSummary = new System.Windows.Forms.Panel();
            this.lblRequestSummary = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnNewJobs = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.lblManagerName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSearchColumn = new System.Windows.Forms.Label();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            this.lblAssignedRequests = new System.Windows.Forms.Label();
            this.comboBoxSearchColumn = new System.Windows.Forms.ComboBox();
            this.radioButtonCompleted = new System.Windows.Forms.RadioButton();
            this.radioButtonWorkInProgress = new System.Windows.Forms.RadioButton();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonAssigned = new System.Windows.Forms.RadioButton();
            this.dateTimePickerCreation = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerAssign = new System.Windows.Forms.DateTimePicker();
            this.AssignedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateofAssignment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateofCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAssignedRequests = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPriorityAll = new System.Windows.Forms.RadioButton();
            this.radioButtonPriorityFalse = new System.Windows.Forms.RadioButton();
            this.radioButtonPriorityTrue = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlJobSummary.SuspendLayout();
            this.pnlSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedRequests)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJobNew
            // 
            this.lblJobNew.Location = new System.Drawing.Point(656, 83);
            this.lblJobNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobNew.Name = "lblJobNew";
            this.lblJobNew.Size = new System.Drawing.Size(121, 49);
            this.lblJobNew.TabIndex = 20;
            this.lblJobNew.Text = "New";
            this.lblJobNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJobAssigned
            // 
            this.lblJobAssigned.Location = new System.Drawing.Point(468, 83);
            this.lblJobAssigned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobAssigned.Name = "lblJobAssigned";
            this.lblJobAssigned.Size = new System.Drawing.Size(121, 49);
            this.lblJobAssigned.TabIndex = 19;
            this.lblJobAssigned.Text = "Assigned";
            this.lblJobAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJobWorkInProgress
            // 
            this.lblJobWorkInProgress.Location = new System.Drawing.Point(252, 85);
            this.lblJobWorkInProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobWorkInProgress.Name = "lblJobWorkInProgress";
            this.lblJobWorkInProgress.Size = new System.Drawing.Size(121, 49);
            this.lblJobWorkInProgress.TabIndex = 18;
            this.lblJobWorkInProgress.Text = "Work In Progress";
            this.lblJobWorkInProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRequestCompleted
            // 
            this.lblRequestCompleted.Location = new System.Drawing.Point(45, 85);
            this.lblRequestCompleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestCompleted.Name = "lblRequestCompleted";
            this.lblRequestCompleted.Size = new System.Drawing.Size(121, 49);
            this.lblRequestCompleted.TabIndex = 17;
            this.lblRequestCompleted.Text = "Completed";
            this.lblRequestCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewCount
            // 
            this.lblNewCount.AutoSize = true;
            this.lblNewCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNewCount.Location = new System.Drawing.Point(699, 47);
            this.lblNewCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewCount.Name = "lblNewCount";
            this.lblNewCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNewCount.Size = new System.Drawing.Size(30, 31);
            this.lblNewCount.TabIndex = 16;
            this.lblNewCount.Text = "0";
            // 
            // lblAssignedCount
            // 
            this.lblAssignedCount.AutoSize = true;
            this.lblAssignedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedCount.Location = new System.Drawing.Point(509, 47);
            this.lblAssignedCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssignedCount.Name = "lblAssignedCount";
            this.lblAssignedCount.Size = new System.Drawing.Size(30, 31);
            this.lblAssignedCount.TabIndex = 15;
            this.lblAssignedCount.Text = "0";
            // 
            // lblWorkInProgressCount
            // 
            this.lblWorkInProgressCount.AutoSize = true;
            this.lblWorkInProgressCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkInProgressCount.Location = new System.Drawing.Point(294, 47);
            this.lblWorkInProgressCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkInProgressCount.Name = "lblWorkInProgressCount";
            this.lblWorkInProgressCount.Size = new System.Drawing.Size(30, 31);
            this.lblWorkInProgressCount.TabIndex = 14;
            this.lblWorkInProgressCount.Text = "0";
            // 
            // lblCompletedCount
            // 
            this.lblCompletedCount.AutoSize = true;
            this.lblCompletedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedCount.Location = new System.Drawing.Point(86, 47);
            this.lblCompletedCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompletedCount.Name = "lblCompletedCount";
            this.lblCompletedCount.Size = new System.Drawing.Size(30, 31);
            this.lblCompletedCount.TabIndex = 13;
            this.lblCompletedCount.Text = "0";
            // 
            // lblDashboardHeading
            // 
            this.lblDashboardHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardHeading.Location = new System.Drawing.Point(387, 15);
            this.lblDashboardHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDashboardHeading.Name = "lblDashboardHeading";
            this.lblDashboardHeading.Size = new System.Drawing.Size(299, 49);
            this.lblDashboardHeading.TabIndex = 0;
            this.lblDashboardHeading.Text = "Dashboard";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(-18, 272);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(359, 36);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "WELCOME BACK";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlJobSummary
            // 
            this.pnlJobSummary.BackColor = System.Drawing.SystemColors.Window;
            this.pnlJobSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlJobSummary.Controls.Add(this.lblJobNew);
            this.pnlJobSummary.Controls.Add(this.lblJobAssigned);
            this.pnlJobSummary.Controls.Add(this.lblRequestSummary);
            this.pnlJobSummary.Controls.Add(this.lblJobWorkInProgress);
            this.pnlJobSummary.Controls.Add(this.lblCompletedCount);
            this.pnlJobSummary.Controls.Add(this.lblRequestCompleted);
            this.pnlJobSummary.Controls.Add(this.lblWorkInProgressCount);
            this.pnlJobSummary.Controls.Add(this.lblNewCount);
            this.pnlJobSummary.Controls.Add(this.lblAssignedCount);
            this.pnlJobSummary.Location = new System.Drawing.Point(394, 68);
            this.pnlJobSummary.Margin = new System.Windows.Forms.Padding(4);
            this.pnlJobSummary.Name = "pnlJobSummary";
            this.pnlJobSummary.Size = new System.Drawing.Size(847, 145);
            this.pnlJobSummary.TabIndex = 13;
            // 
            // lblRequestSummary
            // 
            this.lblRequestSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestSummary.Location = new System.Drawing.Point(12, 9);
            this.lblRequestSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestSummary.Name = "lblRequestSummary";
            this.lblRequestSummary.Size = new System.Drawing.Size(211, 31);
            this.lblRequestSummary.TabIndex = 12;
            this.lblRequestSummary.Text = "Request Summary";
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
            // btnNewJobs
            // 
            this.btnNewJobs.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNewJobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewJobs.FlatAppearance.BorderSize = 0;
            this.btnNewJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewJobs.ForeColor = System.Drawing.Color.White;
            this.btnNewJobs.Location = new System.Drawing.Point(0, 461);
            this.btnNewJobs.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewJobs.Name = "btnNewJobs";
            this.btnNewJobs.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnNewJobs.Size = new System.Drawing.Size(363, 53);
            this.btnNewJobs.TabIndex = 2;
            this.btnNewJobs.Text = "New Requests";
            this.btnNewJobs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewJobs.UseVisualStyleBackColor = false;
            this.btnNewJobs.Click += new System.EventHandler(this.btnNewJobs_Click);
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
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDashboard.Enabled = false;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 400);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(367, 43);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlSideMenu.Controls.Add(this.lblManagerName);
            this.pnlSideMenu.Controls.Add(this.lblWelcome);
            this.pnlSideMenu.Controls.Add(this.btnDashboard);
            this.pnlSideMenu.Controls.Add(this.btnLogOut);
            this.pnlSideMenu.Controls.Add(this.btnNewJobs);
            this.pnlSideMenu.Controls.Add(this.btnProfile);
            this.pnlSideMenu.Controls.Add(this.pictureBox1);
            this.pnlSideMenu.Location = new System.Drawing.Point(0, -1);
            this.pnlSideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(349, 673);
            this.pnlSideMenu.TabIndex = 27;
            // 
            // lblManagerName
            // 
            this.lblManagerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerName.ForeColor = System.Drawing.Color.White;
            this.lblManagerName.Location = new System.Drawing.Point(-22, 308);
            this.lblManagerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagerName.Name = "lblManagerName";
            this.lblManagerName.Size = new System.Drawing.Size(367, 47);
            this.lblManagerName.TabIndex = 30;
            this.lblManagerName.Text = "managername";
            this.lblManagerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APU_Printing_Management_System.Properties.Resources.Picture_1_6;
            this.pictureBox1.Location = new System.Drawing.Point(-18, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // lblSearchColumn
            // 
            this.lblSearchColumn.AutoSize = true;
            this.lblSearchColumn.Location = new System.Drawing.Point(399, 291);
            this.lblSearchColumn.Name = "lblSearchColumn";
            this.lblSearchColumn.Size = new System.Drawing.Size(101, 16);
            this.lblSearchColumn.TabIndex = 30;
            this.lblSearchColumn.Text = "Search Column:";
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(888, 292);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(62, 16);
            this.lblKeyword.TabIndex = 31;
            this.lblKeyword.Text = "Keyword:";
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.Location = new System.Drawing.Point(953, 286);
            this.textBoxKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(276, 22);
            this.textBoxKeyword.TabIndex = 32;
            // 
            // lblAssignedRequests
            // 
            this.lblAssignedRequests.AutoSize = true;
            this.lblAssignedRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedRequests.Location = new System.Drawing.Point(396, 236);
            this.lblAssignedRequests.Name = "lblAssignedRequests";
            this.lblAssignedRequests.Size = new System.Drawing.Size(266, 31);
            this.lblAssignedRequests.TabIndex = 33;
            this.lblAssignedRequests.Text = "Assigned Requests";
            // 
            // comboBoxSearchColumn
            // 
            this.comboBoxSearchColumn.FormattingEnabled = true;
            this.comboBoxSearchColumn.Items.AddRange(new object[] {
            "Request ID",
            "Requested By",
            "Assigned To"});
            this.comboBoxSearchColumn.Location = new System.Drawing.Point(508, 288);
            this.comboBoxSearchColumn.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSearchColumn.Name = "comboBoxSearchColumn";
            this.comboBoxSearchColumn.Size = new System.Drawing.Size(284, 24);
            this.comboBoxSearchColumn.TabIndex = 35;
            // 
            // radioButtonCompleted
            // 
            this.radioButtonCompleted.AutoSize = true;
            this.radioButtonCompleted.Location = new System.Drawing.Point(11, 20);
            this.radioButtonCompleted.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCompleted.Name = "radioButtonCompleted";
            this.radioButtonCompleted.Size = new System.Drawing.Size(94, 20);
            this.radioButtonCompleted.TabIndex = 37;
            this.radioButtonCompleted.Text = "Completed";
            this.radioButtonCompleted.UseVisualStyleBackColor = true;
            // 
            // radioButtonWorkInProgress
            // 
            this.radioButtonWorkInProgress.AutoSize = true;
            this.radioButtonWorkInProgress.Location = new System.Drawing.Point(119, 20);
            this.radioButtonWorkInProgress.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonWorkInProgress.Name = "radioButtonWorkInProgress";
            this.radioButtonWorkInProgress.Size = new System.Drawing.Size(131, 20);
            this.radioButtonWorkInProgress.TabIndex = 38;
            this.radioButtonWorkInProgress.Text = "Work In Progress";
            this.radioButtonWorkInProgress.UseVisualStyleBackColor = true;
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.radioButtonAll);
            this.groupBoxStatus.Controls.Add(this.radioButtonAssigned);
            this.groupBoxStatus.Controls.Add(this.radioButtonWorkInProgress);
            this.groupBoxStatus.Controls.Add(this.radioButtonCompleted);
            this.groupBoxStatus.Location = new System.Drawing.Point(650, 333);
            this.groupBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStatus.Size = new System.Drawing.Size(254, 87);
            this.groupBoxStatus.TabIndex = 39;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status";
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(119, 49);
            this.radioButtonAll.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(43, 20);
            this.radioButtonAll.TabIndex = 41;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonAssigned
            // 
            this.radioButtonAssigned.AutoSize = true;
            this.radioButtonAssigned.Location = new System.Drawing.Point(11, 48);
            this.radioButtonAssigned.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAssigned.Name = "radioButtonAssigned";
            this.radioButtonAssigned.Size = new System.Drawing.Size(85, 20);
            this.radioButtonAssigned.TabIndex = 39;
            this.radioButtonAssigned.Text = "Assigned";
            this.radioButtonAssigned.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerCreation
            // 
            this.dateTimePickerCreation.Checked = false;
            this.dateTimePickerCreation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCreation.Location = new System.Drawing.Point(490, 341);
            this.dateTimePickerCreation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerCreation.Name = "dateTimePickerCreation";
            this.dateTimePickerCreation.ShowCheckBox = true;
            this.dateTimePickerCreation.Size = new System.Drawing.Size(135, 22);
            this.dateTimePickerCreation.TabIndex = 44;
            this.dateTimePickerCreation.Value = new System.DateTime(2024, 5, 21, 23, 3, 19, 0);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(399, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 38);
            this.label2.TabIndex = 45;
            this.label2.Text = "Date of Creation:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(399, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 36);
            this.label1.TabIndex = 47;
            this.label1.Text = "Date of Assignment:";
            // 
            // dateTimePickerAssign
            // 
            this.dateTimePickerAssign.Checked = false;
            this.dateTimePickerAssign.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAssign.Location = new System.Drawing.Point(490, 382);
            this.dateTimePickerAssign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerAssign.Name = "dateTimePickerAssign";
            this.dateTimePickerAssign.ShowCheckBox = true;
            this.dateTimePickerAssign.Size = new System.Drawing.Size(135, 22);
            this.dateTimePickerAssign.TabIndex = 46;
            this.dateTimePickerAssign.Value = new System.DateTime(2024, 5, 21, 23, 3, 19, 0);
            // 
            // AssignedTo
            // 
            this.AssignedTo.DataPropertyName = "WorkerName";
            this.AssignedTo.HeaderText = "Assigned To";
            this.AssignedTo.MinimumWidth = 10;
            this.AssignedTo.Name = "AssignedTo";
            this.AssignedTo.ReadOnly = true;
            this.AssignedTo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // RequestedBy
            // 
            this.RequestedBy.DataPropertyName = "CustomerName";
            this.RequestedBy.HeaderText = "Requested By";
            this.RequestedBy.MinimumWidth = 10;
            this.RequestedBy.Name = "RequestedBy";
            this.RequestedBy.ReadOnly = true;
            // 
            // Priority
            // 
            this.Priority.DataPropertyName = "Priority";
            this.Priority.HeaderText = "Priority";
            this.Priority.MinimumWidth = 10;
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "RequestStatus";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 10;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // DateofAssignment
            // 
            this.DateofAssignment.DataPropertyName = "DateofAssignment";
            this.DateofAssignment.HeaderText = "Assigned";
            this.DateofAssignment.MinimumWidth = 10;
            this.DateofAssignment.Name = "DateofAssignment";
            this.DateofAssignment.ReadOnly = true;
            this.DateofAssignment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DateofCreation
            // 
            this.DateofCreation.DataPropertyName = "DateOfCreation";
            this.DateofCreation.HeaderText = "Created ";
            this.DateofCreation.MinimumWidth = 10;
            this.DateofCreation.Name = "DateofCreation";
            this.DateofCreation.ReadOnly = true;
            // 
            // RequestID
            // 
            this.RequestID.DataPropertyName = "RequestID";
            this.RequestID.HeaderText = "Request ID";
            this.RequestID.MinimumWidth = 10;
            this.RequestID.Name = "RequestID";
            this.RequestID.ReadOnly = true;
            // 
            // dgvAssignedRequests
            // 
            this.dgvAssignedRequests.AllowUserToAddRows = false;
            this.dgvAssignedRequests.AllowUserToDeleteRows = false;
            this.dgvAssignedRequests.AllowUserToResizeColumns = false;
            this.dgvAssignedRequests.AllowUserToResizeRows = false;
            this.dgvAssignedRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignedRequests.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignedRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAssignedRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequestID,
            this.DateofCreation,
            this.DateofAssignment,
            this.Status,
            this.Priority,
            this.RequestedBy,
            this.AssignedTo});
            this.dgvAssignedRequests.Location = new System.Drawing.Point(394, 428);
            this.dgvAssignedRequests.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAssignedRequests.Name = "dgvAssignedRequests";
            this.dgvAssignedRequests.RowHeadersVisible = false;
            this.dgvAssignedRequests.RowHeadersWidth = 82;
            this.dgvAssignedRequests.Size = new System.Drawing.Size(847, 232);
            this.dgvAssignedRequests.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPriorityAll);
            this.groupBox1.Controls.Add(this.radioButtonPriorityFalse);
            this.groupBox1.Controls.Add(this.radioButtonPriorityTrue);
            this.groupBox1.Location = new System.Drawing.Point(932, 333);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(192, 87);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Priority";
            // 
            // radioButtonPriorityAll
            // 
            this.radioButtonPriorityAll.AutoSize = true;
            this.radioButtonPriorityAll.Checked = true;
            this.radioButtonPriorityAll.Location = new System.Drawing.Point(112, 27);
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
            this.radioButtonPriorityFalse.Location = new System.Drawing.Point(21, 53);
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
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1148, 388);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 26);
            this.btnClear.TabIndex = 52;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1148, 348);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 25);
            this.btnSearch.TabIndex = 51;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerAssign);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerCreation);
            this.Controls.Add(this.comboBoxSearchColumn);
            this.Controls.Add(this.lblAssignedRequests);
            this.Controls.Add(this.textBoxKeyword);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.lblSearchColumn);
            this.Controls.Add(this.dgvAssignedRequests);
            this.Controls.Add(this.pnlSideMenu);
            this.Controls.Add(this.pnlJobSummary);
            this.Controls.Add(this.lblDashboardHeading);
            this.Controls.Add(this.groupBoxStatus);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Dashboard";
            this.pnlJobSummary.ResumeLayout(false);
            this.pnlJobSummary.PerformLayout();
            this.pnlSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedRequests)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDashboardHeading;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlJobSummary;
        private System.Windows.Forms.Label lblRequestSummary;
        private System.Windows.Forms.Label lblCompletedCount;
        private System.Windows.Forms.Label lblNewCount;
        private System.Windows.Forms.Label lblAssignedCount;
        private System.Windows.Forms.Label lblWorkInProgressCount;
        private System.Windows.Forms.Label lblRequestCompleted;
        private System.Windows.Forms.Label lblJobNew;
        private System.Windows.Forms.Label lblJobAssigned;
        private System.Windows.Forms.Label lblJobWorkInProgress;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnNewJobs;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSearchColumn;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox textBoxKeyword;
        private System.Windows.Forms.Label lblAssignedRequests;
        private System.Windows.Forms.ComboBox comboBoxSearchColumn;
        private System.Windows.Forms.RadioButton radioButtonCompleted;
        private System.Windows.Forms.RadioButton radioButtonWorkInProgress;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.RadioButton radioButtonAssigned;
        private System.Windows.Forms.Label lblManagerName;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerAssign;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateofAssignment;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateofCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestID;
        private System.Windows.Forms.DataGridView dgvAssignedRequests;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPriorityAll;
        private System.Windows.Forms.RadioButton radioButtonPriorityFalse;
        private System.Windows.Forms.RadioButton radioButtonPriorityTrue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
    }
}

