using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DemoTest
{
    class dbInfo
    {
        public MySqlConnection mysqli = new MySqlConnection("server = localhost; user = root; database = demopr; password = ; SSL mode = None");
        public MySqlConnection getConnection()
        {
            return mysqli;
        }
    }
}
