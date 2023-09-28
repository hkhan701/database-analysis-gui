namespace SaleAnalysis
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCustomerInfo = new System.Windows.Forms.Button();
            this.buttonEmployeeInfo = new System.Windows.Forms.Button();
            this.btnProdcutInfo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.container = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonInventoryInfo = new System.Windows.Forms.Button();
            this.buttonPurchaseInfo = new System.Windows.Forms.Button();
            this.buttonSaleInfo = new System.Windows.Forms.Button();
            this.buttonStatisticPurchase = new System.Windows.Forms.Button();
            this.buttonStatisticSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1087, 682);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonStatisticSale);
            this.groupBox1.Controls.Add(this.buttonStatisticPurchase);
            this.groupBox1.Controls.Add(this.buttonSaleInfo);
            this.groupBox1.Controls.Add(this.buttonPurchaseInfo);
            this.groupBox1.Controls.Add(this.buttonInventoryInfo);
            this.groupBox1.Controls.Add(this.buttonCustomerInfo);
            this.groupBox1.Controls.Add(this.buttonEmployeeInfo);
            this.groupBox1.Controls.Add(this.btnProdcutInfo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 682);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // buttonCustomerInfo
            // 
            this.buttonCustomerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCustomerInfo.BackColor = System.Drawing.Color.SlateGray;
            this.buttonCustomerInfo.FlatAppearance.BorderSize = 0;
            this.buttonCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomerInfo.ForeColor = System.Drawing.Color.White;
            this.buttonCustomerInfo.Location = new System.Drawing.Point(14, 81);
            this.buttonCustomerInfo.Name = "buttonCustomerInfo";
            this.buttonCustomerInfo.Size = new System.Drawing.Size(193, 24);
            this.buttonCustomerInfo.TabIndex = 0;
            this.buttonCustomerInfo.Text = "Customer Information";
            this.buttonCustomerInfo.UseVisualStyleBackColor = false;
            this.buttonCustomerInfo.Click += new System.EventHandler(this.buttonCustomerInfo_Click);
            // 
            // buttonEmployeeInfo
            // 
            this.buttonEmployeeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEmployeeInfo.BackColor = System.Drawing.Color.SlateGray;
            this.buttonEmployeeInfo.FlatAppearance.BorderSize = 0;
            this.buttonEmployeeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeeInfo.ForeColor = System.Drawing.Color.White;
            this.buttonEmployeeInfo.Location = new System.Drawing.Point(14, 51);
            this.buttonEmployeeInfo.Name = "buttonEmployeeInfo";
            this.buttonEmployeeInfo.Size = new System.Drawing.Size(193, 24);
            this.buttonEmployeeInfo.TabIndex = 0;
            this.buttonEmployeeInfo.Text = "Employee Information";
            this.buttonEmployeeInfo.UseVisualStyleBackColor = false;
            this.buttonEmployeeInfo.Click += new System.EventHandler(this.buttonEmployeeInfo_Click);
            // 
            // btnProdcutInfo
            // 
            this.btnProdcutInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProdcutInfo.BackColor = System.Drawing.Color.SlateGray;
            this.btnProdcutInfo.FlatAppearance.BorderSize = 0;
            this.btnProdcutInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdcutInfo.ForeColor = System.Drawing.Color.White;
            this.btnProdcutInfo.Location = new System.Drawing.Point(14, 21);
            this.btnProdcutInfo.Name = "btnProdcutInfo";
            this.btnProdcutInfo.Size = new System.Drawing.Size(193, 24);
            this.btnProdcutInfo.TabIndex = 0;
            this.btnProdcutInfo.Text = "Product Information";
            this.toolTip1.SetToolTip(this.btnProdcutInfo, "Query products\' information by keyword");
            this.btnProdcutInfo.UseVisualStyleBackColor = false;
            this.btnProdcutInfo.Click += new System.EventHandler(this.buttonProductInfo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.container);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(867, 682);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Function Pannel";
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(3, 20);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(861, 659);
            this.container.TabIndex = 0;
            // 
            // buttonInventoryInfo
            // 
            this.buttonInventoryInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInventoryInfo.BackColor = System.Drawing.Color.SlateGray;
            this.buttonInventoryInfo.FlatAppearance.BorderSize = 0;
            this.buttonInventoryInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventoryInfo.ForeColor = System.Drawing.Color.White;
            this.buttonInventoryInfo.Location = new System.Drawing.Point(14, 111);
            this.buttonInventoryInfo.Name = "buttonInventoryInfo";
            this.buttonInventoryInfo.Size = new System.Drawing.Size(193, 24);
            this.buttonInventoryInfo.TabIndex = 0;
            this.buttonInventoryInfo.Text = "Inventory Information";
            this.buttonInventoryInfo.UseVisualStyleBackColor = false;
            this.buttonInventoryInfo.Click += new System.EventHandler(this.buttonInventoryInfo_Click);
            // 
            // buttonPurchaseInfo
            // 
            this.buttonPurchaseInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPurchaseInfo.BackColor = System.Drawing.Color.SlateGray;
            this.buttonPurchaseInfo.FlatAppearance.BorderSize = 0;
            this.buttonPurchaseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPurchaseInfo.ForeColor = System.Drawing.Color.White;
            this.buttonPurchaseInfo.Location = new System.Drawing.Point(12, 141);
            this.buttonPurchaseInfo.Name = "buttonPurchaseInfo";
            this.buttonPurchaseInfo.Size = new System.Drawing.Size(193, 24);
            this.buttonPurchaseInfo.TabIndex = 0;
            this.buttonPurchaseInfo.Text = "Purchase Information";
            this.buttonPurchaseInfo.UseVisualStyleBackColor = false;
            this.buttonPurchaseInfo.Click += new System.EventHandler(this.buttonPurchaseInfo_Click);
            // 
            // buttonSaleInfo
            // 
            this.buttonSaleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaleInfo.BackColor = System.Drawing.Color.SlateGray;
            this.buttonSaleInfo.FlatAppearance.BorderSize = 0;
            this.buttonSaleInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaleInfo.ForeColor = System.Drawing.Color.White;
            this.buttonSaleInfo.Location = new System.Drawing.Point(13, 171);
            this.buttonSaleInfo.Name = "buttonSaleInfo";
            this.buttonSaleInfo.Size = new System.Drawing.Size(193, 24);
            this.buttonSaleInfo.TabIndex = 0;
            this.buttonSaleInfo.Text = "Sale Information";
            this.buttonSaleInfo.UseVisualStyleBackColor = false;
            this.buttonSaleInfo.Click += new System.EventHandler(this.buttonSaleInfo_Click);
            // 
            // buttonStatisticPurchase
            // 
            this.buttonStatisticPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStatisticPurchase.BackColor = System.Drawing.Color.SlateGray;
            this.buttonStatisticPurchase.FlatAppearance.BorderSize = 0;
            this.buttonStatisticPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatisticPurchase.ForeColor = System.Drawing.Color.White;
            this.buttonStatisticPurchase.Location = new System.Drawing.Point(14, 201);
            this.buttonStatisticPurchase.Name = "buttonStatisticPurchase";
            this.buttonStatisticPurchase.Size = new System.Drawing.Size(193, 24);
            this.buttonStatisticPurchase.TabIndex = 0;
            this.buttonStatisticPurchase.Text = "Statistic Purchase Information";
            this.buttonStatisticPurchase.UseVisualStyleBackColor = false;
            this.buttonStatisticPurchase.Click += new System.EventHandler(this.buttonStatisticPurchase_Click);
            // 
            // buttonStatisticSale
            // 
            this.buttonStatisticSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStatisticSale.BackColor = System.Drawing.Color.SlateGray;
            this.buttonStatisticSale.FlatAppearance.BorderSize = 0;
            this.buttonStatisticSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatisticSale.ForeColor = System.Drawing.Color.White;
            this.buttonStatisticSale.Location = new System.Drawing.Point(14, 231);
            this.buttonStatisticSale.Name = "buttonStatisticSale";
            this.buttonStatisticSale.Size = new System.Drawing.Size(193, 24);
            this.buttonStatisticSale.TabIndex = 0;
            this.buttonStatisticSale.Text = "Statistic Sale Information";
            this.buttonStatisticSale.UseVisualStyleBackColor = false;
            this.buttonStatisticSale.Click += new System.EventHandler(this.buttonStatisticSale_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 682);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Sale Analysis";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProdcutInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Button buttonCustomerInfo;
        private System.Windows.Forms.Button buttonEmployeeInfo;
        private System.Windows.Forms.Button buttonInventoryInfo;
        private System.Windows.Forms.Button buttonPurchaseInfo;
        private System.Windows.Forms.Button buttonSaleInfo;
        private System.Windows.Forms.Button buttonStatisticPurchase;
        private System.Windows.Forms.Button buttonStatisticSale;
    }
}

