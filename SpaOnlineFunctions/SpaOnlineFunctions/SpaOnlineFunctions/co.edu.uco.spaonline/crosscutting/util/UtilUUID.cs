using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.exception.concrete;
using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.messages.enumerator;
using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.util
{
    public class UtilUUID
    {
        public static readonly Guid UUIDDEFECTO = new Guid(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

        private UtilUUID() { }
        public static Guid generarUUIDDefecto() {
            return UUIDDEFECTO;
        }
        public static Guid convertirStringAUUID(String uuidString)
        {
            try {
                return Guid.Parse(uuidString);
            } 
            catch(FormatException excepcion) {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0040);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0058);
                throw DataSpaOnlineException.crear(excepcion, mensajeUsuario, mensajeTecnico);
            }
        }
        public static Guid generarUUIDAleatorio() {
            return Guid.NewGuid();
        }
        public static  bool EsNulo( Guid uuid)
        {
            return (uuid == null) || (uuid == UUIDDEFECTO);
        }
        public static  Guid obtenerValorDefecto( Guid uuid,  Guid valorDefecto)
        {
            return EsNulo(uuid) ? valorDefecto : uuid;
        }
    }
}
