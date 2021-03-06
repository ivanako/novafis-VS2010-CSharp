﻿using System;
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

                FormOfPayment fpy = null;

                if (drAppointment["FPG_Code"] != DBNull.Value)
                {
                    fpy = FormOfPaymentBL.findOneFormOfPayment(Convert.ToString(drAppointment["FPG_Code"]));
                }

                Appointment app = new Appointment()
                {
                    Identifier = Convert.ToInt32(drAppointment["CIT_ID"]),
                    Date = Convert.ToDateTime(drAppointment["CIT_Fecha"]),
                    Time = drAppointment["CIT_Hora"].ToString(),
                    Observation = drAppointment["CIT_Observacion"].ToString(),
                    Paid = Convert.ToDouble(drAppointment["CIT_Cobrado"]),
                    Debt = Convert.ToDouble(drAppointment["CIT_Deuda"]),
                    IsCancelled = Convert.ToBoolean(drAppointment["CIT_Anulada"]),
                    CancellationWhy = drAppointment["CIT_MotivoAnulacion"].ToString(),
                    //RegistryDate = Convert.ToDateTime(drAppointment["CIT_FechaRegistro"]),
                    Physiotherapist = phy,
                    Patient = pat,
                    FormOfPayment = fpy
                };

                if (drAppointment["CIT_FechaRegistro"] == DBNull.Value)
                {
                    app.RegistryDate = Constants.NULL_DATE;
                }
                else
                {
                    app.RegistryDate = Convert.ToDateTime(drAppointment["CIT_FechaRegistro"]);
                }

                lstAppointments.Add(app);
            }

            return lstAppointments;
        }

        public static bool saveAppointment(Appointment app)
        {
            bool saveOK = false;

            saveOK = AppointmentDL.saveAppointment(app);

            return saveOK;
        }

        public static bool deleteAppointment(Appointment app)
        {
            bool delOK = false;

            delOK = AppointmentDL.deleteAppointment(app);

            return delOK;
        }

        public static bool checkDebt(int idPatient, DateTime appDate, ref double patDebt, ref DateTime patDebtDate, ref string patObs)
        {
            bool chackOK = false;

            chackOK = AppointmentDL.checkDebt(idPatient, appDate, ref patDebt, ref patDebtDate, ref patObs);

            return chackOK;
        }

        public static List<Appointment> searchDefaulters(DateTime debtDate)
        {
            List<Appointment> lstAppointments = new List<Appointment>();

            DataTable dtAppointments = AppointmentDL.searchDefaulters(debtDate);

            foreach (DataRow drAppointment in dtAppointments.Rows)
            {
                Patient pat = PatientBL.findOnePatient(Convert.ToInt32(drAppointment["PAC_ID"]));

                Appointment app = new Appointment()
                {
                    Identifier = Convert.ToInt32(drAppointment["CIT_ID"]),
                    Date = Convert.ToDateTime(drAppointment["CIT_Fecha"]),
                    Time = drAppointment["CIT_Hora"].ToString(),
                    //Observation = drAppointment["CIT_Observacion"].ToString(),
                    //Paid = Convert.ToDouble(drAppointment["CIT_Cobrado"]),
                    Debt = Convert.ToDouble(drAppointment["CIT_Deuda"]),
                    //IsCancelled = Convert.ToBoolean(drAppointment["CIT_Anulada"]),
                    //CancellationWhy = drAppointment["CIT_MotivoAnulacion"].ToString(),
                    //Physiotherapist = phy
                    Patient = pat
                };

                lstAppointments.Add(app);
            }

            return lstAppointments;
        }
    }
}
