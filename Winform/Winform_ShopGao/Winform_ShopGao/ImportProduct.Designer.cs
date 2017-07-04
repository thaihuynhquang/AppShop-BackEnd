namespace Winform_ShopGao
{
    partial class ImportProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportProduct));
            this.cmb_Supplier = new System.Windows.Forms.ComboBox();
            this.lb_TenNCC = new System.Windows.Forms.Label();
            this.cmn_Product = new System.Windows.Forms.ComboBox();
            this.lb_TenSP = new System.Windows.Forms.Label();
            this.txtB_UnitInStock = new System.Windows.Forms.TextBox();
            this.txtB_UnitPrice = new System.Windows.Forms.TextBox();
            this.lb_DonGIa = new System.Windows.Forms.Label();
            this.lb_SL = new System.Windows.Forms.Label();
            this.btn_importProduct = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_Supplier
            // 
            this.cmb_Supplier.FormattingEnabled = true;
            this.cmb_Supplier.Location = new System.Drawing.Point(222, 29);
            this.cmb_Supplier.Name = "cmb_Supplier";
            this.cmb_Supplier.Size = new System.Drawing.Size(219, 21);
            this.cmb_Supplier.TabIndex = 0;
            // 
            // lb_TenNCC
            // 
            this.lb_TenNCC.AutoSize = true;
            this.lb_TenNCC.Location = new System.Drawing.Point(122, 32);
            this.lb_TenNCC.Name = "lb_TenNCC";
            this.lb_TenNCC.Size = new System.Drawing.Size(78, 13);
            this.lb_TenNCC.TabIndex = 1;
            this.lb_TenNCC.Text = "Nhà cung cấp:";
            // 
            // cmn_Product
            // 
            this.cmn_Product.FormattingEnabled = true;
            this.cmn_Product.Location = new System.Drawing.Point(222, 78);
            this.cmn_Product.Name = "cmn_Product";
            this.cmn_Product.Size = new System.Drawing.Size(219, 21);
            this.cmn_Product.TabIndex = 2;
            // 
            // lb_TenSP
            // 
            this.lb_TenSP.AutoSize = true;
            this.lb_TenSP.Location = new System.Drawing.Point(142, 81);
            this.lb_TenSP.Name = "lb_TenSP";
            this.lb_TenSP.Size = new System.Drawing.Size(58, 13);
            this.lb_TenSP.TabIndex = 3;
            this.lb_TenSP.Text = "Sản phẩm:";
            // 
            // txtB_UnitInStock
            // 
            this.txtB_UnitInStock.Location = new System.Drawing.Point(222, 125);
            this.txtB_UnitInStock.Name = "txtB_UnitInStock";
            this.txtB_UnitInStock.Size = new System.Drawing.Size(219, 20);
            this.txtB_UnitInStock.TabIndex = 4;
            this.txtB_UnitInStock.Text = "10";
            // 
            // txtB_UnitPrice
            // 
            this.txtB_UnitPrice.Location = new System.Drawing.Point(222, 169);
            this.txtB_UnitPrice.Name = "txtB_UnitPrice";
            this.txtB_UnitPrice.Size = new System.Drawing.Size(219, 20);
            this.txtB_UnitPrice.TabIndex = 5;
            this.txtB_UnitPrice.Text = "10";
            // 
            // lb_DonGIa
            // 
            this.lb_DonGIa.AutoSize = true;
            this.lb_DonGIa.Location = new System.Drawing.Point(121, 172);
            this.lb_DonGIa.Name = "lb_DonGIa";
            this.lb_DonGIa.Size = new System.Drawing.Size(79, 13);
            this.lb_DonGIa.TabIndex = 6;
            this.lb_DonGIa.Text = "Đơn giá (VNĐ):";
            // 
            // lb_SL
            // 
            this.lb_SL.AutoSize = true;
            this.lb_SL.Location = new System.Drawing.Point(148, 128);
            this.lb_SL.Name = "lb_SL";
            this.lb_SL.Size = new System.Drawing.Size(52, 13);
            this.lb_SL.TabIndex = 7;
            this.lb_SL.Text = "Số lượng:";
            // 
            // btn_importProduct
            // 
            this.btn_importProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_importProduct.Image")));
            this.btn_importProduct.Location = new System.Drawing.Point(165, 228);
            this.btn_importProduct.Name = "btn_importProduct";
            this.btn_importProduct.Size = new System.Drawing.Size(130, 50);
            this.btn_importProduct.TabIndex = 8;
            this.btn_importProduct.Text = "Nhập hàng";
            this.btn_importProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_importProduct.UseVisualStyleBackColor = true;
            this.btn_importProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(344, 228);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(130, 50);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // ImportProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 300);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_importProduct);
            this.Controls.Add(this.lb_SL);
            this.Controls.Add(this.lb_DonGIa);
            this.Controls.Add(this.txtB_UnitPrice);
            this.Controls.Add(this.txtB_UnitInStock);
            this.Controls.Add(this.lb_TenSP);
            this.Controls.Add(this.cmn_Product);
            this.Controls.Add(this.lb_TenNCC);
            this.Controls.Add(this.cmb_Supplier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImportProduct";
            this.Text = "Nhập hàng";
            this.Load += new System.EventHandler(this.ImportProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Supplier;
        private System.Windows.Forms.Label lb_TenNCC;
        private System.Windows.Forms.ComboBox cmn_Product;
        private System.Windows.Forms.Label lb_TenSP;
        private System.Windows.Forms.TextBox txtB_UnitInStock;
        private System.Windows.Forms.TextBox txtB_UnitPrice;
        private System.Windows.Forms.Label lb_DonGIa;
        private System.Windows.Forms.Label lb_SL;
        private System.Windows.Forms.Button btn_importProduct;
        private System.Windows.Forms.Button btn_Exit;
    }
}