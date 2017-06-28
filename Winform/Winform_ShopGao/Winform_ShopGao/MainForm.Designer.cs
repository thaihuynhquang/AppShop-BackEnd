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
            this.tabPaneMainForm = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNaviPage_NhaCungCap = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btt_DelSupplier = new System.Windows.Forms.Button();
            this.btt_EditSupplier = new System.Windows.Forms.Button();
            this.btt_newSupplier = new System.Windows.Forms.Button();
            this.supplierGridControl = new System.Windows.Forms.DataGridView();
            this.tabNaviPage_SanPham = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btt_EditProduct = new System.Windows.Forms.Button();
            this.btt_newProduct = new System.Windows.Forms.Button();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.tabNaviPage_KhachHang = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btt_newUser = new System.Windows.Forms.Button();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.tabNaviPage_DonHang = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_newBill = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabNaviPage_NhapHang = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_importProduct = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneMainForm)).BeginInit();
            this.tabPaneMainForm.SuspendLayout();
            this.tabNaviPage_NhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridControl)).BeginInit();
            this.tabNaviPage_SanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.tabNaviPage_KhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.tabNaviPage_DonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabNaviPage_NhapHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPaneMainForm
            // 
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_NhaCungCap);
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_SanPham);
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_KhachHang);
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_DonHang);
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_NhapHang);
            this.tabPaneMainForm.Location = new System.Drawing.Point(12, 12);
            this.tabPaneMainForm.Name = "tabPaneMainForm";
            this.tabPaneMainForm.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNaviPage_NhaCungCap,
            this.tabNaviPage_SanPham,
            this.tabNaviPage_KhachHang,
            this.tabNaviPage_DonHang,
            this.tabNaviPage_NhapHang});
            this.tabPaneMainForm.RegularSize = new System.Drawing.Size(971, 480);
            this.tabPaneMainForm.SelectedPage = this.tabNaviPage_SanPham;
            this.tabPaneMainForm.Size = new System.Drawing.Size(971, 480);
            this.tabPaneMainForm.TabIndex = 0;
            this.tabPaneMainForm.Text = "asdas";
            this.tabPaneMainForm.Click += new System.EventHandler(this.tabPane1_Click);
            // 
            // tabNaviPage_NhaCungCap
            // 
            this.tabNaviPage_NhaCungCap.Caption = "NHÀ CUNG CẤP";
            this.tabNaviPage_NhaCungCap.Controls.Add(this.btt_DelSupplier);
            this.tabNaviPage_NhaCungCap.Controls.Add(this.btt_EditSupplier);
            this.tabNaviPage_NhaCungCap.Controls.Add(this.btt_newSupplier);
            this.tabNaviPage_NhaCungCap.Controls.Add(this.supplierGridControl);
            this.tabNaviPage_NhaCungCap.Name = "tabNaviPage_NhaCungCap";
            this.tabNaviPage_NhaCungCap.Size = new System.Drawing.Size(953, 435);
            // 
            // btt_DelSupplier
            // 
            this.btt_DelSupplier.Location = new System.Drawing.Point(336, 366);
            this.btt_DelSupplier.Name = "btt_DelSupplier";
            this.btt_DelSupplier.Size = new System.Drawing.Size(162, 34);
            this.btt_DelSupplier.TabIndex = 3;
            this.btt_DelSupplier.Text = "Xóa nhà cung cấp";
            this.btt_DelSupplier.UseVisualStyleBackColor = true;
            this.btt_DelSupplier.Click += new System.EventHandler(this.button1_Click);
            // 
            // btt_EditSupplier
            // 
            this.btt_EditSupplier.Location = new System.Drawing.Point(520, 366);
            this.btt_EditSupplier.Name = "btt_EditSupplier";
            this.btt_EditSupplier.Size = new System.Drawing.Size(165, 34);
            this.btt_EditSupplier.TabIndex = 2;
            this.btt_EditSupplier.Text = "Thay đổi thông tin";
            this.btt_EditSupplier.UseVisualStyleBackColor = true;
            this.btt_EditSupplier.Click += new System.EventHandler(this.button2_Click);
            // 
            // btt_newSupplier
            // 
            this.btt_newSupplier.Location = new System.Drawing.Point(707, 366);
            this.btt_newSupplier.Name = "btt_newSupplier";
            this.btt_newSupplier.Size = new System.Drawing.Size(165, 34);
            this.btt_newSupplier.TabIndex = 1;
            this.btt_newSupplier.Text = "Thêm nhà cung cấp";
            this.btt_newSupplier.UseVisualStyleBackColor = true;
            this.btt_newSupplier.Click += new System.EventHandler(this.newSupp_Click);
            // 
            // supplierGridControl
            // 
            this.supplierGridControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierGridControl.Location = new System.Drawing.Point(4, 4);
            this.supplierGridControl.Name = "supplierGridControl";
            this.supplierGridControl.Size = new System.Drawing.Size(946, 333);
            this.supplierGridControl.TabIndex = 0;
            // 
            // tabNaviPage_SanPham
            // 
            this.tabNaviPage_SanPham.Caption = "SẢN PHẨM";
            this.tabNaviPage_SanPham.Controls.Add(this.btt_EditProduct);
            this.tabNaviPage_SanPham.Controls.Add(this.btt_newProduct);
            this.tabNaviPage_SanPham.Controls.Add(this.productGridView);
            this.tabNaviPage_SanPham.Name = "tabNaviPage_SanPham";
            this.tabNaviPage_SanPham.Size = new System.Drawing.Size(953, 435);
            this.tabNaviPage_SanPham.VisibleChanged += new System.EventHandler(this.tabNavigationPage2_VisibleChanged);
            // 
            // btt_EditProduct
            // 
            this.btt_EditProduct.Location = new System.Drawing.Point(695, 360);
            this.btt_EditProduct.Name = "btt_EditProduct";
            this.btt_EditProduct.Size = new System.Drawing.Size(173, 34);
            this.btt_EditProduct.TabIndex = 2;
            this.btt_EditProduct.Text = "Thay đổi thông tin";
            this.btt_EditProduct.UseVisualStyleBackColor = true;
            this.btt_EditProduct.Click += new System.EventHandler(this.button4_Click);
            // 
            // btt_newProduct
            // 
            this.btt_newProduct.Location = new System.Drawing.Point(464, 360);
            this.btt_newProduct.Name = "btt_newProduct";
            this.btt_newProduct.Size = new System.Drawing.Size(173, 34);
            this.btt_newProduct.TabIndex = 1;
            this.btt_newProduct.Text = "Thêm sản phẩm mới";
            this.btt_newProduct.UseVisualStyleBackColor = true;
            this.btt_newProduct.Click += new System.EventHandler(this.button3_Click);
            // 
            // productGridView
            // 
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(4, 4);
            this.productGridView.Name = "productGridView";
            this.productGridView.Size = new System.Drawing.Size(946, 334);
            this.productGridView.TabIndex = 0;
            // 
            // tabNaviPage_KhachHang
            // 
            this.tabNaviPage_KhachHang.Caption = "KHÁCH HÀNG";
            this.tabNaviPage_KhachHang.Controls.Add(this.btn_Edit);
            this.tabNaviPage_KhachHang.Controls.Add(this.btt_newUser);
            this.tabNaviPage_KhachHang.Controls.Add(this.userGridView);
            this.tabNaviPage_KhachHang.Name = "tabNaviPage_KhachHang";
            this.tabNaviPage_KhachHang.Size = new System.Drawing.Size(953, 435);
            this.tabNaviPage_KhachHang.VisibleChanged += new System.EventHandler(this.Users_VisibleChanged);
            this.tabNaviPage_KhachHang.Click += new System.EventHandler(this.Users_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(568, 354);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(133, 35);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Thay đổi thông tin";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btt_newUser
            // 
            this.btt_newUser.Location = new System.Drawing.Point(730, 354);
            this.btt_newUser.Name = "btt_newUser";
            this.btt_newUser.Size = new System.Drawing.Size(133, 35);
            this.btt_newUser.TabIndex = 1;
            this.btt_newUser.Text = "Thêm khách hàng";
            this.btt_newUser.UseVisualStyleBackColor = true;
            this.btt_newUser.Click += new System.EventHandler(this.button5_Click);
            // 
            // userGridView
            // 
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(4, 4);
            this.userGridView.Name = "userGridView";
            this.userGridView.Size = new System.Drawing.Size(946, 333);
            this.userGridView.TabIndex = 0;
            // 
            // tabNaviPage_DonHang
            // 
            this.tabNaviPage_DonHang.Caption = "ĐƠN HÀNG";
            this.tabNaviPage_DonHang.Controls.Add(this.button8);
            this.tabNaviPage_DonHang.Controls.Add(this.btn_newBill);
            this.tabNaviPage_DonHang.Controls.Add(this.dataGridView1);
            this.tabNaviPage_DonHang.Name = "tabNaviPage_DonHang";
            this.tabNaviPage_DonHang.Size = new System.Drawing.Size(953, 435);
            this.tabNaviPage_DonHang.VisibleChanged += new System.EventHandler(this.tabNavigationPage3_VisibleChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(539, 357);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Detail bill";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_newBill
            // 
            this.btn_newBill.Location = new System.Drawing.Point(670, 357);
            this.btn_newBill.Name = "btn_newBill";
            this.btn_newBill.Size = new System.Drawing.Size(75, 23);
            this.btn_newBill.TabIndex = 1;
            this.btn_newBill.Text = "Thêm đơn hàng";
            this.btn_newBill.UseVisualStyleBackColor = true;
            this.btn_newBill.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(946, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabNaviPage_NhapHang
            // 
            this.tabNaviPage_NhapHang.Caption = "NHẬP HÀNG";
            this.tabNaviPage_NhapHang.Controls.Add(this.btn_importProduct);
            this.tabNaviPage_NhapHang.Controls.Add(this.dataGridView2);
            this.tabNaviPage_NhapHang.Name = "tabNaviPage_NhapHang";
            this.tabNaviPage_NhapHang.Size = new System.Drawing.Size(953, 435);
            this.tabNaviPage_NhapHang.VisibleChanged += new System.EventHandler(this.tabNavigationPage4_VisibleChanged);
            // 
            // btn_importProduct
            // 
            this.btn_importProduct.Location = new System.Drawing.Point(569, 353);
            this.btn_importProduct.Name = "btn_importProduct";
            this.btn_importProduct.Size = new System.Drawing.Size(118, 36);
            this.btn_importProduct.TabIndex = 1;
            this.btn_importProduct.Text = "Nhập hàng";
            this.btn_importProduct.UseVisualStyleBackColor = true;
            this.btn_importProduct.Click += new System.EventHandler(this.button9_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(946, 334);
            this.dataGridView2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 501);
            this.Controls.Add(this.tabPaneMainForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabNaviPage_NhapHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPaneMainForm;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_NhaCungCap;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_SanPham;
        private System.Windows.Forms.DataGridView supplierGridControl;
        private System.Windows.Forms.Button btt_EditSupplier;
        private System.Windows.Forms.Button btt_newSupplier;
        private System.Windows.Forms.Button btt_DelSupplier;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Button btt_newProduct;
        private System.Windows.Forms.Button btt_EditProduct;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_KhachHang;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btt_newUser;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_DonHang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_newBill;
        private System.Windows.Forms.Button button8;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_NhapHang;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_importProduct;
    }
}