using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSConvertnumber.CSD
{
    public class Convertir
    {
        public string Numero2Letras(ulong Numero)
        {
            string Respuesta;
            NumberConversion.NumberConversionSoapTypeClient oConvNum = new NumberConversion.NumberConversionSoapTypeClient("NumberConversionSoap");

            Respuesta = oConvNum.NumberToWords(Numero);

            return Respuesta;
        }
        public string Numero2Dolares(decimal Numero)
        {
            string Respuesta;

            NumberConversion.NumberConversionSoapTypeClient oConvNum = new NumberConversion.NumberConversionSoapTypeClient("NumberConversionSoap");

            Respuesta = oConvNum.NumberToDollars(Numero);

            return Respuesta;

        }

    }
}