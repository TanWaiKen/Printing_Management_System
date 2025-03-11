namespace APU_Printing_Management_System
{
    partial class WorkerDashboard
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
            this.btn_inProgress = new System.Windows.Forms.Button();
            this.btn_completed = new System.Windows.Forms.Button();
            this.btn_assigned = new System.Windows.Forms.Button();
            this.btn_clearPanel = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dgv_all = new System.Windows.Forms.DataGridView();
            this.dgv_selected = new System.Windows.Forms.DataGridView();
            this.combo_calendar = new System.Windows.Forms.ComboBox();
            this.combo_deadline = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_cusID = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_deadline = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_jobCompleted = new System.Windows.Forms.Label();
            this.lbl_jobIncomplete = new System.Windows.Forms.Label();
            this.lbl_totalJob = new System.Windows.Forms.Label();
            this.txt_jobCompleted = new System.Windows.Forms.TextBox();
            this.txt_jobIncomplete = new System.Windows.Forms.TextBox();
            this.txt_totalJob = new System.Windows.Forms.TextBox();
            this.txt_cusID = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_deadline = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.lbl_requestID = new System.Windows.Forms.Label();
            this.txt_requestID = new System.Windows.Forms.TextBox();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_workerName = new System.Windows.Forms.Label();
            this.lbl_profile = new System.Windows.Forms.Label();
            this.lbl_logOut = new System.Windows.Forms.Label();
            this.btn_clearfilter = new System.Windows.Forms.Button();
            this.cb_priority = new System.Windows.Forms.CheckBox();
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.rb_all = new System.Windows.Forms.RadioButton();
            this.rb_completed = new System.Windows.Forms.RadioButton();
            this.rb_inProgress = new System.Windows.Forms.RadioButton();
            this.rb_assigned = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selected)).BeginInit();
            this.gb_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_inProgress
            // 
            this.btn_inProgress.BackColor = System.Drawing.Color.Gold;
            this.btn_inProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inProgress.Location = new System.Drawing.Point(840, 625);
            this.btn_inProgress.Name = "btn_inProgress";
            this.btn_inProgress.Size = new System.Drawing.Size(170, 30);
            this.btn_inProgress.TabIndex = 1;
            this.btn_inProgress.Text = "Work In Progress";
            this.btn_inProgress.UseVisualStyleBackColor = false;
            this.btn_inProgress.Click += new System.EventHandler(this.btn_inProgress_Click);
            // 
            // btn_completed
            // 
            this.btn_completed.BackColor = System.Drawing.Color.Gold;
            this.btn_completed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_completed.Location = new System.Drawing.Point(1055, 625);
            this.btn_completed.Name = "btn_completed";
            this.btn_completed.Size = new System.Drawing.Size(170, 30);
            this.btn_completed.TabIndex = 2;
            this.btn_completed.Text = "Completed";
            this.btn_completed.UseVisualStyleBackColor = false;
            this.btn_completed.Click += new System.EventHandler(this.btn_completed_Click);
            // 
            // btn_assigned
            // 
            this.btn_assigned.BackColor = System.Drawing.Color.Gold;
            this.btn_assigned.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_assigned.Location = new System.Drawing.Point(625, 625);
            this.btn_assigned.Name = "btn_assigned";
            this.btn_assigned.Size = new System.Drawing.Size(170, 30);
            this.btn_assigned.TabIndex = 3;
            this.btn_assigned.Text = "Assigned";
            this.btn_assigned.UseVisualStyleBackColor = false;
            this.btn_assigned.Click += new System.EventHandler(this.btn_assigned_Click);
            // 
            // btn_clearPanel
            // 
            this.btn_clearPanel.BackColor = System.Drawing.Color.LightGray;
            this.btn_clearPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clearPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clearPanel.Location = new System.Drawing.Point(410, 625);
            this.btn_clearPanel.Name = "btn_clearPanel";
            this.btn_clearPanel.Size = new System.Drawing.Size(170, 30);
            this.btn_clearPanel.TabIndex = 4;
            this.btn_clearPanel.Text = "Clear Panel";
            this.btn_clearPanel.UseVisualStyleBackColor = false;
            this.btn_clearPanel.Click += new System.EventHandler(this.btn_clearPanel_Click_1);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.AllowDrop = true;
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(925, 25);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // dgv_all
            // 
            this.dgv_all.AllowUserToAddRows = false;
            this.dgv_all.AllowUserToDeleteRows = false;
            this.dgv_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_all.Location = new System.Drawing.Point(410, 264);
            this.dgv_all.Name = "dgv_all";
            this.dgv_all.ReadOnly = true;
            this.dgv_all.RowHeadersWidth = 51;
            this.dgv_all.RowTemplate.Height = 24;
            this.dgv_all.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_all.Size = new System.Drawing.Size(815, 150);
            this.dgv_all.TabIndex = 7;
            this.dgv_all.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_all_RowHeaderMouseDoubleClick);
            // 
            // dgv_selected
            // 
            this.dgv_selected.AllowUserToAddRows = false;
            this.dgv_selected.AllowUserToDeleteRows = false;
            this.dgv_selected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_selected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_selected.Location = new System.Drawing.Point(410, 460);
            this.dgv_selected.Name = "dgv_selected";
            this.dgv_selected.ReadOnly = true;
            this.dgv_selected.RowHeadersWidth = 51;
            this.dgv_selected.RowTemplate.Height = 24;
            this.dgv_selected.Size = new System.Drawing.Size(500, 150);
            this.dgv_selected.TabIndex = 8;
            // 
            // combo_calendar
            // 
            this.combo_calendar.BackColor = System.Drawing.Color.Gold;
            this.combo_calendar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.combo_calendar.FormattingEnabled = true;
            this.combo_calendar.Items.AddRange(new object[] {
            "None",
            "Deadline",
            "Date of Creation",
            "Date of Assignment"});
            this.combo_calendar.Location = new System.Drawing.Point(725, 145);
            this.combo_calendar.Name = "combo_calendar";
            this.combo_calendar.Size = new System.Drawing.Size(150, 24);
            this.combo_calendar.TabIndex = 10;
            this.combo_calendar.SelectedIndexChanged += new System.EventHandler(this.combo_calendar_SelectedIndexChanged);
            // 
            // combo_deadline
            // 
            this.combo_deadline.BackColor = System.Drawing.Color.Gold;
            this.combo_deadline.ForeColor = System.Drawing.SystemColors.InfoText;
            this.combo_deadline.FormattingEnabled = true;
            this.combo_deadline.Items.AddRange(new object[] {
            "None",
            "In 1 day",
            "In 3 days",
            "In 7 days",
            "In 30 days",
            "Late"});
            this.combo_deadline.Location = new System.Drawing.Point(725, 206);
            this.combo_deadline.Name = "combo_deadline";
            this.combo_deadline.Size = new System.Drawing.Size(150, 24);
            this.combo_deadline.TabIndex = 11;
            this.combo_deadline.SelectedIndexChanged += new System.EventHandler(this.combo_deadline_SelectedIndexChanged);
            // 
            // txt_search
            // 
            this.txt_search.AccessibleDescription = "";
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(460, 72);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(385, 23);
            this.txt_search.TabIndex = 13;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // lbl_cusID
            // 
            this.lbl_cusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cusID.Location = new System.Drawing.Point(930, 492);
            this.lbl_cusID.Name = "lbl_cusID";
            this.lbl_cusID.Size = new System.Drawing.Size(135, 20);
            this.lbl_cusID.TabIndex = 14;
            this.lbl_cusID.Text = "Customer ID:";
            // 
            // lbl_price
            // 
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(930, 524);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(135, 20);
            this.lbl_price.TabIndex = 15;
            this.lbl_price.Text = "Total Price: ";
            // 
            // lbl_deadline
            // 
            this.lbl_deadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deadline.Location = new System.Drawing.Point(930, 556);
            this.lbl_deadline.Name = "lbl_deadline";
            this.lbl_deadline.Size = new System.Drawing.Size(135, 20);
            this.lbl_deadline.TabIndex = 16;
            this.lbl_deadline.Text = "Deadline: ";
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Orange;
            this.lbl_status.Location = new System.Drawing.Point(930, 588);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(135, 20);
            this.lbl_status.TabIndex = 17;
            this.lbl_status.Text = "Request Status";
            // 
            // lbl_jobCompleted
            // 
            this.lbl_jobCompleted.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_jobCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jobCompleted.Location = new System.Drawing.Point(64, 448);
            this.lbl_jobCompleted.Name = "lbl_jobCompleted";
            this.lbl_jobCompleted.Size = new System.Drawing.Size(152, 43);
            this.lbl_jobCompleted.TabIndex = 18;
            this.lbl_jobCompleted.Text = "Job(s) completed this month";
            this.lbl_jobCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_jobIncomplete
            // 
            this.lbl_jobIncomplete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_jobIncomplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jobIncomplete.Location = new System.Drawing.Point(64, 522);
            this.lbl_jobIncomplete.Name = "lbl_jobIncomplete";
            this.lbl_jobIncomplete.Size = new System.Drawing.Size(152, 43);
            this.lbl_jobIncomplete.TabIndex = 19;
            this.lbl_jobIncomplete.Text = "Job(s) incomplete this month";
            this.lbl_jobIncomplete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_totalJob
            // 
            this.lbl_totalJob.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_totalJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalJob.Location = new System.Drawing.Point(64, 598);
            this.lbl_totalJob.Name = "lbl_totalJob";
            this.lbl_totalJob.Size = new System.Drawing.Size(122, 43);
            this.lbl_totalJob.TabIndex = 20;
            this.lbl_totalJob.Text = "Total job(s) this month";
            this.lbl_totalJob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_jobCompleted
            // 
            this.txt_jobCompleted.BackColor = System.Drawing.Color.White;
            this.txt_jobCompleted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_jobCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jobCompleted.Location = new System.Drawing.Point(246, 454);
            this.txt_jobCompleted.Name = "txt_jobCompleted";
            this.txt_jobCompleted.ReadOnly = true;
            this.txt_jobCompleted.Size = new System.Drawing.Size(45, 31);
            this.txt_jobCompleted.TabIndex = 22;
            this.txt_jobCompleted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_jobIncomplete
            // 
            this.txt_jobIncomplete.BackColor = System.Drawing.Color.White;
            this.txt_jobIncomplete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_jobIncomplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jobIncomplete.Location = new System.Drawing.Point(246, 528);
            this.txt_jobIncomplete.Name = "txt_jobIncomplete";
            this.txt_jobIncomplete.ReadOnly = true;
            this.txt_jobIncomplete.Size = new System.Drawing.Size(45, 31);
            this.txt_jobIncomplete.TabIndex = 23;
            this.txt_jobIncomplete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_totalJob
            // 
            this.txt_totalJob.BackColor = System.Drawing.Color.White;
            this.txt_totalJob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_totalJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalJob.Location = new System.Drawing.Point(246, 604);
            this.txt_totalJob.Name = "txt_totalJob";
            this.txt_totalJob.ReadOnly = true;
            this.txt_totalJob.Size = new System.Drawing.Size(45, 31);
            this.txt_totalJob.TabIndex = 24;
            this.txt_totalJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_cusID
            // 
            this.txt_cusID.BackColor = System.Drawing.SystemColors.Window;
            this.txt_cusID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cusID.Location = new System.Drawing.Point(1085, 492);
            this.txt_cusID.Name = "txt_cusID";
            this.txt_cusID.ReadOnly = true;
            this.txt_cusID.Size = new System.Drawing.Size(140, 17);
            this.txt_cusID.TabIndex = 27;
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.SystemColors.Window;
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(1085, 524);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(140, 17);
            this.txt_price.TabIndex = 28;
            // 
            // txt_deadline
            // 
            this.txt_deadline.BackColor = System.Drawing.SystemColors.Window;
            this.txt_deadline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_deadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deadline.Location = new System.Drawing.Point(1085, 556);
            this.txt_deadline.Name = "txt_deadline";
            this.txt_deadline.ReadOnly = true;
            this.txt_deadline.Size = new System.Drawing.Size(140, 17);
            this.txt_deadline.TabIndex = 29;
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.SystemColors.Window;
            this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.Location = new System.Drawing.Point(1085, 588);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(140, 17);
            this.txt_status.TabIndex = 30;
            // 
            // lbl_requestID
            // 
            this.lbl_requestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_requestID.Location = new System.Drawing.Point(931, 460);
            this.lbl_requestID.Name = "lbl_requestID";
            this.lbl_requestID.Size = new System.Drawing.Size(135, 20);
            this.lbl_requestID.TabIndex = 31;
            this.lbl_requestID.Text = "Request ID:";
            // 
            // txt_requestID
            // 
            this.txt_requestID.BackColor = System.Drawing.SystemColors.Window;
            this.txt_requestID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_requestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_requestID.Location = new System.Drawing.Point(1085, 460);
            this.txt_requestID.Name = "txt_requestID";
            this.txt_requestID.ReadOnly = true;
            this.txt_requestID.Size = new System.Drawing.Size(140, 17);
            this.txt_requestID.TabIndex = 33;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.BackColor = System.Drawing.Color.Gold;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.White;
            this.lbl_welcome.Location = new System.Drawing.Point(63, 250);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(225, 43);
            this.lbl_welcome.TabIndex = 34;
            this.lbl_welcome.Text = "WELCOME BACK";
            this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_workerName
            // 
            this.lbl_workerName.BackColor = System.Drawing.Color.Gold;
            this.lbl_workerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workerName.ForeColor = System.Drawing.Color.White;
            this.lbl_workerName.Location = new System.Drawing.Point(63, 285);
            this.lbl_workerName.Name = "lbl_workerName";
            this.lbl_workerName.Size = new System.Drawing.Size(225, 43);
            this.lbl_workerName.TabIndex = 35;
            this.lbl_workerName.Text = "workername";
            this.lbl_workerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_profile
            // 
            this.lbl_profile.AutoSize = true;
            this.lbl_profile.BackColor = System.Drawing.Color.Gold;
            this.lbl_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profile.ForeColor = System.Drawing.Color.White;
            this.lbl_profile.Location = new System.Drawing.Point(63, 360);
            this.lbl_profile.Name = "lbl_profile";
            this.lbl_profile.Size = new System.Drawing.Size(88, 20);
            this.lbl_profile.TabIndex = 36;
            this.lbl_profile.Text = "Profile ->";
            this.lbl_profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_profile.Click += new System.EventHandler(this.lbl_profile_Click);
            // 
            // lbl_logOut
            // 
            this.lbl_logOut.AutoSize = true;
            this.lbl_logOut.BackColor = System.Drawing.Color.Gold;
            this.lbl_logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logOut.ForeColor = System.Drawing.Color.White;
            this.lbl_logOut.Location = new System.Drawing.Point(65, 394);
            this.lbl_logOut.Name = "lbl_logOut";
            this.lbl_logOut.Size = new System.Drawing.Size(100, 20);
            this.lbl_logOut.TabIndex = 37;
            this.lbl_logOut.Text = "Log Out ->";
            this.lbl_logOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_logOut.Click += new System.EventHandler(this.lbl_logOut_Click);
            // 
            // btn_clearfilter
            // 
            this.btn_clearfilter.AutoSize = true;
            this.btn_clearfilter.BackColor = System.Drawing.Color.LightGray;
            this.btn_clearfilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_clearfilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clearfilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clearfilter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clearfilter.Location = new System.Drawing.Point(410, 206);
            this.btn_clearfilter.Name = "btn_clearfilter";
            this.btn_clearfilter.Size = new System.Drawing.Size(170, 26);
            this.btn_clearfilter.TabIndex = 38;
            this.btn_clearfilter.Text = "Clear Filter";
            this.btn_clearfilter.UseVisualStyleBackColor = false;
            this.btn_clearfilter.Click += new System.EventHandler(this.btn_clearfilter_Click);
            // 
            // cb_priority
            // 
            this.cb_priority.AutoSize = true;
            this.cb_priority.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cb_priority.Location = new System.Drawing.Point(625, 210);
            this.cb_priority.Name = "cb_priority";
            this.cb_priority.Size = new System.Drawing.Size(70, 20);
            this.cb_priority.TabIndex = 39;
            this.cb_priority.Text = "Priority";
            this.cb_priority.UseVisualStyleBackColor = false;
            this.cb_priority.CheckedChanged += new System.EventHandler(this.cb_priority_CheckedChanged);
            // 
            // gb_status
            // 
            this.gb_status.BackColor = System.Drawing.Color.White;
            this.gb_status.Controls.Add(this.rb_all);
            this.gb_status.Controls.Add(this.rb_completed);
            this.gb_status.Controls.Add(this.rb_inProgress);
            this.gb_status.Controls.Add(this.rb_assigned);
            this.gb_status.Location = new System.Drawing.Point(410, 113);
            this.gb_status.Name = "gb_status";
            this.gb_status.Size = new System.Drawing.Size(285, 83);
            this.gb_status.TabIndex = 40;
            this.gb_status.TabStop = false;
            this.gb_status.Text = "Status";
            // 
            // rb_all
            // 
            this.rb_all.AutoSize = true;
            this.rb_all.BackColor = System.Drawing.Color.White;
            this.rb_all.Location = new System.Drawing.Point(127, 49);
            this.rb_all.Name = "rb_all";
            this.rb_all.Size = new System.Drawing.Size(43, 20);
            this.rb_all.TabIndex = 3;
            this.rb_all.TabStop = true;
            this.rb_all.Text = "All";
            this.rb_all.UseVisualStyleBackColor = false;
            this.rb_all.CheckedChanged += new System.EventHandler(this.rb_all_CheckedChanged);
            // 
            // rb_completed
            // 
            this.rb_completed.AutoSize = true;
            this.rb_completed.BackColor = System.Drawing.Color.White;
            this.rb_completed.Location = new System.Drawing.Point(15, 49);
            this.rb_completed.Name = "rb_completed";
            this.rb_completed.Size = new System.Drawing.Size(94, 20);
            this.rb_completed.TabIndex = 2;
            this.rb_completed.TabStop = true;
            this.rb_completed.Text = "Completed";
            this.rb_completed.UseVisualStyleBackColor = false;
            this.rb_completed.CheckedChanged += new System.EventHandler(this.rb_completed_CheckedChanged);
            // 
            // rb_inProgress
            // 
            this.rb_inProgress.AutoSize = true;
            this.rb_inProgress.BackColor = System.Drawing.Color.White;
            this.rb_inProgress.Location = new System.Drawing.Point(127, 23);
            this.rb_inProgress.Name = "rb_inProgress";
            this.rb_inProgress.Size = new System.Drawing.Size(131, 20);
            this.rb_inProgress.TabIndex = 1;
            this.rb_inProgress.TabStop = true;
            this.rb_inProgress.Text = "Work In Progress";
            this.rb_inProgress.UseVisualStyleBackColor = false;
            this.rb_inProgress.CheckedChanged += new System.EventHandler(this.rb_inProgress_CheckedChanged);
            // 
            // rb_assigned
            // 
            this.rb_assigned.AutoSize = true;
            this.rb_assigned.BackColor = System.Drawing.Color.White;
            this.rb_assigned.Location = new System.Drawing.Point(15, 23);
            this.rb_assigned.Name = "rb_assigned";
            this.rb_assigned.Size = new System.Drawing.Size(85, 20);
            this.rb_assigned.TabIndex = 0;
            this.rb_assigned.TabStop = true;
            this.rb_assigned.Text = "Assigned";
            this.rb_assigned.UseVisualStyleBackColor = false;
            this.rb_assigned.CheckedChanged += new System.EventHandler(this.rb_assigned_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::APU_Printing_Management_System.Properties.Resources.worker_bg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1262, 673);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(410, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "- Search RequestID / CustomerID / ManagerID -";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(722, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "- Calender Filter Criteria - ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(722, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "- Deadline -";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_status);
            this.Controls.Add(this.cb_priority);
            this.Controls.Add(this.btn_clearfilter);
            this.Controls.Add(this.lbl_logOut);
            this.Controls.Add(this.lbl_profile);
            this.Controls.Add(this.lbl_workerName);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.txt_requestID);
            this.Controls.Add(this.lbl_requestID);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_deadline);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_cusID);
            this.Controls.Add(this.txt_totalJob);
            this.Controls.Add(this.txt_jobIncomplete);
            this.Controls.Add(this.txt_jobCompleted);
            this.Controls.Add(this.lbl_totalJob);
            this.Controls.Add(this.lbl_jobIncomplete);
            this.Controls.Add(this.lbl_jobCompleted);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_deadline);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_cusID);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.combo_deadline);
            this.Controls.Add(this.combo_calendar);
            this.Controls.Add(this.dgv_selected);
            this.Controls.Add(this.dgv_all);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btn_clearPanel);
            this.Controls.Add(this.btn_assigned);
            this.Controls.Add(this.btn_completed);
            this.Controls.Add(this.btn_inProgress);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(-10, 0);
            this.MaximizeBox = false;
            this.Name = "WorkerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worker Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selected)).EndInit();
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_inProgress;
        private System.Windows.Forms.Button btn_completed;
        private System.Windows.Forms.Button btn_assigned;
        private System.Windows.Forms.Button btn_clearPanel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dgv_all;
        private System.Windows.Forms.DataGridView dgv_selected;
        private System.Windows.Forms.ComboBox combo_calendar;
        private System.Windows.Forms.ComboBox combo_deadline;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_cusID;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_deadline;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_jobCompleted;
        private System.Windows.Forms.Label lbl_jobIncomplete;
        private System.Windows.Forms.Label lbl_totalJob;
        private System.Windows.Forms.TextBox txt_jobCompleted;
        private System.Windows.Forms.TextBox txt_jobIncomplete;
        private System.Windows.Forms.TextBox txt_totalJob;
        private System.Windows.Forms.TextBox txt_cusID;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_deadline;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label lbl_requestID;
        private System.Windows.Forms.TextBox txt_requestID;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_workerName;
        private System.Windows.Forms.Label lbl_profile;
        private System.Windows.Forms.Label lbl_logOut;
        private System.Windows.Forms.Button btn_clearfilter;
        private System.Windows.Forms.CheckBox cb_priority;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.RadioButton rb_assigned;
        private System.Windows.Forms.RadioButton rb_completed;
        private System.Windows.Forms.RadioButton rb_inProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_all;
    }
}

