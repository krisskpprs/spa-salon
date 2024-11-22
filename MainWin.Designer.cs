namespace spa_salon
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
            this.voiti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textlogin = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zabililogin = new System.Windows.Forms.LinkLabel();
            this.registracia = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // voiti
            // 
            this.voiti.ForeColor = System.Drawing.Color.Black;
            this.voiti.Location = new System.Drawing.Point(354, 291);
            this.voiti.Name = "voiti";
            this.voiti.Size = new System.Drawing.Size(96, 27);
            this.voiti.TabIndex = 0;
            this.voiti.Text = "Войти";
            this.voiti.UseVisualStyleBackColor = true;
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
            // zabililogin
            // 
            this.zabililogin.AutoSize = true;
            this.zabililogin.LinkColor = System.Drawing.Color.Black;
            this.zabililogin.Location = new System.Drawing.Point(228, 323);
            this.zabililogin.Name = "zabililogin";
            this.zabililogin.Size = new System.Drawing.Size(91, 13);
            this.zabililogin.TabIndex = 8;
            this.zabililogin.TabStop = true;
            this.zabililogin.Text = "Забыли пароль?";
            // 
            // registracia
            // 
            this.registracia.AutoSize = true;
            this.registracia.LinkColor = System.Drawing.Color.Black;
            this.registracia.Location = new System.Drawing.Point(491, 323);
            this.registracia.Name = "registracia";
            this.registracia.Size = new System.Drawing.Size(72, 13);
            this.registracia.TabIndex = 9;
            this.registracia.TabStop = true;
            this.registracia.Text = "Регистрация";
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registracia);
            this.Controls.Add(this.zabililogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.voiti);
            this.Name = "MainWin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voiti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textlogin;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel zabililogin;
        private System.Windows.Forms.LinkLabel registracia;
    }
}

