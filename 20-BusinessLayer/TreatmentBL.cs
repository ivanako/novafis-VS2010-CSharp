using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects;
using System.Data;
using DataLayer;

namespace BusinessLayer
{
    public class TreatmentBL
    {
        public static List<Treatment> findTreatmentsByPatient(int idPatient)
        {
            List<Treatment> lstTreatments = new List<Treatment>();

            DataTable dtTreatments = TreatmentDL.findTreatmentsByPatient(idPatient);

            foreach (DataRow drTreatment in dtTreatments.Rows)
            {
                Physiotherapist physio = PhysioBL.findOnePhysio(Convert.ToInt32(drTreatment["FIS_ID"]));
                TreatmentStatus status = TreatmentStatusBL.findOneStatus(Convert.ToByte(drTreatment["EST_ID"]));
                Location loc = LocationBL.findOneLocation(Convert.ToInt32(drTreatment["LOC_ID"]));
                Lesion les = LesionBL.findOneLesion(Convert.ToInt32(drTreatment["LES_ID"]));

                Treatment treat = new Treatment()
                {
                    Identifier = Convert.ToInt32(drTreatment["PAT_ID"]),
                    Description = drTreatment["PAT_Descripcion"].ToString(),
                    Date = Convert.ToDateTime(drTreatment["PAT_Fecha"]),
                    Paid = Convert.ToDouble(drTreatment["PAT_Cobrado"]),
                    Debt = Convert.ToDouble(drTreatment["PAT_Deuda"]),
                    Sessions = Convert.ToInt16(drTreatment["PAT_Sesiones"]),
                    Physiotherapist = physio,
                    Status = status,
                    Location = loc,
                    Lesion = les
                };

                lstTreatments.Add(treat);
            }

            return lstTreatments;
        }

        public static bool saveTreatment(Treatment treatment, int idPaciente)
        {
            //List<Treatment> lstTreatments = new List<Treatment>();

            bool isOK = true;

            if (treatment.Identifier == 0)
            {
                isOK = TreatmentDL.addTreatment(treatment, idPaciente);
            }
            else
            {
                isOK = TreatmentDL.modifyTreatment(treatment);
            }

            //if (isOK)
            //{
            //    lstTreatments = findTreatmentsByPatient(idPaciente);
            //}

            //return lstTreatments;
            return isOK;
        }
    }
}
