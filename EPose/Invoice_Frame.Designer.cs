﻿namespace EPose
{
    partial class Invoice_Frame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice_Frame));
            this.topPanel = new System.Windows.Forms.Panel();
            this.invoiceNumber = new System.Windows.Forms.Label();
            this.topLeftPanel = new System.Windows.Forms.Panel();
            this.barcodeInput = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.topDisplay = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.btnMembership = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.receivedAmount = new System.Windows.Forms.TextBox();
            this.invoicePanel = new System.Windows.Forms.Panel();
            this.invoiceItems = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.holdInvoice = new System.Windows.Forms.Button();
            this.nextInvoice = new System.Windows.Forms.Button();
            this.Keyboard = new System.Windows.Forms.Button();
            this.voidInvoice = new System.Windows.Forms.Button();
            this.sales_return = new System.Windows.Forms.Button();
            this.recepentA4Button = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.textBoxNetDue = new System.Windows.Forms.TextBox();
            this.labelDue = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxVat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBoxCreditLimit = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.topLeftPanel.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.invoicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.invoiceNumber);
            this.topPanel.Controls.Add(this.topLeftPanel);
            this.topPanel.Controls.Add(this.topDisplay);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(3, 40);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1089, 128);
            this.topPanel.TabIndex = 4;
            // 
            // invoiceNumber
            // 
            this.invoiceNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.invoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNumber.Location = new System.Drawing.Point(754, 71);
            this.invoiceNumber.Name = "invoiceNumber";
            this.invoiceNumber.Size = new System.Drawing.Size(335, 57);
            this.invoiceNumber.TabIndex = 53;
            this.invoiceNumber.Text = "Create Invoice(Ctrl + N)";
            this.invoiceNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topLeftPanel
            // 
            this.topLeftPanel.Controls.Add(this.barcodeInput);
            this.topLeftPanel.Controls.Add(this.label17);
            this.topLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.topLeftPanel.Location = new System.Drawing.Point(0, 71);
            this.topLeftPanel.Name = "topLeftPanel";
            this.topLeftPanel.Size = new System.Drawing.Size(764, 57);
            this.topLeftPanel.TabIndex = 52;
            // 
            // barcodeInput
            // 
            this.barcodeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barcodeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeInput.ForeColor = System.Drawing.SystemColors.Desktop;
            this.barcodeInput.Location = new System.Drawing.Point(93, 11);
            this.barcodeInput.Name = "barcodeInput";
            this.barcodeInput.Size = new System.Drawing.Size(632, 35);
            this.barcodeInput.TabIndex = 1;
            this.barcodeInput.Enter += new System.EventHandler(this.barcodeInput_Enter);
            this.barcodeInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcodeInput_KeyDown);
            this.barcodeInput.Leave += new System.EventHandler(this.barcodeInput_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Centaur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label17.Location = new System.Drawing.Point(10, 16);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 27);
            this.label17.TabIndex = 45;
            this.label17.Text = "Barcode";
            // 
            // topDisplay
            // 
            this.topDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.topDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topDisplay.ForeColor = System.Drawing.Color.DarkRed;
            this.topDisplay.Location = new System.Drawing.Point(0, 0);
            this.topDisplay.Name = "topDisplay";
            this.topDisplay.Size = new System.Drawing.Size(1089, 71);
            this.topDisplay.TabIndex = 50;
            this.topDisplay.Text = "0 unit @ 0 tk";
            this.topDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.btnMembership);
            this.panelBody.Controls.Add(this.btnCustomer);
            this.panelBody.Controls.Add(this.textBox9);
            this.panelBody.Controls.Add(this.textBoxChange);
            this.panelBody.Controls.Add(this.label10);
            this.panelBody.Controls.Add(this.label9);
            this.panelBody.Controls.Add(this.label12);
            this.panelBody.Controls.Add(this.receivedAmount);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBody.Location = new System.Drawing.Point(3, 745);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1089, 62);
            this.panelBody.TabIndex = 5;
            // 
            // btnMembership
            // 
            this.btnMembership.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMembership.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnMembership.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembership.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembership.ForeColor = System.Drawing.Color.White;
            this.btnMembership.Location = new System.Drawing.Point(833, 11);
            this.btnMembership.Margin = new System.Windows.Forms.Padding(2);
            this.btnMembership.Name = "btnMembership";
            this.btnMembership.Size = new System.Drawing.Size(133, 39);
            this.btnMembership.TabIndex = 46;
            this.btnMembership.Text = "Membership";
            this.btnMembership.UseVisualStyleBackColor = false;
            this.btnMembership.Click += new System.EventHandler(this.btnMembership_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(970, 11);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(112, 39);
            this.btnCustomer.TabIndex = 46;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(600, 25);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(113, 26);
            this.textBox9.TabIndex = 40;
            this.textBox9.Text = "0.0";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxChange
            // 
            this.textBoxChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChange.Location = new System.Drawing.Point(326, 23);
            this.textBoxChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.Size = new System.Drawing.Size(180, 26);
            this.textBoxChange.TabIndex = 39;
            this.textBoxChange.Text = "0.0";
            this.textBoxChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxChange.Enter += new System.EventHandler(this.textBoxChange_Enter);
            this.textBoxChange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxChange_KeyDown);
            this.textBoxChange.Leave += new System.EventHandler(this.textBoxChange_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(537, 27);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 18);
            this.label10.TabIndex = 38;
            this.label10.Text = "Adjust";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(261, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 37;
            this.label9.Text = "Return";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(10, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 23);
            this.label12.TabIndex = 45;
            this.label12.Text = "Received";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receivedAmount
            // 
            this.receivedAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receivedAmount.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedAmount.Location = new System.Drawing.Point(107, 24);
            this.receivedAmount.Margin = new System.Windows.Forms.Padding(2);
            this.receivedAmount.Name = "receivedAmount";
            this.receivedAmount.Size = new System.Drawing.Size(136, 26);
            this.receivedAmount.TabIndex = 44;
            this.receivedAmount.Text = "0.0";
            this.receivedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.receivedAmount.Enter += new System.EventHandler(this.receivedAmount_Enter);
            this.receivedAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.receivedAmount_KeyDown);
            this.receivedAmount.Leave += new System.EventHandler(this.receivedAmount_Leave);
            // 
            // invoicePanel
            // 
            this.invoicePanel.Controls.Add(this.invoiceItems);
            this.invoicePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.invoicePanel.Location = new System.Drawing.Point(3, 168);
            this.invoicePanel.Margin = new System.Windows.Forms.Padding(2);
            this.invoicePanel.Name = "invoicePanel";
            this.invoicePanel.Size = new System.Drawing.Size(713, 577);
            this.invoicePanel.TabIndex = 0;
            // 
            // invoiceItems
            // 
            this.invoiceItems.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.invoiceItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.invoiceItemId,
            this.EName,
            this.Email,
            this.Department,
            this.Price,
            this.quantity,
            this.vat,
            this.discount,
            this.total});
            this.invoiceItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.invoiceItems.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.invoiceItems.Location = new System.Drawing.Point(0, 0);
            this.invoiceItems.Name = "invoiceItems";
            this.invoiceItems.Size = new System.Drawing.Size(713, 577);
            this.invoiceItems.TabIndex = 9;
            this.invoiceItems.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.invoiceItems_CellBeginEdit);
            this.invoiceItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceItems_CellEndEdit);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // invoiceItemId
            // 
            this.invoiceItemId.HeaderText = "invoice_item_id";
            this.invoiceItemId.Name = "invoiceItemId";
            this.invoiceItemId.Visible = false;
            // 
            // EName
            // 
            this.EName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EName.DefaultCellStyle = dataGridViewCellStyle1;
            this.EName.HeaderText = "Sl No";
            this.EName.Name = "EName";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Email.DefaultCellStyle = dataGridViewCellStyle2;
            this.Email.HeaderText = "Item Name";
            this.Email.Name = "Email";
            // 
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Department.DefaultCellStyle = dataGridViewCellStyle3;
            this.Department.HeaderText = "Unite";
            this.Department.Name = "Department";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Price.DefaultCellStyle = dataGridViewCellStyle4;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // quantity
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.quantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.quantity.HeaderText = "Qty";
            this.quantity.Name = "quantity";
            // 
            // vat
            // 
            this.vat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.vat.DefaultCellStyle = dataGridViewCellStyle6;
            this.vat.HeaderText = "VAT%";
            this.vat.Name = "vat";
            // 
            // discount
            // 
            this.discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.discount.DefaultCellStyle = dataGridViewCellStyle7;
            this.discount.HeaderText = "Disc(%)";
            this.discount.Name = "discount";
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.total.DefaultCellStyle = dataGridViewCellStyle8;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(756, 168);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 577);
            this.panel1.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.holdInvoice);
            this.panel8.Controls.Add(this.nextInvoice);
            this.panel8.Controls.Add(this.Keyboard);
            this.panel8.Controls.Add(this.voidInvoice);
            this.panel8.Controls.Add(this.sales_return);
            this.panel8.Controls.Add(this.recepentA4Button);
            this.panel8.Controls.Add(this.button10);
            this.panel8.Controls.Add(this.buttonReport);
            this.panel8.Controls.Add(this.button7);
            this.panel8.Location = new System.Drawing.Point(2, 337);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(325, 238);
            this.panel8.TabIndex = 36;
            // 
            // holdInvoice
            // 
            this.holdInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.holdInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.holdInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.holdInvoice.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdInvoice.ForeColor = System.Drawing.Color.White;
            this.holdInvoice.Location = new System.Drawing.Point(111, 17);
            this.holdInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.holdInvoice.Name = "holdInvoice";
            this.holdInvoice.Size = new System.Drawing.Size(99, 58);
            this.holdInvoice.TabIndex = 10;
            this.holdInvoice.Text = "Hold";
            this.holdInvoice.UseVisualStyleBackColor = false;
            // 
            // nextInvoice
            // 
            this.nextInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.nextInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextInvoice.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextInvoice.ForeColor = System.Drawing.Color.White;
            this.nextInvoice.Location = new System.Drawing.Point(5, 17);
            this.nextInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.nextInvoice.Name = "nextInvoice";
            this.nextInvoice.Size = new System.Drawing.Size(102, 58);
            this.nextInvoice.TabIndex = 9;
            this.nextInvoice.Text = "Next Invoice";
            this.nextInvoice.UseVisualStyleBackColor = false;
            this.nextInvoice.Click += new System.EventHandler(this.nextInvoice_Click);
            // 
            // Keyboard
            // 
            this.Keyboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.Keyboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Keyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Keyboard.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keyboard.ForeColor = System.Drawing.Color.White;
            this.Keyboard.Location = new System.Drawing.Point(214, 17);
            this.Keyboard.Margin = new System.Windows.Forms.Padding(2);
            this.Keyboard.Name = "Keyboard";
            this.Keyboard.Size = new System.Drawing.Size(103, 58);
            this.Keyboard.TabIndex = 8;
            this.Keyboard.Text = "Keyboard";
            this.Keyboard.UseVisualStyleBackColor = false;
            // 
            // voidInvoice
            // 
            this.voidInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.voidInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voidInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voidInvoice.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voidInvoice.ForeColor = System.Drawing.Color.White;
            this.voidInvoice.Location = new System.Drawing.Point(110, 89);
            this.voidInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.voidInvoice.Name = "voidInvoice";
            this.voidInvoice.Size = new System.Drawing.Size(99, 58);
            this.voidInvoice.TabIndex = 7;
            this.voidInvoice.Text = "Void";
            this.voidInvoice.UseVisualStyleBackColor = false;
            this.voidInvoice.Click += new System.EventHandler(this.voidInvoice_Click);
            // 
            // sales_return
            // 
            this.sales_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.sales_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sales_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sales_return.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_return.ForeColor = System.Drawing.Color.White;
            this.sales_return.Location = new System.Drawing.Point(4, 89);
            this.sales_return.Margin = new System.Windows.Forms.Padding(2);
            this.sales_return.Name = "sales_return";
            this.sales_return.Size = new System.Drawing.Size(102, 58);
            this.sales_return.TabIndex = 6;
            this.sales_return.Text = "Return(F5)";
            this.sales_return.UseVisualStyleBackColor = false;
            this.sales_return.Click += new System.EventHandler(this.sales_return_Click);
            // 
            // recepentA4Button
            // 
            this.recepentA4Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.recepentA4Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recepentA4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recepentA4Button.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recepentA4Button.ForeColor = System.Drawing.Color.White;
            this.recepentA4Button.Location = new System.Drawing.Point(213, 89);
            this.recepentA4Button.Margin = new System.Windows.Forms.Padding(2);
            this.recepentA4Button.Name = "recepentA4Button";
            this.recepentA4Button.Size = new System.Drawing.Size(103, 58);
            this.recepentA4Button.TabIndex = 5;
            this.recepentA4Button.Text = "Recepent A4";
            this.recepentA4Button.UseVisualStyleBackColor = false;
            this.recepentA4Button.Click += new System.EventHandler(this.recepentA4Button_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(111, 162);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(99, 58);
            this.button10.TabIndex = 4;
            this.button10.Text = "Payment";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.buttonReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport.ForeColor = System.Drawing.Color.White;
            this.buttonReport.Location = new System.Drawing.Point(5, 162);
            this.buttonReport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(102, 58);
            this.buttonReport.TabIndex = 3;
            this.buttonReport.Text = "Receipt";
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(214, 162);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 58);
            this.button7.TabIndex = 1;
            this.button7.Text = "Remove Item";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.textBoxDiscount);
            this.panel9.Controls.Add(this.textBoxNetDue);
            this.panel9.Controls.Add(this.labelDue);
            this.panel9.Controls.Add(this.totalTextBox);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.textBoxVat);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Location = new System.Drawing.Point(2, 140);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(325, 191);
            this.panel9.TabIndex = 35;
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscount.Location = new System.Drawing.Point(179, 100);
            this.textBoxDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(134, 31);
            this.textBoxDiscount.TabIndex = 54;
            this.textBoxDiscount.Text = "0.0";
            this.textBoxDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDiscount.Enter += new System.EventHandler(this.textBoxDiscount_Enter);
            this.textBoxDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDiscount_KeyDown);
            this.textBoxDiscount.Leave += new System.EventHandler(this.textBoxDiscount_Leave);
            // 
            // textBoxNetDue
            // 
            this.textBoxNetDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNetDue.Enabled = false;
            this.textBoxNetDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNetDue.Location = new System.Drawing.Point(180, 145);
            this.textBoxNetDue.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNetDue.Name = "textBoxNetDue";
            this.textBoxNetDue.ReadOnly = true;
            this.textBoxNetDue.Size = new System.Drawing.Size(136, 31);
            this.textBoxNetDue.TabIndex = 49;
            this.textBoxNetDue.Text = "0.0";
            this.textBoxNetDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelDue
            // 
            this.labelDue.BackColor = System.Drawing.Color.Transparent;
            this.labelDue.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDue.Location = new System.Drawing.Point(9, 144);
            this.labelDue.Name = "labelDue";
            this.labelDue.Size = new System.Drawing.Size(163, 31);
            this.labelDue.TabIndex = 48;
            this.labelDue.Text = "Net Due";
            this.labelDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalTextBox
            // 
            this.totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTextBox.Enabled = false;
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(179, 10);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(134, 31);
            this.totalTextBox.TabIndex = 47;
            this.totalTextBox.Text = "0.0";
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(9, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 31);
            this.label6.TabIndex = 46;
            this.label6.Text = "Invoice Total";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxVat
            // 
            this.textBoxVat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVat.Enabled = false;
            this.textBoxVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVat.Location = new System.Drawing.Point(179, 56);
            this.textBoxVat.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVat.Name = "textBoxVat";
            this.textBoxVat.ReadOnly = true;
            this.textBoxVat.Size = new System.Drawing.Size(136, 31);
            this.textBoxVat.TabIndex = 43;
            this.textBoxVat.Text = "0.0";
            this.textBoxVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(9, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 31);
            this.label4.TabIndex = 31;
            this.label4.Text = "Total Discount";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(9, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 31);
            this.label11.TabIndex = 30;
            this.label11.Text = "Total VAT";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.textBox14);
            this.panel6.Controls.Add(this.textBoxBalance);
            this.panel6.Controls.Add(this.textBox12);
            this.panel6.Controls.Add(this.textBoxCreditLimit);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.textBoxCustomer);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Location = new System.Drawing.Point(2, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(325, 133);
            this.panel6.TabIndex = 33;
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(271, 173);
            this.textBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(82, 26);
            this.textBox14.TabIndex = 38;
            this.textBox14.Text = "0";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBalance.Location = new System.Drawing.Point(208, 89);
            this.textBoxBalance.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(89, 26);
            this.textBoxBalance.TabIndex = 35;
            this.textBoxBalance.Text = "0";
            this.textBoxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(104, 89);
            this.textBox12.Margin = new System.Windows.Forms.Padding(2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 26);
            this.textBox12.TabIndex = 34;
            this.textBox12.Text = "0";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCreditLimit
            // 
            this.textBoxCreditLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreditLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCreditLimit.Location = new System.Drawing.Point(9, 89);
            this.textBoxCreditLimit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCreditLimit.Name = "textBoxCreditLimit";
            this.textBoxCreditLimit.Size = new System.Drawing.Size(93, 26);
            this.textBoxCreditLimit.TabIndex = 33;
            this.textBoxCreditLimit.Text = "0";
            this.textBoxCreditLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label16.Location = new System.Drawing.Point(211, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 18);
            this.label16.TabIndex = 32;
            this.label16.Text = "BALANCE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(16, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 18);
            this.label13.TabIndex = 30;
            this.label13.Text = "CR.Limit";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label15.Location = new System.Drawing.Point(123, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 18);
            this.label15.TabIndex = 31;
            this.label15.Text = "DUES";
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomer.Location = new System.Drawing.Point(9, 31);
            this.textBoxCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(288, 26);
            this.textBoxCustomer.TabIndex = 26;
            this.textBoxCustomer.Enter += new System.EventHandler(this.textBoxCustomer_Enter);
            this.textBoxCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCustomer_KeyDown);
            this.textBoxCustomer.MouseLeave += new System.EventHandler(this.textBoxCustomer_MouseLeave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(110, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 18);
            this.label14.TabIndex = 16;
            this.label14.Text = "Customer";
            // 
            // Invoice_Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 810);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.invoicePanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panelBody);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Invoice_Frame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Frame_Load);
            this.Shown += new System.EventHandler(this.Invoice_Frame_Shown);
            this.Controls.SetChildIndex(this.panelBody, 0);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.invoicePanel, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.topPanel.ResumeLayout(false);
            this.topLeftPanel.ResumeLayout(false);
            this.topLeftPanel.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.invoicePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel topLeftPanel;
        private System.Windows.Forms.TextBox barcodeInput;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel invoicePanel;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView invoiceItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBoxCreditLimit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label topDisplay;
        private System.Windows.Forms.Label invoiceNumber;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox textBoxNetDue;
        private System.Windows.Forms.Label labelDue;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox receivedAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxVat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Button voidInvoice;
        private System.Windows.Forms.Button sales_return;
        private System.Windows.Forms.Button recepentA4Button;
        private System.Windows.Forms.Button holdInvoice;
        private System.Windows.Forms.Button nextInvoice;
        private System.Windows.Forms.Button Keyboard;
        private System.Windows.Forms.Button btnMembership;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;


    }
}