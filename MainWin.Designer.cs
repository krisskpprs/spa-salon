﻿namespace spa_salon
{
    partial class MainWin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnvoiti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textlogin = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.registration = new System.Windows.Forms.LinkLabel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnvoiti
            // 
            this.btnvoiti.ForeColor = System.Drawing.Color.Black;
            this.btnvoiti.Location = new System.Drawing.Point(354, 291);
            this.btnvoiti.Name = "btnvoiti";
            this.btnvoiti.Size = new System.Drawing.Size(96, 27);
            this.btnvoiti.TabIndex = 0;
            this.btnvoiti.Text = "Войти";
            this.btnvoiti.UseVisualStyleBackColor = true;
            this.btnvoiti.Click += new System.EventHandler(this.btnvoiti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spa-salon";
            // 
            // textlogin
            // 
            this.textlogin.Location = new System.Drawing.Point(324, 208);
            this.textlogin.Name = "textlogin";
            this.textlogin.Size = new System.Drawing.Size(239, 20);
            this.textlogin.TabIndex = 2;
            this.textlogin.TextChanged += new System.EventHandler(this.textlogin_TextChanged);
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(324, 250);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(239, 20);
            this.textpassword.TabIndex = 3;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(260, 208);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(58, 17);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.Click += new System.EventHandler(this.label2_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(228, 250);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(90, 17);
            this.password.TabIndex = 5;
            this.password.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(285, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Авторизация";
            // 
            // registration
            // 
            this.registration.AutoSize = true;
            this.registration.LinkColor = System.Drawing.Color.Black;
            this.registration.Location = new System.Drawing.Point(366, 334);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(72, 13);
            this.registration.TabIndex = 9;
            this.registration.TabStop = true;
            this.registration.Text = "Регистрация";
            this.registration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registration_LinkClicked);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(574, 230);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvoiti);
            this.Name = "MainWin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoiti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textlogin;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel registration;
        private System.Windows.Forms.Label lblMessage;
    }
}

