
namespace Design
{
    partial class AdminUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUI));
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btnreporting = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnorders = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.paneltitlebar = new System.Windows.Forms.Panel();
            this.guestLabel = new System.Windows.Forms.Label();
            this.paneldesktoppanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelmenu.SuspendLayout();
            this.paneltitlebar.SuspendLayout();
            this.paneldesktoppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.White;
            this.panelmenu.Controls.Add(this.button1);
            this.panelmenu.Controls.Add(this.btnreporting);
            this.panelmenu.Controls.Add(this.btncustomer);
            this.panelmenu.Controls.Add(this.btnorders);
            this.panelmenu.Controls.Add(this.btnproduct);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Margin = new System.Windows.Forms.Padding(1);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(188, 529);
            this.panelmenu.TabIndex = 0;
            // 
            // btnreporting
            // 
            this.btnreporting.BackColor = System.Drawing.Color.White;
            this.btnreporting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnreporting.FlatAppearance.BorderSize = 0;
            this.btnreporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnreporting.Image = ((System.Drawing.Image)(resources.GetObject("btnreporting.Image")));
            this.btnreporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreporting.Location = new System.Drawing.Point(0, 240);
            this.btnreporting.Margin = new System.Windows.Forms.Padding(1);
            this.btnreporting.Name = "btnreporting";
            this.btnreporting.Padding = new System.Windows.Forms.Padding(6);
            this.btnreporting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnreporting.Size = new System.Drawing.Size(188, 80);
            this.btnreporting.TabIndex = 4;
            this.btnreporting.Text = "Generate Manager";
            this.btnreporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreporting.UseVisualStyleBackColor = false;
            this.btnreporting.Click += new System.EventHandler(this.button3_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.BackColor = System.Drawing.Color.White;
            this.btncustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncustomer.FlatAppearance.BorderSize = 0;
            this.btncustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btncustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncustomer.Image = ((System.Drawing.Image)(resources.GetObject("btncustomer.Image")));
            this.btncustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncustomer.Location = new System.Drawing.Point(0, 160);
            this.btncustomer.Margin = new System.Windows.Forms.Padding(1);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Padding = new System.Windows.Forms.Padding(6);
            this.btncustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btncustomer.Size = new System.Drawing.Size(188, 80);
            this.btncustomer.TabIndex = 3;
            this.btncustomer.Text = "coustomer";
            this.btncustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncustomer.UseVisualStyleBackColor = false;
            this.btncustomer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnorders
            // 
            this.btnorders.BackColor = System.Drawing.Color.White;
            this.btnorders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnorders.FlatAppearance.BorderSize = 0;
            this.btnorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorders.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnorders.Image = ((System.Drawing.Image)(resources.GetObject("btnorders.Image")));
            this.btnorders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorders.Location = new System.Drawing.Point(0, 80);
            this.btnorders.Margin = new System.Windows.Forms.Padding(1);
            this.btnorders.Name = "btnorders";
            this.btnorders.Padding = new System.Windows.Forms.Padding(6);
            this.btnorders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnorders.Size = new System.Drawing.Size(188, 80);
            this.btnorders.TabIndex = 2;
            this.btnorders.Text = "offers";
            this.btnorders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnorders.UseVisualStyleBackColor = false;
            this.btnorders.Click += new System.EventHandler(this.btnorders_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.BackColor = System.Drawing.Color.White;
            this.btnproduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnproduct.FlatAppearance.BorderSize = 0;
            this.btnproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnproduct.Image = ((System.Drawing.Image)(resources.GetObject("btnproduct.Image")));
            this.btnproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduct.Location = new System.Drawing.Point(0, 0);
            this.btnproduct.Margin = new System.Windows.Forms.Padding(1);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Padding = new System.Windows.Forms.Padding(6);
            this.btnproduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnproduct.Size = new System.Drawing.Size(188, 80);
            this.btnproduct.TabIndex = 1;
            this.btnproduct.Text = "employee";
            this.btnproduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproduct.UseVisualStyleBackColor = false;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // paneltitlebar
            // 
            this.paneltitlebar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paneltitlebar.Controls.Add(this.guestLabel);
            this.paneltitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitlebar.Location = new System.Drawing.Point(188, 0);
            this.paneltitlebar.Margin = new System.Windows.Forms.Padding(1);
            this.paneltitlebar.Name = "paneltitlebar";
            this.paneltitlebar.Size = new System.Drawing.Size(719, 81);
            this.paneltitlebar.TabIndex = 1;
            this.paneltitlebar.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltitlebar_Paint);
            // 
            // guestLabel
            // 
            this.guestLabel.AutoSize = true;
            this.guestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestLabel.Location = new System.Drawing.Point(312, 29);
            this.guestLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.guestLabel.Name = "guestLabel";
            this.guestLabel.Size = new System.Drawing.Size(124, 20);
            this.guestLabel.TabIndex = 0;
            this.guestLabel.Text = "Welcome Admin";
            this.guestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paneldesktoppanel
            // 
            this.paneldesktoppanel.Controls.Add(this.button2);
            this.paneldesktoppanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldesktoppanel.Location = new System.Drawing.Point(188, 81);
            this.paneldesktoppanel.Margin = new System.Windows.Forms.Padding(1);
            this.paneldesktoppanel.Name = "paneldesktoppanel";
            this.paneldesktoppanel.Size = new System.Drawing.Size(719, 448);
            this.paneldesktoppanel.TabIndex = 2;
            this.paneldesktoppanel.Paint += new System.Windows.Forms.PaintEventHandler(this.paneldesktoppanel_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 320);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(6);
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(188, 80);
            this.button1.TabIndex = 5;
            this.button1.Text = "  Log out";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(269, 67);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 324);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 529);
            this.Controls.Add(this.paneldesktoppanel);
            this.Controls.Add(this.paneltitlebar);
            this.Controls.Add(this.panelmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "AdminUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminUI_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelmenu.ResumeLayout(false);
            this.paneltitlebar.ResumeLayout(false);
            this.paneltitlebar.PerformLayout();
            this.paneldesktoppanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button btnreporting;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnorders;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Panel paneltitlebar;
        private System.Windows.Forms.Panel paneldesktoppanel;
        private System.Windows.Forms.Label guestLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

