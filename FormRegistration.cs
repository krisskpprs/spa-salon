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
using System.Xml.Linq;

namespace spa_salon
{
    public partial class FormRegistration : Form
    {
        DB DB = new DB();
        public FormRegistration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void FormRegistration_Load(object sender, EventArgs e)
        {
            textPassword.PasswordChar = '*';
            textLogin.MaxLength = 50;
            textPassword.MaxLength = 50;

        }

        private Boolean check_client(string Login)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand($"select Login from [Clients] where Login = '{Login}'", DB.GetSqlConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует");
                return true;
            }
            else return false;
        }

        private void button_zareg_Click(object sender, EventArgs e)
        {
            var FirstName = textFirstName.Text;
            var LastName = textLastName.Text;
            var DataOfBirth = textDataOfBirth.Text;
            var Phone = textPhone.Text;
            var Login = textLogin.Text;
            var Password = textPassword.Text;
            int roleId = 2;

            if (check_client(Login) == false)
            {
                SqlCommand command = new SqlCommand($"insert into [Clients](FirstName, LastName, Login, Password) values('{FirstName}', '{LastName}', '{Login}', '{Password}')", DB.GetSqlConnection());
                DB.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вы вошли в аккаунт!");
                    FormAdmin formAdmin  = new FormAdmin(roleId);
                    this.Hide();
                    formAdmin.ShowDialog();
                }
                else MessageBox.Show("Такого аккаунта нет!");
            }
            DB.closeConnection();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
