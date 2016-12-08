using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;

namespace DatabaseLayer
{
    internal class MyConnection
    {
        internal static string buildConnectionString()
        {
            MySqlConnectionStringBuilder cnnString = new MySqlConnectionStringBuilder();
            cnnString.Server = Properties.Settings.Default.myServer;
            cnnString.Database = Properties.Settings.Default.myDatabase;
            cnnString.UserID = Properties.Settings.Default.myUser;
            cnnString.Password = Properties.Settings.Default.myPwd;
            cnnString.IntegratedSecurity = Properties.Settings.Default.myIntSecurity;
            cnnString.CharacterSet = Properties.Settings.Default.myCharset;

            return cnnString.ConnectionString;
        }


        public static bool isDBAlive()
        {
            bool cnnOK = true;

            try
            {
                string cnnString = buildConnectionString();

                using (MySqlConnection myCnn = new MySqlConnection(cnnString))
                {
                    myCnn.Open();
                }
            }
            catch (Exception exError)
            {
                cnnOK = false;
            }

            return cnnOK;
        }
    }
}
