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
        }
        public void Create_colums()
        {
            dgv_usluga.Columns.Add("ServiceID", "id");
            dgv_usluga.Columns.Add("ServiceName", "Название услуги");
            dgv_usluga.Columns.Add("Price", "Цена");
        }
        public void Read_single_row(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetDecimal(4).ToString());
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void FormAdmin_Load(object sender, EventArgs e)
        {
            Create_colums();
            Refresh_data_grid(dgv_usluga);   

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

    }
}
