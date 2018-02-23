namespace EPose
{
    partial class PrinterSelect_Frame
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonA4 = new System.Windows.Forms.RadioButton();
            this.radioButtonLongRecept = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.lstPrinterList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Page Type";
            // 
            // radioButtonA4
            // 
            this.radioButtonA4.AutoSize = true;
            this.radioButtonA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonA4.Location = new System.Drawing.Point(16, 79);
            this.radioButtonA4.Name = "radioButtonA4";
            this.radioButtonA4.Size = new System.Drawing.Size(93, 24);
            this.radioButtonA4.TabIndex = 5;
            this.radioButtonA4.TabStop = true;
            this.radioButtonA4.Text = "A4 Paper";
            this.radioButtonA4.UseVisualStyleBackColor = true;
            // 
            // radioButtonLongRecept
            // 
            this.radioButtonLongRecept.AutoSize = true;
            this.radioButtonLongRecept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLongRecept.Location = new System.Drawing.Point(134, 79);
            this.radioButtonLongRecept.Name = "radioButtonLongRecept";
            this.radioButtonLongRecept.Size = new System.Drawing.Size(119, 24);
            this.radioButtonLongRecept.TabIndex = 6;
            this.radioButtonLongRecept.TabStop = true;
            this.radioButtonLongRecept.Text = "Long Recept";
            this.radioButtonLongRecept.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Printer";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.buttonPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(220, 281);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(92, 31);
            this.buttonPrint.TabIndex = 9;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // lstPrinterList
            // 
            this.lstPrinterList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPrinterList.FormattingEnabled = true;
            this.lstPrinterList.ItemHeight = 16;
            this.lstPrinterList.Location = new System.Drawing.Point(16, 152);
            this.lstPrinterList.Name = "lstPrinterList";
            this.lstPrinterList.Size = new System.Drawing.Size(296, 116);
            this.lstPrinterList.TabIndex = 10;
            // 
            // PrinterSelect_Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 325);
            this.Controls.Add(this.lstPrinterList);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonLongRecept);
            this.Controls.Add(this.radioButtonA4);
            this.Controls.Add(this.label1);
            this.Name = "PrinterSelect_Frame";
            this.Text = "PrinterSelect_Frame";
            this.Load += new System.EventHandler(this.PrinterSelect_Frame_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.radioButtonA4, 0);
            this.Controls.SetChildIndex(this.radioButtonLongRecept, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.buttonPrint, 0);
            this.Controls.SetChildIndex(this.lstPrinterList, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonA4;
        private System.Windows.Forms.RadioButton radioButtonLongRecept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.ListBox lstPrinterList;
    }
}