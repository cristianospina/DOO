using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.messages.enumerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.util
{
    class UtilObjeto
    {
        public static readonly string VACIO = "";

        private UtilObjeto() { }

        public static bool EsNulo<T>(T objeto)
        {
            return objeto == null;
        }

        public static bool EsNulooVacio<T>(T objeto)
        {
            return objeto == null || objeto.Equals(VACIO);
        }

        public static T ObtenerValorDefecto<T>(T objeto, T valorDefecto)
        {
            return EsNulo(objeto) ? valorDefecto : objeto;
        }

        internal static CodigoMensaje ObtenerValorDefecto(CodigoMensaje codigo, object value)
        {
            throw new NotImplementedException();
        }
    }
}
