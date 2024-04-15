using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting
{
    class SpaOnlineException : Exception
    {
        private LugarException lugar;
        private Exception excepcionRaiz;
        private string mensajeUsuario;
        private string mensajeTecnico;
        private bool tieneExcepcionRaiz;

        public SpaOnlineException(LugarException lugar, Exception exceptionRaiz, string mensajeUsuario, string mensajeTecnico, bool tieneExcepcionRaiz) {

            setLugar(lugar);
            setExcepcionRaiz(excepcionRaiz);
            setMensajeUsuario(mensajeUsuario);
            setMensajeTecnico(mensajeTecnico);
        }
        private void setLugar(LugarException lugar)
        {  
            this.lugar = UtilObjeto.ObtenerValorDefecto(lugar, LugarException.GENERAL);
        }
        private void setExcepcionRaiz(Exception excepcionRaiz)
        {
            this.excepcionRaiz = UtilObjeto.ObtenerValorDefecto(excepcionRaiz, new Exception());
        }
        private  void setMensajeUsuario( String mensajeUsuario)
        {
            this.mensajeUsuario = UtilTexto.AplicarTrim(mensajeUsuario);
        }
        private  void setMensajeTecnico( String mensajeTecnico)
        {
            this.mensajeTecnico = UtilTexto.AplicarTrim(mensajeTecnico);
        }
        public  LugarException getLugar()
        {
            return lugar;
        }
        public Exception getExcepcionRaiz()
        {
            return excepcionRaiz;
        }
        public  String getMensajeUsuario()
        {
            return mensajeUsuario;
        }
        public  String getMensajeTecnico()
        {
            return mensajeTecnico;
        }
        public  bool  isTieneExcepcionRaiz()
        {
            return tieneExcepcionRaiz;
        }


    }
}
