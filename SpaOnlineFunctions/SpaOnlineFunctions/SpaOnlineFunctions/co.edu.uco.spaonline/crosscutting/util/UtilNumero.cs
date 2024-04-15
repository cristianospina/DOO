using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.util
{
    class UtilNumero
    {
        public static int NUMERODEFECTO = 0000;

        public static bool longitudMinimaValida(int? valor, int longitud) {
            string numero = valor.ToString();
            return UtilTexto.AplicarTrim(numero).Length >= longitud;
        }

        public static bool longitudaxiamValida(int? dato, int longitud) {
            String numero = dato.ToString();
            return UtilTexto.AplicarTrim(numero).Length <= longitud;
        }
        public static  bool estaNulo( int? valor)
        {
            return UtilObjeto.EsNulo(valor);
        }
    }
}
