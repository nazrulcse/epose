namespace EPose
{
    partial class Layout_Frame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout_Frame));
            this.titleBar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.PictureBox();
            this.formTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leftBorder = new System.Windows.Forms.Panel();
            this.rightBorder = new System.Windows.Forms.Panel();
            this.bottomBorder = new System.Windows.Forms.Panel();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(223)))));
            this.titleBar.Controls.Add(this.pictureBox2);
            this.titleBar.Controls.Add(this.pictureBox3);
            this.titleBar.Controls.Add(this.btnexit);
            this.titleBar.Controls.Add(this.formTitle);
            this.titleBar.Controls.Add(this.pictureBox1);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(885, 40);
            this.titleBar.TabIndex = 2;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(819, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.pictureBox2.Size = new System.Drawing.Size(22, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(841, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.pictureBox3.Size = new System.Drawing.Size(22, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(863, 0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnexit.Size = new System.Drawing.Size(22, 40);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnexit.TabIndex = 3;
            this.btnexit.TabStop = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // formTitle
            // 
            this.formTitle.BackColor = System.Drawing.Color.Transparent;
            this.formTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.formTitle.Location = new System.Drawing.Point(39, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(577, 40);
            this.formTitle.TabIndex = 3;
            this.formTitle.Text = "Main window";
            this.formTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formTitle_MouseDown);
            this.formTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formTitle_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // leftBorder
            // 
            this.leftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(223)))));
            this.leftBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBorder.Location = new System.Drawing.Point(0, 40);
            this.leftBorder.Name = "leftBorder";
            this.leftBorder.Size = new System.Drawing.Size(3, 507);
            this.leftBorder.TabIndex = 3;
            // 
            // rightBorder
            // 
            this.rightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(223)))));
            this.rightBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorder.Location = new System.Drawing.Point(882, 40);
            this.rightBorder.Name = "rightBorder";
            this.rightBorder.Size = new System.Drawing.Size(3, 507);
            this.rightBorder.TabIndex = 3;
            // 
            // bottomBorder
            // 
            this.bottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(223)))));
            this.bottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBorder.Location = new System.Drawing.Point(3, 544);
            this.bottomBorder.Name = "bottomBorder";
            this.bottomBorder.Size = new System.Drawing.Size(879, 3);
            this.bottomBorder.TabIndex = 3;
            // 
            // Layout_Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 547);
            this.Controls.Add(this.bottomBorder);
            this.Controls.Add(this.rightBorder);
            this.Controls.Add(this.leftBorder);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Layout_Frame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Layout";
            this.Load += new System.EventHandler(this.Layout_Frame_Load);
            this.titleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.PictureBox btnexit;
        private System.Windows.Forms.Panel leftBorder;
        private System.Windows.Forms.Panel rightBorder;
        private System.Windows.Forms.Panel bottomBorder;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}