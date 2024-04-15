using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.data.entity
{
    public class TipoServicioEntity
    {
        private Guid id;
        private String nombreTipoServicio;

        private TipoServicioEntity(Guid id, String nombreTipoServicio)
        {
            setId(id);
            setNombreTipoServicio(nombreTipoServicio);
        }
        public static  TipoServicioEntity crear( Guid id,  String nombreTipoServicio)
        {
            return new TipoServicioEntity(id, nombreTipoServicio);
        }

        private  void setId(Guid id)
        {
            this.id = id;
        }

        private  void setNombreTipoServicio(String nombreTipoServicio)
        {
            this.nombreTipoServicio = nombreTipoServicio;
        }

        public  Guid getId()
        {
            return id;
        }

        public String getNombreTipoServicio()
        {
            return nombreTipoServicio;
        }
    }
}
