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
        int selected_row_prod;


        public FormAdmin(int roleId)
        {
            InitializeComponent();

            gb_uslugi.Visible = true;
            gd_products.Visible = false;

            if (roleId == 2)
            {
                buttondobav.Visible = false;
                buttonizmenit.Visible = false;
                buttondelete.Visible = false;
                button_dob.Visible = false;
                button_izmen.Visible = false;
                button_delet.Visible = false;
                button_dobav.Visible = false;
                button_izm.Visible = false;
                button_del.Visible = false;
                button_d.Visible = false;
                button_i.Visible = false;
                button_de.Visible = false;
                gb_supply.Visible = false;
                button_supply.Visible = false;
                button_clients.Visible = false;
                button_dobavite.Visible=false;
                button_izmenite.Visible=false;
                button_deleete.Visible=false;
                gb_clients.Visible=false;
                button_suppliers.Visible=false;




            }
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

            dgv_reviews.Columns.Add("ReviewID", "id отзыва");
            dgv_reviews.Columns.Add("Rating", "Оценка");
            dgv_reviews.Columns.Add("Comment", "Комментарий");

            dgv_employees.Columns.Add("EmployeeID", "id специалиста");
            dgv_employees.Columns.Add("FirstName", "Имя ");
            dgv_employees.Columns.Add("LastName", "Фамилия");
            dgv_employees.Columns.Add("Position", "Должность");
            dgv_employees.Columns.Add("ContactPhone", "Номер телефона");
            dgv_employees.Columns.Add("Email", "Почта");
            dgv_employees.Columns.Add("WorkSchedule", "График работы");

            dgv_supply.Columns.Add("SupplyID", "id поставки");
            dgv_supply.Columns.Add("SupplierID", "id поставщика ");
            dgv_supply.Columns.Add("SupplyDate", "Дата поставки");
            dgv_supply.Columns.Add("Cost", "Цена");

            dgv_suppliers.Columns.Add("SuppliersID", "id поставщика");
            dgv_suppliers.Columns.Add("CompanyName", "Название компаниии ");
            dgv_suppliers.Columns.Add("ContactPhone", "Телефон");
            dgv_suppliers.Columns.Add("Email", "Почта");
            dgv_suppliers.Columns.Add("Address", "Адрес");

            dgv_clients.Columns.Add("ClientsID", "id клиента");
            dgv_clients.Columns.Add("FirstName", "Имя");
            dgv_clients.Columns.Add("LastName", "Фамилия");
            dgv_clients.Columns.Add("ContactPhone", "Телефон");
            dgv_clients.Columns.Add("DataofBirth", "Дата Рождения");
            dgv_clients.Columns.Add("Login", "Логин");
            dgv_clients.Columns.Add("Password", "Пароль");
            dgv_clients.Columns.Add("Client_status_ID", "id статуса");

        }
        public void Read_single_row(DataGridView dgw, IDataRecord record, int n)
        {
            if (n ==0) dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetDecimal(4).ToString());
            if (n == 1) dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetDecimal(3).ToString(), record.GetInt32(4), record.GetInt32(5), record.GetInt32(6));
            if (n == 2) dgw.Rows.Add(record.GetInt32(0), record.GetInt32(3),record.GetString(4));
            if (n == 3) dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6));
            if (n == 4) dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetDateTime(2), record.GetDecimal(3).ToString());
            if (n == 5) dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4));
            if (n == 6) dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetDateTime(4), record.GetString(5), record.GetString(6), record.GetInt32(7));
        }


        public void Refresh_data_grid(DataGridView dgw, string table, int n)
        {
            dgw.Rows.Clear();
            string query_string = $"select * from {table}";
            SqlCommand command = new SqlCommand(query_string, DB.GetSqlConnection());
            DB.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Read_single_row(dgw, reader, n);
            }
            reader.Close();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            Create_colums();
            Refresh_data_grid(dgv_usluga, "services", 0);
            Refresh_data_grid(dgv_usluga2, "products", 1);
            Refresh_data_grid(dgv_reviews, "reviews", 2);
            Refresh_data_grid(dgv_employees, "employees", 3);
            Refresh_data_grid(dgv_supply, "supplies", 4);
            Refresh_data_grid(dgv_suppliers, "suppliers", 5);
            Refresh_data_grid(dgv_clients, "clients", 6);

            gb_uslugi.Visible = true;
            gd_products.Visible = false;
            gb_employees.Visible = false;
            gb_reviews.Visible = true;
            gb_clients.Visible = false;
        }

        private void button_uslugi_Click(object sender, EventArgs e)
        {
            gb_uslugi.Visible = true;
            gd_products.Visible = false;
            gb_employees.Visible = false;
            gb_clients.Visible = false;

        }

        private void button_products_Click(object sender, EventArgs e)
        {
            gb_uslugi.Visible = false;
            gd_products.Visible = true;
            gb_employees.Visible = false;
            gb_clients.Visible = false;

        }

        private void button_employees_Click(object sender, EventArgs e)
        {
            gb_uslugi.Visible = false;
            gd_products.Visible = false;
            gb_employees.Visible = true;
            gb_clients.Visible = false;

        }


        private void button_clients_Click(object sender, EventArgs e)
        {
            gb_uslugi.Visible = false;
            gd_products.Visible = false;
            gb_employees.Visible = false;
            gb_clients.Visible = true;
        }

        private void button_supply_Click(object sender, EventArgs e)
        {
            gb_supply.Visible = true;
            gb_suplilers.Visible = false;
        }

        private void button_suppliers_Click(object sender, EventArgs e)
        {
            gb_supply.Visible = false;
            gb_suplilers.Visible = true;
        }
        

        private void dgv_usluga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_row = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_usluga.Rows[selected_row];
                label_price.Text = $"{row.Cells[4].Value.ToString()}₽";
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
                Read_single_row(dgv, read, 0);
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
                Read_single_row(dgv, read, 1);
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
                Read_single_row(dgv, read, 3);
            }

            read.Close();
        }

        private void Search_c(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string searchString = $"select * from [Clients] where concat (ClientsID, FirstName, LastName, ContactPhone, DataofBirth, Login, Password) like '%{textsearch5.Text}%'";

            SqlCommand comment = new SqlCommand(searchString, DB.GetSqlConnection());

            DB.openConnection();

            SqlDataReader read = comment.ExecuteReader();

            while (read.Read())
            {
                Read_single_row(dgv, read, 6);
            }

            read.Close();
        }

        private void Search_s(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string searchString = $"select * from [Supplies] where concat (SupplyID, SupplierID, SupplyDate, Cost) like '%{textsearch6.Text}%'";

            SqlCommand comment = new SqlCommand(searchString, DB.GetSqlConnection());

            DB.openConnection();

            SqlDataReader read = comment.ExecuteReader();

            while (read.Read())
            {
                Read_single_row(dgv, read, 4);
            }

            read.Close();
        }

        private void Search_ss(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string searchString = $"select * from [Suppliers] where concat (SuppliersID, CompanyName, ContactPhone, Email, Address) like '%{textsearch3.Text}%'";

            SqlCommand comment = new SqlCommand(searchString, DB.GetSqlConnection());

            DB.openConnection();

            SqlDataReader read = comment.ExecuteReader();

            while (read.Read())
            {
                Read_single_row(dgv, read, 5);
            }

            read.Close();
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            Search_t(dgv_usluga);
        }

        private void textsearch2_TextChanged(object sender, EventArgs e)
        {
            Search_y(dgv_usluga2);
        }


        private void textsearch5_TextChanged(object sender, EventArgs e)
        {
            Search_c(dgv_clients);
        }

        private void textsearch4_TextChanged(object sender, EventArgs e)
        {
            Search_e(dgv_employees);
        }

        private void textsearch6_TextChanged(object sender, EventArgs e)
        {
            Search_s(dgv_supply);
        }

        private void textsearch3_TextChanged(object sender, EventArgs e)
        {
            Search_ss(dgv_suppliers);
        }

        private void label_price2_Click(object sender, EventArgs e)
        {

        }

        private void dgv_usluga2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_row_prod = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_usluga2.Rows[selected_row_prod];
                label_price2.Text = $"{row.Cells[3].Value.ToString()}₽";
            }
        }

        private void button_delet_Click(object sender, EventArgs e)
        {
            Delete_Row();
        }

        public void Delete_Row()
        {
            try
            {
                DataGridViewRow row = dgv_usluga2.Rows[selected_row_prod];
                string query_string = $"delete from products where ProductID={row.Cells[0].Value.ToString()}";
                SqlCommand command = new SqlCommand(query_string, DB.GetSqlConnection());
                DB.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                Refresh_data_grid(dgv_usluga2, "products", 1);
            }
            catch (Exception ex) {
                MessageBox.Show("hfjbfh");
            }

        }

        private void button_izmen_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_usluga2.Rows[selected_row_prod];
            ChangeProduct changeProduct = new ChangeProduct(row, 1);
            changeProduct.Show();
            this.Hide();

        }


        //private void button_del_Click(object sender, EventArgs e)
        //{
        //    DataGridViewRow row = dgv_usluga2.Rows[selected_row_prod];
        //    ChangeProduct changeProduct = new ChangeProduct(row);
        //    changeProduct.Show();
        //    this.Hide();
        //}

        private void button_dob_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_usluga2.Rows[selected_row_prod];
            ChangeProduct changeProduct = new ChangeProduct(row, 2);
            changeProduct.Show();
            this.Hide();
        }

        private void button_reviews_Click(object sender, EventArgs e)
        {
        }
    }
}
