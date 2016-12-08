using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using MySql.Data.MySqlClient;
using Objects;

namespace DatabaseLayer
{
    public class MyStoredProcs
    {
        public static DataTable callStoredProc(string spName, List<MySqlParameter> lstParams)
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

                        myCmd.CommandText = spName;
                        myCmd.CommandType = System.Data.CommandType.StoredProcedure;
                        myCmd.Connection = myCnn;

                        if (lstParams != null)
                        {
                            myCmd.Parameters.AddRange(lstParams.ToArray());
                        }

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

        public static bool callStoredProc(string spName, List<MySqlParameter> lstParams, ref int rowCount)
        {
            //int affectedRowsCount = 0;
            bool isOK = true;

            try
            {
                using (MySqlConnection myCnn = new MySqlConnection())
                {
                    myCnn.ConnectionString = MyConnection.buildConnectionString();

                    using (MySqlCommand myCmd = new MySqlCommand())
                    {
                        myCnn.Open();

                        myCmd.CommandText = spName;
                        myCmd.CommandType = System.Data.CommandType.StoredProcedure;
                        myCmd.Connection = myCnn;

                        if (lstParams != null)
                        {
                            myCmd.Parameters.AddRange(lstParams.ToArray());
                        }

                        rowCount = myCmd.ExecuteNonQuery();
                        isOK = (rowCount == 1);
                    }
                }
            }
            catch (MySqlException myError)
            {
                //myError.
                isOK = false;
            }
            catch (Exception exError)
            {
                //exError.
                isOK = false;
            }

            return isOK;
        }
    }
}
