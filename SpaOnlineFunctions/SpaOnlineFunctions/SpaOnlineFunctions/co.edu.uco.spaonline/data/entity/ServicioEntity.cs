using SpaOnlineFunctions.co.edu.uco.spaonline.data.entity.support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.data.entity
{
    public  class ServicioEntity
    {
        private Guid id;
        private TipoServicioEntity tipoServicio;
        private InformacionServicioEntity informacionServicio;
        private int? precio;
        private int? duracionHoraServicio;

        private ServicioEntity( Guid id,  TipoServicioEntity tipoServicio,  InformacionServicioEntity informacionServicio,  int precio,
                 int duracionHoraServicio)
        {

            setId(id);
            setTipoServicio(tipoServicio);
            setInformacionServicio(informacionServicio);
            setPrecio(precio);
            setDuracionHoraServicio(duracionHoraServicio);
        }

        public static  ServicioEntity crear( Guid id,  TipoServicioEntity tipoServicio,  InformacionServicioEntity informacionServicio,  int precio,
                 int duracionHoraServicio)
        {
            return new ServicioEntity(id, tipoServicio, informacionServicio, precio, duracionHoraServicio);
        }

        private  void setId(Guid id)
        {
            this.id = id;
        }

        private  void setTipoServicio(TipoServicioEntity tipoServicio)
        {
            this.tipoServicio = tipoServicio;
        }

        private  void setInformacionServicio(InformacionServicioEntity informacionServicio)
        {
            this.informacionServicio = informacionServicio;
        }

        private  void setPrecio(int? precio)
        {
            this.precio = precio;
        }

        private  void setDuracionHoraServicio(int? duracionHoraServicio)
        {
            this.duracionHoraServicio = duracionHoraServicio;
        }

        public  Guid getId()
        {
            return id;
        }

        public  TipoServicioEntity getTipoServicio()
        {
            return tipoServicio;
        }

        public  InformacionServicioEntity getInformacionServicio()
        {
            return informacionServicio;
        }

        public  int?  getPrecio()
        {
            return precio;
        }

        public  int? getDuracionHoraServicio()
        {
            return duracionHoraServicio;
        }
    }
}
