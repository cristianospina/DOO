using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.exception.concrete;
using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.messages.enumerator;
using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.messages;
using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.data.dao
{
    public class SQLDAO
    {
        private SqlConnection conexion;

        public SQLDAO(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        private void setConexion(SqlConnection conexion) {
            
            this.conexion = conexion;
        
        }
        public static SqlConnection Conn()
        {
            string conStr = Environment.GetEnvironmentVariable($"ConnectionStrings:", EnvironmentVariableTarget.Process);
            if (string.IsNullOrEmpty(conStr)) // Azure Functions App Service naming convention
                conStr = Environment.GetEnvironmentVariable($"", EnvironmentVariableTarget.Process);
            else if (!string.IsNullOrEmpty(conStr)) {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0004);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0027);
                throw DataSpaOnlineException.crear(mensajeUsuario, mensajeTecnico);
            }
            return new SqlConnection(conStr);
        }

        protected  SqlConnection getConexion()
        {
            return conexion;
        }
        public static void PrepareTextCmd(SqlCommand cmd)
        {
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
        }

    }
}
