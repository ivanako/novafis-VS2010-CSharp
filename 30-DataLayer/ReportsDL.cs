using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using DatabaseLayer;

namespace DataLayer
{
    public class ReportsDL
    {
        public static DataTable generatePhysioPatient(DateTime repDateStart, Nullable<DateTime> repDateEnd)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "fFechaIni", MySqlDbType = MySqlDbType.Date, Value = repDateStart, Direction = ParameterDirection.Input}
            };

            MySqlParameter sqlParam = null;

            if (repDateEnd == null)
            {
                sqlParam = new MySqlParameter() { ParameterName = "fFechaFin", MySqlDbType = MySqlDbType.Date, Value = DBNull.Value, Direction = ParameterDirection.Input };
            }
            else
            {
                sqlParam = new MySqlParameter() { ParameterName = "fFechaFin", MySqlDbType = MySqlDbType.Date, Value = repDateEnd, Direction = ParameterDirection.Input };
            }
            lstParams.Add(sqlParam);

            return MyStoredProcs.callStoredProc("spInformes_PacientesFisios", lstParams);
        }

        public static DataTable generateFormPaymentPatient(DateTime repDateStart, Nullable<DateTime> repDateEnd)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "fFechaIni", MySqlDbType = MySqlDbType.Date, Value = repDateStart, Direction = ParameterDirection.Input}
            };

            MySqlParameter sqlParam = null;

            if (repDateEnd == null)
            {
                sqlParam = new MySqlParameter() { ParameterName = "fFechaFin", MySqlDbType = MySqlDbType.Date, Value = DBNull.Value, Direction = ParameterDirection.Input };
            }
            else
            {
                sqlParam = new MySqlParameter() { ParameterName = "fFechaFin", MySqlDbType = MySqlDbType.Date, Value = repDateEnd, Direction = ParameterDirection.Input };
            }
            lstParams.Add(sqlParam);

            return MyStoredProcs.callStoredProc("spInformes_FormaPagoPacientes", lstParams);
        }
    }
       
}
