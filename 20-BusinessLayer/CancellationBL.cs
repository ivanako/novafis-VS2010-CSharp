using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Objects;
using DataLayer;

namespace BusinessLayer
{
    public class CancellationBL
    {
        public static List<Cancellation> findAllCancellations(int idPatient)
        {
            List<Cancellation> lstCancellations = new List<Cancellation>();

            DataTable dtCancellation = CancellationDL.findAllCancellations(idPatient);

            foreach (DataRow drCanc in dtCancellation.Rows)
            {
                Cancellation canc = new Cancellation()
                {
                    Identifier = Convert.ToInt32(drCanc["PAA_ID"]),
                    Date = Convert.ToDateTime(drCanc["PAA_Fecha"]),
                    Reason = drCanc["PAA_Motivo"].ToString()
                };

                lstCancellations.Add(canc);
            }

            return lstCancellations;
        }

        public static bool addCancellation(Cancellation cancellation, int idPatient)
        {
            return CancellationDL.addCancellation(cancellation, idPatient);
        }

        public static bool modifyCancellation(Cancellation cancellation)
        {
            return CancellationDL.modifyCancellation(cancellation);
        }
    }
}
