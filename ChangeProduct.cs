using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spa_salon
{
    public partial class ChangeProduct : Form
    {
        DB DB = new DB();
        public ChangeProduct(DataGridViewRow row, int n)
        {
            InitializeComponent();
            get_row(row);
            if (n == 2)
            {
                button_izm.Visible = false;
                button_dobaa.Visible = true;
            }
        }
       
        DataGridViewRow row2;
        

        public void get_row(DataGridViewRow row)
        {
            row2 = row;
        }

        private void button_otmena_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin(1);
            formAdmin.Show();
            this.Close();
        }

        private void button_izm_Click(object sender, EventArgs e)
        {
            Change_Row();
        }

        public void Change_Row()
        {
        
         string[] inp_text_value = { textBox_prod_izm.Text, textBox_descr.Text, textBox_price.Text, textBox_stock.Text, textBox_supplier.Text, textBox_client.Text };

            for (int i = 0; i < 6; i++) 
            {
                if (inp_text_value[i] == "") 
                {
                    inp_text_value[i] = row2.Cells[i + 1].Value.ToString();
                }
            }
            string query_string = $"Update products set ProductName = '{inp_text_value[0]}', Description = '{inp_text_value[1]}', Price = '{inp_text_value[2]}', StockQuantity = '{inp_text_value[3]}', SupplierID = '{inp_text_value[4]}', ClientID='{inp_text_value[5]}' where ProductID='{row2.Cells[0].Value.ToString()}'";
            SqlCommand command = new SqlCommand(query_string, DB.GetSqlConnection());
            DB.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();

            MessageBox.Show("Изменения сохранились!");
            FormAdmin formAdmin = new FormAdmin(1);
            this.Show();
            formAdmin.Show();
            this.Hide();

        }

        private void button_dob_Click(object sender, EventArgs e)
        {
            Add_Row();
        }

        public void Add_Row()
        {
            try
            {
                string query_string = $"INSERT INTO products (ProductName, Description, Price, StockQuantity, SupplierID, ClientID) VALUES ('{textBox_prod_izm.Text}', '{textBox_descr.Text}', '{textBox_price.Text}', '{textBox_stock.Text}', '{textBox_supplier.Text}', '{textBox_client.Text}')";

                SqlCommand command = new SqlCommand(query_string, DB.GetSqlConnection());

                DB.openConnection();
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!");
                FormAdmin formAdmin = new FormAdmin(1);
                this.Show();
                formAdmin.Show();
                this.Hide();
            }
            catch (Exception ex) { MessageBox.Show("Заполните все поля!"); }


        }

        private void button_dobaa_Click(object sender, EventArgs e)
        {
            Add_Row();
        }

        private void ChangeProduct_Load(object sender, EventArgs e)
        {

        }
    }
}

