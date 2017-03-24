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


        public static string removeAccents2(string srcString)
        {
            StringBuilder sbFormatString = new StringBuilder();

            char[] arrSrc = srcString.ToCharArray();

            foreach (char src in arrSrc)
            {
                int ascii = src;

                switch (ascii)
                {
                    case 193: // Á
                    case 196: // Ä
                    case 225: // á
                    case 228: // ä
                        sbFormatString.Append((char)65); // A
                        break;
                    case 201: // É
                    case 203: // Ë
                    case 233: // é
                    case 235: // ë
                        sbFormatString.Append((char)69); // E
                        break;
                    case 205: // Í
                    case 207: // Ï
                    case 237: // í
                    case 239: // ï
                        sbFormatString.Append((char)73); // I
                        break;
                    case 211: // Ó
                    case 214: // Ö
                    case 243: // ó
                    case 246: // ö
                        sbFormatString.Append((char)79); // O
                        break;
                    case 218: // Ú
                    case 220: // Ü
                    case 250: // ú
                    case 252: // ü
                        sbFormatString.Append((char)85); // U
                        break;
                    default:
                        sbFormatString.Append(src);
                        break;
                }
            }

            return sbFormatString.ToString();
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
