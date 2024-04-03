using System;

using co.edu.uco.spaonline.crosscutting.messages.enumerator;

namespace co.edu.uco.spaonline.crosscutting.messages
{

    public class Mensaje
    {
        private CodigoMensaje codigo;
        private TipoMensaje tipo;
        private CategoriaMensaje categoria;
        private string contenido;

        private Mensaje(CodigoMensaje codigo, TipoMensaje tipo, CategoriaMensaje categoria, string contenido)
        {
            SetCodigo(codigo);
            SetTipo(tipo);
            SetCategoria(categoria);
            SetContenido(contenido);
        }

        public static Mensaje Crear(CodigoMensaje codigo, TipoMensaje tipo, CategoriaMensaje categoria, string contenido)
        {
            return new Mensaje(codigo, tipo, categoria, contenido);
        }

        private void SetCodigo(CodigoMensaje codigo)
        {
            if (codigo == null)
            {
                string mensajeUsuario = CatalogoMensajes.ObtenerContenido(CodigoMensaje.M0000004);
                string mensajeTecnico = CatalogoMensajes.ObtenerContenido(CodigoMensaje.M0000001);
                throw new CrosscuttingSpaOnlineException(mensajeUsuario, mensajeTecnico);
            }
            this.codigo = codigo;
        }

        private void SetTipo(TipoMensaje tipo)
        {
            this.tipo = tipo != null ? tipo : TipoMensaje.USUARIO;
        }

        private void SetCategoria(CategoriaMensaje categoria)
        {
            this.categoria = categoria != null ? categoria : CategoriaMensaje.FATAL;
        }

        private void SetContenido(string contenido)
        {
            this.contenido = contenido?.Trim();
        }

        public CodigoMensaje GetCodigo()
        {
            return codigo;
        }

        public TipoMensaje GetTipo()
        {
            return tipo;
        }

        public CategoriaMensaje GetCategoria()
        {
            return categoria;
        }

        public string GetContenido()
        {
            return contenido;
        }
    }
}