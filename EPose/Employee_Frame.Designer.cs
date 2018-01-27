namespace EPose
{
    partial class Employee_Frame
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.active_employee = new System.Windows.Forms.CheckBox();
            this.all_employee = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.employeeList = new System.Windows.Forms.DataGridView();
            this.EName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Joining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.textBox1);
            this.controlPanel.Controls.Add(this.active_employee);
            this.controlPanel.Controls.Add(this.all_employee);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(3, 40);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(983, 93);
            this.controlPanel.TabIndex = 3;
            this.controlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.controlPanel_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(11, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Search by name, designation, phone......";
            // 
            // active_employee
            // 
            this.active_employee.AutoSize = true;
            this.active_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.active_employee.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.active_employee.Location = new System.Drawing.Point(776, 49);
            this.active_employee.Name = "active_employee";
            this.active_employee.Size = new System.Drawing.Size(180, 24);
            this.active_employee.TabIndex = 2;
            this.active_employee.Text = "Only Active Employee";
            this.active_employee.UseVisualStyleBackColor = true;
            // 
            // all_employee
            // 
            this.all_employee.AutoSize = true;
            this.all_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_employee.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.all_employee.Location = new System.Drawing.Point(774, 19);
            this.all_employee.Name = "all_employee";
            this.all_employee.Size = new System.Drawing.Size(191, 24);
            this.all_employee.TabIndex = 1;
            this.all_employee.Text = "All Employee Including ";
            this.all_employee.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee List: (565)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.employeeList);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(3, 133);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(983, 504);
            this.dataPanel.TabIndex = 4;
            // 
            // employeeList
            // 
            this.employeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.employeeList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.employeeList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.employeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EName,
            this.Designation,
            this.Email,
            this.Phone,
            this.Joining,
            this.Country,
            this.Department,
            this.Address});
            this.employeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.employeeList.Location = new System.Drawing.Point(0, 0);
            this.employeeList.Name = "employeeList";
            this.employeeList.RowHeadersWidth = 52;
            this.employeeList.Size = new System.Drawing.Size(983, 504);
            this.employeeList.TabIndex = 0;
            this.employeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeList_CellContentClick);
            // 
            // EName
            // 
            this.EName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.EName.DefaultCellStyle = dataGridViewCellStyle1;
            this.EName.HeaderText = "Name";
            this.EName.MinimumWidth = 10;
            this.EName.Name = "EName";
            // 
            // Designation
            // 
            this.Designation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Designation.DefaultCellStyle = dataGridViewCellStyle2;
            this.Designation.FillWeight = 120F;
            this.Designation.HeaderText = "Designation";
            this.Designation.MinimumWidth = 10;
            this.Designation.Name = "Designation";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Email.DefaultCellStyle = dataGridViewCellStyle3;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Phone.DefaultCellStyle = dataGridViewCellStyle4;
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Joining
            // 
            this.Joining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Joining.DefaultCellStyle = dataGridViewCellStyle5;
            this.Joining.HeaderText = "Address";
            this.Joining.Name = "Joining";
            // 
            // Country
            // 
            this.Country.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Country.DefaultCellStyle = dataGridViewCellStyle6;
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            // 
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Department.DefaultCellStyle = dataGridViewCellStyle7;
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Address.DefaultCellStyle = dataGridViewCellStyle8;
            this.Address.HeaderText = "Joining";
            this.Address.Name = "Address";
            // 
            // Employee_Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 640);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.controlPanel);
            this.Name = "Employee_Frame";
            this.Text = "Employee";
            this.Controls.SetChildIndex(this.controlPanel, 0);
            this.Controls.SetChildIndex(this.dataPanel, 0);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox active_employee;
        private System.Windows.Forms.CheckBox all_employee;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView employeeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn EName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Joining;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;

    }
}