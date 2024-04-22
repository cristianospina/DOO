using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.data.entity.support
{
    public class CorreoElectronicoClienteEntity
    {
        private string correoElectronico;
        private BooleanEntity correoElectronicoConfirmmado;

        private CorreoElectronicoClienteEntity(string correoElectronico, BooleanEntity correoElectronicoConfirmmado)
        {
            setCorreoElectronico(correoElectronico);
            setCorreoElectronicoConfirmado(correoElectronicoConfirmmado);
        }

        public static CorreoElectronicoClienteEntity crear(String correoElectronico, BooleanEntity correoElectronicoConfirmado) {
            return new CorreoElectronicoClienteEntity(correoElectronico, correoElectronicoConfirmado);
        }
   

        private void setCorreoElectronico(String correoElectronico) { 
            this.correoElectronico = correoElectronico;
        }
        private void setCorreoElectronicoConfirmado(BooleanEntity correoElectronicoConfirmado) {
            this.correoElectronicoConfirmmado = correoElectronicoConfirmado;
        }
        public String getCorreoElectronico() {
            return correoElectronico;
        }
        public BooleanEntity IsCorreoElectronicoConfirmado()
        {
            return correoElectronicoConfirmmado;
        } 
    }
}
