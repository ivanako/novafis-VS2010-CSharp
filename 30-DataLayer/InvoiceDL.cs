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
    public class InvoiceDL
    {
        public static DataTable findInvoicesByPhysio(int idPhysio)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "sIDFactura", MySqlDbType = MySqlDbType.String, Size = 9, Value = DBNull.Value, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "idFisio", MySqlDbType = MySqlDbType.Int32, Value = idPhysio, Direction = ParameterDirection.Input}
            };

            DataTable dtPhysios = MyStoredProcs.callStoredProc("spFacturas_LLenar", lstParams);

            return dtPhysios;
        }

        public static string addInvoice(Invoice inv)
        {
            string invNumber = string.Empty;

            bool addOK = true;

            Nullable<int> idPatient = null;

            if (inv.Patient != null)
            {
                idPatient = inv.Patient.Identifier;
            }

            string otherPat = null;

            if (!string.IsNullOrWhiteSpace(inv.Client))
            {
                otherPat = inv.Client;
            }

            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "fFecha", MySqlDbType = MySqlDbType.Date, Value = inv.Date, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iIDPaciente", MySqlDbType = MySqlDbType.Int32, Value = idPatient, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sReceptor", MySqlDbType = MySqlDbType.VarChar, Size = 100, Value = otherPat, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sIdentificacion", MySqlDbType = MySqlDbType.VarChar, Size = 15, Value = inv.Identification, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "iSesiones", MySqlDbType = MySqlDbType.Byte, Value = inv.Sessions, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "sTratamiento", MySqlDbType = MySqlDbType.VarChar, Size = 100, Value = inv.Treatment, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "dImporte", MySqlDbType = MySqlDbType.Decimal, Scale = 5, Precision = 2, Value = inv.Amount, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "idFisio", MySqlDbType = MySqlDbType.Int32, Value = inv.Physio.Identifier, Direction = ParameterDirection.Input},
                new MySqlParameter() {ParameterName = "numFactura", MySqlDbType = MySqlDbType.String, Size = 9, Direction = ParameterDirection.Output}
            };

            int invCount = 0;

            addOK = MyStoredProcs.callStoredProc("spFacturas_Anadir", lstParams, ref invCount);

            if (addOK)
            {
                invNumber = lstParams[8].Value.ToString();
            }

            return invNumber;
        }
    }
}
