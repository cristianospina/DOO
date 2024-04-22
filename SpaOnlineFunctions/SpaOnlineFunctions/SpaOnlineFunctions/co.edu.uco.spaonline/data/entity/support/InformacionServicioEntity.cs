using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.data.entity.support
{
    public class InformacionServicioEntity
    {
        private String nombreServicio;
        private String descripcionServicio;

        private InformacionServicioEntity(String nombreServicio, String descripcionServicio)
        {
            setNombreServicio(nombreServicio);
            setDescripcionServicio(descripcionServicio);
        }
        public static InformacionServicioEntity crear( String nombre,  String descripcionServicio)
        {
            return new InformacionServicioEntity(nombre, descripcionServicio);
        }
        private void setNombreServicio(String nombreServicio) {
            this.nombreServicio = nombreServicio;
        }
        private  void setDescripcionServicio(String descripcionServicio)
        {
            this.descripcionServicio = descripcionServicio;
        }
        public  String getNombreServicio()
        {
            return nombreServicio;
        }
        public  String getDescripcionServicio()
        {
            return descripcionServicio;
        }

    }
}
