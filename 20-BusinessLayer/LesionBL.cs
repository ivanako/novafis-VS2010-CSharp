using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects;
using System.Data;
using DataLayer;

namespace BusinessLayer
{
    public class LesionBL
    {
        public static List<Lesion> findAllLesions()
        {
            List<Lesion> lstLesions = new List<Lesion>();

            DataTable dtLesions = LesionDL.findAllLesions();

            foreach (DataRow drLes in dtLesions.Rows)
            {
                Lesion les = new Lesion()
                {
                    Identifier = Convert.ToInt32(drLes["LES_ID"]),
                    Description = drLes["LES_Descripcion"].ToString()
                };

                lstLesions.Add(les);
            }

            return lstLesions;
        }

        public static Lesion findOneLesion(int idLesion)
        {
            Lesion lesion = new Lesion();

            DataTable dtLesion = LesionDL.findOneLesion(idLesion);

            if (dtLesion.Rows.Count == 1)
            {
                lesion.Identifier = Convert.ToInt32(dtLesion.Rows[0]["LES_ID"]);
                lesion.Description = dtLesion.Rows[0]["LES_Descripcion"].ToString();
            }

            return lesion;
        }

        public static List<Lesion> saveLesion(Lesion lesion)
        {
            List<Lesion> lstLesions = new List<Lesion>();

            bool isOK = true;

            if (lesion.Identifier == 0)
            {
                isOK = LesionDL.addLesion(lesion);
            }
            else
            {
                isOK = LesionDL.modifyLesion(lesion);
            }

            if (isOK)
            {
                lstLesions = findAllLesions();
            }

            return lstLesions;
        }
    }
}
