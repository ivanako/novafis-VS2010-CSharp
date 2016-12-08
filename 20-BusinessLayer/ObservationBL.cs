using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Objects;
using DataLayer;

namespace BusinessLayer
{
    public class ObservationBL
    {
        public static List<Observation> findObservationsByPatient(int idPatient)
        {
            List<Observation> lstObservations = new List<Observation>();

            DataTable dtObservations = ObservationDL.findObservationsByPatient(idPatient);

            foreach (DataRow drObs in dtObservations.Rows)
            {
                Observation obs = new Observation()
                {
                    Identifier = Convert.ToInt32(drObs["PAO_ID"]),
                    Description = drObs["PAO_Descripcion"].ToString()
                };

                lstObservations.Add(obs);
            }

            return lstObservations;
        }

        public static bool addObservation(Observation observation, int idPatient)
        {
            return ObservationDL.addObservation(observation, idPatient);
        }

        public static bool modifyObservation(Observation observation)
        {
            return ObservationDL.modifyObservation(observation);
        }
    }
}
