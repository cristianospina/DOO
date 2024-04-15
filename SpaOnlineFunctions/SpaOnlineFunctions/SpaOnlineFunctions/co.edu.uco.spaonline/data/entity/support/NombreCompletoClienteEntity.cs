using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnlineFunctions.co.edu.uco.spaonline.data.entity.support
{
    public class NombreCompletoClienteEntity
    {
        public String primerNombre;
        public String segundoNombre;
        public String primerApellido;
        public String segundoApellido;

        private NombreCompletoClienteEntity(String primerNombre, String segundoNombre, String primerApellido,
            String segundoApellido)
        {
            setPrimerNombre(primerNombre);
            setSegundoNombre(segundoNombre);
            setPrimerApellido(primerApellido);
            setSegundoApellido(segundoApellido);
        }
        public static NombreCompletoClienteEntity crear(String primerNombre, String segundoNombre, String primerApellido,
            String segundoApellido)
        {
            return new NombreCompletoClienteEntity(primerNombre, segundoNombre, primerApellido, segundoApellido);
        }

        private  void setPrimerNombre(String primerNombre)
        {
            this.primerNombre = primerNombre;
        }
        private  void setSegundoNombre(String segundoNombre)
        {
            this.segundoNombre = segundoNombre;
        }
        private  void setPrimerApellido(String primerApellido)
        {
            this.primerApellido = primerApellido;
        }
        private  void setSegundoApellido(String segundoApellido)
        {
            this.segundoApellido = segundoApellido;
        }
        public String getPrimerNombre()
        {
            return primerNombre;
        }
        public String getSegundoNombre()
        {
            return segundoNombre;
        }
        public String getPrimerApellido()
        {
            return primerApellido;
        }
        public String getSegundoApellido()
        {
            return segundoApellido;
        }

    }
}
