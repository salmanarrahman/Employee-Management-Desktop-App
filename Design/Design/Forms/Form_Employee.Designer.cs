
using System;
using System.Windows.Forms;

namespace Design.Forms
{
    partial class Form_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Employee));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.searchEmployee = new System.Windows.Forms.Button();
            this.removeEmployee = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.employeeListGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(75, 42);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.searchEmployee);
            this.panel1.Controls.Add(this.removeEmployee);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 551);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 336);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 84);
            this.button3.TabIndex = 5;
            this.button3.Text = "  Refresh";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchEmployee
            // 
            this.searchEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchEmployee.FlatAppearance.BorderSize = 0;
            this.searchEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmployee.Image = ((System.Drawing.Image)(resources.GetObject("searchEmployee.Image")));
            this.searchEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchEmployee.Location = new System.Drawing.Point(0, 252);
            this.searchEmployee.Margin = new System.Windows.Forms.Padding(1);
            this.searchEmployee.Name = "searchEmployee";
            this.searchEmployee.Size = new System.Drawing.Size(219, 84);
            this.searchEmployee.TabIndex = 4;
            this.searchEmployee.Text = "Search Employee";
            this.searchEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchEmployee.UseVisualStyleBackColor = true;
            this.searchEmployee.Click += new System.EventHandler(this.searchEmployee_Click);
            // 
            // removeEmployee
            // 
            this.removeEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeEmployee.FlatAppearance.BorderSize = 0;
            this.removeEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEmployee.Image = ((System.Drawing.Image)(resources.GetObject("removeEmployee.Image")));
            this.removeEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeEmployee.Location = new System.Drawing.Point(0, 168);
            this.removeEmployee.Margin = new System.Windows.Forms.Padding(1);
            this.removeEmployee.Name = "removeEmployee";
            this.removeEmployee.Size = new System.Drawing.Size(219, 84);
            this.removeEmployee.TabIndex = 3;
            this.removeEmployee.Text = "Remove Employee";
            this.removeEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeEmployee.UseVisualStyleBackColor = true;
            this.removeEmployee.Click += new System.EventHandler(this.removeEmployee_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 84);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 84);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update Employee";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Employee";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // employeeListGridView
            // 
            this.employeeListGridView.AllowUserToAddRows = false;
            this.employeeListGridView.AllowUserToDeleteRows = false;
            this.employeeListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeListGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.employeeListGridView.Location = new System.Drawing.Point(313, 0);
            this.employeeListGridView.Name = "employeeListGridView";
            this.employeeListGridView.ReadOnly = true;
            this.employeeListGridView.RowHeadersWidth = 102;
            this.employeeListGridView.Size = new System.Drawing.Size(457, 551);
            this.employeeListGridView.TabIndex = 2;
            this.employeeListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeListGridView_CellContentClick);
            // 
            // Form_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 551);
            this.Controls.Add(this.employeeListGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Employee";
            this.Load += new System.EventHandler(this.Form_Employee_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private void employeeListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button searchEmployee;
        private System.Windows.Forms.Button removeEmployee;
        private System.Windows.Forms.DataGridView employeeListGridView;
        private System.Windows.Forms.Button button3;
    }
}