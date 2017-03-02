using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using DatabaseLayer;

namespace DataLayer
{
    public class FormOfPaymentDL
    {
        public static DataTable findAllFormsOfPayment()
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "idFormaPago", MySqlDbType = MySqlDbType.String, Size = 3, Value = DBNull.Value, Direction = ParameterDirection.Input}
            };

            return MyStoredProcs.callStoredProc("spFormasPago_Llenar", lstParams);
        }

        public static DataTable findOneFormOfPayment(string idFormOfPayment)
        {
            List<MySqlParameter> lstParams = new List<MySqlParameter>()
            {
                new MySqlParameter() {ParameterName = "idFormaPago", MySqlDbType = MySqlDbType.String, Size = 3, Value = idFormOfPayment, Direction = ParameterDirection.Input}
            };

            return MyStoredProcs.callStoredProc("spFormasPago_Llenar", lstParams);
        }
    }
}
