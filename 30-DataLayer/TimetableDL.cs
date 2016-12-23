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
    public class TimetableDL
    {
        public static DataTable findAllTimetablesByPhysio(int idPhysio)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "fFecha", MySqlDbType = MySqlDbType.Date, Value = DBNull.Value, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDFisio", MySqlDbType = MySqlDbType.Int32, Value = idPhysio, Direction = ParameterDirection.Input}
            };

            return MyStoredProcs.callStoredProc("spJornadas_LLenar", lstParams);
        }

        public static DataTable findTimetableByPhysioAndDate(int idPhysio, DateTime date)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "fFecha", MySqlDbType = MySqlDbType.Date, Value = date, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDFisio", MySqlDbType = MySqlDbType.Int32, Value = idPhysio, Direction = ParameterDirection.Input}
            };

            return MyStoredProcs.callStoredProc("spJornadas_LLenar", lstParams);
        }

        public static bool saveTimetable(Timetable timeTable)
        {
            bool isOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "fDia", MySqlDbType = MySqlDbType.Date, Value = timeTable.Date, Direction = ParameterDirection.Input},
                //new MySqlParameter() {ParameterName = "sHoraIniM", MySqlDbType = MySqlDbType.String, Size = 5, Value = timeTable.MorningTimeStart, Direction = ParameterDirection.Input},
                //new MySqlParameter() {ParameterName = "sHoraFinM", MySqlDbType = MySqlDbType.String, Size = 5, Value = timeTable.MorningTimeFinish, Direction = ParameterDirection.Input},
                //new MySqlParameter() {ParameterName = "sHoraIniT", MySqlDbType = MySqlDbType.String, Size = 5, Value = timeTable.AfternoonTimeStart, Direction = ParameterDirection.Input},
                //new MySqlParameter() {ParameterName = "sHoraFinT", MySqlDbType = MySqlDbType.String, Size = 5, Value = timeTable.AfternoonTimeFinish, Direction = ParameterDirection.Input},
                //new MySqlParameter() {ParameterName = "iIntervaloM", MySqlDbType = MySqlDbType.Byte, Value = timeTable.MorningDuration, Direction = ParameterDirection.Input},
                //new MySqlParameter() {ParameterName = "iIntervaloT", MySqlDbType = MySqlDbType.Byte, Value = timeTable.AfternoonDuration, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDJornada", MySqlDbType = MySqlDbType.Int32, Value = timeTable.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "idFisio", MySqlDbType = MySqlDbType.Int32, Value = timeTable.Physiotherapist.Identifier, Direction = ParameterDirection.Input}
            };

            MySqlParameter sqlParam = null;

            if (string.IsNullOrWhiteSpace(timeTable.MorningTimeStart))
            {
                sqlParam = new MySqlParameter() { ParameterName = "sHoraIniM", MySqlDbType = MySqlDbType.String, Size = 5, Value = DBNull.Value, Direction = ParameterDirection.Input };
            }
            else
            {
                sqlParam = new MySqlParameter() { ParameterName = "sHoraIniM", MySqlDbType = MySqlDbType.String, Size = 5, Value = timeTable.MorningTimeStart, Direction = ParameterDirection.Input };
            }
            lstParams.Add(sqlParam);

            if (string.IsNullOrWhiteSpace(timeTable.MorningTimeFinish))
            {
                sqlParam = new MySqlParameter() { ParameterName = "sHoraFinM", MySqlDbType = MySqlDbType.String, Size = 5, Value = DBNull.Value, Direction = ParameterDirection.Input };
            }
            else
            {
                sqlParam = new MySqlParameter() { ParameterName = "sHoraFinM", MySqlDbType = MySqlDbType.String, Size = 5, Value = timeTable.MorningTimeFinish, Direction = ParameterDirection.Input };
            }
            lstParams.Add(sqlParam);

            if (string.IsNullOrWhiteSpace(timeTable.AfternoonTimeStart))
            {
                sqlParam = new MySqlParameter() { ParameterName = "sHoraIniT", MySqlDbType = MySqlDbType.String, Size = 5, Value = DBNull.Value, Direction = ParameterDirection.Input };
            }
            else
            {
                sqlParam = new MySqlParameter() { ParameterName = "sHoraIniT", MySqlDbType = MySqlDbType.String, Size = 5, Value = timeTable.AfternoonTimeStart, Direction = ParameterDirection.Input };
            }
            lstParams.Add(sqlParam);

            if (string.IsNullOrWhiteSpace(timeTable.AfternoonTimeFinish))
            {
                sqlParam = new MySqlParameter() { ParameterName = "sHoraFinT", MySqlDbType = MySqlDbType.String, Size = 5, Value = DBNull.Value, Direction = ParameterDirection.Input };
            }
            else
            {
                sqlParam = new MySqlParameter() { ParameterName = "sHoraFinT", MySqlDbType = MySqlDbType.String, Size = 5, Value = timeTable.AfternoonTimeFinish, Direction = ParameterDirection.Input };
            }
            lstParams.Add(sqlParam);

            if (timeTable.MorningDuration == 0)
            {
                sqlParam = new MySqlParameter() { ParameterName = "iIntervaloM", MySqlDbType = MySqlDbType.Byte, Value = DBNull.Value, Direction = ParameterDirection.Input };
            }
            else
            {
                sqlParam = new MySqlParameter() { ParameterName = "iIntervaloM", MySqlDbType = MySqlDbType.Byte, Value = timeTable.MorningDuration, Direction = ParameterDirection.Input };
            }
            lstParams.Add(sqlParam);

            if (timeTable.AfternoonDuration == 0)
            {
                sqlParam = new MySqlParameter() { ParameterName = "iIntervaloT", MySqlDbType = MySqlDbType.Byte, Value = DBNull.Value, Direction = ParameterDirection.Input };
            }
            else
            {
                sqlParam = new MySqlParameter() { ParameterName = "iIntervaloT", MySqlDbType = MySqlDbType.Byte, Value = timeTable.AfternoonDuration, Direction = ParameterDirection.Input };
            }
            lstParams.Add(sqlParam);


            int tmtCount = 0;

            isOK = MyStoredProcs.callStoredProc("spJornadas_Guardar", lstParams, ref tmtCount);

            return isOK;
        }
    }
}
