using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects;
using DataLayer;
using System.Data;

namespace BusinessLayer
{
    public class NoteBL
    {
        public static List<Note> findAllNotes()
        {
            List<Note> lstNotes = new List<Note>();

            DataTable dtNotes = NoteDL.findAllNotes();

            foreach (DataRow drNote in dtNotes.Rows)
            {
                Note note = new Note()
                {
                    Identifier = Convert.ToInt32(drNote["NOT_ID"]),
                    Date = Convert.ToDateTime(drNote["NOT_Fecha"]),
                    Description = drNote["NOT_Descripcion"].ToString()
                };

                lstNotes.Add(note);
            }

            return lstNotes;
        }

        public static List<Note> saveNote(Note note)
        {
            List<Note> lstNotes = new List<Note>();

            bool isOK = true;

            if (note.Identifier == 0)
            {
                isOK = NoteDL.addNote(note);
            }
            else
            {
                isOK = NoteDL.modifyNote(note);
            }

            if (isOK)
            {
                lstNotes = findAllNotes();
            }

            return lstNotes;
        }

        public static List<Note> deleteNote(int idNote)
        {
            List<Note> lstNotes = new List<Note>();

            bool isOK = NoteDL.deleteNote(idNote);

            if (isOK)
            {
                lstNotes = findAllNotes();
            }

            return lstNotes;
        }
    }
}
