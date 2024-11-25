using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spa_salon
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FirstName = textFirstName.Text;
            string LastName = textLastName.Text;
            string DataOfBirth = textDataOfBirth.Text;
            string Phone = textPhone.Text;
            string Login = textLogin.Text;
            string Password = textPassword.Text;

            if (string.IsNullOrEmpty(FirstName) ||
                string.IsNullOrEmpty(LastName) ||
                string.IsNullOrEmpty(DataOfBirth) ||
                string.IsNullOrEmpty(Phone) ||
                string.IsNullOrEmpty(Login) ||
                string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (!Phone.All(char.IsDigit))
            {
                MessageBox.Show("Номер телефона должен содержать только цифры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form FormAvtoriz = new Form();
            FormAvtoriz.Show();
            this.Hide();
        }
    }
}
