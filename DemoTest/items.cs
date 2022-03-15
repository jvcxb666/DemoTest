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
    public partial class items : Form
    {
        
        public items()
        {
            InitializeComponent();
        }

        private void DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void items_Load(object sender, EventArgs e)
        {
            dbInfo db = new dbInfo();
            MySqlConnection mysqli = db.mysqli;
            MySqlCommand select = new MySqlCommand("SELECT * FROM `table`", mysqli);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            mysqli.Open();
            adapter.SelectCommand = select;
            adapter.Fill(table);
            mysqli.Close();
            datagrid.DataSource = table.DefaultView;
        }

        private void search_submit_Click(object sender, EventArgs e)
        {
            dbInfo db = new dbInfo();
            MySqlConnection mysqli = db.mysqli;
            string search_param = seachBox.Text;
            MySqlCommand select = new MySqlCommand("SELECT * FROM `table` WHERE `company` LIKE @p", mysqli);
            select.Parameters.Add("@p", MySqlDbType.VarChar).Value = "%" + search_param + "%";
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            mysqli.Open();
            adapter.SelectCommand = select;
            adapter.Fill(table);
            mysqli.Close();
            datagrid.DataSource = table.DefaultView;
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            dbInfo db = new dbInfo();
            MySqlConnection mysqli = db.mysqli;
            MySqlCommand select = new MySqlCommand("SELECT * FROM `table` WHERE 1", mysqli);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            mysqli.Open();
            adapter.SelectCommand = select;
            adapter.Fill(table);
            mysqli.Close();
            datagrid.DataSource = table.DefaultView;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        private void filter_click_Click(object sender, EventArgs e)
        {
            string column = sort_column.Text;
            string type = sort_type.Text;
            dbInfo db = new dbInfo();
            MySqlConnection mysqli = db.mysqli;
            MySqlCommand select = new MySqlCommand("SELECT * FROM `table` WHERE 1 ORDER BY `" + column + "` " + type, mysqli);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            mysqli.Open();
            adapter.SelectCommand = select;
            adapter.Fill(table);
            mysqli.Close();
            datagrid.DataSource = table.DefaultView;
        }

        private void seachBox_TextChanged(object sender, EventArgs e)
        {
            dbInfo db = new dbInfo();
            MySqlConnection mysqli = db.mysqli;
            string search_param = seachBox.Text;
            MySqlCommand select = new MySqlCommand("SELECT * FROM `table` WHERE `company` LIKE @p", mysqli);
            select.Parameters.Add("@p", MySqlDbType.VarChar).Value = "%" + search_param + "%";
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            mysqli.Open();
            adapter.SelectCommand = select;
            adapter.Fill(table);
            mysqli.Close();
            datagrid.DataSource = table.DefaultView;
        }

        private void sort_column_SelectedIndexChanged(object sender, EventArgs e)
        {
            string column = sort_column.Text;
            string type = sort_type.Text;
            if(type == null)
            {
                type = "ASC";
            }
            dbInfo db = new dbInfo();
            MySqlConnection mysqli = db.mysqli;
            MySqlCommand select = new MySqlCommand("SELECT * FROM `table` WHERE 1 ORDER BY `" + column + "` " + type, mysqli);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            mysqli.Open();
            adapter.SelectCommand = select;
            adapter.Fill(table);
            mysqli.Close();
            datagrid.DataSource = table.DefaultView;
        }

        private void sort_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            string column = sort_column.Text;
            if(column == null)
            {
                column = "company";
            }
            string type = sort_type.Text;
            dbInfo db = new dbInfo();
            MySqlConnection mysqli = db.mysqli;
            MySqlCommand select = new MySqlCommand("SELECT * FROM `table` WHERE 1 ORDER BY `" + column + "` " + type, mysqli);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            mysqli.Open();
            adapter.SelectCommand = select;
            adapter.Fill(table);
            mysqli.Close();
            datagrid.DataSource = table.DefaultView;
        }
    }
}
