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
            this.btnvoiti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textlogin = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.registration = new System.Windows.Forms.LinkLabel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnvoiti
            // 
            this.btnvoiti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(119)))));
            this.btnvoiti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoiti.ForeColor = System.Drawing.Color.Transparent;
            this.btnvoiti.Location = new System.Drawing.Point(718, 563);
            this.btnvoiti.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnvoiti.Name = "btnvoiti";
            this.btnvoiti.Size = new System.Drawing.Size(192, 52);
            this.btnvoiti.TabIndex = 0;
            this.btnvoiti.Text = "Войти";
            this.btnvoiti.UseVisualStyleBackColor = false;
            this.btnvoiti.Click += new System.EventHandler(this.btnvoiti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(119)))));
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(534, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 115);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spa-salon";
            // 
            // textlogin
            // 
            this.textlogin.Location = new System.Drawing.Point(648, 400);
            this.textlogin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textlogin.Name = "textlogin";
            this.textlogin.Size = new System.Drawing.Size(474, 31);
            this.textlogin.TabIndex = 2;
            this.textlogin.TextChanged += new System.EventHandler(this.textlogin_TextChanged);
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(648, 481);
            this.textpassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(474, 31);
            this.textpassword.TabIndex = 3;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login.Location = new System.Drawing.Point(520, 400);
            this.login.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(119, 36);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.Click += new System.EventHandler(this.label2_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.password.Location = new System.Drawing.Point(438, 481);
            this.password.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(194, 36);
            this.password.TabIndex = 5;
            this.password.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Yu Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(548, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(566, 62);
            this.label4.TabIndex = 7;
            this.label4.Text = "Авторизация";
            // 
            // registration
            // 
            this.registration.AutoSize = true;
            this.registration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registration.LinkColor = System.Drawing.Color.Black;
            this.registration.Location = new System.Drawing.Point(712, 658);
            this.registration.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(204, 25);
            this.registration.TabIndex = 9;
            this.registration.TabStop = true;
            this.registration.Text = "Еще нет аккаунта?";
            this.registration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registration_LinkClicked);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(1148, 442);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 25);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(119)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-6, -10);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1618, 256);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::spa_salon.Properties.Resources.bambuk_98hcmr5dzry8_512;
            this.panel2.Location = new System.Drawing.Point(43, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 240);
            this.panel2.TabIndex = 0;
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1602, 835);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvoiti);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainWin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWin_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

