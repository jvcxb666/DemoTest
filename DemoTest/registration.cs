using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
  

namespace DemoTest
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 auth = new Form1();
            auth.Show();
        }

        private void Register_submit_Click(object sender, EventArgs e)
        {
            dbInfo db = new dbInfo();
            MySqlConnection mysqli = db.mysqli;
            string name = NameBox.Text;
            string email = EmailBox.Text;
            string password = PassBox.Text;
            string check;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand select = new MySqlCommand("SELECT `email` FROM `users` WHERE `email` = @e", mysqli);
            select.Parameters.Add("@e", MySqlDbType.VarChar).Value = email;
            MySqlCommand insert = new MySqlCommand("INSERT INTO `users`(`name`, `email`, `password`) VALUES (@n,@e,@p)", mysqli);
            insert.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            insert.Parameters.Add("@e", MySqlDbType.VarChar).Value = email;
            insert.Parameters.Add("@p", MySqlDbType.VarChar).Value = password;
            mysqli.Open();
            adapter.SelectCommand = select;
            adapter.Fill(table);
            if (table.Rows.Count <= 0)
            {
                if (insert.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("success");
                    this.Close();
                    Form1 auth = new Form1();
                    auth.Show();

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Email is already taken");
            }

        }
    }
}
