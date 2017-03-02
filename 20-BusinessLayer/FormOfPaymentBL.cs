using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects;
using System.Data;
using DataLayer;

namespace BusinessLayer
{
    public class FormOfPaymentBL
    {
        public static List<FormOfPayment> findAllFormsOfPayment()
        {
            List<FormOfPayment> lstFormsPayment = new List<FormOfPayment>();

            DataTable dtFormsPayment = FormOfPaymentDL.findAllFormsOfPayment();

            foreach (DataRow drFpy in dtFormsPayment.Rows)
            {
                FormOfPayment fpy = new FormOfPayment()
                {
                    Code = Convert.ToString(drFpy["FPG_Code"]),
                    Name = Convert.ToString(drFpy["FPG_Nombre"])
                };

                lstFormsPayment.Add(fpy);
            }

            return lstFormsPayment;
        }

        public static FormOfPayment findOneFormOfPayment(string idFormOfPayment)
        {
            FormOfPayment formPayment = new FormOfPayment();

            DataTable dtFormsPayment = FormOfPaymentDL.findOneFormOfPayment(idFormOfPayment);

            if (dtFormsPayment.Rows.Count == 1)
            {
                formPayment.Code = Convert.ToString(dtFormsPayment.Rows[0]["FPG_Code"]);
                formPayment.Name = Convert.ToString(dtFormsPayment.Rows[0]["FPG_Nombre"]);
            }

            return formPayment;
        }
    }
}
