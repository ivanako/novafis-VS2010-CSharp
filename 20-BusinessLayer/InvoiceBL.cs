using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects;
using System.Data;
using DataLayer;

namespace BusinessLayer
{
    public class InvoiceBL
    {
        public static List<Invoice> findInvoicesByPhysio(int idPhysio)
        {
            List<Invoice> lstInvoices = new List<Invoice>();

            DataTable dtInvoices = InvoiceDL.findInvoicesByPhysio(idPhysio);

            foreach (DataRow drInvoice in dtInvoices.Rows)
            {
                Patient pat = null;

                if (drInvoice["PAC_ID"] != DBNull.Value)
                {
                    pat = PatientBL.findOnePatient(Convert.ToInt32(drInvoice["PAC_ID"]));
                }

                Physiotherapist physio = PhysioBL.findOnePhysio(Convert.ToInt32(drInvoice["FIS_ID"]));

                Invoice inv = new Invoice()
                {
                    Identifier = Convert.ToInt32(drInvoice["FAC_ID"]),
                    InvoiceNumber = Convert.ToString(drInvoice["FAC_Numero"]),
                    Date = DateTime.Parse(Convert.ToString(drInvoice["FAC_Fecha"])),
                    Identification = Convert.ToString(drInvoice["FAC_Identificacion"]),
                    Client = Convert.ToString(drInvoice["FAC_Receptor"]),
                    Sessions = Convert.ToByte(drInvoice["FAC_Sesiones"]),
                    Treatment = Convert.ToString(drInvoice["FAC_Tratamiento"]),
                    Amount = Convert.ToDouble(drInvoice["FAC_Importe"]),
                    Patient = pat,
                    Physio = physio
                };

                lstInvoices.Add(inv);
            }

            return lstInvoices;
        }

        public static Invoice addInvoice(Invoice inv)
        {
            Invoice newInvoice = inv;

            string invNumber = InvoiceDL.addInvoice(inv);

            newInvoice.InvoiceNumber = invNumber;

            return newInvoice;
        }
    }
}
