using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.exception.concrete
{
    internal class DataSpaOnlineException : SpaOnlineException
    {
        public DataSpaOnlineException(LugarException lugar, Exception exceptionRaiz, string mensajeUsuario, string mensajeTecnico, bool tieneExcepcionRaiz) : base(lugar, exceptionRaiz, mensajeUsuario, mensajeTecnico, tieneExcepcionRaiz)
        {
        }
        public static SpaOnlineException crear(String mensajeUsuario)
        {
            return new ControllerSpaOnlineException(LugarException.DATA, null, mensajeUsuario, null, false);
        }
        public static SpaOnlineException crear(String mensajeUsuario, String mensajeTecnico)
        {
            return new ControllerSpaOnlineException(LugarException.DATA, null, mensajeUsuario, mensajeTecnico, false);
        }
        public static SpaOnlineException crear(Exception excepcionRaiz, String mensajeUsuario, String mensajeTecnico)
        {
            return new ControllerSpaOnlineException(LugarException.DATA, excepcionRaiz, mensajeUsuario, mensajeTecnico, true);
        }
    }
}
