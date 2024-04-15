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
     class Mensaje
    {
        private CodigoMensaje codigo;
        private TipoMensaje tipo;
        private CategoriaMensajes categoria;
        private String contenido;

        public Mensaje( CodigoMensaje codigo,  TipoMensaje tipo,  CategoriaMensajes categoria,  String contenido) {
            setCodigo(codigo);
            setTipo(tipo);
            setCategoria(categoria);
            setContenido(contenido);
        }
        public static  Mensaje crear( CodigoMensaje codigo,  TipoMensaje tipo,  CategoriaMensajes categoria,  String contenido)
        {
            return new Mensaje(codigo, tipo, categoria, contenido);
        }

        private  void setCodigo( CodigoMensaje codigo)
        {
            if (UtilObjeto.EsNulo(codigo))
            {
                var mensajeUsuario = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0004);
                var mensajeTecnico = CatalogoMensajes.obtenerContenido(CodigoMensaje.M0001);
                throw CrosscuttingSpaOnlineException.crear(mensajeUsuario, mensajeTecnico);
            }
            this.codigo = UtilObjeto.ObtenerValorDefecto(codigo, null);
        }
        private  void setTipo( TipoMensaje tipo)
        {
            this.tipo = UtilObjeto.ObtenerValorDefecto(tipo, TipoMensaje.USUARIO);
        }
        private  void setCategoria( CategoriaMensajes categoriaMensajes)
        {
            this.categoria = UtilObjeto.ObtenerValorDefecto(categoria, CategoriaMensajes.FATAL);
        }
        private  void setContenido( String contenido)
        {
            this.contenido = UtilTexto.AplicarTrim(contenido);
        }
        public  CodigoMensaje getCodigo()
        {
            return codigo;
        }
        public  TipoMensaje getTipo()
        {
            return tipo;
        }
        public  CategoriaMensajes getCategoria()
        {
            return categoria;
        }
        public  String getContenido()
        {
            return contenido;
        }
    }
}
