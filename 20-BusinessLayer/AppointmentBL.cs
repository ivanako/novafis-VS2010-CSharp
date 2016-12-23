using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects;
using System.Data;
using DataLayer;

namespace BusinessLayer
{
    public class AppointmentBL
    {
        public static List<Appointment> findAppointmentsByDate(DateTime appDate, int idPhysio)
        {
            List<Appointment> lstAppointments = new List<Appointment>();

            DataTable dtAppointments = AppointmentDL.findAppointmentsByDate(appDate, idPhysio);

            foreach (DataRow drAppointment in dtAppointments.Rows)
            {
                Physiotherapist phy = PhysioBL.findOnePhysio(Convert.ToInt32(drAppointment["FIS_ID"]));
                Patient pat = PatientBL.findOnePatient(Convert.ToInt32(drAppointment["PAC_ID"]));
                pat.Treatments = TreatmentBL.findTreatmentsByPatient(pat.Identifier);
                
                Appointment app = new Appointment()
                {
                    Identifier = Convert.ToInt32(drAppointment["CIT_ID"]),
                    Date = Convert.ToDateTime(drAppointment["CIT_Fecha"]),
                    Time = drAppointment["CIT_Hora"].ToString(),
                    Observation = drAppointment["CIT_Observacion"].ToString(),
                    Paid = Convert.ToDouble(drAppointment["CIT_Cobrado"]),
                    Debt = Convert.ToDouble(drAppointment["CIT_Deuda"]),
                    Cancelled = Convert.ToBoolean(drAppointment["CIT_Anulada"]),
                    Physiotherapist = phy,
                    Patient = pat
                };

                lstAppointments.Add(app);
            }

            return lstAppointments;
        }
    }
}
