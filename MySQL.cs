using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace Teamproject1
{
    class MySQL
    {
        string ServerName;
        string DataBase;
        string userid;
        string userpw;

        MySqlConnection connection;

        public MySQL(string servername, string database, string userid, string userpw)
        {
            this.userid = userid;
            this.userpw = userpw;
            this.ServerName = servername;
            this.DataBase = database;
        }
        public MySqlConnection Connection()
        {
            connection = new MySqlConnection("Server=" + ServerName + ";Database=" + DataBase + ";Uid=" + userid + ";Pwd=" + userpw);
            return connection;
        }
        public Boolean DBConnection()
        {
            connection = new MySqlConnection("Server=" + ServerName + ";Database=" + DataBase + ";Uid=" + userid + ";Pwd=" + userpw);
            connection.Open();
            Boolean temp = connection.Ping();
            if (temp == true)
            {
                return temp;
            }
            else
            {
                return temp;
            }
        }
        public Boolean Sql(string SQL)
        {
            Boolean connection_result = DBConnection();

            try
            {
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public string Select_Sql(string SQL)
        {
            return "";
        }

    }
}
