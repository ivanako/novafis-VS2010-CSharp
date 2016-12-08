using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects;
using System.Data;
using DataLayer;

namespace BusinessLayer
{
    public class AddressBL
    {
        public static Address findOneAddress(int idPatient)
        {
            Address addr = new Address();

            DataTable dtAddress = AddressDL.findOneAddress(idPatient);

            if (dtAddress != null)
            {
                if (dtAddress.Rows.Count == 1)
                {
                    Province prv = GeographyBL.findOneProvince(dtAddress.Rows[0]["PRV_ID"].ToString());

                    addr.Thoroughfare = dtAddress.Rows[0]["PAD_Via"].ToString();
                    addr.Number = dtAddress.Rows[0]["PAD_Numero"].ToString();
                    addr.Block = dtAddress.Rows[0]["PAD_Bloque"].ToString();
                    addr.Floor = dtAddress.Rows[0]["PAD_Piso"].ToString();
                    addr.Stair = dtAddress.Rows[0]["PAD_Escalera"].ToString();
                    addr.Gate = dtAddress.Rows[0]["PAD_Puerta"].ToString();
                    addr.PostCode = dtAddress.Rows[0]["PAD_CPostal"].ToString();
                    addr.Phone1 = dtAddress.Rows[0]["PAD_Telefono1"].ToString();
                    addr.Phone2 = dtAddress.Rows[0]["PAD_Telefono2"].ToString();
                    addr.Phone3 = dtAddress.Rows[0]["PAD_Telefono3"].ToString();
                    addr.Email = dtAddress.Rows[0]["PAD_EMail"].ToString();
                    addr.Web = dtAddress.Rows[0]["PAD_Web"].ToString();
                    addr.City = dtAddress.Rows[0]["PAD_Ciudad"].ToString();
                    addr.Number = dtAddress.Rows[0]["PAD_Numero"].ToString();
                    addr.Province = prv;
                }
            }

            return addr;
        }

        public static bool saveAddress(Address patAddress, int idPatient)
        {
            bool saveOK = false;

            DataTable dtAddresses = AddressDL.findOneAddress(idPatient);

            if (dtAddresses.Rows.Count == 0)
            {
                saveOK = AddressDL.addAddress(patAddress, idPatient);
            }
            else
            {
                saveOK = AddressDL.modifyAddress(patAddress, idPatient);
            }

            return saveOK;
        }
    }
}
