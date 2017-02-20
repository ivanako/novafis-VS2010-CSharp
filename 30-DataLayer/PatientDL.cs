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
    public class PatientDL
    {
        public static DataTable findAllPatients()
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "idPatient", MySqlDbType = MySqlDbType.Int32, Value = DBNull.Value, Direction = ParameterDirection.Input}
            };

            return MyStoredProcs.callStoredProc("spPatients_FindAll", lstParams);
        }

        public static DataTable findOnePatient(int idPatient)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "idPatient", MySqlDbType = MySqlDbType.Int32, Value = idPatient, Direction = ParameterDirection.Input}
            };

            return MyStoredProcs.callStoredProc("spPatients_FindAll", lstParams);
        }

        public static int addPatient(Patient pat)
        {
            int idPatient = 0;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "sNombre", MySqlDbType = MySqlDbType.VarChar, Size = 50, Value = pat.Name, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sApellido1", MySqlDbType = MySqlDbType.VarChar, Size = 50, Value = pat.Surname1, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sApellido2", MySqlDbType = MySqlDbType.VarChar, Size = 50, Value = pat.Surname2, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sIdentificacion", MySqlDbType = MySqlDbType.VarChar, Size = 20, Value = pat.Identification, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "fFRegistro", MySqlDbType = MySqlDbType.Date, Value = pat.EntryDate, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "fFNacimiento", MySqlDbType = MySqlDbType.Date, Value = pat.DateOfBirth, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sSexo", MySqlDbType = MySqlDbType.String, Size = 1, Value = pat.Gender, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sConocer", MySqlDbType = MySqlDbType.VarChar, Size = 100, Value = pat.HowHeardAboutUs, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDPaciente", MySqlDbType = MySqlDbType.Int32, Direction = ParameterDirection.Output},
                new MySqlParameter() {ParameterName = "bListaNegra", MySqlDbType = MySqlDbType.Bit, Value = pat.BlackList, Direction = ParameterDirection.Input}
            };

            MySqlParameter sqlAdd = null;

            if (pat.Physiotherapist == null)
            {
                sqlAdd = new MySqlParameter() { ParameterName = "iIDFisio", MySqlDbType = MySqlDbType.Int32, Value = DBNull.Value, Direction = ParameterDirection.Input };
            }
            else
            {
                sqlAdd = new MySqlParameter() { ParameterName = "iIDFisio", MySqlDbType = MySqlDbType.Int32, Value = pat.Physiotherapist.Identifier, Direction = ParameterDirection.Input };
            }
            lstParams.Add(sqlAdd);

            if (pat.Source == null)
            {
                sqlAdd = new MySqlParameter() { ParameterName = "iIDFuente", MySqlDbType = MySqlDbType.Int32, Value = DBNull.Value, Direction = ParameterDirection.Input };
            }
            else
            {
                sqlAdd = new MySqlParameter() { ParameterName = "iIDFuente", MySqlDbType = MySqlDbType.Int32, Value = pat.Source.Identifier, Direction = ParameterDirection.Input };
            }
            lstParams.Add(sqlAdd);

            int patCount = 0;

            bool isOK = MyStoredProcs.callStoredProc("spPacientes_DPersonalesAnadir", lstParams, ref patCount);

            if (isOK)
            {
                idPatient = Convert.ToInt32(lstParams[8].Value);
            }

            return idPatient;
        }

        public static bool modifyPatient(Patient pat)
        {
            bool isOK = false;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "sNombre", MySqlDbType = MySqlDbType.VarChar, Size = 50, Value = pat.Name, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sApellido1", MySqlDbType = MySqlDbType.VarChar, Size = 50, Value = pat.Surname1, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sApellido2", MySqlDbType = MySqlDbType.VarChar, Size = 50, Value = pat.Surname2, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sIdentificacion", MySqlDbType = MySqlDbType.VarChar, Size = 20, Value = pat.Identification, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "fFRegistro", MySqlDbType = MySqlDbType.Date, Value = pat.EntryDate, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "fFNacimiento", MySqlDbType = MySqlDbType.Date, Value = pat.DateOfBirth, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sSexo", MySqlDbType = MySqlDbType.String, Size = 1, Value = pat.Gender, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sConocer", MySqlDbType = MySqlDbType.VarChar, Size = 100, Value = pat.HowHeardAboutUs, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDFisio", MySqlDbType = MySqlDbType.Int32, Value = pat.Physiotherapist.Identifier, Direction = ParameterDirection.Input},
                //new MySqlParameter() {ParameterName = "iIDFuente", MySqlDbType = MySqlDbType.Int32, Value = pat.Source.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDPaciente", MySqlDbType = MySqlDbType.Int32, Value = pat.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "bListaNegra", MySqlDbType = MySqlDbType.Bit, Value = pat.BlackList, Direction = ParameterDirection.Input}
            };


            MySqlParameter sqlMod = null;

            if (pat.Source == null)
            {
                sqlMod = new MySqlParameter() { ParameterName = "iIDFuente", MySqlDbType = MySqlDbType.Int32, Value = DBNull.Value, Direction = ParameterDirection.Input };
            }
            else
            {
                sqlMod = new MySqlParameter() { ParameterName = "iIDFuente", MySqlDbType = MySqlDbType.Int32, Value = pat.Source.Identifier, Direction = ParameterDirection.Input };
            }
            lstParams.Add(sqlMod);


            int patCount = 0;

            isOK = MyStoredProcs.callStoredProc("spPacientes_DPersonalesModificar", lstParams, ref patCount);

            return isOK;
        }

        public static bool deletePatient(int idPatient)
        {
            bool isOK = false;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDPaciente", MySqlDbType = MySqlDbType.Int32, Value = idPatient, Direction = ParameterDirection.Input}
            };

            int patCount = 0;

            isOK = MyStoredProcs.callStoredProc("spPacientes_Eliminar", lstParams, ref patCount);

            return isOK;
        }

        public static DataTable searchPatients(string patName, string patSurname1, string patSurname2, string patIdentification, 
            string patAboutUs, string patPhone, int patSource)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "patName", MySqlDbType = MySqlDbType.VarChar, Size = 50, Value = patName, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "patSurname1", MySqlDbType = MySqlDbType.VarChar, Size = 50, Value = patSurname1, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "patSurname2", MySqlDbType = MySqlDbType.VarChar, Size = 50, Value = patSurname2, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "patIdentification", MySqlDbType = MySqlDbType.VarChar, Size = 20, Value = patIdentification, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "patAboutUs", MySqlDbType = MySqlDbType.VarChar, Size = 100, Value = patAboutUs, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "patPhone", MySqlDbType = MySqlDbType.VarChar, Size = 20, Value = patPhone, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "patSource", MySqlDbType = MySqlDbType.Int32, Value = patSource, Direction = ParameterDirection.Input}
            };

            return MyStoredProcs.callStoredProc("spPacientes_Search", lstParams);
        }
    }
}
