using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.exception.concrete;
using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.messages.enumerator;
using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.messages
{
    internal class CatalogoMensajes
    {
        private static Dictionary<CodigoMensaje, Mensaje> MENSAJES = new Dictionary<CodigoMensaje, Mensaje>();

        

        CatalogoMensajes() { }

        private static void cargarMensajes() {

            agregarMensaje(Mensaje.crear(CodigoMensaje.M0001, TipoMensaje.TECNICO, CategoriaMensajes.FATAL, "No se recibio el codigo del mensaje que se queria crear. No es posible continuar con el proceso..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0002, TipoMensaje.TECNICO, CategoriaMensajes.FATAL, "No existe un Mensaje con el codigo indicado. No es posible continuar con el proceso..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0003, TipoMensaje.TECNICO, CategoriaMensajes.FATAL, "No es posible obtener un mensaje con un codigo basio o nulo. No es posible continuar con el proceso..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0004, TipoMensaje.USUARIO, CategoriaMensajes.FATAL, "Se ha presentado un problema inesperado tratando de llevar a cabo la operacion deseada. por favor intente de nuevo y si el problema persiste, contacte al administrador de la aplicacion..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0005, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema tratando de validar si la conexion SQL estaba abierta. Se presento una excepcion SQLException. por favor verifique que la traza completa del error presentado, para asi poder diagnosticar con mayor certeza que sucedio..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0006, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema tratando de validar si la conexion SQL estaba abierta. Se presento una excepcion Generica SQLException . por favor verifique que la traza completa del error presentado, para asi poder diagnosticar con mayor certeza que sucedio..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0007, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "No es posible validar si una conexion esta  abierta cuando es nula. Se presento una excepcion SQLException. por favor verifique que la traza completa del error presentado, para asi poder diagnosticar con mayor certeza que sucedio..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0008, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "No es posible cerrar una conexion que esta nula. por favor verifique que la traza completa del error presentado, para asi poder diagnosticar con mayor certeza que sucedio..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0009, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "No es posible cerrar una conexion que ya esta cerrada. por favor verifique que la traza completa del error presentado, para asi poder diagnosticar con mayor certeza que sucedio..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0010, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "No es posible iniciar una transaccion que esta nula. Se presento una excepcion SQLException. por favor verifique que la traza completa del error presentado, para asi poder diagnosticar con mayor certeza que sucedio..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0011, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "No es posible iniciar una transacción con una conexión cerrada..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0012, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "No es posible iniciar una transacción que ya ha sido iniciada..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0013, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema tratando de cerrar una conexión SQL. Se presentó una excepción de tipo SQLException. Por favor verifique la traza completa del error presentado, para así poder diagnosticar con mayor certeza qué sucedió..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0014, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema inesperado tratando de cerrar la conexión. Se presentó una excepción genérica de tipo Exception. Por favor verifique la traza completa del error presentado, para así poder diagnosticar con mayor certeza qué sucedió..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0015, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema tratando de iniciar la transacción de una conexión SQL. Se presentó una excepción de tipo SQLException. Por favor verifique la traza completa del error presentado, para así poder diagnosticar con mayor certeza qué sucedió..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0016, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema inesperado tratando de iniciar la transacción de una conexión. Se presentó una excepción genérica de tipo Exception. Por favor verifique la traza completa del error presentado, para así poder diagnosticar con mayor certeza qué sucedió..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0017, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "No es posible confirmar una transacción con una conexión que está nula..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0018, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "No es posible confirmar una transacción con una conexión cerrada..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0019, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "No es posible confirmar una transacción que no fue iniciada..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0020, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema tratando de confirmar la transacción de una conexión SQL. Se presentó una excepción de tipo SQLException. Por favor verifique la traza completa del error presentado, para así poder diagnosticar con mayor certeza qué sucedió..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0021, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema inesperado tratando de confirmar la transacción de una conexión. Se presentó una excepción genérica de tipo Exception. Por favor verifique la traza completa del error presentado, para así poder diagnosticar con mayor certeza qué sucedió..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0022, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "No es posible cancelar una transacción con una conexión que está nula..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0023, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "No es posible cancelar una transacción con una conexión cerrada..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0024, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "No es posible cancelar una transacción que no fue iniciada..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0025, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema tratando de cancelar la transacción de una conexión SQL. Se presentó una excepción de tipo SQLException. Por favor verifique la traza completa del error presentado, para así poder diagnosticar con mayor certeza qué sucedió..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0026, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema inesperado cancelar de confirmar la transacción de una conexión. Se presentó una excepción genérica de tipo Exception. Por favor verifique la traza completa del error presentado, para así poder diagnosticar con mayor certeza qué sucedió..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0027, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "No es posible cerrar una conexión que está nula..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0028, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema tratando de obtener la conexión con SQL Server. Se presentó una excepción de tipo SQLException. Por favor verifique la traza completa del error presentado, para así poder diagnosticar con mayor certeza qué sucedió..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0029, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema inesperado tratando de obtener la conexión con SQL Server. Se presentó una excepción genérica de tipo Exception. Por favor verifique la traza completa del error presentado, para así poder diagnosticar con mayor certeza qué sucedió..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0030, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "La Factorìa de datos para PostgreSQL no se encuentra implementada..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0031, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "La Factorìa de datos para MySQL no se encuentra implementada..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0032, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "La Factorìa de datos para Oracle no se encuentra implementada..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0033, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "La Factorìa de datos deseada no se encuentra implementada..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0034, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema tratando de obtener el DAO de ClienteSQLServerDAO debido a que la conexiòn actualmente està cerrada, por lo que no hay una conexiòn vàlida disponible..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0035, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema tratando de obtener el DAO de TipoIdentificacionSQLServerDAO debido a que la conexiòn actualmente està cerrada, por lo que no hay una conexiòn vàlida disponible..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0036, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema tratando de crear el DAO deseado, debido a que la conexiòn actualmente està cerrada, por lo que no hay una conexiòn vàlida disponible..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0037, TipoMensaje.USUARIO, CategoriaMensajes.ERROR, "Se ha presentado un problema tratando de registrar la informacion del nuevo tipo de identificacio..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0038, TipoMensaje.USUARIO, CategoriaMensajes.ERROR, "Se ha presentado un problema tratando de modificar la información del tipo de identificación..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0039, TipoMensaje.USUARIO, CategoriaMensajes.ERROR, "Se ha presentado un problema tratando de eliminar la información del tipo de identificación..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0040, TipoMensaje.USUARIO, CategoriaMensajes.ERROR, "Se ha presentado un problema tratando de consultar la informacion del tipo de identificacion por el identificador deseado...."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0041, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema de tipo SQLException en el metodo crea de la clase TipoIdentificacionSQLServer tratando de llevar a cabo el registro del nuevo Tipo de Identificacion. Por favor revise la traza completa del problema presentado para asi poder identificar que sucedio..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0042, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema inesperado de tipo SQLException en el metodo crea de la clase TipoIdentificacionSQLServer traatande de llevar a cabo el registro del nuevo Tipo de Identificacion. Por favor revise la traza completa del problema presentado para asi poder identificar que sucedio..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0043, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema de tipo SQLException en el método modificar de la clase TipoIdentificacionSQLServer tratando de llevar a cabo la modificación del Tipo de Identificación. Por favor, revise la traza completa del problema presentado para identificar lo que sucedió..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0044, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema inesperado de tipo SQLException en el método modificar de la clase TipoIdentificacionSQLServer tratando de llevar a cabo la modificación del Tipo de Identificación. Por favor, revise la traza completa del problema presentado para identificar lo que sucedió..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0045, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema de tipo SQLException en el método eliminar de la clase TipoIdentificacionSQLServer tratando de eliminar el Tipo de Identificación. Por favor, revise la traza completa del problema presentado para identificar lo que sucedió..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0046, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema inesperado de tipo SQLException en el método eliminar de la clase TipoIdentificacionSQLServer tratando de eliminar el Tipo de Identificación. Por favor, revise la traza completa del problema presentado para identificar lo que sucedió..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0047, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema  de tipo SQLException en el metodo consultar por Id de la clase TipoIdentificacionSQLServer tratando de preparar la sentencia SQL de la consulta del tipo identificacion. Por favor revise la traza completa del problema presentado para asi poder identificar que sucedio..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0048, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema  de tipo Exception en el metodo consultar por Id de la clase TipoIdentificacionSQLServer tratando de preparar la sentencia SQL de la consulta del tipo identificacion. Por favor revise la traza completa del problema presentado para asi poder identificar que sucedio..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0049, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema  de tipo SQLException en el metodo crea de la clase TipoIdentificacionSQLServer tratandotratando de consultar la sentencia SQL de la consulta del tipo identificacion. Por favor revise la traza completa del problema presentado para asi poder identificar que sucedio..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0050, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema  inesperado de tipo Exception en el metodo crea de la clase TipoIdentificacionSQLServer tratandotratando de consultar la sentencia SQL de la consulta del tipo identificacion. Por favor revise la traza completa del problema presentado para asi poder identificar que sucedio..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0051, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema de tipo SQLException en el metodoprepararEjecutarSentenciaConsulta de la Clase TipoIdentificacionSQLDAO tratando de preparar la sentencia SQL. por favor revise la traza completadelproblema presentado"));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0052, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema de tipo Exception en el metodoprepararEjecutarSentenciaConsulta de la Clase TipoIdentificacionSQLDAO tratando de preparar la sentencia SQL. por favor revise la traza completadelproblema presentado"));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0053, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema de tipo SQLException en el metodo colocarParametroConsulta de la Clase TipoIdentificacionSQLDAO tratando de colocar los parametros de la consulta SQL. por favor revise la traza completadelproblema presentado"));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0054, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema inesperado de tipo Exception en el metodo colocarParametroConsulta de la Clase TipoIdentificacionSQLDAO tratando de colocar los parametros de la consulta SQL. por favor revise la traza completadelproblema presentado"));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0055, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema  de tipo SQLException en el metodo crea de la clase TipoIdentificacionSQLServer tratandotratando de consultar la sentencia SQL de la consulta del tipo identificacion. Por favor revise la traza completa del problema presentado para asi poder identificar que sucedio..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0056, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema  inesperado de tipo Exception en el metodo crea de la clase TipoIdentificacionSQLServer tratandotratando de consultar la sentencia SQL de la consulta del tipo identificacion. Por favor revise la traza completa del problema presentado para asi poder identificar que sucedio..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0057, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema tratando de convertir el UUID de String a UUID"));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0058, TipoMensaje.USUARIO, CategoriaMensajes.ERROR, "Se ha presentado un problema con el Identificador.  por favor intente de nuevo y si el problema persiste, contacte al administrador de la aplicacion..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0059, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema tratando de registrar la informacion del nuevo Cliente..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0060, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema de tipo SQLException en el metodo crea de la clase ClienteSQLServer, tratando de llevar a cabo el registro del nuevo Cliente. Por favor revise la traza completa del problema presentado para asi poder identificar que sucedio..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0061, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema inesperado de tipo SQLException en el metodo crea de la clase ClienteSQLServer traatande de llevar a cabo el registro del nuevo Cliente. Por favor revise la traza completa del problema presentado para asi poder identificar que sucedio..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0062, TipoMensaje.USUARIO, CategoriaMensajes.ERROR, "Se ha presentado un problema tratando de modificar la información del Cliente..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0063, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema de tipo SQLException en el método modificar de la clase ClienteSQLServer tratando de llevar a cabo la modificación del Cliente. Por favor, revise la traza completa del problema presentado para identificar lo que sucedió..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0064, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema inesperado de tipo SQLException en el método modificar de la clase Cliente. Por favor, revise la traza completa del problema presentado para identificar lo que sucedió..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0065, TipoMensaje.USUARIO, CategoriaMensajes.ERROR, "Se ha presentado un problema tratando de eliminar la información del Cliente..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0066, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema de tipo SQLException en el método eliminar de la clase ClienteSQLServer tratando de eliminar el Cliente. Por favor, revise la traza completa del problema presentado para identificar lo que sucedió..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0067, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "Se ha presentado un problema inesperado de tipo SQLException en el método eliminar de la clase ClienteSQLServer tratando de eliminar el Cliente. Por favor, revise la traza completa del problema presentado para identificar lo que sucedió..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0068, TipoMensaje.USUARIO, CategoriaMensajes.ERROR, "se ha presentado un problema tratando de llevar a cabo el registro de la informacion del nuevo tipo de identificacion..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0069, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "se ha presentado un problema en el metodo setFactoria de la clase RegistrarTipoIdentificacionUseCase, debido a que la factoria con la cual se desea crear esta nula..."));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0070, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "se ha presentado un problema en el metodo toDomain de la Clase TipoIdentificacion. No es Posible mapear un tipo de identificacion dominio a partir de una entidad de tipo identificacion entity nula"));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0071, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "se ha presentado un problema en el metodo toEntity de la Clase TipoIdentificacion. No es Posible mapear un tipo de identificacion entity a partir de una entidad de tipo identificacion domain nula"));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0072, TipoMensaje.TECNICO, CategoriaMensajes.ERROR, "se ha presentado un problema en el metodo toDomain de la Clase Cliente. No es Posible mapear un Cliente dominio a partir de una entidad de Cliente entity nula"));
            agregarMensaje(Mensaje.crear(CodigoMensaje.M0073, TipoMensaje.USUARIO, CategoriaMensajes.CONFIRMACION, "Transaccion Existosa!!"));
        }

        private static  void agregarMensaje( Mensaje mensaje)
        {
            MENSAJES.Add(mensaje.getCodigo(), mensaje);
        }
        public static  Mensaje obtenerMensaje( CodigoMensaje codigo)
        {
            if (UtilObjeto.EsNulo(codigo))
            {
                var mensajeUsuario = obtenerContenido(CodigoMensaje.M0004);
                var mensajeTecnico = obtenerContenido(CodigoMensaje.M0003);
                throw CrosscuttingSpaOnlineException.crear(mensajeUsuario, mensajeTecnico);
            }
            if (MENSAJES.TryGetValue(codigo, out Mensaje mensaje))
            {
                return mensaje;
            }
            else
            {
                var mensajeUsuario = obtenerContenido(CodigoMensaje.M0004);
                var mensajeTecnico = obtenerContenido(CodigoMensaje.M0002);
                throw CrosscuttingSpaOnlineException.crear(mensajeUsuario, mensajeTecnico);
            }
        }
        public static  String obtenerContenido(CodigoMensaje codigo)
        {
            return obtenerMensaje(codigo).getContenido();
        }
    }
}
