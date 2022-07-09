using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMySqlForm
{
    internal class MySql
    {
        private bool isLoginOk;
        private bool foundUsers;

        public bool FoundUsers { get { return foundUsers;} set { foundUsers = value; } }
        public Personal Person { get { return person; } set { person = value; } }


        MySqlConnection con;
        MySqlDataReader reader;
        MySqlCommand cmd;

        Personal person;

        bool sqlConnection(string sql)
        {
            try
            {
                string connection = (@"Data Source = localhost; Port = 3306 ; Initial Catalog = PersonalManagment; User Id = Java; Password = 111111;");

                con = new MySqlConnection(connection);

                con.Open();

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return false;
            }
        }

        public void sqlRead(string sql)
        {
            isLoginOk = sqlConnection(sql);

            if (isLoginOk)
            {
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    
                    while (reader.Read())
                    {
                        person = new Personal
                            (
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4),
                                reader.GetString(5)
                            );
                    }
                    foundUsers = true;
                }
                else
                {
                    foundUsers = false;
                }
            }
            else
            {

            }
        }

        
    }
}
