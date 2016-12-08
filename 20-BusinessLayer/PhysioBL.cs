using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objects;
using System.Data;
using DataLayer;

namespace BusinessLayer
{
    public class PhysioBL
    {
        public static List<Physiotherapist> findAllPhysios()
        {
            List<Physiotherapist> lstPhysios = new List<Physiotherapist>();

            DataTable dtPhysios = PhysioDL.findAllPhysios();
            
            foreach (DataRow drPhysio in dtPhysios.Rows)
            {
                Physiotherapist physio = new Physiotherapist()
                {
                    Identifier = Convert.ToInt32(drPhysio["FIS_ID"]),
                    Name = drPhysio["FIS_Nombre"].ToString(),
                    Surname1 = drPhysio["FIS_Apellido1"].ToString(),
                    Surname2 = drPhysio["FIS_Apellido2"].ToString(),
                    Alias = drPhysio["FIS_Alias"].ToString(),
                    EntryDate = DateTime.Parse(drPhysio["FIS_FechaAlta"].ToString()),
                    TerminationDate = drPhysio["FIS_FechaBaja"] == DBNull.Value ? Constants.NULL_DATE : DateTime.Parse(drPhysio["FIS_FechaBaja"].ToString()),
                    Gender = drPhysio["FIS_Sexo"].ToString()[0],
                    Identification = drPhysio["FIS_Identificacion"].ToString(),
                    LicenseNumber = drPhysio["FIS_NumColegiado"].ToString(),
                    Colour = drPhysio["FIS_Color"].ToString()
                };

                lstPhysios.Add(physio);
            }

            return lstPhysios;
        }

        public static Physiotherapist findOnePhysio(int idPhysio)
        {
            Physiotherapist physio = new Physiotherapist();

            DataTable dtPhysio = PhysioDL.findOnePhysio(idPhysio);


            if (dtPhysio.Rows.Count == 1)
            {
                physio.Identifier = Convert.ToInt32(dtPhysio.Rows[0]["FIS_ID"]);
                physio.Name = dtPhysio.Rows[0]["FIS_Nombre"].ToString();
                physio.Surname1 = dtPhysio.Rows[0]["FIS_Apellido1"].ToString();
                physio.Surname2 = dtPhysio.Rows[0]["FIS_Apellido2"].ToString();
                physio.Alias = dtPhysio.Rows[0]["FIS_Alias"].ToString();
            }

            return physio;
        }

        public static List<Physiotherapist> savePhysio(Physiotherapist physio)
        {
            List<Physiotherapist> lstPhysios = new List<Physiotherapist>();

            bool isOK = PhysioDL.savePhysio(physio);

            if (isOK)
            {
                lstPhysios = findAllPhysios();
            }

            return lstPhysios;
        }
    }
}
