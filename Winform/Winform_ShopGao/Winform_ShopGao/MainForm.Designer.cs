namespace Winform_ShopGao
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabPaneMainForm = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNaviPage_NhaCungCap = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_RefreshDataSupplier = new System.Windows.Forms.Button();
            this.btt_EditSupplier = new System.Windows.Forms.Button();
            this.btt_newSupplier = new System.Windows.Forms.Button();
            this.supplierGridControl = new System.Windows.Forms.DataGridView();
            this.tabNaviPage_SanPham = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btt_EditProduct = new System.Windows.Forms.Button();
            this.btt_newProduct = new System.Windows.Forms.Button();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.tabNaviPage_KhachHang = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.tabNaviPage_DonHang = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_newBill = new System.Windows.Forms.Button();
            this.GridView_Bills = new System.Windows.Forms.DataGridView();
            this.tabNaviPage_NhapHang = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_importProduct = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabNaviPage_GiaoHang = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_EditShipper = new System.Windows.Forms.Button();
            this.btn_InsertShipper = new System.Windows.Forms.Button();
            this.GridView_Shippers = new System.Windows.Forms.DataGridView();
            this.tabNaviPage_LoaiSanPham = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_EditProductType = new System.Windows.Forms.Button();
            this.btn_InsertProductType = new System.Windows.Forms.Button();
            this.GridView_ProductType = new System.Windows.Forms.DataGridView();
            this.btn_ChangePass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneMainForm)).BeginInit();
            this.tabPaneMainForm.SuspendLayout();
            this.tabNaviPage_NhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridControl)).BeginInit();
            this.tabNaviPage_SanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.tabNaviPage_KhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.tabNaviPage_DonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Bills)).BeginInit();
            this.tabNaviPage_NhapHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabNaviPage_GiaoHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Shippers)).BeginInit();
            this.tabNaviPage_LoaiSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_ProductType)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPaneMainForm
            // 
            this.tabPaneMainForm.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.tabPaneMainForm.Appearance.Options.UseBackColor = true;
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_NhaCungCap);
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_SanPham);
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_KhachHang);
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_DonHang);
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_NhapHang);
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_GiaoHang);
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_LoaiSanPham);
            this.tabPaneMainForm.Location = new System.Drawing.Point(12, 12);
            this.tabPaneMainForm.Name = "tabPaneMainForm";
            this.tabPaneMainForm.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabPaneMainForm.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNaviPage_NhaCungCap,
            this.tabNaviPage_NhapHang,
            this.tabNaviPage_SanPham,
            this.tabNaviPage_LoaiSanPham,
            this.tabNaviPage_DonHang,
            this.tabNaviPage_GiaoHang,
            this.tabNaviPage_KhachHang});
            this.tabPaneMainForm.RegularSize = new System.Drawing.Size(971, 467);
            this.tabPaneMainForm.SelectedPage = this.tabNaviPage_NhaCungCap;
            this.tabPaneMainForm.Size = new System.Drawing.Size(971, 467);
            this.tabPaneMainForm.TabIndex = 0;
            this.tabPaneMainForm.Text = "asdas";
            // 
            // tabNaviPage_NhaCungCap
            // 
            this.tabNaviPage_NhaCungCap.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.tabNaviPage_NhaCungCap.Appearance.Options.UseBackColor = true;
            this.tabNaviPage_NhaCungCap.Caption = "NHÀ CUNG CẤP";
            this.tabNaviPage_NhaCungCap.Controls.Add(this.btn_RefreshDataSupplier);
            this.tabNaviPage_NhaCungCap.Controls.Add(this.btt_EditSupplier);
            this.tabNaviPage_NhaCungCap.Controls.Add(this.btt_newSupplier);
            this.tabNaviPage_NhaCungCap.Controls.Add(this.supplierGridControl);
            this.tabNaviPage_NhaCungCap.Name = "tabNaviPage_NhaCungCap";
            this.tabNaviPage_NhaCungCap.Size = new System.Drawing.Size(953, 422);
            this.tabNaviPage_NhaCungCap.VisibleChanged += new System.EventHandler(this.tabNaviPage_NhaCungCap_VisibleChanged);
            // 
            // btn_RefreshDataSupplier
            // 
            this.btn_RefreshDataSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshDataSupplier.Image")));
            this.btn_RefreshDataSupplier.Location = new System.Drawing.Point(417, 359);
            this.btn_RefreshDataSupplier.Name = "btn_RefreshDataSupplier";
            this.btn_RefreshDataSupplier.Size = new System.Drawing.Size(130, 50);
            this.btn_RefreshDataSupplier.TabIndex = 2;
            this.btn_RefreshDataSupplier.Text = "Tải lại dữ liệu";
            this.btn_RefreshDataSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RefreshDataSupplier.UseVisualStyleBackColor = true;
            this.btn_RefreshDataSupplier.Click += new System.EventHandler(this.btn_RefreshDataSupplier_Click);
            // 
            // btt_EditSupplier
            // 
            this.btt_EditSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btt_EditSupplier.Image")));
            this.btt_EditSupplier.Location = new System.Drawing.Point(758, 359);
            this.btt_EditSupplier.Name = "btt_EditSupplier";
            this.btt_EditSupplier.Size = new System.Drawing.Size(180, 50);
            this.btt_EditSupplier.TabIndex = 2;
            this.btt_EditSupplier.Text = "Thay đổi thông tin";
            this.btt_EditSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btt_EditSupplier.UseVisualStyleBackColor = true;
            this.btt_EditSupplier.Click += new System.EventHandler(this.button2_Click);
            // 
            // btt_newSupplier
            // 
            this.btt_newSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btt_newSupplier.Image")));
            this.btt_newSupplier.Location = new System.Drawing.Point(563, 359);
            this.btt_newSupplier.Name = "btt_newSupplier";
            this.btt_newSupplier.Size = new System.Drawing.Size(180, 50);
            this.btt_newSupplier.TabIndex = 1;
            this.btt_newSupplier.Text = "Thêm nhà cung cấp";
            this.btt_newSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btt_newSupplier.UseVisualStyleBackColor = true;
            this.btt_newSupplier.Click += new System.EventHandler(this.newSupp_Click);
            // 
            // supplierGridControl
            // 
            this.supplierGridControl.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.supplierGridControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierGridControl.Location = new System.Drawing.Point(4, 4);
            this.supplierGridControl.Name = "supplierGridControl";
            this.supplierGridControl.Size = new System.Drawing.Size(946, 340);
            this.supplierGridControl.TabIndex = 0;
            // 
            // tabNaviPage_SanPham
            // 
            this.tabNaviPage_SanPham.Caption = "SẢN PHẨM";
            this.tabNaviPage_SanPham.Controls.Add(this.btt_EditProduct);
            this.tabNaviPage_SanPham.Controls.Add(this.btt_newProduct);
            this.tabNaviPage_SanPham.Controls.Add(this.productGridView);
            this.tabNaviPage_SanPham.Name = "tabNaviPage_SanPham";
            this.tabNaviPage_SanPham.Size = new System.Drawing.Size(953, 422);
            this.tabNaviPage_SanPham.VisibleChanged += new System.EventHandler(this.tabNavigationPage2_VisibleChanged);
            // 
            // btt_EditProduct
            // 
            this.btt_EditProduct.Image = ((System.Drawing.Image)(resources.GetObject("btt_EditProduct.Image")));
            this.btt_EditProduct.Location = new System.Drawing.Point(756, 360);
            this.btt_EditProduct.Name = "btt_EditProduct";
            this.btt_EditProduct.Size = new System.Drawing.Size(180, 50);
            this.btt_EditProduct.TabIndex = 2;
            this.btt_EditProduct.Text = "Thay đổi thông tin";
            this.btt_EditProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btt_EditProduct.UseVisualStyleBackColor = true;
            this.btt_EditProduct.Click += new System.EventHandler(this.button4_Click);
            // 
            // btt_newProduct
            // 
            this.btt_newProduct.Image = ((System.Drawing.Image)(resources.GetObject("btt_newProduct.Image")));
            this.btt_newProduct.Location = new System.Drawing.Point(557, 360);
            this.btt_newProduct.Name = "btt_newProduct";
            this.btt_newProduct.Size = new System.Drawing.Size(180, 50);
            this.btt_newProduct.TabIndex = 1;
            this.btt_newProduct.Text = "Thêm sản phẩm mới";
            this.btt_newProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btt_newProduct.UseVisualStyleBackColor = true;
            this.btt_newProduct.Click += new System.EventHandler(this.button3_Click);
            // 
            // productGridView
            // 
            this.productGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(4, 4);
            this.productGridView.Name = "productGridView";
            this.productGridView.Size = new System.Drawing.Size(946, 340);
            this.productGridView.TabIndex = 0;
            // 
            // tabNaviPage_KhachHang
            // 
            this.tabNaviPage_KhachHang.Caption = "KHÁCH HÀNG";
            this.tabNaviPage_KhachHang.Controls.Add(this.userGridView);
            this.tabNaviPage_KhachHang.Name = "tabNaviPage_KhachHang";
            this.tabNaviPage_KhachHang.Size = new System.Drawing.Size(953, 422);
            this.tabNaviPage_KhachHang.VisibleChanged += new System.EventHandler(this.Users_VisibleChanged);
            // 
            // userGridView
            // 
            this.userGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(4, 4);
            this.userGridView.Name = "userGridView";
            this.userGridView.Size = new System.Drawing.Size(946, 340);
            this.userGridView.TabIndex = 0;
            // 
            // tabNaviPage_DonHang
            // 
            this.tabNaviPage_DonHang.Caption = "ĐƠN HÀNG";
            this.tabNaviPage_DonHang.Controls.Add(this.btn_newBill);
            this.tabNaviPage_DonHang.Controls.Add(this.GridView_Bills);
            this.tabNaviPage_DonHang.Name = "tabNaviPage_DonHang";
            this.tabNaviPage_DonHang.Size = new System.Drawing.Size(953, 422);
            this.tabNaviPage_DonHang.VisibleChanged += new System.EventHandler(this.tabNavigationPage3_VisibleChanged);
            // 
            // btn_newBill
            // 
            this.btn_newBill.Image = ((System.Drawing.Image)(resources.GetObject("btn_newBill.Image")));
            this.btn_newBill.Location = new System.Drawing.Point(756, 359);
            this.btn_newBill.Name = "btn_newBill";
            this.btn_newBill.Size = new System.Drawing.Size(180, 50);
            this.btn_newBill.TabIndex = 1;
            this.btn_newBill.Text = "Chi tiết đơn hàng";
            this.btn_newBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_newBill.UseVisualStyleBackColor = true;
            this.btn_newBill.Click += new System.EventHandler(this.button7_Click);
            // 
            // GridView_Bills
            // 
            this.GridView_Bills.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.GridView_Bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Bills.Location = new System.Drawing.Point(4, 4);
            this.GridView_Bills.Name = "GridView_Bills";
            this.GridView_Bills.Size = new System.Drawing.Size(946, 340);
            this.GridView_Bills.TabIndex = 0;
            // 
            // tabNaviPage_NhapHang
            // 
            this.tabNaviPage_NhapHang.Caption = "NHẬP HÀNG";
            this.tabNaviPage_NhapHang.Controls.Add(this.btn_importProduct);
            this.tabNaviPage_NhapHang.Controls.Add(this.dataGridView2);
            this.tabNaviPage_NhapHang.Name = "tabNaviPage_NhapHang";
            this.tabNaviPage_NhapHang.Size = new System.Drawing.Size(953, 422);
            this.tabNaviPage_NhapHang.VisibleChanged += new System.EventHandler(this.tabNavigationPage4_VisibleChanged);
            // 
            // btn_importProduct
            // 
            this.btn_importProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_importProduct.Image")));
            this.btn_importProduct.Location = new System.Drawing.Point(806, 359);
            this.btn_importProduct.Name = "btn_importProduct";
            this.btn_importProduct.Size = new System.Drawing.Size(130, 50);
            this.btn_importProduct.TabIndex = 1;
            this.btn_importProduct.Text = "Nhập hàng";
            this.btn_importProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_importProduct.UseVisualStyleBackColor = true;
            this.btn_importProduct.Click += new System.EventHandler(this.button9_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(946, 340);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabNaviPage_GiaoHang
            // 
            this.tabNaviPage_GiaoHang.Caption = "NHÂN VIÊN GIAO HÀNG";
            this.tabNaviPage_GiaoHang.Controls.Add(this.btn_EditShipper);
            this.tabNaviPage_GiaoHang.Controls.Add(this.btn_InsertShipper);
            this.tabNaviPage_GiaoHang.Controls.Add(this.GridView_Shippers);
            this.tabNaviPage_GiaoHang.Name = "tabNaviPage_GiaoHang";
            this.tabNaviPage_GiaoHang.Size = new System.Drawing.Size(953, 422);
            this.tabNaviPage_GiaoHang.VisibleChanged += new System.EventHandler(this.tabNaviPage_Shipper_VisibleChanged);
            // 
            // btn_EditShipper
            // 
            this.btn_EditShipper.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditShipper.Image")));
            this.btn_EditShipper.Location = new System.Drawing.Point(752, 358);
            this.btn_EditShipper.Name = "btn_EditShipper";
            this.btn_EditShipper.Size = new System.Drawing.Size(180, 50);
            this.btn_EditShipper.TabIndex = 2;
            this.btn_EditShipper.Text = "Thay đổi thông tin";
            this.btn_EditShipper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EditShipper.UseVisualStyleBackColor = true;
            this.btn_EditShipper.Click += new System.EventHandler(this.btn_EditShipper_Click);
            // 
            // btn_InsertShipper
            // 
            this.btn_InsertShipper.Image = ((System.Drawing.Image)(resources.GetObject("btn_InsertShipper.Image")));
            this.btn_InsertShipper.Location = new System.Drawing.Point(555, 358);
            this.btn_InsertShipper.Name = "btn_InsertShipper";
            this.btn_InsertShipper.Size = new System.Drawing.Size(180, 50);
            this.btn_InsertShipper.TabIndex = 1;
            this.btn_InsertShipper.Text = "Thêm nhân viên giao hàng";
            this.btn_InsertShipper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_InsertShipper.UseVisualStyleBackColor = true;
            this.btn_InsertShipper.Click += new System.EventHandler(this.btn_InsertShipper_Click);
            // 
            // GridView_Shippers
            // 
            this.GridView_Shippers.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.GridView_Shippers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Shippers.Location = new System.Drawing.Point(4, 3);
            this.GridView_Shippers.Name = "GridView_Shippers";
            this.GridView_Shippers.Size = new System.Drawing.Size(946, 340);
            this.GridView_Shippers.TabIndex = 0;
            // 
            // tabNaviPage_LoaiSanPham
            // 
            this.tabNaviPage_LoaiSanPham.Caption = "LOẠI SẢN PHẨM";
            this.tabNaviPage_LoaiSanPham.Controls.Add(this.btn_EditProductType);
            this.tabNaviPage_LoaiSanPham.Controls.Add(this.btn_InsertProductType);
            this.tabNaviPage_LoaiSanPham.Controls.Add(this.GridView_ProductType);
            this.tabNaviPage_LoaiSanPham.Name = "tabNaviPage_LoaiSanPham";
            this.tabNaviPage_LoaiSanPham.Size = new System.Drawing.Size(953, 422);
            this.tabNaviPage_LoaiSanPham.VisibleChanged += new System.EventHandler(this.tabNaviPage_ProductType_VisibleChanged);
            // 
            // btn_EditProductType
            // 
            this.btn_EditProductType.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditProductType.Image")));
            this.btn_EditProductType.Location = new System.Drawing.Point(756, 356);
            this.btn_EditProductType.Name = "btn_EditProductType";
            this.btn_EditProductType.Size = new System.Drawing.Size(180, 50);
            this.btn_EditProductType.TabIndex = 2;
            this.btn_EditProductType.Text = "Thay đổi thông tin";
            this.btn_EditProductType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EditProductType.UseVisualStyleBackColor = true;
            this.btn_EditProductType.Click += new System.EventHandler(this.btn_EditProductType_Click);
            // 
            // btn_InsertProductType
            // 
            this.btn_InsertProductType.Image = ((System.Drawing.Image)(resources.GetObject("btn_InsertProductType.Image")));
            this.btn_InsertProductType.Location = new System.Drawing.Point(559, 356);
            this.btn_InsertProductType.Name = "btn_InsertProductType";
            this.btn_InsertProductType.Size = new System.Drawing.Size(180, 50);
            this.btn_InsertProductType.TabIndex = 1;
            this.btn_InsertProductType.Text = "Thêm loại sản phẩm mới";
            this.btn_InsertProductType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_InsertProductType.UseVisualStyleBackColor = true;
            this.btn_InsertProductType.Click += new System.EventHandler(this.btn_InsertProductType_Click);
            // 
            // GridView_ProductType
            // 
            this.GridView_ProductType.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.GridView_ProductType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_ProductType.Location = new System.Drawing.Point(4, 3);
            this.GridView_ProductType.Name = "GridView_ProductType";
            this.GridView_ProductType.Size = new System.Drawing.Size(946, 340);
            this.GridView_ProductType.TabIndex = 0;
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChangePass.Image")));
            this.btn_ChangePass.Location = new System.Drawing.Point(12, 485);
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.Size = new System.Drawing.Size(180, 50);
            this.btn_ChangePass.TabIndex = 1;
            this.btn_ChangePass.Text = "Thay đổi mật khẩu";
            this.btn_ChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ChangePass.UseVisualStyleBackColor = true;
            this.btn_ChangePass.Click += new System.EventHandler(this.btn_ChangePass_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 539);
            this.Controls.Add(this.btn_ChangePass);
            this.Controls.Add(this.tabPaneMainForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Gạo Ngon và Rẻ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneMainForm)).EndInit();
            this.tabPaneMainForm.ResumeLayout(false);
            this.tabNaviPage_NhaCungCap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridControl)).EndInit();
            this.tabNaviPage_SanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.tabNaviPage_KhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.tabNaviPage_DonHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Bills)).EndInit();
            this.tabNaviPage_NhapHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabNaviPage_GiaoHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Shippers)).EndInit();
            this.tabNaviPage_LoaiSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_ProductType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPaneMainForm;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_NhaCungCap;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_SanPham;
        private System.Windows.Forms.DataGridView supplierGridControl;
        private System.Windows.Forms.Button btt_EditSupplier;
        private System.Windows.Forms.Button btt_newSupplier;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Button btt_newProduct;
        private System.Windows.Forms.Button btt_EditProduct;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_KhachHang;
        private System.Windows.Forms.DataGridView userGridView;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_DonHang;
        private System.Windows.Forms.DataGridView GridView_Bills;
        private System.Windows.Forms.Button btn_newBill;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_NhapHang;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_importProduct;
        private System.Windows.Forms.Button btn_ChangePass;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_GiaoHang;
        private System.Windows.Forms.Button btn_EditShipper;
        private System.Windows.Forms.Button btn_InsertShipper;
        private System.Windows.Forms.DataGridView GridView_Shippers;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_LoaiSanPham;
        private System.Windows.Forms.Button btn_EditProductType;
        private System.Windows.Forms.Button btn_InsertProductType;
        private System.Windows.Forms.DataGridView GridView_ProductType;
        private System.Windows.Forms.Button btn_RefreshDataSupplier;
    }
}