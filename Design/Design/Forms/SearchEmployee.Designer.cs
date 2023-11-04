
namespace Design.Forms
{
    partial class SearchEmployee
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchEmpIdTextBox = new System.Windows.Forms.TextBox();
            this.searchEmpNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchEmployeeListGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchEmployeeListGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.searchButton);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.searchEmpIdTextBox);
            this.groupBox5.Controls.Add(this.searchEmpNameTextBox);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.searchEmployeeListGridView);
            this.groupBox5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(26, 93);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(694, 418);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search Employee";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(380, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 29);
            this.searchButton.TabIndex = 19;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // searchEmpIdTextBox
            // 
            this.searchEmpIdTextBox.Location = new System.Drawing.Point(193, 18);
            this.searchEmpIdTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.searchEmpIdTextBox.Name = "searchEmpIdTextBox";
            this.searchEmpIdTextBox.Size = new System.Drawing.Size(166, 25);
            this.searchEmpIdTextBox.TabIndex = 5;
            // 
            // searchEmpNameTextBox
            // 
            this.searchEmpNameTextBox.Location = new System.Drawing.Point(193, 57);
            this.searchEmpNameTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.searchEmpNameTextBox.Name = "searchEmpNameTextBox";
            this.searchEmpNameTextBox.Size = new System.Drawing.Size(166, 25);
            this.searchEmpNameTextBox.TabIndex = 4;
            this.searchEmpNameTextBox.TextChanged += new System.EventHandler(this.searchEmpNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // searchEmployeeListGridView
            // 
            this.searchEmployeeListGridView.AllowUserToAddRows = false;
            this.searchEmployeeListGridView.AllowUserToDeleteRows = false;
            this.searchEmployeeListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchEmployeeListGridView.Location = new System.Drawing.Point(0, 98);
            this.searchEmployeeListGridView.Name = "searchEmployeeListGridView";
            this.searchEmployeeListGridView.ReadOnly = true;
            this.searchEmployeeListGridView.RowHeadersWidth = 102;
            this.searchEmployeeListGridView.Size = new System.Drawing.Size(694, 314);
            this.searchEmployeeListGridView.TabIndex = 0;
            this.searchEmployeeListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchEmployeeListGridView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkViolet;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 88);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search Employe";
            // 
            // SearchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "SearchEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchEmployee";
            this.Load += new System.EventHandler(this.SearchEmployee_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchEmployeeListGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView searchEmployeeListGridView;
        private System.Windows.Forms.TextBox searchEmpNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchEmpIdTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}