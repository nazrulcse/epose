namespace EPose
{
    partial class Employee
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
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.controlPanel.Location = new System.Drawing.Point(0, 49);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(992, 114);
            this.controlPanel.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 60);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(590, 35);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Search by name, designation, phone......";
            // 
            // active_employee
            // 
            this.active_employee.AutoSize = true;
            this.active_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.active_employee.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.active_employee.Location = new System.Drawing.Point(736, 55);
            this.active_employee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.active_employee.Name = "active_employee";
            this.active_employee.Size = new System.Drawing.Size(226, 29);
            this.active_employee.TabIndex = 2;
            this.active_employee.Text = "Only Active Employee";
            this.active_employee.UseVisualStyleBackColor = true;
            // 
            // all_employee
            // 
            this.all_employee.AutoSize = true;
            this.all_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_employee.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.all_employee.Location = new System.Drawing.Point(733, 18);
            this.all_employee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.all_employee.Name = "all_employee";
            this.all_employee.Size = new System.Drawing.Size(236, 29);
            this.all_employee.TabIndex = 1;
            this.all_employee.Text = "All Employee Including ";
            this.all_employee.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee List: (565)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.employeeList);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(0, 163);
            this.dataPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(992, 445);
            this.dataPanel.TabIndex = 4;
            // 
            // employeeList
            // 
            this.employeeList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.employeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EName,
            this.Designation,
            this.Email,
            this.Phone,
            this.Department});
            this.employeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.employeeList.Location = new System.Drawing.Point(0, 0);
            this.employeeList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(992, 445);
            this.employeeList.TabIndex = 0;
            this.employeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeList_CellContentClick);
            // 
            // EName
            // 
            this.EName.HeaderText = "Name";
            this.EName.Name = "EName";
            // 
            // Designation
            // 
            this.Designation.HeaderText = "Designation";
            this.Designation.Name = "Designation";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 608);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.controlPanel);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Employee";
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
        private System.Windows.Forms.DataGridView employeeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox active_employee;
        private System.Windows.Forms.CheckBox all_employee;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;

    }
}