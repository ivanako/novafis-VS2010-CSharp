using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataLayer;
using Objects;

namespace BusinessLayer
{
    public class TreatmentStatusBL
    {
        public static List<TreatmentStatus> findAllStatuses()
        {
            List<TreatmentStatus> lstStatuses = new List<TreatmentStatus>();

            DataTable dtStatuses = TreatmentStatusDL.findAllStatuses();

            foreach (DataRow drStatus in dtStatuses.Rows)
            {
                TreatmentStatus status = new TreatmentStatus()
                {
                    Identifier = Convert.ToByte(drStatus["EST_ID"]),
                    Description = drStatus["EST_Descripcion"].ToString()
                };

                lstStatuses.Add(status);
            }

            return lstStatuses;
        }

        public static TreatmentStatus findOneStatus(byte idStatus)
        {
            TreatmentStatus status = new TreatmentStatus();

            DataTable dtStatus = TreatmentStatusDL.findOneStatus(idStatus);

            if (dtStatus.Rows.Count == 1)
            {
                status.Identifier = Convert.ToByte(dtStatus.Rows[0]["EST_ID"]);
                status.Description = dtStatus.Rows[0]["EST_Descripcion"].ToString();
            }

            return status;
        }
    }
}
