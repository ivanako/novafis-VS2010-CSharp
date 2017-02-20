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
                    Name = drPatient["PAC_Nombre"].ToString().ToUpper(),
                    Surname1 = drPatient["PAC_Apellido1"].ToString().ToUpper(),
                    Surname2 = drPatient["PAC_Apellido2"].ToString().ToUpper(),
                    Identification = drPatient["PAC_Identificacion"].ToString().ToUpper(),
                    EntryDate = DateTime.Parse(drPatient["PAC_FechaRegistro"].ToString()),
                    HowHeardAboutUs = drPatient["PAC_Conocer"].ToString().ToUpper(),
                    Gender = drPatient["PAC_Sexo"] == DBNull.Value ? Constants.NULL_CHAR : drPatient["PAC_Sexo"].ToString()[0],
                    DateOfBirth = drPatient["PAC_FechaNacimiento"] == DBNull.Value ? Constants.NULL_DATE : DateTime.Parse(drPatient["PAC_FechaNacimiento"].ToString()),
                    BlackList = Convert.ToBoolean(drPatient["PAC_ListaNegra"]),
                    Deleted = Convert.ToBoolean(drPatient["PAC_Eliminado"]),
                    Source = src,
                    Physiotherapist = physio
                };

                lstPatients.Add(pat);
            }

            return lstPatients;
        }

        public static Patient findOnePatient(int idPatient)
        {
            Patient pat = null;

            DataTable dtPatients = PatientDL.findOnePatient(idPatient);

            if (dtPatients.Rows.Count == 1)
            {
                DataRow drPatient = dtPatients.Rows[0];

                Source src = null;

                if (drPatient["FNT_ID"] != DBNull.Value)
                {
                    src = SourceBL.findOneSource(Convert.ToInt32(drPatient["FNT_ID"]));
                }

                Physiotherapist physio = PhysioBL.findOnePhysio(Convert.ToInt32(drPatient["FIS_ID"]));

                pat = new Patient()
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
            }
            else
            {
                pat = new Patient();
            }

            return pat;
        }

        public static Patient savePatient(Patient patient)
        {
            Patient savedPatient = patient;

            if (!string.IsNullOrWhiteSpace(patient.Name))
            {
                savedPatient.Name = General.removeAccents(patient.Name.Trim()).ToUpper();
            }
            if (!string.IsNullOrWhiteSpace(patient.Surname1))
            {
                savedPatient.Surname1 = General.removeAccents(patient.Surname1.Trim()).ToUpper();
            }
            if (!string.IsNullOrWhiteSpace(patient.Surname2))
            {
                savedPatient.Surname2 = General.removeAccents(patient.Surname2.Trim()).ToUpper();
            }

            bool isOK = false;

            if (patient.Identifier == 0)
            {
                int idPatient = PatientDL.addPatient(patient);

                savedPatient.Identifier = idPatient;

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

            //return isOK;
            return savedPatient;
        }

        public static bool deletePatient(int idPatient)
        {
            return PatientDL.deletePatient(idPatient);
        }

        public static List<Patient> searchPatients(string patName, string patSurname1, string patSurname2, string patIdentification,
            string patAboutUs, string patPhone, int patSource)
        {
            List<Patient> lstPatients = new List<Patient>();

            DataTable dtPatients = PatientDL.searchPatients(patName, patSurname1, patSurname2, patIdentification, patAboutUs, patPhone, patSource);

            foreach (DataRow drPatient in dtPatients.Rows)
            {
                Patient pat = findOnePatient(Convert.ToInt32(drPatient["PAC_ID"]));

                lstPatients.Add(pat);
            }

            return lstPatients;
        }
    }
}
