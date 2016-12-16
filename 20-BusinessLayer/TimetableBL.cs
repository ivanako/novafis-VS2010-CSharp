﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects;
using System.Data;
using DataLayer;

namespace BusinessLayer
{
    public class TimetableBL
    {
        public static List<Timetable> findAllTimetablesByPhysio(int idPhysio)
        {
            List<Timetable> lstTimetables = new List<Timetable>();

            DataTable dtTimetables = TimetableDL.findAllTimetablesByPhysio(idPhysio);

            foreach (DataRow drTimes in dtTimetables.Rows)
            {
                Timetable time = new Timetable()
                {
                    Identifier = Convert.ToInt32(drTimes["JOR_ID"]),
                    Date = Convert.ToDateTime(drTimes["JOR_Fecha"]),
                    MorningTimeStart = drTimes["JOR_HoraIniM"].ToString(),
                    MorningTimeFinish = drTimes["JOR_HoraFinM"].ToString(),
                    //MorningDuration = drTimes["JOR_IntervaloM"] == DBNull.Value ? Convert.ToByte(0) : Convert.ToByte(drTimes["JOR_IntervaloM"]),
                    AfternoonTimeStart = drTimes["JOR_HoraIniT"].ToString(),
                    AfternoonTimeFinish = drTimes["JOR_HoraFinT"].ToString()
                    //AfternoonDuration = Convert.ToByte(drTimes["JOR_IntervaloT"])
                };

                if (drTimes["JOR_IntervaloM"] == DBNull.Value)
                {
                    time.MorningDuration = null;
                }
                else
                {
                    time.MorningDuration = Convert.ToByte(drTimes["JOR_IntervaloM"]);
                }
                if (drTimes["JOR_IntervaloT"] == DBNull.Value)
                {
                    time.AfternoonDuration = null;
                }
                else
                {
                    time.AfternoonDuration = Convert.ToByte(drTimes["JOR_IntervaloT"]);
                }

                lstTimetables.Add(time);
            }

            return lstTimetables;
        }

        public static bool saveTimetable(Timetable timeTable)
        {
            return TimetableDL.saveTimetable(timeTable);
        }
    }
}