namespace Winform_ShopGao
{
    partial class LoginForm
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
            this.btt_SignIn = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.txtB_Username = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.txtB_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btt_SignIn
            // 
            this.btt_SignIn.Location = new System.Drawing.Point(144, 135);
            this.btt_SignIn.Name = "btt_SignIn";
            this.btt_SignIn.Size = new System.Drawing.Size(125, 36);
            this.btt_SignIn.TabIndex = 0;
            this.btt_SignIn.Text = "Đăng Nhập";
            this.btt_SignIn.UseVisualStyleBackColor = true;
            this.btt_SignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(34, 45);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(81, 13);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Tên đăng nhập";
            // 
            // txtB_Username
            // 
            this.txtB_Username.Location = new System.Drawing.Point(131, 38);
            this.txtB_Username.Name = "txtB_Username";
            this.txtB_Username.Size = new System.Drawing.Size(163, 20);
            this.txtB_Username.TabIndex = 2;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(63, 91);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(52, 13);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Mặt khẩu";
            // 
            // txtB_Password
            // 
            this.txtB_Password.Location = new System.Drawing.Point(131, 84);
            this.txtB_Password.Name = "txtB_Password";
            this.txtB_Password.PasswordChar = '*';
            this.txtB_Password.Size = new System.Drawing.Size(163, 20);
            this.txtB_Password.TabIndex = 4;
            this.txtB_Password.Text = "123";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 199);
            this.Controls.Add(this.txtB_Password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.txtB_Username);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.btt_SignIn);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt_SignIn;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox txtB_Username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox txtB_Password;
    }
}

