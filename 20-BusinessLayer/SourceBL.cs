using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataLayer;
using Objects;

namespace BusinessLayer
{
    public class SourceBL
    {
        public static List<Source> findAllSources()
        {
            List<Source> lstSources = new List<Source>();

            DataTable dtSources = SourceDL.findAllSources();

            foreach (DataRow drSource in dtSources.Rows)
            {
                Source src = new Source()
                {
                    Identifier = Convert.ToInt32(drSource["FNT_ID"]),
                    Description = drSource["FNT_Descripcion"].ToString()
                };

                lstSources.Add(src);
            }

            return lstSources;
        }

        public static Source findOneSource(int idSource)
        {
            Source src = new Source();

            DataTable dtSource = SourceDL.findOneSource(idSource);

            if (dtSource.Rows.Count == 1)
            {
                src.Identifier = Convert.ToInt32(dtSource.Rows[0]["FNT_ID"]);
                src.Description = dtSource.Rows[0]["FNT_Descripcion"].ToString();
            }

            return src;
        }

        public static List<Source> saveSource(Source src)
        {
            List<Source> lstSources = new List<Source>();

            bool isOK = SourceDL.saveSource(src);

            if (isOK)
            {
                lstSources = findAllSources();
            }

            return lstSources;
        }
    }
}
