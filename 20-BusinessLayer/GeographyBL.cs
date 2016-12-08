using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects;
using System.Data;
using DataLayer;

namespace BusinessLayer
{
    public class GeographyBL
    {
        public static List<Province> findAllProvinces()
        {
            List<Province> lstProvinces = new List<Province>();

            DataTable dtProvinces = GeographyDL.findAllProvinces();

            foreach (DataRow drProvince in dtProvinces.Rows)
            {
                Province prv = new Province() 
                {
                    Identifier = drProvince["PRV_ID"].ToString(),
                    Name = drProvince["PRV_Provincia"].ToString()
                };

                lstProvinces.Add(prv);
            }

            return lstProvinces;
        }

        public static Province findOneProvince(string idProvince)
        {
            Province prv = new Province();

            DataTable dtProvince = GeographyDL.findOneProvince(idProvince);

            if (dtProvince.Rows.Count == 1)
            {
                prv.Identifier = dtProvince.Rows[0]["PRV_ID"].ToString();
                prv.Name = dtProvince.Rows[0]["PRV_Provincia"].ToString();
            }

            return prv;
        }
    }
}
