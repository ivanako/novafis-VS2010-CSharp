using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DatabaseLayer;
using Objects;
using MySql.Data.MySqlClient;

namespace DataLayer
{
    public class LesionDL
    {
        public static DataTable findAllLesions()
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "idLesion", MySqlDbType = MySqlDbType.Int32, Value = DBNull.Value, Direction = ParameterDirection.Input}
            };

            return MyStoredProcs.callStoredProc("spLesiones_LLenar", lstParams);
        }

        public static DataTable findOneLesion(int idLesion)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "idLesion", MySqlDbType = MySqlDbType.Int32, Value = idLesion, Direction = ParameterDirection.Input}
            };

            return MyStoredProcs.callStoredProc("spLesiones_LLenar", lstParams);
        }

        public static bool addLesion(Lesion lesion)
        {
            bool isOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "sLesion", MySqlDbType = MySqlDbType.VarChar, Size = 100, Value = lesion.Description, Direction = ParameterDirection.Input}
            };

            int lesCount = 0;

            isOK = MyStoredProcs.callStoredProc("spLesiones_Anadir", lstParams, ref lesCount);

            return isOK;
        }

        public static bool modifyLesion(Lesion lesion)
        {
            bool isOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDLesion", MySqlDbType = MySqlDbType.Int32, Value = lesion.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sLesion", MySqlDbType = MySqlDbType.VarChar, Size = 100, Value = lesion.Description, Direction = ParameterDirection.Input}
            };

            int lesCount = 0;

            isOK = MyStoredProcs.callStoredProc("spLesiones_Modificar", lstParams, ref lesCount);

            return isOK;
        }
    }
}
