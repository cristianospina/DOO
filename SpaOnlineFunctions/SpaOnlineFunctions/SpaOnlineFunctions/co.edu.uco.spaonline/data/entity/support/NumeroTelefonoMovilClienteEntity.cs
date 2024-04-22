using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.data.entity.support
{
    public class NumeroTelefonoMovilClienteEntity
    {
        private String numeroTelefonoMovil;
        private BooleanEntity numeroTelefonoMovilConfirmado;


        private NumeroTelefonoMovilClienteEntity( String numeroTelefonoMovil,  BooleanEntity numeroTelefonoMovilConfirmado)
        {
            setNumeroTelefonoMovil(numeroTelefonoMovil);
            setNumeroTelefonoMovilConfirmado(numeroTelefonoMovilConfirmado);
        }

        public static  NumeroTelefonoMovilClienteEntity crear( String numeroTelefonoMovil,  BooleanEntity numeroTelefonoMovilConfirmado)
        {
            return new NumeroTelefonoMovilClienteEntity(numeroTelefonoMovil, numeroTelefonoMovilConfirmado);
        }
        private  void setNumeroTelefonoMovil( String numeroTelefonoMovil)
        {
            this.numeroTelefonoMovil = numeroTelefonoMovil;
        }

        private  void setNumeroTelefonoMovilConfirmado( BooleanEntity numeroTelefonoMovilConfirmado)
        {
            this.numeroTelefonoMovilConfirmado = numeroTelefonoMovilConfirmado;
        }

        public  String getNumeroTelefonoMovil()
        {
            return numeroTelefonoMovil;
        }

        public  BooleanEntity isNumeroTelefonoMovilConfirmado()
        {
            return numeroTelefonoMovilConfirmado;
        }
    }
}
