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
    public class TreatmentStatusDL
    {
        public static DataTable findAllStatuses()
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "idEstado", MySqlDbType = MySqlDbType.Byte, Value = DBNull.Value, Direction = ParameterDirection.Input}
            };

            return MyStoredProcs.callStoredProc("spEstados_LLenar", lstParams);
        }

        public static DataTable findOneStatus(byte idStatus)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "idEstado", MySqlDbType = MySqlDbType.Byte, Value = idStatus, Direction = ParameterDirection.Input}
            };

            return MyStoredProcs.callStoredProc("spEstados_LLenar", lstParams);
        }
    }
}
