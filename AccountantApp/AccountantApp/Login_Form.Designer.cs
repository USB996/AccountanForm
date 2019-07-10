namespace AccountantApp
{
    partial class AccountantApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantApp));
            this.UsrNm_bx = new System.Windows.Forms.TextBox();
            this.Password_bx = new System.Windows.Forms.TextBox();
            this.Username_Label = new System.Windows.Forms.Label();
            this.PassWord_Label = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Error_label = new System.Windows.Forms.Label();
            this.Register_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsrNm_bx
            // 
            this.UsrNm_bx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsrNm_bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrNm_bx.Location = new System.Drawing.Point(109, 281);
            this.UsrNm_bx.Margin = new System.Windows.Forms.Padding(30);
            this.UsrNm_bx.Multiline = true;
            this.UsrNm_bx.Name = "UsrNm_bx";
            this.UsrNm_bx.Size = new System.Drawing.Size(281, 30);
            this.UsrNm_bx.TabIndex = 1;
            this.UsrNm_bx.TextChanged += new System.EventHandler(this.UsrNm_bx_TextChanged);
            // 
            // Password_bx
            // 
            this.Password_bx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_bx.Location = new System.Drawing.Point(109, 348);
            this.Password_bx.Multiline = true;
            this.Password_bx.Name = "Password_bx";
            this.Password_bx.Size = new System.Drawing.Size(281, 30);
            this.Password_bx.TabIndex = 2;
            this.Password_bx.UseSystemPasswordChar = true;
            this.Password_bx.TextChanged += new System.EventHandler(this.Password_bx_TextChanged);
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Label.Location = new System.Drawing.Point(12, 280);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(88, 22);
            this.Username_Label.TabIndex = 3;
            this.Username_Label.Text = "User Name:";
            // 
            // PassWord_Label
            // 
            this.PassWord_Label.AutoSize = true;
            this.PassWord_Label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWord_Label.Location = new System.Drawing.Point(12, 348);
            this.PassWord_Label.Name = "PassWord_Label";
            this.PassWord_Label.Size = new System.Drawing.Size(72, 22);
            this.PassWord_Label.TabIndex = 4;
            this.PassWord_Label.Text = "Password";
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.White;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Login_btn.Location = new System.Drawing.Point(128, 459);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(243, 40);
            this.Login_btn.TabIndex = 5;
            this.Login_btn.Text = "Log In";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Error_label
            // 
            this.Error_label.AutoSize = true;
            this.Error_label.Font = new System.Drawing.Font("Sylfaen", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_label.ForeColor = System.Drawing.Color.DarkRed;
            this.Error_label.Location = new System.Drawing.Point(120, 229);
            this.Error_label.Name = "Error_label";
            this.Error_label.Size = new System.Drawing.Size(258, 22);
            this.Error_label.TabIndex = 6;
            this.Error_label.Text = "Incorrect User Name Or Password";
            this.Error_label.Visible = false;
            // 
            // Register_label
            // 
            this.Register_label.AutoSize = true;
            this.Register_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_label.ForeColor = System.Drawing.Color.DimGray;
            this.Register_label.Location = new System.Drawing.Point(217, 413);
            this.Register_label.Name = "Register_label";
            this.Register_label.Size = new System.Drawing.Size(64, 22);
            this.Register_label.TabIndex = 7;
            this.Register_label.Text = "Register";
            this.Register_label.Click += new System.EventHandler(this.Register_label_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AccountantApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 548);
            this.Controls.Add(this.Register_label);
            this.Controls.Add(this.Error_label);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.PassWord_Label);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.Password_bx);
            this.Controls.Add(this.UsrNm_bx);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountantApp";
            this.Text = "Accountantapp_LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox UsrNm_bx;
        private System.Windows.Forms.TextBox Password_bx;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label PassWord_Label;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Label Error_label;
        private System.Windows.Forms.Label Register_label;
    }
}

