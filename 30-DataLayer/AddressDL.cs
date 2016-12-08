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
    public class AddressDL
    {
        public static DataTable findOneAddress(int idPatient)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDPaciente", MySqlDbType = MySqlDbType.Int32, Value = idPatient, Direction = ParameterDirection.Input}
            };

            return MyStoredProcs.callStoredProc("spPacientes_DireccionLLenar", lstParams);
        }

        public static bool addAddress(Address patAddress, int idPatient)
        {
            bool addOK = false;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDPaciente", MySqlDbType = MySqlDbType.Int32, Value = idPatient, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sVia", MySqlDbType = MySqlDbType.VarChar, Size = 100, Value = patAddress.Thoroughfare, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sNumero", MySqlDbType = MySqlDbType.VarChar, Size = 20, Value = patAddress.Number, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sBloque", MySqlDbType = MySqlDbType.VarChar, Size = 50, Value = patAddress.Block, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sPiso", MySqlDbType = MySqlDbType.VarChar, Size = 10, Value = patAddress.Floor, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sEscalera", MySqlDbType = MySqlDbType.VarChar, Size = 20, Value = patAddress.Stair, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sPuerta", MySqlDbType = MySqlDbType.VarChar, Size = 20, Value = patAddress.Gate, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sCPostal", MySqlDbType = MySqlDbType.VarChar, Size = 10, Value = patAddress.PostCode, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sTelefono1", MySqlDbType = MySqlDbType.VarChar, Size = 10, Value = patAddress.Phone1, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sTelefono2", MySqlDbType = MySqlDbType.VarChar, Size = 10, Value = patAddress.Phone2, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sTelefono3", MySqlDbType = MySqlDbType.VarChar, Size = 10, Value = patAddress.Phone3, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sEMail", MySqlDbType = MySqlDbType.VarChar, Size = 50, Value = patAddress.Email, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sWeb", MySqlDbType = MySqlDbType.VarChar, Size = 100, Value = patAddress.Web, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sCiudad", MySqlDbType = MySqlDbType.VarChar, Size = 100, Value = patAddress.City, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sIDProvincia", MySqlDbType = MySqlDbType.String, Size = 2, Value = patAddress.Province.Identifier, Direction = ParameterDirection.Input}
            };

            int addressCount = 0;

            addOK = MyStoredProcs.callStoredProc("spPacientes_DireccionAnadir", lstParams, ref addressCount);

            return addOK;
        }

        public static bool modifyAddress(Address patAddress, int idPatient)
        {
            bool addOK = false;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDPaciente", MySqlDbType = MySqlDbType.Int32, Value = idPatient, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sVia", MySqlDbType = MySqlDbType.VarChar, Size = 100, Value = patAddress.Thoroughfare, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sNumero", MySqlDbType = MySqlDbType.VarChar, Size = 20, Value = patAddress.Number, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sBloque", MySqlDbType = MySqlDbType.VarChar, Size = 50, Value = patAddress.Block, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sPiso", MySqlDbType = MySqlDbType.VarChar, Size = 10, Value = patAddress.Floor, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sEscalera", MySqlDbType = MySqlDbType.VarChar, Size = 20, Value = patAddress.Stair, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sPuerta", MySqlDbType = MySqlDbType.VarChar, Size = 20, Value = patAddress.Gate, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sCPostal", MySqlDbType = MySqlDbType.VarChar, Size = 10, Value = patAddress.PostCode, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sTelefono1", MySqlDbType = MySqlDbType.VarChar, Size = 10, Value = patAddress.Phone1, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sTelefono2", MySqlDbType = MySqlDbType.VarChar, Size = 10, Value = patAddress.Phone2, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sTelefono3", MySqlDbType = MySqlDbType.VarChar, Size = 10, Value = patAddress.Phone3, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sEMail", MySqlDbType = MySqlDbType.VarChar, Size = 50, Value = patAddress.Email, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sWeb", MySqlDbType = MySqlDbType.VarChar, Size = 100, Value = patAddress.Web, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sCiudad", MySqlDbType = MySqlDbType.VarChar, Size = 100, Value = patAddress.City, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sIDProvincia", MySqlDbType = MySqlDbType.String, Size = 2, Value = patAddress.Province.Identifier, Direction = ParameterDirection.Input}
            };

            int addressCount = 0;

            addOK = MyStoredProcs.callStoredProc("spPacientes_DireccionModificar", lstParams, ref addressCount);

            return addOK;
        }
    }
}
