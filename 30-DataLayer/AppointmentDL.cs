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
    public class AppointmentDL
    {
        public static DataTable findAppointmentsByDate(DateTime appDate, int idPhysio)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "fFecha", MySqlDbType = MySqlDbType.Date, Value = appDate, Direction = ParameterDirection.Input}
                //new MySqlParameter() {ParameterName = "idFisio", MySqlDbType = MySqlDbType.Int32, Value = idPhysio, Direction = ParameterDirection.Input}
            };

            MySqlParameter sqlAdd = null;

            if (idPhysio == 0)
            {
                sqlAdd = new MySqlParameter() { ParameterName = "idFisio", MySqlDbType = MySqlDbType.Int32, Value = DBNull.Value, Direction = ParameterDirection.Input };
            }
            else
            {
                sqlAdd = new MySqlParameter() { ParameterName = "idFisio", MySqlDbType = MySqlDbType.Int32, Value = idPhysio, Direction = ParameterDirection.Input };
            }
            lstParams.Add(sqlAdd);

            return MyStoredProcs.callStoredProc("spCitas_LLenar", lstParams);
        }

        public static bool saveAppointment(Appointment app)
        {
            bool saveOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDCita", MySqlDbType = MySqlDbType.Int32, Value = app.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "fFecha", MySqlDbType = MySqlDbType.Date, Value = app.Date, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sHora", MySqlDbType = MySqlDbType.String, Size = 5, Value = app.Time, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDPaciente", MySqlDbType = MySqlDbType.Int32, Value = app.Patient.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sObservacion", MySqlDbType = MySqlDbType.VarChar, Size = 200, Value = app.Observation, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "bAnular", MySqlDbType = MySqlDbType.Bit, Value = app.IsCancelled, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sMotivo", MySqlDbType = MySqlDbType.VarChar, Size = 200, Value = app.CancellationWhy, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "dCobrado", MySqlDbType = MySqlDbType.Decimal, Scale = 5, Precision = 2, Value = app.Paid, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "dDeuda", MySqlDbType = MySqlDbType.Decimal, Scale = 5, Precision = 2, Value = app.Debt, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDFisio", MySqlDbType = MySqlDbType.Int32, Value = app.Physiotherapist.Identifier, Direction = ParameterDirection.Input}
            };

            saveOK = MyStoredProcs.callStoredProc2("spCitas_Guardar", lstParams);

            return saveOK;
        }

        public static bool deleteAppointment(Appointment app)
        {
            bool delOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDCita", MySqlDbType = MySqlDbType.Int32, Value = app.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "fFecha", MySqlDbType = MySqlDbType.Date, Value = app.Date, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDPaciente", MySqlDbType = MySqlDbType.Int32, Value = app.Patient.Identifier, Direction = ParameterDirection.Input},
            };

            delOK = MyStoredProcs.callStoredProc2("spCitas_Eliminar", lstParams);

            return delOK;
        }


        public static bool checkDebt(int idPatient, DateTime appDate, ref double patDebt, ref DateTime patDebtDate, ref string patObs)
        {
            bool checkOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDPaciente", MySqlDbType = MySqlDbType.Int32, Value = idPatient, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "fFecha", MySqlDbType = MySqlDbType.Date, Value = appDate, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "dDeuda", MySqlDbType = MySqlDbType.Decimal, Scale = 5, Precision = 2, Direction = ParameterDirection.Output},
                new MySqlParameter() {ParameterName = "fFechaDeuda", MySqlDbType = MySqlDbType.Date, Direction = ParameterDirection.Output},
                new MySqlParameter() {ParameterName = "sObs", MySqlDbType = MySqlDbType.VarChar, Size = 500, Direction = ParameterDirection.Output}
            };

            checkOK = MyStoredProcs.callStoredProc2("spCitas_ComprobarDeuda", lstParams);

            if (checkOK)
            {
                if (lstParams[2].Value != DBNull.Value)
                {
                    patDebt = Convert.ToDouble(lstParams[2].Value);
                }
                if (lstParams[3].Value != DBNull.Value)
                {
                    patDebtDate = DateTime.Parse(lstParams[3].Value.ToString());
                }
                patObs = Convert.ToString(lstParams[4].Value);
            }

            return checkOK;
        }
    }
}
