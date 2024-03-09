using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaOnline.co.edu.uco.spaonline.data
{
    public interface TipoIdentificacionDAO
    {
        void Crear();
        void Modificar();
        void Eliminar();

        TipoIdentificacionEntity ConsultarPorId(Guid id);
        
        List  <TipoIdentificacionEntity> Consultar (TipoIdentificacionEntity entity);
    }
}
