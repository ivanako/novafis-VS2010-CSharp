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
    public class TreatmentDL
    {
        public static DataTable findTreatmentsByPatient(int idPatient)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDPaciente", MySqlDbType = MySqlDbType.Int32, Value = idPatient, Direction = ParameterDirection.Input},
            };

            return MyStoredProcs.callStoredProc("spTratamientos_LLenar", lstParams);
        }

        public static bool addTreatment(Treatment treatment, int idPaciente)
        {
            bool isOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "fFecha", MySqlDbType = MySqlDbType.Date, Value = treatment.Date, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sDescripcion", MySqlDbType = MySqlDbType.VarChar, Size = 500, Value = treatment.Description, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDEstado", MySqlDbType = MySqlDbType.Byte, Value = treatment.Status.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDLocalizacion", MySqlDbType = MySqlDbType.Int32, Value = treatment.Location.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDLesion", MySqlDbType = MySqlDbType.Int32, Value = treatment.Lesion.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iSesiones", MySqlDbType = MySqlDbType.Int16, Value = treatment.Sessions, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDFisio", MySqlDbType = MySqlDbType.Int32, Value = treatment.Physiotherapist.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDPaciente", MySqlDbType = MySqlDbType.Int32, Value = idPaciente, Direction = ParameterDirection.Input}
            };

            int treatCount = 0;

            isOK = MyStoredProcs.callStoredProc("spTratamientos_Anadir", lstParams, ref treatCount);

            return isOK;
        }

        public static bool modifyTreatment(Treatment treatment)
        {
            bool isOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "fFecha", MySqlDbType = MySqlDbType.Date, Value = treatment.Date, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sDescripcion", MySqlDbType = MySqlDbType.VarChar, Size = 500, Value = treatment.Description, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDEstado", MySqlDbType = MySqlDbType.Byte, Value = treatment.Status.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDLocalizacion", MySqlDbType = MySqlDbType.Int32, Value = treatment.Location.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDLesion", MySqlDbType = MySqlDbType.Int32, Value = treatment.Lesion.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iSesiones", MySqlDbType = MySqlDbType.Int16, Value = treatment.Sessions, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDFisio", MySqlDbType = MySqlDbType.Int32, Value = treatment.Physiotherapist.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDTratamiento", MySqlDbType = MySqlDbType.Int32, Value = treatment.Identifier, Direction = ParameterDirection.Input}
            };

            int treatCount = 0;

            isOK = MyStoredProcs.callStoredProc("spTratamientos_Modificar", lstParams, ref treatCount);

            return isOK;
        }

        public static bool deleteTreatment(long idTreatment)
        {
            bool isOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDTratamiento", MySqlDbType = MySqlDbType.Int64, Value = idTreatment, Direction = ParameterDirection.Input}
            };

            int treatCount = 0;

            isOK = MyStoredProcs.callStoredProc("spTratamientos_Eliminar", lstParams, ref treatCount);

            return isOK;
        }
    }
}
