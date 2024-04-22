using SpaOnlineFunctions.co.edu.uco.spaonline.data.entity.support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.data.entity
{
    public class ClienteEntity
    {
        private Guid id;
        private TipoIdentificacionEntity tipoIdentificacion;
        private String identificacion;
        private NombreCompletoClienteEntity nombreCompleto;
        private CorreoElectronicoClienteEntity correoElectronico;
        private NumeroTelefonoMovilClienteEntity numeroTelefonoMovil;
        private   DateTime fechaNacimiento;

        private ClienteEntity( Guid id,  TipoIdentificacionEntity tipoIdentificacion,  String identificacion,  NombreCompletoClienteEntity nombreClienteEntity,  CorreoElectronicoClienteEntity correoClienteEntity,  NumeroTelefonoMovilClienteEntity numeroTelefonoMovilClienteEntity,  DateTime fechaNacimiento)
        {

            setId(id);
            setTipoIdentificacion(tipoIdentificacion);
            setIdentificacion(identificacion);
            setNombreCompleto(nombreClienteEntity);
            setCorreoElectronico(correoClienteEntity);
            setNumeroTelefonoMovil(numeroTelefonoMovilClienteEntity);
            setFechaNacimiento(fechaNacimiento);

        }
        public static  ClienteEntity crear( Guid id,  TipoIdentificacionEntity tipoIdentificacion,  String identificacion,  NombreCompletoClienteEntity nombreCompletoCliente,  CorreoElectronicoClienteEntity correoElectronicoCliente,  NumeroTelefonoMovilClienteEntity numeroTelefonoMovilCliente,  DateTime fechaNacimiento)
        {
            return new ClienteEntity(id, tipoIdentificacion, identificacion, nombreCompletoCliente, correoElectronicoCliente, numeroTelefonoMovilCliente, fechaNacimiento);
        }


        private  void setId(Guid id)
        {
            this.id = id;
        }
        private  void setTipoIdentificacion(TipoIdentificacionEntity tipoIdentificacion)
        {
            this.tipoIdentificacion = tipoIdentificacion;
        }
        private  void setIdentificacion(String identificacion)
        {
            this.identificacion = identificacion;
        }

        public  void setNombreCompleto(NombreCompletoClienteEntity nombreCompleto)
        {
            this.nombreCompleto = nombreCompleto;
        }
        public  CorreoElectronicoClienteEntity getCorreoElectronico()
        {
            return correoElectronico;
        }
        private  void setCorreoElectronico(CorreoElectronicoClienteEntity correoElectronico)
        {
            this.correoElectronico = correoElectronico;
        }
        public  NumeroTelefonoMovilClienteEntity getNumeroTelefonoMovil()
        {
            return numeroTelefonoMovil;
        }
        private  void setNumeroTelefonoMovil(NumeroTelefonoMovilClienteEntity numeroTelefonoMovil)
        {
            this.numeroTelefonoMovil = numeroTelefonoMovil;
        }
        public  Guid getId()
        {
            return id;
        }
        public  TipoIdentificacionEntity getTipoIdentificacion()
        {
            return tipoIdentificacion;
        }
        public  String getIdentificacion()
        {
            return identificacion;
        }
        public  NombreCompletoClienteEntity getNombreCompleto()
        {
            return nombreCompleto;
        }
        public  DateTime getFechaNacimiento()
        {
            return fechaNacimiento;
        }
        private  void setFechaNacimiento( DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
    }
}
