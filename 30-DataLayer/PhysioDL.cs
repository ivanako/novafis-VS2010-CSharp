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
    public class PhysioDL
    {
        public static DataTable findAllPhysios()
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDFisio", MySqlDbType = MySqlDbType.Int32, Value = DBNull.Value, Direction = ParameterDirection.Input}
            };

            DataTable dtPhysios = MyStoredProcs.callStoredProc("spFisios_LLenar", lstParams);

            return dtPhysios;
        }

        public static DataTable findOnePhysio(int idPhysio)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDFisio", MySqlDbType = MySqlDbType.Int32, Value = idPhysio, Direction = ParameterDirection.Input}
            };

            return MyStoredProcs.callStoredProc("spFisios_LLenar", lstParams); ;
        }


        public static bool savePhysio(Physiotherapist physio)
        {
            bool isOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDFisio", MySqlDbType = MySqlDbType.Int32, Value = physio.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sNombre", MySqlDbType = MySqlDbType.VarChar, Size = 50, Value = physio.Name, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sApellido1", MySqlDbType = MySqlDbType.VarChar, Size = 50, Value = physio.Surname1, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sApellido2", MySqlDbType = MySqlDbType.VarChar, Size = 50, Value = physio.Surname2, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sAlias", MySqlDbType = MySqlDbType.VarChar, Size = 50, Value = physio.Alias, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sIdentificacion", MySqlDbType = MySqlDbType.VarChar, Size = 20, Value = physio.Identification, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "fFechaAlta", MySqlDbType = MySqlDbType.Date, Value = physio.EntryDate, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sNumColegiado", MySqlDbType = MySqlDbType.VarChar, Size = 50, Value = physio.LicenseNumber, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sSexo", MySqlDbType = MySqlDbType.String, Size = 1, Value = physio.Gender, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "fFechaBaja", MySqlDbType = MySqlDbType.Date, Value = physio.TerminationDate, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sColor", MySqlDbType = MySqlDbType.String, Size = 7, Value = physio.Colour, Direction = ParameterDirection.Input}
            };

            int phyCount = 0;

            isOK = MyStoredProcs.callStoredProc("spFisios_Guardar", lstParams, ref phyCount);

            return isOK;
        }
    }
}
