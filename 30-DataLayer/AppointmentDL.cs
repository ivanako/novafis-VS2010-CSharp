using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using DatabaseLayer;

namespace DataLayer
{
    public class AppointmentDL
    {
        public static DataTable findAppointmentsByDate(DateTime appDate, int idPhysio)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "fFecha", MySqlDbType = MySqlDbType.Date, Value = appDate, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "idFisio", MySqlDbType = MySqlDbType.Int32, Value = idPhysio, Direction = ParameterDirection.Input}
            };

            return MyStoredProcs.callStoredProc("spCitas_LLenar", lstParams);
        }
    }
}
