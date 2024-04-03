using System;

namespace co.edu.uco.spaonline.crosscutting.messages
{
    public sealed class CatalogoMensajes
    {
        private static readonly Dictionary<CodigoMensaje, Mensaje> MENSAJES = new Dictionary<CodigoMensaje, Mensaje>();

        static CatalogoMensajes()
        {
            CargarMensajes();
        }

        private CatalogoMensajes() { }

        private static void CargarMensajes()
        {
            //AgregarMensaje(Mensaje.Crear(CodigoMensaje.M0000001, TipoMensaje.TECNICO, CategoriaMensaje.FATAL, "No se recibio el codigo del mensaje que se queria crear. No es posible continuar con el proceso..."));


        }

        private static void AgregarMensaje(Mensaje mensaje)
        {
            MENSAJES[mensaje.Codigo] = mensaje;
        }

        public static Mensaje ObtenerMensaje(CodigoMensaje codigo)
        {
            if (UtilObjeto.EsNulo(codigo))
            {
                var mensajeUsuario = ObtenerContenido(CodigoMensaje.M0000004);
                var mensajeTecnico = ObtenerContenido(CodigoMensaje.M0000003);
                throw CrosscuttingSpaOnlineException.Crear(mensajeUsuario, mensajeTecnico);
            }

            if (!MENSAJES.ContainsKey(codigo))
            {
                var mensajeUsuario = ObtenerContenido(CodigoMensaje.M0000004);
                var mensajeTecnico = ObtenerContenido(CodigoMensaje.M0000002);
                throw CrosscuttingSpaOnlineException.Crear(mensajeUsuario, mensajeTecnico);
            }

            return MENSAJES[codigo];
        }

        public static string ObtenerContenido(CodigoMensaje codigo)
        {
            return ObtenerMensaje(codigo).Contenido;
        }
    }

}