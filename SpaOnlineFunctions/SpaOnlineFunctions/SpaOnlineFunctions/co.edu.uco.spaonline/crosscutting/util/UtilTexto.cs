using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting
{
    internal class UtilTexto
    {
        public static readonly string VACIO = "";
        private static readonly string PATTER_SOLO_LETRAS = "^[A-Za-záéíóúÁÉÍÓÚ]+$";
        private static readonly string PATTER_SOLO_LETRAS_DIGITOS_ESPACIOS = "^[0-9a-zA-ZÁÉÍÓÚáéíóú ]+";
        private static readonly string PATTERN_CORREO_ELECTRONICO = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$";
        private static readonly string PATTERN_NUMERO_TELEFONO = "^[0-9]+$";

        private UtilTexto() { }

        public static string ObtenerValorDefecto(string valor, string valorDefecto)
        {
            return util.UtilObjeto.ObtenerValorDefecto(valor, valorDefecto);
        }

        public static string ObtenerValorDefecto(string valor)
        {
            return ObtenerValorDefecto(valor, VACIO);
        }

        public static string AplicarTrim(string valor)
        {
            return ObtenerValorDefecto(valor).Trim();
        }

        public static bool IgualSinTrim(string valorUno, string valorDos)
        {
            return ObtenerValorDefecto(valorUno).Equals(ObtenerValorDefecto(valorDos));
        }

        public static bool IgualConTrim(string valorUno, string valorDos)
        {
            return AplicarTrim(valorUno).Equals(AplicarTrim(valorDos));
        }

        public static bool IgualSinTrimIgnoreCase(string valorUno, string valorDos)
        {
            return ObtenerValorDefecto(valorUno).Equals(ObtenerValorDefecto(valorDos), StringComparison.OrdinalIgnoreCase);
        }

        public static bool IgualConTrimIgnoreCase(string valorUno, string valorDos)
        {
            return AplicarTrim(valorUno).Equals(AplicarTrim(valorDos), StringComparison.OrdinalIgnoreCase);
        }

        public static bool EstaNulo(string valor)
        {
            return UtilObjeto.EsNulo(valor);
        }

        public static bool EstaVacio(string valor)
        {
            return IgualConTrim(valor, VACIO);
        }

        public static bool LongitudMinimaValida(string valor, int longitud)
        {
            return AplicarTrim(valor).Length >= longitud;
        }

        public static bool LongitudMaximaValida(string valor, int longitud)
        {
            return AplicarTrim(valor).Length <= longitud;
        }

        public static bool LongitudValida(string valor, int longitudMinima, int longitudMaxima)
        {
            return LongitudMinimaValida(valor, longitudMinima) && LongitudMaximaValida(valor, longitudMaxima);
        }

        public static bool ContieneSoloLetras(string valor)
        {
            return Regex.IsMatch(ObtenerValorDefecto(valor), PATTER_SOLO_LETRAS);
        }

        public static bool ContieneSoloLetrasDigitosEspacios(string valor)
        {
            return Regex.IsMatch(ObtenerValorDefecto(valor), PATTER_SOLO_LETRAS_DIGITOS_ESPACIOS);
        }

        public static bool ContieneFormatoCorreo(string valor)
        {
            return Regex.IsMatch(ObtenerValorDefecto(valor), PATTERN_CORREO_ELECTRONICO);
        }

        public static bool ContieneSoloDigitos(string valor)
        {
            return Regex.IsMatch(ObtenerValorDefecto(valor), PATTERN_NUMERO_TELEFONO);
        }
    }
}
