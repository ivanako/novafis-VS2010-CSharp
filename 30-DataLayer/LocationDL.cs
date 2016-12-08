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
    public class LocationDL
    {

        public static DataTable findAllLocations()
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "idLocalizacion", MySqlDbType = MySqlDbType.Int32, Value = DBNull.Value, Direction = ParameterDirection.Input}
            };

            return MyStoredProcs.callStoredProc("spLocalizaciones_LLenar", lstParams); ;
        }

        public static DataTable findOneLocation(int idLocalizacion)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "idLocalizacion", MySqlDbType = MySqlDbType.Int32, Value = idLocalizacion, Direction = ParameterDirection.Input}
            };

            return MyStoredProcs.callStoredProc("spLocalizaciones_LLenar", lstParams);
        }

        public static bool addLocation(Location location)
        {
            bool isOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "sLocalizacion", MySqlDbType = MySqlDbType.VarChar, Size = 100, Value = location.Description, Direction = ParameterDirection.Input}
            };

            int locCount = 0;

            isOK = MyStoredProcs.callStoredProc("spLocalizaciones_Anadir", lstParams, ref locCount);

            return isOK;
        }

        public static bool modifyLocation(Location location)
        {
            bool isOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDLocalizacion", MySqlDbType = MySqlDbType.Int32, Value = location.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sLocalizacion", MySqlDbType = MySqlDbType.VarChar, Size = 100, Value = location.Description, Direction = ParameterDirection.Input}
            };

            int locCount = 0;

            isOK = MyStoredProcs.callStoredProc("spLocalizaciones_Modificar", lstParams, ref locCount);

            return isOK;
        }
    }
}
