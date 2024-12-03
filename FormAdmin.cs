using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spa_salon
{
    public partial class FormAdmin : Form
    {
        DB DB = new DB();
        int selected_row;

        public FormAdmin()
        {
            InitializeComponent();

            gb_uslugi.Visible = true;
            gd_products.Visible = false;
        }
        public void Create_colums()
        {
            dgv_usluga.Columns.Add("ServiceID", "id");
            dgv_usluga.Columns.Add("ServiceName", "Название услуги");
            dgv_usluga.Columns.Add("Description", "Описание услуги");
            dgv_usluga.Columns.Add("Duration", "Продолжительность/час");
            dgv_usluga.Columns.Add("Price", "Цена");

            dgv_usluga2.Columns.Add("ProductID", "id");
            dgv_usluga2.Columns.Add("ProductName", "Название товара");
            dgv_usluga2.Columns.Add("Description", "Описание товара");
            dgv_usluga2.Columns.Add("Price", "Цена");
            dgv_usluga2.Columns.Add("StockQuantity", "Количество на складе");
            dgv_usluga2.Columns.Add("SupplierID", "id поставщика");
            dgv_usluga2.Columns.Add("ClientID", "id клиента");

            dgv_reviews.Columns.Add("ReviewID", "id отзывы");
            dgv_reviews.Columns.Add("ClientID", "id клиента ");
            dgv_reviews.Columns.Add("ServiceID", "id услуги");
            dgv_reviews.Columns.Add("Rating", "Оценка");
            dgv_reviews.Columns.Add("Comment", "Комментарий");
            dgv_reviews.Columns.Add("ReviewDate", "Дата отзыва");

            dgv_employees.Columns.Add("EmployeeID", "id специалиста");
            dgv_employees.Columns.Add("FirstName", "Имя ");
            dgv_employees.Columns.Add("LastName", "Фамилия");
            dgv_employees.Columns.Add("Position", "Должность");
            dgv_employees.Columns.Add("ContactPhone", "Номер телефона");
            dgv_employees.Columns.Add("Email", "Почта");
            dgv_employees.Columns.Add("WorkSchedule", "График работы");
         

        }
        public void Read_single_row(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetDecimal(4).ToString());
        }

        public void Read_single_row_2(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetDecimal(3).ToString(), record.GetInt32(4), record.GetInt32(5), record.GetInt32(6));
        }

        public void Read_single_row_3(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record.GetString(4), record.GetDateTime(5));
        }

        public void Read_single_row_4(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6));
        }

        public void Refresh_data_grid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string query_string = $"select * from Services";
            SqlCommand command = new SqlCommand(query_string, DB.GetSqlConnection());
            DB.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Read_single_row(dgw, reader);
            }
            reader.Close();
        }

        public void Refresh_data_grid_2(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string query_string = $"select * from Products";
            SqlCommand command = new SqlCommand(query_string, DB.GetSqlConnection());
            DB.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Read_single_row_2(dgw, reader);
            }
            reader.Close();
        }

        public void Refresh_data_grid_3(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string query_string = $"select * from Reviews";
            SqlCommand command = new SqlCommand(query_string, DB.GetSqlConnection());
            DB.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Read_single_row_3(dgw, reader);
            }
            reader.Close();
        }

        public void Refresh_data_grid_4(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string query_string = $"select * from Employees";
            SqlCommand command = new SqlCommand(query_string, DB.GetSqlConnection());
            DB.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Read_single_row_4(dgw, reader);
            }
            reader.Close();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            Create_colums();
            Refresh_data_grid(dgv_usluga);   
            Refresh_data_grid_2(dgv_usluga2);
            Refresh_data_grid_3(dgv_reviews);
            Refresh_data_grid_4(dgv_employees);
        }

        private void button_uslugi_Click(object sender, EventArgs e)
        {
            gb_uslugi.Visible = true;
            gd_products.Visible = false;
        }

        private void button_products_Click(object sender, EventArgs e)
        {
            gb_uslugi.Visible = false;
            gd_products.Visible = true;
        }

        private void dgv_usluga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_row = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_usluga.Rows[selected_row];
                label_price.Text = $"{row.Cells[2].Value.ToString()}₽";
            }
        }

        private void Search_t(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string searchString = $"select * from [Services] where concat (ServiceID, ServiceName, Description, Duration, Price) like '%{textsearch.Text}%'";

            SqlCommand comment = new SqlCommand(searchString, DB.GetSqlConnection());

            DB.openConnection();

            SqlDataReader read = comment.ExecuteReader();

            while (read.Read())
            {
                Read_single_row(dgv, read);
            }

            read.Close();
        }

        private void Search_y(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string searchString = $"select * from [Products] where concat (ProductID, ProductName, Description, Price, StockQuantity, SupplierID, ClientID) like '%{textsearch2.Text}%'";

            SqlCommand comment = new SqlCommand(searchString, DB.GetSqlConnection());

            DB.openConnection();

            SqlDataReader read = comment.ExecuteReader();

            while (read.Read())
            {
                Read_single_row_2(dgv, read);
            }

            read.Close();
        }

        private void Search_e(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string searchString = $"select * from [Employees] where concat (EmployeeID, FirstName, LastName, Position, ContactPhone, Email, WorkSchedule) like '%{textsearch4.Text}%'";

            SqlCommand comment = new SqlCommand(searchString, DB.GetSqlConnection());

            DB.openConnection();

            SqlDataReader read = comment.ExecuteReader();

            while (read.Read())
            {
                Read_single_row_4(dgv, read);
            }

            read.Close();
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            Search_t(dgv_usluga);
        }

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_usluga2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textsearch2_TextChanged(object sender, EventArgs e)
        {
            Search_y(dgv_usluga2);
        }

        private void dgv_reviews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelsearch_Click(object sender, EventArgs e)
        {

        }

        private void textsearch4_TextChanged(object sender, EventArgs e)
        {
            Search_e(dgv_employees);
        }

        private void button_employees_Click(object sender, EventArgs e)
        {

        }
    }
}
