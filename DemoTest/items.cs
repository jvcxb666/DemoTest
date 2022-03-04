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
            MySqlCommand select = new MySqlCommand("SELECT * FROM `table` WHERE 1", mysqli);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            mysqli.Open();
            adapter.SelectCommand = select;
            adapter.Fill(table);
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
            datagrid.DataSource = table.DefaultView;
        }
    }
}
