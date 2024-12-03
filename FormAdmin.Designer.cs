namespace spa_salon
{
    partial class FormAdmin
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
            this.dgv_usluga = new System.Windows.Forms.DataGridView();
            this.buttondobav = new System.Windows.Forms.Button();
            this.buttonizmenit = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.label_price = new System.Windows.Forms.Label();
            this.buttonzapis = new System.Windows.Forms.Button();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.labelsearch = new System.Windows.Forms.Label();
            this.dgv_usluga2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textsearch2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gd_products = new System.Windows.Forms.GroupBox();
            this.gb_uslugi = new System.Windows.Forms.GroupBox();
            this.button_uslugi = new System.Windows.Forms.Button();
            this.button_products = new System.Windows.Forms.Button();
            this.dgv_reviews = new System.Windows.Forms.DataGridView();
            this.gb_reviews = new System.Windows.Forms.GroupBox();
            this.button_reviews = new System.Windows.Forms.Button();
            this.gb_employees = new System.Windows.Forms.GroupBox();
            this.dgv_employees = new System.Windows.Forms.DataGridView();
            this.button_dobav = new System.Windows.Forms.Button();
            this.button_izm = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.textsearch4 = new System.Windows.Forms.TextBox();
            this.label_search = new System.Windows.Forms.Label();
            this.button_employees = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usluga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usluga2)).BeginInit();
            this.gd_products.SuspendLayout();
            this.gb_uslugi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reviews)).BeginInit();
            this.gb_reviews.SuspendLayout();
            this.gb_employees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_usluga
            // 
            this.dgv_usluga.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_usluga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usluga.Location = new System.Drawing.Point(6, 20);
            this.dgv_usluga.Name = "dgv_usluga";
            this.dgv_usluga.Size = new System.Drawing.Size(425, 231);
            this.dgv_usluga.TabIndex = 0;
            this.dgv_usluga.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usluga_CellClick);
            // 
            // buttondobav
            // 
            this.buttondobav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
            this.buttondobav.Location = new System.Drawing.Point(438, 20);
            this.buttondobav.Name = "buttondobav";
            this.buttondobav.Size = new System.Drawing.Size(75, 23);
            this.buttondobav.TabIndex = 1;
            this.buttondobav.Text = "Добавить";
            this.buttondobav.UseVisualStyleBackColor = false;
            // 
            // buttonizmenit
            // 
            this.buttonizmenit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
            this.buttonizmenit.Location = new System.Drawing.Point(438, 49);
            this.buttonizmenit.Name = "buttonizmenit";
            this.buttonizmenit.Size = new System.Drawing.Size(75, 23);
            this.buttonizmenit.TabIndex = 2;
            this.buttonizmenit.Text = "Изменить";
            this.buttonizmenit.UseVisualStyleBackColor = false;
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
            this.buttondelete.Location = new System.Drawing.Point(438, 78);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 23);
            this.buttondelete.TabIndex = 3;
            this.buttondelete.Text = "Удалить";
            this.buttondelete.UseVisualStyleBackColor = false;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_price.Location = new System.Drawing.Point(453, 190);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(60, 17);
            this.label_price.TabIndex = 0;
            this.label_price.Text = "Цена";
            // 
            // buttonzapis
            // 
            this.buttonzapis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
            this.buttonzapis.Location = new System.Drawing.Point(439, 213);
            this.buttonzapis.Name = "buttonzapis";
            this.buttonzapis.Size = new System.Drawing.Size(92, 38);
            this.buttonzapis.TabIndex = 5;
            this.buttonzapis.Text = "Записаться";
            this.buttonzapis.UseVisualStyleBackColor = false;
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(439, 108);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(74, 20);
            this.textsearch.TabIndex = 5;
            this.textsearch.TextChanged += new System.EventHandler(this.textsearch_TextChanged);
            // 
            // labelsearch
            // 
            this.labelsearch.AutoSize = true;
            this.labelsearch.Location = new System.Drawing.Point(456, 131);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(39, 13);
            this.labelsearch.TabIndex = 6;
            this.labelsearch.Text = "Поиск";
            this.labelsearch.Click += new System.EventHandler(this.labelsearch_Click);
            // 
            // dgv_usluga2
            // 
            this.dgv_usluga2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_usluga2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usluga2.Location = new System.Drawing.Point(2, 20);
            this.dgv_usluga2.Name = "dgv_usluga2";
            this.dgv_usluga2.Size = new System.Drawing.Size(425, 231);
            this.dgv_usluga2.TabIndex = 7;
            this.dgv_usluga2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usluga2_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Забронировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Цена";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(435, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(435, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(435, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textsearch2
            // 
            this.textsearch2.Location = new System.Drawing.Point(435, 110);
            this.textsearch2.Name = "textsearch2";
            this.textsearch2.Size = new System.Drawing.Size(74, 20);
            this.textsearch2.TabIndex = 13;
            this.textsearch2.TextChanged += new System.EventHandler(this.textsearch2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Поиск";
            // 
            // gd_products
            // 
            this.gd_products.Controls.Add(this.dgv_usluga2);
            this.gd_products.Controls.Add(this.label2);
            this.gd_products.Controls.Add(this.button1);
            this.gd_products.Controls.Add(this.textsearch2);
            this.gd_products.Controls.Add(this.label1);
            this.gd_products.Controls.Add(this.button4);
            this.gd_products.Controls.Add(this.button2);
            this.gd_products.Controls.Add(this.button3);
            this.gd_products.Location = new System.Drawing.Point(22, 32);
            this.gd_products.Name = "gd_products";
            this.gd_products.Size = new System.Drawing.Size(543, 265);
            this.gd_products.TabIndex = 15;
            this.gd_products.TabStop = false;
            this.gd_products.Text = "Товары";
            // 
            // gb_uslugi
            // 
            this.gb_uslugi.Controls.Add(this.labelsearch);
            this.gb_uslugi.Controls.Add(this.dgv_usluga);
            this.gb_uslugi.Controls.Add(this.label_price);
            this.gb_uslugi.Controls.Add(this.buttondobav);
            this.gb_uslugi.Controls.Add(this.buttonzapis);
            this.gb_uslugi.Controls.Add(this.buttonizmenit);
            this.gb_uslugi.Controls.Add(this.buttondelete);
            this.gb_uslugi.Controls.Add(this.textsearch);
            this.gb_uslugi.Location = new System.Drawing.Point(21, 32);
            this.gb_uslugi.Name = "gb_uslugi";
            this.gb_uslugi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gb_uslugi.Size = new System.Drawing.Size(541, 267);
            this.gb_uslugi.TabIndex = 16;
            this.gb_uslugi.TabStop = false;
            this.gb_uslugi.Text = "Услуги";
            this.gb_uslugi.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button_uslugi
            // 
            this.button_uslugi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
            this.button_uslugi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_uslugi.Location = new System.Drawing.Point(35, 13);
            this.button_uslugi.Name = "button_uslugi";
            this.button_uslugi.Size = new System.Drawing.Size(94, 38);
            this.button_uslugi.TabIndex = 17;
            this.button_uslugi.Text = "Услуги";
            this.button_uslugi.UseVisualStyleBackColor = false;
            this.button_uslugi.Click += new System.EventHandler(this.button_uslugi_Click);
            // 
            // button_products
            // 
            this.button_products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
            this.button_products.Location = new System.Drawing.Point(35, 67);
            this.button_products.Name = "button_products";
            this.button_products.Size = new System.Drawing.Size(94, 38);
            this.button_products.TabIndex = 18;
            this.button_products.Text = "Товары";
            this.button_products.UseVisualStyleBackColor = false;
            this.button_products.Click += new System.EventHandler(this.button_products_Click);
            // 
            // dgv_reviews
            // 
            this.dgv_reviews.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_reviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reviews.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_reviews.Location = new System.Drawing.Point(27, 335);
            this.dgv_reviews.Name = "dgv_reviews";
            this.dgv_reviews.Size = new System.Drawing.Size(525, 141);
            this.dgv_reviews.TabIndex = 19;
            this.dgv_reviews.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reviews_CellContentClick);
            // 
            // gb_reviews
            // 
            this.gb_reviews.Controls.Add(this.button_reviews);
            this.gb_reviews.Location = new System.Drawing.Point(12, 314);
            this.gb_reviews.Name = "gb_reviews";
            this.gb_reviews.Size = new System.Drawing.Size(550, 255);
            this.gb_reviews.TabIndex = 20;
            this.gb_reviews.TabStop = false;
            this.gb_reviews.Text = "Отзывы";
            // 
            // button_reviews
            // 
            this.button_reviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
            this.button_reviews.Location = new System.Drawing.Point(15, 178);
            this.button_reviews.Name = "button_reviews";
            this.button_reviews.Size = new System.Drawing.Size(91, 64);
            this.button_reviews.TabIndex = 0;
            this.button_reviews.Text = "Оставить отзыв";
            this.button_reviews.UseVisualStyleBackColor = false;
            // 
            // gb_employees
            // 
            this.gb_employees.Controls.Add(this.label_search);
            this.gb_employees.Controls.Add(this.textsearch4);
            this.gb_employees.Controls.Add(this.button_del);
            this.gb_employees.Controls.Add(this.button_izm);
            this.gb_employees.Controls.Add(this.button_dobav);
            this.gb_employees.Controls.Add(this.dgv_employees);
            this.gb_employees.Location = new System.Drawing.Point(21, 32);
            this.gb_employees.Name = "gb_employees";
            this.gb_employees.Size = new System.Drawing.Size(541, 258);
            this.gb_employees.TabIndex = 21;
            this.gb_employees.TabStop = false;
            this.gb_employees.Text = "Специалисты";
            // 
            // dgv_employees
            // 
            this.dgv_employees.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employees.Location = new System.Drawing.Point(6, 19);
            this.dgv_employees.Name = "dgv_employees";
            this.dgv_employees.Size = new System.Drawing.Size(425, 231);
            this.dgv_employees.TabIndex = 0;
            // 
            // button_dobav
            // 
            this.button_dobav.Location = new System.Drawing.Point(438, 30);
            this.button_dobav.Name = "button_dobav";
            this.button_dobav.Size = new System.Drawing.Size(75, 23);
            this.button_dobav.TabIndex = 1;
            this.button_dobav.Text = "Добавить";
            this.button_dobav.UseVisualStyleBackColor = true;
            // 
            // button_izm
            // 
            this.button_izm.Location = new System.Drawing.Point(439, 60);
            this.button_izm.Name = "button_izm";
            this.button_izm.Size = new System.Drawing.Size(75, 23);
            this.button_izm.TabIndex = 2;
            this.button_izm.Text = "Изменить";
            this.button_izm.UseVisualStyleBackColor = true;
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(439, 90);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(75, 23);
            this.button_del.TabIndex = 3;
            this.button_del.Text = "Удалить";
            this.button_del.UseVisualStyleBackColor = true;
            // 
            // textsearch4
            // 
            this.textsearch4.Location = new System.Drawing.Point(439, 120);
            this.textsearch4.Name = "textsearch4";
            this.textsearch4.Size = new System.Drawing.Size(75, 20);
            this.textsearch4.TabIndex = 4;
            this.textsearch4.TextChanged += new System.EventHandler(this.textsearch4_TextChanged);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Location = new System.Drawing.Point(456, 143);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(39, 13);
            this.label_search.TabIndex = 5;
            this.label_search.Text = "Поиск";
            // 
            // button_employees
            // 
            this.button_employees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
            this.button_employees.Location = new System.Drawing.Point(35, 123);
            this.button_employees.Name = "button_employees";
            this.button_employees.Size = new System.Drawing.Size(94, 38);
            this.button_employees.TabIndex = 22;
            this.button_employees.Text = "Специалисты";
            this.button_employees.UseVisualStyleBackColor = false;
            this.button_employees.Click += new System.EventHandler(this.button_employees_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(119)))));
            this.panel1.Controls.Add(this.button_employees);
            this.panel1.Controls.Add(this.button_uslugi);
            this.panel1.Controls.Add(this.button_products);
            this.panel1.Location = new System.Drawing.Point(666, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 930);
            this.panel1.TabIndex = 23;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(827, 918);
            this.Controls.Add(this.dgv_reviews);
            this.Controls.Add(this.gb_uslugi);
            this.Controls.Add(this.gd_products);
            this.Controls.Add(this.gb_reviews);
            this.Controls.Add(this.gb_employees);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usluga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usluga2)).EndInit();
            this.gd_products.ResumeLayout(false);
            this.gd_products.PerformLayout();
            this.gb_uslugi.ResumeLayout(false);
            this.gb_uslugi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reviews)).EndInit();
            this.gb_reviews.ResumeLayout(false);
            this.gb_employees.ResumeLayout(false);
            this.gb_employees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_usluga;
        private System.Windows.Forms.Button buttondobav;
        private System.Windows.Forms.Button buttonizmenit;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonzapis;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.DataGridView dgv_usluga2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textsearch2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gd_products;
        private System.Windows.Forms.GroupBox gb_uslugi;
        private System.Windows.Forms.Button button_uslugi;
        private System.Windows.Forms.Button button_products;
        private System.Windows.Forms.DataGridView dgv_reviews;
        private System.Windows.Forms.GroupBox gb_reviews;
        private System.Windows.Forms.Button button_reviews;
        private System.Windows.Forms.GroupBox gb_employees;
        private System.Windows.Forms.DataGridView dgv_employees;
        private System.Windows.Forms.Button button_dobav;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.TextBox textsearch4;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_izm;
        private System.Windows.Forms.Button button_employees;
        private System.Windows.Forms.Panel panel1;
    }
}