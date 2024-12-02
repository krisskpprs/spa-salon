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
            this.gb_usluga = new System.Windows.Forms.GroupBox();
            this.buttonzapis = new System.Windows.Forms.Button();
            this.label_price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usluga)).BeginInit();
            this.gb_usluga.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_usluga
            // 
            this.dgv_usluga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usluga.Location = new System.Drawing.Point(12, 32);
            this.dgv_usluga.Name = "dgv_usluga";
            this.dgv_usluga.Size = new System.Drawing.Size(426, 231);
            this.dgv_usluga.TabIndex = 0;
            this.dgv_usluga.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usluga_CellClick);
            // 
            // buttondobav
            // 
            this.buttondobav.Location = new System.Drawing.Point(444, 32);
            this.buttondobav.Name = "buttondobav";
            this.buttondobav.Size = new System.Drawing.Size(75, 23);
            this.buttondobav.TabIndex = 1;
            this.buttondobav.Text = "Добавить";
            this.buttondobav.UseVisualStyleBackColor = true;
            this.buttondobav.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonizmenit
            // 
            this.buttonizmenit.Location = new System.Drawing.Point(444, 61);
            this.buttonizmenit.Name = "buttonizmenit";
            this.buttonizmenit.Size = new System.Drawing.Size(75, 23);
            this.buttonizmenit.TabIndex = 2;
            this.buttonizmenit.Text = "Изменить";
            this.buttonizmenit.UseVisualStyleBackColor = true;
            this.buttonizmenit.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(444, 90);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 23);
            this.buttondelete.TabIndex = 3;
            this.buttondelete.Text = "Удалить";
            this.buttondelete.UseVisualStyleBackColor = true;
            // 
            // gb_usluga
            // 
            this.gb_usluga.Controls.Add(this.buttonzapis);
            this.gb_usluga.Controls.Add(this.label_price);
            this.gb_usluga.Location = new System.Drawing.Point(12, 272);
            this.gb_usluga.Name = "gb_usluga";
            this.gb_usluga.Size = new System.Drawing.Size(426, 166);
            this.gb_usluga.TabIndex = 4;
            this.gb_usluga.TabStop = false;
            this.gb_usluga.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonzapis
            // 
            this.buttonzapis.Location = new System.Drawing.Point(328, 122);
            this.buttonzapis.Name = "buttonzapis";
            this.buttonzapis.Size = new System.Drawing.Size(92, 38);
            this.buttonzapis.TabIndex = 5;
            this.buttonzapis.Text = "Записаться";
            this.buttonzapis.UseVisualStyleBackColor = true;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_price.Location = new System.Drawing.Point(347, 102);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(60, 17);
            this.label_price.TabIndex = 0;
            this.label_price.Text = "Цена";
            
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_usluga);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonizmenit);
            this.Controls.Add(this.buttondobav);
            this.Controls.Add(this.dgv_usluga);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usluga)).EndInit();
            this.gb_usluga.ResumeLayout(false);
            this.gb_usluga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_usluga;
        private System.Windows.Forms.Button buttondobav;
        private System.Windows.Forms.Button buttonizmenit;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.GroupBox gb_usluga;
        private System.Windows.Forms.Button buttonzapis;
        private System.Windows.Forms.Label label_price;
    }
}