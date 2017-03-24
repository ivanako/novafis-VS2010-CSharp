using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Objects;
using DataLayer;

namespace BusinessLayer
{
    public class ReportsBL
    {
        public static List<ReportPhysioPat> generatePhysioPatient(DateTime repDate, Nullable<DateTime> repDateEnd)
        {
            List<ReportPhysioPat> lstPhysioPat = new List<ReportPhysioPat>();

            DataTable dtPhysioPat = ReportsDL.generatePhysioPatient(repDate, repDateEnd);

            foreach (DataRow drPhyPat in dtPhysioPat.Rows)
            {
                int idPhysio = Convert.ToInt32(drPhyPat["FIS_ID"]);

                Physiotherapist phy = PhysioBL.findOnePhysio(idPhysio);

                ReportPhysioPat phyPat = new ReportPhysioPat()
                {
                    Physio = phy,
                    PatientCount = Convert.ToInt32(drPhyPat["numPacientes"])
                };

                lstPhysioPat.Add(phyPat);
            }

            return lstPhysioPat;
        }

        public static List<ReportFormPaymentPat> generateFormPaymentPatient(DateTime repDate, Nullable<DateTime> repDateEnd)
        {
            List<ReportFormPaymentPat> lstFormPaymentPat = new List<ReportFormPaymentPat>();

            DataTable dtFormPaymentPat = ReportsDL.generateFormPaymentPatient(repDate, repDateEnd);

            foreach (DataRow drFormPaymentPat in dtFormPaymentPat.Rows)
            {
                string codeFormPayment = Convert.ToString(drFormPaymentPat["FPG_Code"]);

                FormOfPayment fpy = FormOfPaymentBL.findOneFormOfPayment(codeFormPayment);

                ReportFormPaymentPat fpyPat = new ReportFormPaymentPat()
                {
                    FormPayment = fpy,
                    PatientCount = Convert.ToInt32(drFormPaymentPat["numPacientes"])
                };

                lstFormPaymentPat.Add(fpyPat);
            }

            return lstFormPaymentPat.OrderBy(fpy => fpy.FormPayment.Name).ToList<ReportFormPaymentPat>(); ;
        }
    }
}
