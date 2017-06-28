namespace Winform_ShopGao
{
    partial class NewBillForm
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
            this.cmbB_Customer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateEdit_OrderDate = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB_Total = new System.Windows.Forms.TextBox();
            this.txtB_Address = new System.Windows.Forms.TextBox();
            this.rtxtB_Note = new System.Windows.Forms.RichTextBox();
            this.txtB_Status = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btt_Create = new System.Windows.Forms.Button();
            this.btt_Exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateEdit_ExpOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtB_District = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtB_City = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ExpOrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ExpOrderDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbB_Customer
            // 
            this.cmbB_Customer.FormattingEnabled = true;
            this.cmbB_Customer.Location = new System.Drawing.Point(108, 28);
            this.cmbB_Customer.Name = "cmbB_Customer";
            this.cmbB_Customer.Size = new System.Drawing.Size(121, 21);
            this.cmbB_Customer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // dateEdit_OrderDate
            // 
            this.dateEdit_OrderDate.EditValue = null;
            this.dateEdit_OrderDate.Location = new System.Drawing.Point(319, 29);
            this.dateEdit_OrderDate.Name = "dateEdit_OrderDate";
            this.dateEdit_OrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_OrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_OrderDate.Size = new System.Drawing.Size(100, 20);
            this.dateEdit_OrderDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "OrderDate";
            // 
            // txtB_Total
            // 
            this.txtB_Total.Location = new System.Drawing.Point(565, 69);
            this.txtB_Total.Name = "txtB_Total";
            this.txtB_Total.Size = new System.Drawing.Size(100, 20);
            this.txtB_Total.TabIndex = 5;
            this.txtB_Total.Text = "10";
            // 
            // txtB_Address
            // 
            this.txtB_Address.Location = new System.Drawing.Point(108, 69);
            this.txtB_Address.Name = "txtB_Address";
            this.txtB_Address.Size = new System.Drawing.Size(100, 20);
            this.txtB_Address.TabIndex = 6;
            this.txtB_Address.Text = "address";
            // 
            // rtxtB_Note
            // 
            this.rtxtB_Note.Location = new System.Drawing.Point(54, 132);
            this.rtxtB_Note.Name = "rtxtB_Note";
            this.rtxtB_Note.Size = new System.Drawing.Size(340, 96);
            this.rtxtB_Note.TabIndex = 7;
            this.rtxtB_Note.Text = "note";
            // 
            // txtB_Status
            // 
            this.txtB_Status.Location = new System.Drawing.Point(565, 117);
            this.txtB_Status.Name = "txtB_Status";
            this.txtB_Status.Size = new System.Drawing.Size(100, 20);
            this.txtB_Status.TabIndex = 8;
            this.txtB_Status.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "status";
            // 
            // btt_Create
            // 
            this.btt_Create.Location = new System.Drawing.Point(861, 195);
            this.btt_Create.Name = "btt_Create";
            this.btt_Create.Size = new System.Drawing.Size(75, 23);
            this.btt_Create.TabIndex = 12;
            this.btt_Create.Text = "Create";
            this.btt_Create.UseVisualStyleBackColor = true;
            this.btt_Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // btt_Exit
            // 
            this.btt_Exit.Location = new System.Drawing.Point(725, 195);
            this.btt_Exit.Name = "btt_Exit";
            this.btt_Exit.Size = new System.Drawing.Size(75, 23);
            this.btt_Exit.TabIndex = 13;
            this.btt_Exit.Text = "Exit";
            this.btt_Exit.UseVisualStyleBackColor = true;
            this.btt_Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Expected Order Date";
            // 
            // dateEdit_ExpOrderDate
            // 
            this.dateEdit_ExpOrderDate.EditValue = null;
            this.dateEdit_ExpOrderDate.Location = new System.Drawing.Point(565, 28);
            this.dateEdit_ExpOrderDate.Name = "dateEdit_ExpOrderDate";
            this.dateEdit_ExpOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_ExpOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_ExpOrderDate.Size = new System.Drawing.Size(100, 20);
            this.dateEdit_ExpOrderDate.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "district";
            // 
            // txtB_District
            // 
            this.txtB_District.Location = new System.Drawing.Point(267, 69);
            this.txtB_District.Name = "txtB_District";
            this.txtB_District.Size = new System.Drawing.Size(100, 20);
            this.txtB_District.TabIndex = 17;
            this.txtB_District.Text = "district";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "city";
            // 
            // txtB_City
            // 
            this.txtB_City.Location = new System.Drawing.Point(415, 69);
            this.txtB_City.Name = "txtB_City";
            this.txtB_City.Size = new System.Drawing.Size(100, 20);
            this.txtB_City.TabIndex = 19;
            this.txtB_City.Text = "city";
            // 
            // NewBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 261);
            this.Controls.Add(this.txtB_City);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtB_District);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateEdit_ExpOrderDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btt_Exit);
            this.Controls.Add(this.btt_Create);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB_Status);
            this.Controls.Add(this.rtxtB_Note);
            this.Controls.Add(this.txtB_Address);
            this.Controls.Add(this.txtB_Total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateEdit_OrderDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbB_Customer);
            this.Name = "NewBillForm";
            this.Text = "NewBillForm";
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_OrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ExpOrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ExpOrderDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbB_Customer;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dateEdit_OrderDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_Total;
        private System.Windows.Forms.TextBox txtB_Address;
        private System.Windows.Forms.RichTextBox rtxtB_Note;
        private System.Windows.Forms.TextBox txtB_Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btt_Create;
        private System.Windows.Forms.Button btt_Exit;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dateEdit_ExpOrderDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtB_District;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtB_City;
    }
}