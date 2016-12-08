using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DatabaseLayer;
using MySql.Data.MySqlClient;
using Objects;

namespace DataLayer
{
    public class SourceDL
    {
        public static DataTable findAllSources()
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDFuente", MySqlDbType = MySqlDbType.Int32, Value = DBNull.Value, Direction = ParameterDirection.Input},
            };

            return MyStoredProcs.callStoredProc("spFuentes_LLenar", lstParams);
        }

        public static DataTable findOneSource(int idSource)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDFuente", MySqlDbType = MySqlDbType.Int32, Value = idSource, Direction = ParameterDirection.Input},
            };

            return MyStoredProcs.callStoredProc("spFuentes_LLenar", lstParams);
        }

        public static bool saveSource(Source source)
        {
            bool isOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDFuente", MySqlDbType = MySqlDbType.Int32, Value = source.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sDescripcion", MySqlDbType = MySqlDbType.VarChar, Size = 100, Value = source.Description, Direction = ParameterDirection.Input}
            };

            int lesCount = 0;

            isOK = MyStoredProcs.callStoredProc("spFuentes_Guardar", lstParams, ref lesCount);

            return isOK;
        }
    }
}
