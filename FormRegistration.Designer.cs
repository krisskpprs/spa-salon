namespace spa_salon
{
    partial class FormRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.DataOfBirth = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textDataOfBirth = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(141, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "РЕГИСТРАЦИЯ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(102, 122);
            this.FirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 18);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "FirstName";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(102, 161);
            this.LastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(96, 18);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "LastName";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(102, 247);
            this.Phone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(65, 18);
            this.Phone.TabIndex = 3;
            this.Phone.Text = "Phone";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(102, 294);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(59, 18);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(103, 337);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(99, 18);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            // 
            // DataOfBirth
            // 
            this.DataOfBirth.AutoSize = true;
            this.DataOfBirth.Location = new System.Drawing.Point(102, 204);
            this.DataOfBirth.Name = "DataOfBirth";
            this.DataOfBirth.Size = new System.Drawing.Size(126, 18);
            this.DataOfBirth.TabIndex = 6;
            this.DataOfBirth.Text = "DataOfBirth";
            // 
            // textFirstName
            // 
            this.textFirstName.BackColor = System.Drawing.Color.MistyRose;
            this.textFirstName.Location = new System.Drawing.Point(256, 119);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(238, 26);
            this.textFirstName.TabIndex = 7;
            this.textFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textLastName
            // 
            this.textLastName.BackColor = System.Drawing.Color.MistyRose;
            this.textLastName.Location = new System.Drawing.Point(256, 158);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(238, 26);
            this.textLastName.TabIndex = 8;
            // 
            // textDataOfBirth
            // 
            this.textDataOfBirth.BackColor = System.Drawing.Color.MistyRose;
            this.textDataOfBirth.Location = new System.Drawing.Point(256, 204);
            this.textDataOfBirth.Name = "textDataOfBirth";
            this.textDataOfBirth.Size = new System.Drawing.Size(238, 26);
            this.textDataOfBirth.TabIndex = 9;
            // 
            // textPhone
            // 
            this.textPhone.BackColor = System.Drawing.Color.MistyRose;
            this.textPhone.Location = new System.Drawing.Point(256, 244);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(238, 26);
            this.textPhone.TabIndex = 10;
            // 
            // textLogin
            // 
            this.textLogin.BackColor = System.Drawing.Color.MistyRose;
            this.textLogin.Location = new System.Drawing.Point(256, 286);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(238, 26);
            this.textLogin.TabIndex = 11;
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.MistyRose;
            this.textPassword.Location = new System.Drawing.Point(256, 337);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(238, 26);
            this.textPassword.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(240, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Зарегестрироваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(612, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textDataOfBirth);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.DataOfBirth);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FormRegistration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label DataOfBirth;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textDataOfBirth;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button button1;
    }
}