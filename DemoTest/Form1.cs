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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_submit_Click(object sender, EventArgs e)
        {
            dbInfo db = new dbInfo();
            MySqlConnection mysqli = db.mysqli;
            string email;
            string password;
            email = EmailBox.Text;
            password = PassBox.Text;
            DataTable result = new DataTable();
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            MySqlCommand select = new MySqlCommand("SELECT * FROM `users` WHERE `email` = @e AND `password` = @p",mysqli);
            select.Parameters.Add("@e",MySqlDbType.VarChar).Value = email;
            select.Parameters.Add("@p",MySqlDbType.VarChar).Value = password;
            mysqli.Open();
            adapt.SelectCommand = select;
            adapt.Fill(result);
            mysqli.Close();

            if (result.Rows.Count > 0)
            {
                MessageBox.Show("a");
                items items = new items();
                this.Hide();
                items.Show();
            }
            else
            {
                MessageBox.Show("b");
            }
        }

        private void Reg_redirect_Click(object sender, EventArgs e)
        {
            registration register = new registration();
            this.Hide();
            register.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
