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
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textlogin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnvoiti_Click(object sender, EventArgs e)
        {
            string login = textlogin.Text;
            string password = textpassword.Text;

            if (login == "admin" && password == "password")
            {

                lblMessage.Text = "Login successful!";

                Form form = new Form();
                form.Show();
                this.Hide();    
            }
            else
            {
                lblMessage.Text = "Invalid login or password";
            }

        }

        private void registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistration registration = new FormRegistration();
            registration.Show();
            this.Hide();

            this.registration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registration_LinkClicked);

        }
    }
}
