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
    public class NoteDL
    {
        public static DataTable findAllNotes()
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDNota", MySqlDbType = MySqlDbType.Int32, Value = DBNull.Value, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "fFecha", MySqlDbType = MySqlDbType.Date, Value = DBNull.Value, Direction = ParameterDirection.Input}
            };

            return MyStoredProcs.callStoredProc("spNotas_LLenar", lstParams);
        }

        public static DataTable findNotesByDate(DateTime noteDate)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDNota", MySqlDbType = MySqlDbType.Int32, Value = DBNull.Value, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "fFecha", MySqlDbType = MySqlDbType.Date, Value = noteDate, Direction = ParameterDirection.Input}
            };

            return MyStoredProcs.callStoredProc("spNotas_LLenar", lstParams);
        }

        public static bool addNote(Note note)
        {
            bool isOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "fFecha", MySqlDbType = MySqlDbType.Date, Value = note.Date, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sNota", MySqlDbType = MySqlDbType.VarChar, Size = 100, Value = note.Description, Direction = ParameterDirection.Input}
            };

            int noteCount = 0;

            isOK = MyStoredProcs.callStoredProc("spNotas_Anadir", lstParams, ref noteCount);

            return isOK;
        }
        public static bool modifyNote(Note note)
        {
            bool isOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "fFecha", MySqlDbType = MySqlDbType.Date, Value = note.Date, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sNota", MySqlDbType = MySqlDbType.VarChar, Size = 100, Value = note.Description, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDNota", MySqlDbType = MySqlDbType.Int32, Value = note.Identifier, Direction = ParameterDirection.Input}
            };

            int noteCount = 0;

            isOK = MyStoredProcs.callStoredProc("spNotas_Modificar", lstParams, ref noteCount);

            return isOK;
        }
        public static bool deleteNote(int idNote)
        {
            bool isOK = true;

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "iIDNota", MySqlDbType = MySqlDbType.Int32, Value = idNote, Direction = ParameterDirection.Input}
            };

            int noteCount = 0;

            isOK = MyStoredProcs.callStoredProc("spNotas_Eliminar", lstParams, ref noteCount);

            return isOK;
        }
    }
}
