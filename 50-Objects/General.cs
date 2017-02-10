using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects
{
    public static class General
    {
        public static string removeAccents(string sourceString)
        {
            
            //string accentedStr;
            byte[] tempBytes = Encoding.GetEncoding("ISO-8859-8").GetBytes(sourceString);
            string asciiStr = Encoding.UTF8.GetString(tempBytes);

            return asciiStr;
        }



    //    Dim sCadenaFormateada As New System.Text.StringBuilder
    //    Dim arrCadena As Char() = sCadena.ToCharArray

    //    For Each sCaracter As Char In arrCadena
    //        Dim iAscii As Integer = Asc(sCaracter)

    //        Select Case iAscii
    //            Case 193, 196, 225, 228 ' Á, Ä, á, ä
    //                sCaracter = "A"
    //            Case 201, 203, 233, 235 ' É, Ë, é, ë
    //                sCaracter = "E"
    //            Case 205, 207, 237, 239 ' Í, Ï, í, ï
    //                sCaracter = "I"
    //            Case 211, 214, 243, 246 ' Ó, Ö, ó, ö
    //                sCaracter = "O"
    //            Case 218, 220, 250, 252 ' Ú, Ü, ú, ü
    //                sCaracter = "U"
    //        End Select

    //        sCadenaFormateada.Append(sCaracter)
    //    Next

    //    Return sCadenaFormateada.ToString

    //End Function
    }
}
