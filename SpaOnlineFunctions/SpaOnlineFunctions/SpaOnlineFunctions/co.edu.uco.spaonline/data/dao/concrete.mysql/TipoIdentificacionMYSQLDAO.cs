using Microsoft.CodeAnalysis;
using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.exception.concrete;
using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.messages.enumerator;
using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.messages;
using SpaOnlineFunctions.co.edu.uco.spaonline.data.entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.Extensions.Primitives;
using SpaOnlineFunctions.co.edu.uco.spaonline.crosscutting.util;
using SpaOnlineFunctions.co.edu.uco.spaonline.data.entity.support;
using MySql.Data.MySqlClient;
using MySqlConnector;
using System.Collections;
using Mysqlx.Crud;
using System.Data;
using System.ComponentModel;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.data.dao
{
    public class TipoIdentificacionMYSQLDAO : SQLDAO, TipoIdentificacionDAO
    {
        public TipoIdentificacionMYSQLDAO(SqlConnection conexion) : base(conexion) {

        }


        public void crear(TipoIdentificacionEntity entity)
        {
            
            try {
                string query = "INSERT INTO tipoidentificacion (id, codigo, nombre, estado) VALUES (@id, @codigo, @nombre, @estado)";
                using (SqlConnection conexion = getConexion())
                {
                    using (SqlCommand comando = new SqlCommand(query, conexion)) {
                        comando.Parameters.AddWithValue("@id", entity.getId);
                        comando.Parameters.AddWithValue("@codigo", entity.getCodigo);
                        comando.Parameters.AddWithValue("@nombre", entity.getNombre);
                        comando.Parameters.AddWithValue("@estado", entity.isEstado().IsValor);

                        conexion.Open();
                        comando.ExecuteNonQuery();

                    }
                    
                }
            }
            catch (SqlException excepcion)
            {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0037);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0041);
                throw DataSpaOnlineException.crear(excepcion, mensajeUsuario, mensajeTecnico);
            }
            catch (Exception excepcion)
            {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0037);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0042);
                throw DataSpaOnlineException.crear(excepcion, mensajeUsuario, mensajeTecnico);
            }
        }

        public void eliminar(Guid id)
        {

            try {
                string query = "DELETE FROM tipoidentificacion WHERE id = @id";
                using (SqlConnection conexion = getConexion())
                {
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", id);

                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException excepcion) {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0039);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0045);
                throw DataSpaOnlineException.crear(excepcion, mensajeUsuario, mensajeTecnico);
            } catch (Exception excepcion) {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0039);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0046);
                throw DataSpaOnlineException.crear(excepcion, mensajeUsuario, mensajeTecnico);
            }
        }

        public void modificar(TipoIdentificacionEntity entity)
        {
            var sentencia = new System.Text.StringBuilder();
            sentencia.Append("UPDATE tipoidentificacion ");
            sentencia.Append("SET codigo = @codigo,");
            sentencia.Append("    nombre = @nombre,");
            sentencia.Append("    estado = @estado ");
            sentencia.Append("WHERE id = @id");

            try
            {
                string query = "UPDATE tipoidentificacion SET codigo = @codigo, nombre = @nombre, estado = @estado WHERE id = @id";
                using (SqlConnection conexion = getConexion())
                {
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@codigo", entity.getCodigo);
                        comando.Parameters.AddWithValue("@nombre", entity.getNombre);
                        comando.Parameters.AddWithValue("@estado", entity.isEstado().IsValor);
                        comando.Parameters.AddWithValue("@id", entity.getId);

                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException excepcion)
            {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0038);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0043);
                throw DataSpaOnlineException.crear(excepcion, mensajeUsuario, mensajeTecnico);
            }
            catch (Exception excepcion)
            {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0038);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0044);
                throw DataSpaOnlineException.crear(excepcion, mensajeUsuario, mensajeTecnico);
            }
        }
        public List<TipoIdentificacionEntity> consultar(SqlCommand cmd)
        {      
            try
            {
                var lista = new List<TipoIdentificacionEntity>();
                SQLDAO.PrepareTextCmd(cmd);
                cmd.CommandText = @"SELECT *
                                   FROM tipoidentificacion;";    

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new TipoIdentificacionEntity((Guid)reader["id"], 
                                (string)reader["codigo"],
                                (string)reader["nombre"],
                                (BooleanEntity)reader["estado"])
                            );
                        }
                    }

                    return lista;
                
            }catch ( DataSpaOnlineException excepcion) {
                throw excepcion;
            }

            catch ( SqlException excepcion) {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0040);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0051);
                throw DataSpaOnlineException.crear(excepcion, mensajeUsuario, mensajeTecnico);
            }

            catch (Exception excepcion) {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0040);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0052);
                throw DataSpaOnlineException.crear(excepcion, mensajeUsuario, mensajeTecnico);
            }
        }

        public Optional<TipoIdentificacionEntity> ConsultarPorId(Guid id)
        {

            throw new NotImplementedException();

        } 
    }
        
}
