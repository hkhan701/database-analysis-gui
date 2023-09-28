﻿
namespace SaleAnalysis.Controls
{
    partial class QueryEmployeeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.btnQuery = new System.Windows.Forms.Button();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tSSN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tManageId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tEmployeeId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tCityName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tAddress = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.tEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tAddress);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tCityName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tPhone);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tSSN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tManageId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tLastName);
            this.panel1.Controls.Add(this.tFirstName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tEmployeeId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 623);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.grid);
            this.groupBox1.Location = new System.Drawing.Point(3, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 505);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(3, 20);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 23;
            this.grid.Size = new System.Drawing.Size(788, 482);
            this.grid.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(689, 32);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(105, 61);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(428, 51);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(255, 24);
            this.tEmail.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // tSSN
            // 
            this.tSSN.Location = new System.Drawing.Point(210, 51);
            this.tSSN.Name = "tSSN";
            this.tSSN.Size = new System.Drawing.Size(145, 24);
            this.tSSN.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "SSN";
            // 
            // tManageId
            // 
            this.tManageId.Location = new System.Drawing.Point(620, 16);
            this.tManageId.Name = "tManageId";
            this.tManageId.Size = new System.Drawing.Size(63, 24);
            this.tManageId.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Manager Id";
            // 
            // tFirstName
            // 
            this.tFirstName.Location = new System.Drawing.Point(240, 16);
            this.tFirstName.Name = "tFirstName";
            this.tFirstName.Size = new System.Drawing.Size(115, 24);
            this.tFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // tEmployeeId
            // 
            this.tEmployeeId.Location = new System.Drawing.Point(86, 16);
            this.tEmployeeId.Name = "tEmployeeId";
            this.tEmployeeId.Size = new System.Drawing.Size(80, 24);
            this.tEmployeeId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Last Name";
            // 
            // tLastName
            // 
            this.tLastName.Location = new System.Drawing.Point(428, 16);
            this.tLastName.Name = "tLastName";
            this.tLastName.Size = new System.Drawing.Size(115, 24);
            this.tLastName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "City";
            // 
            // tCityName
            // 
            this.tCityName.Location = new System.Drawing.Point(55, 85);
            this.tCityName.Name = "tCityName";
            this.tCityName.Size = new System.Drawing.Size(111, 24);
            this.tCityName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Phone";
            // 
            // tPhone
            // 
            this.tPhone.Location = new System.Drawing.Point(55, 51);
            this.tPhone.Name = "tPhone";
            this.tPhone.Size = new System.Drawing.Size(111, 24);
            this.tPhone.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Address";
            // 
            // tAddress
            // 
            this.tAddress.Location = new System.Drawing.Point(231, 85);
            this.tAddress.Name = "tAddress";
            this.tAddress.Size = new System.Drawing.Size(452, 24);
            this.tAddress.TabIndex = 1;
            // 
            // QueryEmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QueryEmployeeControl";
            this.Size = new System.Drawing.Size(800, 623);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tSSN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tEmployeeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tManageId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tCityName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tAddress;
        private System.Windows.Forms.Label label9;
    }
}
