using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects;
using System.Data;
using DataLayer;

namespace BusinessLayer
{
    public class LocationBL
    {
        public static List<Location> findAllLocations()
        {
            List<Location> lstLocations = new List<Location>();

            DataTable dtLocations = LocationDL.findAllLocations();

            foreach (DataRow drLoc in dtLocations.Rows)
            {
                Location loc = new Location()
                {
                    Identifier = Convert.ToInt32(drLoc["LOC_ID"]),
                    Description = drLoc["LOC_Descripcion"].ToString()
                };

                lstLocations.Add(loc);
            }

            return lstLocations;
        }

        public static Location findOneLocation(int idLocalizacion)
        {
            Location location = new Location();

            DataTable dtLocation = LocationDL.findOneLocation(idLocalizacion);

            if (dtLocation.Rows.Count == 1)
            {
                location.Identifier = Convert.ToInt32(dtLocation.Rows[0]["LOC_ID"]);
                location.Description = dtLocation.Rows[0]["LOC_Descripcion"].ToString();
            }

            return location;
        }

        public static List<Location> saveLocation(Location location)
        {
            List<Location> lstLocations = new List<Location>();

            bool isOK = true;

            if (location.Identifier == 0)
            {
                isOK = LocationDL.addLocation(location);
            }
            else
            {
                isOK = LocationDL.modifyLocation(location);
            }

            if (isOK)
            {
                lstLocations = findAllLocations();
            }

            return lstLocations;
        }
    }
}
