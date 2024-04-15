using Microsoft.AspNetCore.Http;
using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.exception.concrete;
using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.messages.enumerator;
using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.messages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.util
{
    public class UtilSQL
    {
        private UtilSQL() { }

        public static bool conexionAbierta(IDbConnection conexion) {
            if (UtilObjeto.EsNulo(conexion))
            {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0004);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0007);
                throw CrosscuttingSpaOnlineException.crear(mensajeUsuario, mensajeTecnico);
            }
            try
            {
                return !(UtilObjeto.EsNulo(conexion) || conexion.State == ConnectionState.Closed);
            }
            catch (SqlException excepcion) {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0004);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0005);
                throw CrosscuttingSpaOnlineException.crear(excepcion, mensajeUsuario, mensajeTecnico);
            } catch ( Exception excepcion) {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0004);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0006);
                throw CrosscuttingSpaOnlineException.crear(excepcion, mensajeUsuario, mensajeTecnico);
            }

        }

        public static void cerrarConexion(IDbConnection conexion) {
            if (UtilObjeto.EsNulo(conexion))
            {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0004);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0008);
                throw CrosscuttingSpaOnlineException.crear(mensajeUsuario, mensajeTecnico);
            }
            try
            {
                if (!conexionAbierta(conexion))
                {
                    var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0004);
                    var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0009);
                    throw CrosscuttingSpaOnlineException.crear(mensajeUsuario, mensajeTecnico);
                }
                conexion.Close();
            }
            catch (CrosscuttingSpaOnlineException excepcion)
            {
                throw excepcion;
            }
            catch ( SqlException excepcion) {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0004);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0013);
                throw CrosscuttingSpaOnlineException.crear(excepcion, mensajeUsuario, mensajeTecnico);
            } catch (Exception excepcion) {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0004);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0014);
                throw CrosscuttingSpaOnlineException.crear(excepcion, mensajeUsuario, mensajeTecnico);
            }
        }

        public static void iniciarTransaccion(IDbConnection conexion) {

            if (UtilObjeto.EsNulo(conexion))
            {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0004);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0008);
                throw CrosscuttingSpaOnlineException.crear(mensajeUsuario, mensajeTecnico);
            }
            try
            {
                if (!conexionAbierta(conexion))
                {
                    var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0004);
                    var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0011);
                    throw CrosscuttingSpaOnlineException.crear(mensajeUsuario, mensajeTecnico);
                }
           
            }
            catch (CrosscuttingSpaOnlineException excepcion)
            {
                throw excepcion;
            }
            catch (SqlException excepcion)
            {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0004);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0015);
                throw CrosscuttingSpaOnlineException.crear(excepcion, mensajeUsuario, mensajeTecnico);
            }
            catch (Exception excepcion)
            {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0004);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0016);
                throw CrosscuttingSpaOnlineException.crear(excepcion, mensajeUsuario, mensajeTecnico);
            }
        }
    }
}
