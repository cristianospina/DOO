using SpaOnlineFunctions.co.edu.uco.spaonline.data.entity.support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.data.entity
{
    public class TipoIdentificacionEntity
    {
        private Guid id;
        private String codigo;
        private String nombre;
        private BooleanEntity estado;

        public TipoIdentificacionEntity( Guid id,  String codigo,  String nombre,  BooleanEntity estado)
        {
            setId(id);
            setCodigo(codigo);
            setNombre(nombre);
            setEstado(estado);
        }

        

        public static  TipoIdentificacionEntity crear( Guid id,  String codigo,  String nombre,  BooleanEntity estado)
        {
            return new TipoIdentificacionEntity(id, codigo, nombre, estado);
        }

        private  void setId( Guid id)
        {
            this.id = id;
        }

        private  void setCodigo( String codigo)
        {
            this.codigo = codigo;
        }

        private  void setNombre( String nombre)
        {
            this.nombre = nombre;
        }

        private  void setEstado( BooleanEntity estado)
        {
            this.estado = estado;
        }

        public  Guid getId()
        {
            return id;
        }

        public  String getCodigo()
        {
            return codigo;
        }

        public  String getNombre()
        {
            return nombre;
        }

        public  BooleanEntity isEstado()
        {
            return estado;
        }
    }
}
