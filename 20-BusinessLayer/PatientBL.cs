using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects;
using System.Data;
using DataLayer;

namespace BusinessLayer
{
    public class PatientBL
    {
        public static List<Patient> findAllPatients()
        {
            List<Patient> lstPatients = new List<Patient>();

            DataTable dtPatients = PatientDL.findAllPatients();

            foreach (DataRow drPatient in dtPatients.Rows)
            {
                Source src = null;

                if (drPatient["FNT_ID"] != DBNull.Value)
                {
                    src = SourceBL.findOneSource(Convert.ToInt32(drPatient["FNT_ID"]));
                }

                Physiotherapist physio = PhysioBL.findOnePhysio(Convert.ToInt32(drPatient["FIS_ID"]));

                Patient pat = new Patient()
                {
                    Identifier = Convert.ToInt32(drPatient["PAC_ID"]),
                    Name = drPatient["PAC_Nombre"].ToString(),
                    Surname1 = drPatient["PAC_Apellido1"].ToString(),
                    Surname2 = drPatient["PAC_Apellido2"].ToString(),
                    Identification = drPatient["PAC_Identificacion"].ToString(),
                    EntryDate = DateTime.Parse(drPatient["PAC_FechaRegistro"].ToString()),
                    HowHeardAboutUs = drPatient["PAC_Conocer"].ToString(),
                    Gender = drPatient["PAC_Sexo"] == DBNull.Value ? Constants.NULL_CHAR : drPatient["PAC_Sexo"].ToString()[0],
                    DateOfBirth = drPatient["PAC_FechaNacimiento"] == DBNull.Value ? Constants.NULL_DATE : DateTime.Parse(drPatient["PAC_FechaNacimiento"].ToString()),
                    BlackList = Convert.ToBoolean(drPatient["PAC_ListaNegra"]),
                    Source = src,
                    Physiotherapist = physio
                };

                

                lstPatients.Add(pat);
            }

            return lstPatients;
        }

        public static bool savePatient(Patient patient)
        {
            //List<Patient> lstPatients = new List<Patient>();

            bool isOK = false;

            if (patient.Identifier == 0)
            {
                int idPatient = PatientDL.addPatient(patient);

                if (idPatient != 0)
                {
                    isOK = AddressDL.addAddress(patient.Address, idPatient);
                }
            }
            else
            {
                isOK = PatientDL.modifyPatient(patient);

                if (isOK)
                {
                    isOK = AddressBL.saveAddress(patient.Address, patient.Identifier);
                }
            }
            //if (isOK)
            //{
            //    lstPatients = findAllPatients();
            //}

            return isOK;
        }

        public static bool deletePatient(int idPatient)
        {
            return PatientDL.deletePatient(idPatient);
        }
    }
}
