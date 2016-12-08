using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using DatabaseLayer;
using Objects;

namespace DataLayer
{
    public class CancellationDL
    {
        public static DataTable findAllCancellations(int idPatient)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDPaciente", MySqlDbType = MySqlDbType.Int32, Value = idPatient, Direction = ParameterDirection.Input},
            };

            return MyStoredProcs.callStoredProc("spAnulaciones_LLenar", lstParams);
        }

        public static bool addCancellation(Cancellation cancellation, int idPatient)
        {
            bool isOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDPaciente", MySqlDbType = MySqlDbType.Int32, Value = idPatient, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "fFecha", MySqlDbType = MySqlDbType.Date, Value = cancellation.Date, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sMotivo", MySqlDbType = MySqlDbType.Text, Value = cancellation.Reason, Direction = ParameterDirection.Input}
            };

            int cancCount = 0;

            isOK = MyStoredProcs.callStoredProc("spAnulaciones_Anadir", lstParams, ref cancCount);

            return isOK;
        }

        public static bool modifyCancellation(Cancellation cancellation)
        {
            bool isOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDAnulacion", MySqlDbType = MySqlDbType.Int32, Value = cancellation.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "fFecha", MySqlDbType = MySqlDbType.Date, Value = cancellation.Date, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sMotivo", MySqlDbType = MySqlDbType.Text, Value = cancellation.Reason, Direction = ParameterDirection.Input}
            };

            int cancCount = 0;

            isOK = MyStoredProcs.callStoredProc("spAnulaciones_Modificar", lstParams, ref cancCount);

            return isOK;
        }
    }
}
