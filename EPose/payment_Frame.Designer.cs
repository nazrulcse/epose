namespace EPose
{
    partial class payment_Frame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.paymentList = new System.Windows.Forms.DataGridView();
            this.EName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Joining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.paymentType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.paymentList);
            this.panel1.Location = new System.Drawing.Point(2, 218);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 327);
            this.panel1.TabIndex = 4;
            // 
            // paymentList
            // 
            this.paymentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.paymentList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.paymentList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.paymentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EName,
            this.Designation,
            this.Email,
            this.Joining,
            this.Column1,
            this.Column2});
            this.paymentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.paymentList.Location = new System.Drawing.Point(0, 0);
            this.paymentList.Name = "paymentList";
            this.paymentList.RowHeadersWidth = 52;
            this.paymentList.Size = new System.Drawing.Size(818, 327);
            this.paymentList.TabIndex = 9;
            // 
            // EName
            // 
            this.EName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.EName.DefaultCellStyle = dataGridViewCellStyle1;
            this.EName.HeaderText = "Id";
            this.EName.MinimumWidth = 10;
            this.EName.Name = "EName";
            this.EName.Width = 80;
            // 
            // Designation
            // 
            this.Designation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Designation.DefaultCellStyle = dataGridViewCellStyle2;
            this.Designation.FillWeight = 120F;
            this.Designation.HeaderText = "payment Type";
            this.Designation.MinimumWidth = 10;
            this.Designation.Name = "Designation";
            this.Designation.Width = 130;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Email.DefaultCellStyle = dataGridViewCellStyle3;
            this.Email.HeaderText = "Invoice Id";
            this.Email.Name = "Email";
            this.Email.Width = 180;
            // 
            // Joining
            // 
            this.Joining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Joining.DefaultCellStyle = dataGridViewCellStyle4;
            this.Joining.HeaderText = "Amount";
            this.Joining.Name = "Joining";
            this.Joining.Width = 170;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.HeaderText = "transaction token";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.amountTextBox);
            this.panel2.Controls.Add(this.paymentType);
            this.panel2.Location = new System.Drawing.Point(157, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 158);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Payment By";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(447, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextBox.Location = new System.Drawing.Point(265, 77);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.amountTextBox.Multiline = true;
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(142, 24);
            this.amountTextBox.TabIndex = 2;
            this.amountTextBox.Text = "0.0";
            this.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTextBox_KeyPress);
            // 
            // paymentType
            // 
            this.paymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentType.FormattingEnabled = true;
            this.paymentType.Items.AddRange(new object[] {
            "Bikash",
            "Cash",
            "Card",
            "Rocket"});
            this.paymentType.Location = new System.Drawing.Point(265, 24);
            this.paymentType.Margin = new System.Windows.Forms.Padding(2);
            this.paymentType.Name = "paymentType";
            this.paymentType.Size = new System.Drawing.Size(142, 28);
            this.paymentType.TabIndex = 1;
            this.paymentType.Text = "Select Payment";
            this.paymentType.SelectedIndexChanged += new System.EventHandler(this.paymentType_SelectedIndexChanged);
            this.paymentType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paymentType_KeyPress);
            // 
            // payment_Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "payment_Frame";
            this.Text = "payment_Frame";
            this.Load += new System.EventHandler(this.payment_Frame_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox paymentType;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView paymentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn EName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Joining;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;

    }
}