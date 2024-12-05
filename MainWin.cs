﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace spa_salon
{
    public partial class MainWin : Form
    {
        DB DB = new DB();
        

        public MainWin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            textpassword.PasswordChar = '*';
            textlogin.MaxLength = 50;
            textpassword.MaxLength = 50;


        }

        private void btnvoiti_Click(object sender, EventArgs e)
        {

            var loginUser = textlogin.Text;
            var loginPassword = textpassword.Text;
         

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select ClientsID, Client_status_ID, Login, Password from Clients where Login = '{loginUser}' and Password = '{loginPassword}'";

            SqlCommand command = new SqlCommand(querystring, DB.GetSqlConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
             
                    MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormAdmin formAdmin = new FormAdmin(Convert.ToInt32(table.Rows[0]["Client_status_ID"]));
                    this.Hide();
                    formAdmin.ShowDialog();
                    this.Show();
             

            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
