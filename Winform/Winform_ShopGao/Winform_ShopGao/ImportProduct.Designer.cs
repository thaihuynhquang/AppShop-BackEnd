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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb_TenNCC = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lb_TenSP = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_DonGIa = new System.Windows.Forms.Label();
            this.lb_SL = new System.Windows.Forms.Label();
            this.btn_importProduct = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(222, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 0;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(222, 78);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(219, 21);
            this.comboBox2.TabIndex = 2;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "10";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(222, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "10";
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
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_TenSP);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lb_TenNCC);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImportProduct";
            this.Text = "Nhập hàng";
            this.Load += new System.EventHandler(this.ImportProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lb_TenNCC;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lb_TenSP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lb_DonGIa;
        private System.Windows.Forms.Label lb_SL;
        private System.Windows.Forms.Button btn_importProduct;
        private System.Windows.Forms.Button btn_Exit;
    }
}