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
            this.cmb_ChooseSupplier = new System.Windows.Forms.ComboBox();
            this.lb_ChooseSupplier = new System.Windows.Forms.Label();
            this.cmb_ChooseProduct = new System.Windows.Forms.ComboBox();
            this.lb_ChooseProduct = new System.Windows.Forms.Label();
            this.txtB_UnitInStock = new System.Windows.Forms.TextBox();
            this.txtB_UnitPrice = new System.Windows.Forms.TextBox();
            this.lb_ImportPrice = new System.Windows.Forms.Label();
            this.lb_ImportQuantity = new System.Windows.Forms.Label();
            this.btn_importProduct = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtB_ProductPrice = new System.Windows.Forms.TextBox();
            this.txtB_ProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ProductPrice = new System.Windows.Forms.Label();
            this.lb_ProductName = new System.Windows.Forms.Label();
            this.txtB_SupplierPhone = new System.Windows.Forms.TextBox();
            this.txtB_SupplierEmail = new System.Windows.Forms.TextBox();
            this.txtB_SupplierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_PhoneSupplier = new System.Windows.Forms.Label();
            this.lb_EmailSupplier = new System.Windows.Forms.Label();
            this.lb_SupplierName = new System.Windows.Forms.Label();
            this.btn_Unclock = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_ChooseSupplier
            // 
            this.cmb_ChooseSupplier.FormattingEnabled = true;
            this.cmb_ChooseSupplier.Location = new System.Drawing.Point(157, 17);
            this.cmb_ChooseSupplier.Name = "cmb_ChooseSupplier";
            this.cmb_ChooseSupplier.Size = new System.Drawing.Size(154, 21);
            this.cmb_ChooseSupplier.TabIndex = 0;
            this.cmb_ChooseSupplier.SelectedIndexChanged += new System.EventHandler(this.cmb_ChooseSupplier_SelectedIndexChanged);
            // 
            // lb_ChooseSupplier
            // 
            this.lb_ChooseSupplier.AutoSize = true;
            this.lb_ChooseSupplier.Location = new System.Drawing.Point(24, 20);
            this.lb_ChooseSupplier.Name = "lb_ChooseSupplier";
            this.lb_ChooseSupplier.Size = new System.Drawing.Size(104, 13);
            this.lb_ChooseSupplier.TabIndex = 1;
            this.lb_ChooseSupplier.Text = "Chọn nhà cung cấp:";
            // 
            // cmb_ChooseProduct
            // 
            this.cmb_ChooseProduct.FormattingEnabled = true;
            this.cmb_ChooseProduct.Location = new System.Drawing.Point(157, 60);
            this.cmb_ChooseProduct.Name = "cmb_ChooseProduct";
            this.cmb_ChooseProduct.Size = new System.Drawing.Size(154, 21);
            this.cmb_ChooseProduct.TabIndex = 2;
            this.cmb_ChooseProduct.SelectedIndexChanged += new System.EventHandler(this.cmn_ChooseProduct_SelectedIndexChanged);
            // 
            // lb_ChooseProduct
            // 
            this.lb_ChooseProduct.AutoSize = true;
            this.lb_ChooseProduct.Location = new System.Drawing.Point(44, 63);
            this.lb_ChooseProduct.Name = "lb_ChooseProduct";
            this.lb_ChooseProduct.Size = new System.Drawing.Size(84, 13);
            this.lb_ChooseProduct.TabIndex = 3;
            this.lb_ChooseProduct.Text = "Chọn sản phẩm:";
            // 
            // txtB_UnitInStock
            // 
            this.txtB_UnitInStock.Location = new System.Drawing.Point(157, 104);
            this.txtB_UnitInStock.Name = "txtB_UnitInStock";
            this.txtB_UnitInStock.Size = new System.Drawing.Size(154, 20);
            this.txtB_UnitInStock.TabIndex = 4;
            // 
            // txtB_UnitPrice
            // 
            this.txtB_UnitPrice.Location = new System.Drawing.Point(157, 142);
            this.txtB_UnitPrice.Name = "txtB_UnitPrice";
            this.txtB_UnitPrice.Size = new System.Drawing.Size(154, 20);
            this.txtB_UnitPrice.TabIndex = 5;
            // 
            // lb_ImportPrice
            // 
            this.lb_ImportPrice.AutoSize = true;
            this.lb_ImportPrice.Location = new System.Drawing.Point(43, 145);
            this.lb_ImportPrice.Name = "lb_ImportPrice";
            this.lb_ImportPrice.Size = new System.Drawing.Size(85, 13);
            this.lb_ImportPrice.TabIndex = 6;
            this.lb_ImportPrice.Text = "Giá nhập (VNĐ):";
            // 
            // lb_ImportQuantity
            // 
            this.lb_ImportQuantity.AutoSize = true;
            this.lb_ImportQuantity.Location = new System.Drawing.Point(49, 107);
            this.lb_ImportQuantity.Name = "lb_ImportQuantity";
            this.lb_ImportQuantity.Size = new System.Drawing.Size(79, 13);
            this.lb_ImportQuantity.TabIndex = 7;
            this.lb_ImportQuantity.Text = "Số lượng nhập:";
            // 
            // btn_importProduct
            // 
            this.btn_importProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_importProduct.Image")));
            this.btn_importProduct.Location = new System.Drawing.Point(207, 193);
            this.btn_importProduct.Name = "btn_importProduct";
            this.btn_importProduct.Size = new System.Drawing.Size(100, 40);
            this.btn_importProduct.TabIndex = 8;
            this.btn_importProduct.Text = "Cập nhật";
            this.btn_importProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_importProduct.UseVisualStyleBackColor = true;
            this.btn_importProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(572, 292);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(130, 50);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.txtB_UnitPrice);
            this.panel1.Controls.Add(this.txtB_UnitInStock);
            this.panel1.Controls.Add(this.lb_ImportQuantity);
            this.panel1.Controls.Add(this.cmb_ChooseProduct);
            this.panel1.Controls.Add(this.btn_importProduct);
            this.panel1.Controls.Add(this.lb_ImportPrice);
            this.panel1.Controls.Add(this.lb_ChooseProduct);
            this.panel1.Controls.Add(this.lb_ChooseSupplier);
            this.panel1.Controls.Add(this.cmb_ChooseSupplier);
            this.panel1.Location = new System.Drawing.Point(365, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 247);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.txtB_ProductPrice);
            this.panel2.Controls.Add(this.txtB_ProductName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lb_ProductPrice);
            this.panel2.Controls.Add(this.lb_ProductName);
            this.panel2.Controls.Add(this.txtB_SupplierPhone);
            this.panel2.Controls.Add(this.txtB_SupplierEmail);
            this.panel2.Controls.Add(this.txtB_SupplierName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lb_PhoneSupplier);
            this.panel2.Controls.Add(this.lb_EmailSupplier);
            this.panel2.Controls.Add(this.lb_SupplierName);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 330);
            this.panel2.TabIndex = 11;
            // 
            // txtB_ProductPrice
            // 
            this.txtB_ProductPrice.Location = new System.Drawing.Point(137, 266);
            this.txtB_ProductPrice.Name = "txtB_ProductPrice";
            this.txtB_ProductPrice.Size = new System.Drawing.Size(146, 20);
            this.txtB_ProductPrice.TabIndex = 12;
            // 
            // txtB_ProductName
            // 
            this.txtB_ProductName.Location = new System.Drawing.Point(137, 227);
            this.txtB_ProductName.Name = "txtB_ProductName";
            this.txtB_ProductName.Size = new System.Drawing.Size(146, 20);
            this.txtB_ProductName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Thông tin sản phẩm";
            // 
            // lb_ProductPrice
            // 
            this.lb_ProductPrice.AutoSize = true;
            this.lb_ProductPrice.Location = new System.Drawing.Point(37, 269);
            this.lb_ProductPrice.Name = "lb_ProductPrice";
            this.lb_ProductPrice.Size = new System.Drawing.Size(79, 13);
            this.lb_ProductPrice.TabIndex = 8;
            this.lb_ProductPrice.Text = "Giá bán (VNĐ):";
            // 
            // lb_ProductName
            // 
            this.lb_ProductName.AutoSize = true;
            this.lb_ProductName.Location = new System.Drawing.Point(58, 230);
            this.lb_ProductName.Name = "lb_ProductName";
            this.lb_ProductName.Size = new System.Drawing.Size(58, 13);
            this.lb_ProductName.TabIndex = 7;
            this.lb_ProductName.Text = "Sản phẩm:";
            // 
            // txtB_SupplierPhone
            // 
            this.txtB_SupplierPhone.Location = new System.Drawing.Point(137, 124);
            this.txtB_SupplierPhone.Name = "txtB_SupplierPhone";
            this.txtB_SupplierPhone.Size = new System.Drawing.Size(146, 20);
            this.txtB_SupplierPhone.TabIndex = 6;
            // 
            // txtB_SupplierEmail
            // 
            this.txtB_SupplierEmail.Location = new System.Drawing.Point(137, 86);
            this.txtB_SupplierEmail.Name = "txtB_SupplierEmail";
            this.txtB_SupplierEmail.Size = new System.Drawing.Size(146, 20);
            this.txtB_SupplierEmail.TabIndex = 5;
            // 
            // txtB_SupplierName
            // 
            this.txtB_SupplierName.Location = new System.Drawing.Point(137, 47);
            this.txtB_SupplierName.Name = "txtB_SupplierName";
            this.txtB_SupplierName.Size = new System.Drawing.Size(146, 20);
            this.txtB_SupplierName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thông tin nhà cung cấp";
            // 
            // lb_PhoneSupplier
            // 
            this.lb_PhoneSupplier.AutoSize = true;
            this.lb_PhoneSupplier.Location = new System.Drawing.Point(58, 127);
            this.lb_PhoneSupplier.Name = "lb_PhoneSupplier";
            this.lb_PhoneSupplier.Size = new System.Drawing.Size(58, 13);
            this.lb_PhoneSupplier.TabIndex = 2;
            this.lb_PhoneSupplier.Text = "Điện thoại:";
            // 
            // lb_EmailSupplier
            // 
            this.lb_EmailSupplier.AutoSize = true;
            this.lb_EmailSupplier.Location = new System.Drawing.Point(81, 89);
            this.lb_EmailSupplier.Name = "lb_EmailSupplier";
            this.lb_EmailSupplier.Size = new System.Drawing.Size(35, 13);
            this.lb_EmailSupplier.TabIndex = 1;
            this.lb_EmailSupplier.Text = "Email:";
            // 
            // lb_SupplierName
            // 
            this.lb_SupplierName.AutoSize = true;
            this.lb_SupplierName.Location = new System.Drawing.Point(41, 50);
            this.lb_SupplierName.Name = "lb_SupplierName";
            this.lb_SupplierName.Size = new System.Drawing.Size(75, 13);
            this.lb_SupplierName.TabIndex = 0;
            this.lb_SupplierName.Text = "Nhà cung cấp";
            // 
            // btn_Unclock
            // 
            this.btn_Unclock.Image = ((System.Drawing.Image)(resources.GetObject("btn_Unclock.Image")));
            this.btn_Unclock.Location = new System.Drawing.Point(426, 292);
            this.btn_Unclock.Name = "btn_Unclock";
            this.btn_Unclock.Size = new System.Drawing.Size(130, 50);
            this.btn_Unclock.TabIndex = 8;
            this.btn_Unclock.Text = "Nhập hàng";
            this.btn_Unclock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Unclock.UseVisualStyleBackColor = true;
            this.btn_Unclock.Click += new System.EventHandler(this.btn_Unclock_Click);
            // 
            // ImportProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 365);
            this.Controls.Add(this.btn_Unclock);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImportProduct";
            this.Text = "Nhập hàng";
            this.Load += new System.EventHandler(this.ImportProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_ChooseSupplier;
        private System.Windows.Forms.Label lb_ChooseSupplier;
        private System.Windows.Forms.ComboBox cmb_ChooseProduct;
        private System.Windows.Forms.Label lb_ChooseProduct;
        private System.Windows.Forms.TextBox txtB_UnitInStock;
        private System.Windows.Forms.TextBox txtB_UnitPrice;
        private System.Windows.Forms.Label lb_ImportPrice;
        private System.Windows.Forms.Label lb_ImportQuantity;
        private System.Windows.Forms.Button btn_importProduct;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_SupplierName;
        private System.Windows.Forms.TextBox txtB_ProductPrice;
        private System.Windows.Forms.TextBox txtB_ProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_ProductPrice;
        private System.Windows.Forms.Label lb_ProductName;
        private System.Windows.Forms.TextBox txtB_SupplierPhone;
        private System.Windows.Forms.TextBox txtB_SupplierEmail;
        private System.Windows.Forms.TextBox txtB_SupplierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_PhoneSupplier;
        private System.Windows.Forms.Label lb_EmailSupplier;
        private System.Windows.Forms.Button btn_Unclock;
    }
}