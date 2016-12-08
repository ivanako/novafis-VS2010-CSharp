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
    public class ObservationDL
    {
        public static DataTable findObservationsByPatient(int idPatient)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDPaciente", MySqlDbType = MySqlDbType.Int32, Value = idPatient, Direction = ParameterDirection.Input},
            };

            return MyStoredProcs.callStoredProc("spObservaciones_LLenar", lstParams);
        }

        public static bool addObservation(Observation observation, int idPatient)
        {
            bool isOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDPaciente", MySqlDbType = MySqlDbType.Int32, Value = idPatient, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sObservacion", MySqlDbType = MySqlDbType.Text, Value = observation.Description, Direction = ParameterDirection.Input}
            };

            int obsCount = 0;

            isOK = MyStoredProcs.callStoredProc("spObservaciones_Anadir", lstParams, ref obsCount);

            return isOK;
        }

        public static bool modifyObservation(Observation observation)
        {
            bool isOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDObservacion", MySqlDbType = MySqlDbType.Int32, Value = observation.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sObservacion", MySqlDbType = MySqlDbType.VarChar, Size = 200, Value = observation.Description, Direction = ParameterDirection.Input}
            };

            int obsCount = 0;

            isOK = MyStoredProcs.callStoredProc("spObservaciones_Modificar", lstParams, ref obsCount);

            return isOK;
        }
    }
}
