using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dictionary
{
    class ConnectionDB
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;pwd = mdes;database=dictionary;");
        MySqlDataAdapter myd = new MySqlDataAdapter();
        MySqlCommand myc = new MySqlCommand();
        DataTable dt = new DataTable();
    }
}
