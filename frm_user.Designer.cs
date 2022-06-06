namespace PayrollSytem
{
    partial class frm_user
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
            this.GroupBox11 = new System.Windows.Forms.GroupBox();
            this.btnMUdel = new System.Windows.Forms.Button();
            this.cbotype = new System.Windows.Forms.ComboBox();
            this.Label38 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Label39 = new System.Windows.Forms.Label();
            this.Label40 = new System.Windows.Forms.Label();
            this.Label41 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.GroupBox12 = new System.Windows.Forms.GroupBox();
            this.dtg_userList = new System.Windows.Forms.DataGridView();
            this.GroupBox11.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_userList)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox11
            // 
            this.GroupBox11.Controls.Add(this.btnMUdel);
            this.GroupBox11.Controls.Add(this.cbotype);
            this.GroupBox11.Controls.Add(this.Label38);
            this.GroupBox11.Controls.Add(this.txtname);
            this.GroupBox11.Controls.Add(this.btn_update);
            this.GroupBox11.Controls.Add(this.Button6);
            this.GroupBox11.Controls.Add(this.Label39);
            this.GroupBox11.Controls.Add(this.Label40);
            this.GroupBox11.Controls.Add(this.Label41);
            this.GroupBox11.Controls.Add(this.txtpass);
            this.GroupBox11.Controls.Add(this.txtuser);
            this.GroupBox11.Controls.Add(this.btnsave);
            this.GroupBox11.Controls.Add(this.lbl_id);
            this.GroupBox11.Location = new System.Drawing.Point(83, 23);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new System.Drawing.Size(483, 199);
            this.GroupBox11.TabIndex = 7;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "Add New User";
            // 
            // btnMUdel
            // 
            this.btnMUdel.Location = new System.Drawing.Point(328, 159);
            this.btnMUdel.Name = "btnMUdel";
            this.btnMUdel.Size = new System.Drawing.Size(75, 23);
            this.btnMUdel.TabIndex = 15;
            this.btnMUdel.Text = "Delete";
            this.btnMUdel.UseVisualStyleBackColor = true;
            this.btnMUdel.Click += new System.EventHandler(this.btnMUdel_Click);
            // 
            // cbotype
            // 
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Items.AddRange(new object[] {
            "Administrator",
            "Staff",
            "Guest"});
            this.cbotype.Location = new System.Drawing.Point(163, 112);
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(121, 21);
            this.cbotype.TabIndex = 2;
            this.cbotype.Text = "Administrator";
            // 
            // Label38
            // 
            this.Label38.AutoSize = true;
            this.Label38.BackColor = System.Drawing.Color.Transparent;
            this.Label38.ForeColor = System.Drawing.Color.Black;
            this.Label38.Location = new System.Drawing.Point(113, 37);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(41, 13);
            this.Label38.TabIndex = 14;
            this.Label38.Text = "Name :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(161, 34);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(218, 20);
            this.txtname.TabIndex = 13;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(157, 159);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(85, 23);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Edit";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(247, 160);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(75, 23);
            this.Button6.TabIndex = 7;
            this.Button6.Text = "New";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Label39
            // 
            this.Label39.AutoSize = true;
            this.Label39.BackColor = System.Drawing.Color.Transparent;
            this.Label39.ForeColor = System.Drawing.Color.Black;
            this.Label39.Location = new System.Drawing.Point(83, 115);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(71, 13);
            this.Label39.TabIndex = 6;
            this.Label39.Text = "User\'s Level :";
            // 
            // Label40
            // 
            this.Label40.AutoSize = true;
            this.Label40.BackColor = System.Drawing.Color.Transparent;
            this.Label40.ForeColor = System.Drawing.Color.Black;
            this.Label40.Location = new System.Drawing.Point(96, 89);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(59, 13);
            this.Label40.TabIndex = 4;
            this.Label40.Text = "Password :";
            // 
            // Label41
            // 
            this.Label41.AutoSize = true;
            this.Label41.BackColor = System.Drawing.Color.Transparent;
            this.Label41.ForeColor = System.Drawing.Color.Black;
            this.Label41.Location = new System.Drawing.Point(93, 63);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(61, 13);
            this.Label41.TabIndex = 5;
            this.Label41.Text = "Username :";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(163, 86);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(218, 20);
            this.txtpass.TabIndex = 1;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(161, 60);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(218, 20);
            this.txtuser.TabIndex = 1;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(79, 160);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Add";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(269, 63);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(15, 13);
            this.lbl_id.TabIndex = 12;
            this.lbl_id.Text = "id";
            // 
            // GroupBox12
            // 
            this.GroupBox12.Controls.Add(this.dtg_userList);
            this.GroupBox12.Location = new System.Drawing.Point(10, 228);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new System.Drawing.Size(658, 188);
            this.GroupBox12.TabIndex = 6;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "List Of Users";
            // 
            // dtg_userList
            // 
            this.dtg_userList.AllowUserToAddRows = false;
            this.dtg_userList.AllowUserToDeleteRows = false;
            this.dtg_userList.AllowUserToResizeColumns = false;
            this.dtg_userList.AllowUserToResizeRows = false;
            this.dtg_userList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_userList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_userList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_userList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_userList.Location = new System.Drawing.Point(3, 16);
            this.dtg_userList.Name = "dtg_userList";
            this.dtg_userList.RowHeadersVisible = false;
            this.dtg_userList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_userList.Size = new System.Drawing.Size(652, 169);
            this.dtg_userList.TabIndex = 0;
            // 
            // frm_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 443);
            this.Controls.Add(this.GroupBox11);
            this.Controls.Add(this.GroupBox12);
            this.Name = "frm_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frm_user_Load);
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox11.PerformLayout();
            this.GroupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_userList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox11;
        internal System.Windows.Forms.Button btnMUdel;
        internal System.Windows.Forms.ComboBox cbotype;
        internal System.Windows.Forms.Label Label38;
        internal System.Windows.Forms.TextBox txtname;
        internal System.Windows.Forms.Button btn_update;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.Label Label39;
        internal System.Windows.Forms.Label Label40;
        internal System.Windows.Forms.Label Label41;
        internal System.Windows.Forms.TextBox txtpass;
        internal System.Windows.Forms.TextBox txtuser;
        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.Label lbl_id;
        internal System.Windows.Forms.GroupBox GroupBox12;
        internal System.Windows.Forms.DataGridView dtg_userList;
    }
}