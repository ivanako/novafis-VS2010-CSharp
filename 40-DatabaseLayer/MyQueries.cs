using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using MySql.Data.MySqlClient;

namespace DatabaseLayer
{
    public class MyQueries
    {
        public static DataTable executeQuery(string sqlQuery)
        {
            DataTable dtData = new DataTable();

            try
            {
                using (MySqlConnection myCnn = new MySqlConnection())
                {
                    myCnn.ConnectionString = MyConnection.buildConnectionString();

                    using (MySqlCommand myCmd = new MySqlCommand())
                    {
                        myCnn.Open();

                        myCmd.CommandText = sqlQuery;
                        myCmd.CommandType = CommandType.Text;
                        myCmd.Connection = myCnn;

                        MySqlDataAdapter myAdapter = new MySqlDataAdapter(myCmd);
                        myAdapter.Fill(dtData);
                    }
                }
            }
            catch (Exception exError)
            {
                dtData = null;
            }

            return dtData;
        }
    }
}
