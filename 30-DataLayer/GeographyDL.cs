using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects;
using DatabaseLayer;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataLayer
{
    public class GeographyDL
    {
        public static DataTable findAllProvinces()
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "idProvincia", MySqlDbType = MySqlDbType.Int32, Value = DBNull.Value, Direction = ParameterDirection.Input},
            };

            return MyStoredProcs.callStoredProc("spProvincias_LLenar", lstParams);
        }

        public static DataTable findOneProvince(string idProvince)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "idProvincia", MySqlDbType = MySqlDbType.Int32, Value = idProvince, Direction = ParameterDirection.Input},
            };

            return MyStoredProcs.callStoredProc("spProvincias_LLenar", lstParams);
        }
    }
}
