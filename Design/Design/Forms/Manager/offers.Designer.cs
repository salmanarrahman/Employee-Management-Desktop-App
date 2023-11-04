
namespace Design.Forms.Manager
{
    partial class offers
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
            this.offerIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.offerStatusComboBox = new System.Windows.Forms.ComboBox();
            this.confirm_button = new System.Windows.Forms.Button();
            this.offerListDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.offerListDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // offerIdTextBox
            // 
            this.offerIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offerIdTextBox.Location = new System.Drawing.Point(148, 141);
            this.offerIdTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.offerIdTextBox.Name = "offerIdTextBox";
            this.offerIdTextBox.Size = new System.Drawing.Size(207, 30);
            this.offerIdTextBox.TabIndex = 2;
            this.offerIdTextBox.TextChanged += new System.EventHandler(this.offerIdTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Offer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Offer Status";
            // 
            // offerStatusComboBox
            // 
            this.offerStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offerStatusComboBox.FormattingEnabled = true;
            this.offerStatusComboBox.Items.AddRange(new object[] {
            "Approve",
            "Decline"});
            this.offerStatusComboBox.Location = new System.Drawing.Point(148, 202);
            this.offerStatusComboBox.Name = "offerStatusComboBox";
            this.offerStatusComboBox.Size = new System.Drawing.Size(207, 33);
            this.offerStatusComboBox.TabIndex = 17;
            // 
            // confirm_button
            // 
            this.confirm_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_button.Location = new System.Drawing.Point(179, 280);
            this.confirm_button.Margin = new System.Windows.Forms.Padding(1);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(158, 40);
            this.confirm_button.TabIndex = 18;
            this.confirm_button.Text = "Confirm";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // offerListDataGridView
            // 
            this.offerListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.offerListDataGridView.Location = new System.Drawing.Point(371, 99);
            this.offerListDataGridView.Name = "offerListDataGridView";
            this.offerListDataGridView.Size = new System.Drawing.Size(433, 402);
            this.offerListDataGridView.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 93);
            this.panel1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Show Offers";
            // 
            // offers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.offerListDataGridView);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.offerStatusComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.offerIdTextBox);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "offers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "offers";
            this.Load += new System.EventHandler(this.offers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.offerListDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox offerIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox offerStatusComboBox;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.DataGridView offerListDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}